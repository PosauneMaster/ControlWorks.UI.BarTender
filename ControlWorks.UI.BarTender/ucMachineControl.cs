using ControlWorks.Pvi.Service;
using log4net;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWorks.UI.BarTender
{
    public partial class ucMachineControl : UserControl, INotifyPropertyChanged
    {

        private readonly ILog _log = LogManager.GetLogger("FileLogger");

        private readonly Stopwatch _jobRunStopwatch = new Stopwatch();
        private readonly string _labelsizesmall = "4 x 4";
        private readonly string _labelsizelarge = "6 x 4";

        private bool _serviceRunning = false;
        private BartenderService _service;
        private string _currentFile;


        private string _status;
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
        private Color _defaultBackColor;
        private Color _defaultForeColor;


        private Color _defaultTestBackColor;
        private Color _defaultTestForeColor;


        private TemplateSettings _currentTemplate;
        public event PropertyChangedEventHandler PropertyChanged;


        private PviController _pvicontroller;
        public ucMachineControl()
        {
            InitializeComponent();
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Properties.Settings.Default.TemplateFilesLocation;
            openFileDialog1.FileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtTemplatePath.Text = openFileDialog1.FileName;

                    var xml = File.ReadAllText(openFileDialog1.FileName);

                    _currentTemplate = TemplateSettings.CreateFromXml(xml);


                    cboOrientation.SelectedIndex = _currentTemplate.CurrentBox.CurrentLabelRotation;
                    cboLabelPlacement.Text = _currentTemplate.LabelPlacement;
                    txtLeftOffset.Text = _currentTemplate.CurrentBox.LabelToLeftCurrentInches.ToString("N2");
                    cboLabelSize.Text = _currentTemplate.LabelSize;
                    cboLabelPosition.Text = _currentTemplate.LabelPositon;
                    txtHeight.Text = _currentTemplate.BoxHeight;
                    txtWidth.Text = _currentTemplate.BoxWidth;
                    _currentFile = _currentTemplate.LabelLocation;

                    var fi = new FileInfo(_currentTemplate.LabelLocation);
                    if (fi.Exists && fi.Extension == ".btw")
                    {
                        var service = GetService();
                        service.PreviewFileRetrieved += Service_PreviewFileRetrieved;

                        Task.Run(() => service.GetPreviewFile(_currentTemplate.LabelLocation, pictureBox1.Width, pictureBox1.Height));
                    }
                    else
                    {
                        pictureBox1.ImageLocation = String.Empty;
                    }
                }
                catch (Exception ex)
                {
                    _log.Error(ex.Message, ex);
                    MessageBox.Show("Error trying to preview file.", "Preview Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ucMachineControl_Load(object sender, EventArgs e)
        {
            txtHeight.Text = Properties.Settings.Default.DefaultBoxHeight;
            txtWidth.Text = Properties.Settings.Default.DefaultBoxWidth;

            cboLabelSize.Items.Clear();

            cboLabelSize.Items.Add(_labelsizelarge);
            cboLabelSize.Items.Add(_labelsizesmall);
            cboLabelSize.SelectedIndex = 0;

            cboLabelPosition.DataSource = Enum.GetValues(typeof(LabelPositon));
            cboLabelPosition.SelectedIndex = 2;

            _defaultBackColor = btnStart.BackColor;
            _defaultForeColor = btnStart.ForeColor;

            this.btnStop.BackColor = Color.Red;
            this.btnStop.ForeColor = Color.White;

            _defaultTestBackColor = btnTestPrint.BackColor;
            _defaultTestForeColor = btnTestPrint.ForeColor;

            cboLabelPlacement.SelectedIndex = 0;
            cboOrientation.SelectedIndex = 2;
            //cboOrientation.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultOrientation;
            //cboLabelPlacement.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultLabelPlacement;
            //txtInfeedSpeed.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultInfeedSpeed;
            //txtPrinterSpeed.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultPrinterSpeed;
            //cboLabelPlacement.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultLabelPlacement;

            _pvicontroller = PviController.Controller;
            _pvicontroller.VariablesChanged += _pvicontroller_VariablesChanged;
            _pvicontroller.Start();

        }

        private void _pvicontroller_VariablesChanged(object sender, Pvi.Service.VariableEventArgs e)
        {
            HandleVariableUpdate(e.PrinterInfo);
        }

        private void HandleVariableUpdate(PrinterInfoDto dto)
        {
            if (InvokeRequired)
            {
                Action<PrinterInfoDto> a = HandleVariableUpdate;
                Invoke(a, dto);
            }
            else
            {
                Status = dto.StatusText;
                txtBoxCount.Text = dto.NumberOfBoxes?.ToString() ?? String.Empty;
                txtFrontLabels.Text = dto.NumberOfFrontLabels?.ToString() ?? String.Empty;
                txtSideLabels.Text = dto.NumberOfSideLabels?.ToString() ?? String.Empty;
                txtTotalLabels.Text = dto.TotalLabelsApplied?.ToString() ?? String.Empty;

                if (dto.ResetNumberOfBoxes.HasValue && dto.ResetNumberOfBoxes.Value == true)
                {
                    txtBoxCount.Text = String.Empty;
                }

                if (dto.ResetNumberOfFrontLabels.HasValue && dto.ResetNumberOfFrontLabels.Value == true)
                {
                    txtFrontLabels.Text = String.Empty;
                }
                if (dto.ResetNumberOfSideLabels.HasValue && dto.ResetNumberOfSideLabels.Value == true)
                {
                    txtSideLabels.Text = String.Empty;
                }
                if (dto.ResetTotalLabelsApplied.HasValue && dto.ResetTotalLabelsApplied.Value == true)
                {
                    txtBoxCount.Text = String.Empty;
                }

                if (dto.ClearPrinter.HasValue && dto.ClearPrinter.Value)
                {
                    var service = GetService();
                    Task.Run(() => service.Cancel());
                }

                if (dto.RefreshLabel.HasValue)
                {
                    if (dto.RefreshLabel.Value)
                    {
                        var service = GetService();

                        var orientation = GetOrientation();
                        var numberOfLabels = txtLabelsPerBox.Text;
                        Task.Run(() => service.PrintFile(_currentFile, orientation, numberOfLabels));
                    }
                }

                if (dto.ConyorsRunning.HasValue && dto.ConyorsRunning.Value)
                {
                    SetStartConveyor();
                }
                else
                {
                    SetStopConveyor();
                }

            }
        }

        private void SetStartConveyor()
        {
            if (InvokeRequired)
            {
                Action a = SetStartConveyor;
                Invoke(a);
            }
            else
            {
                this.btnStart.BackColor = Color.Green;
                this.btnStart.ForeColor = Color.White;
                btnStart.Text = "Running...";

                if (!_jobRunStopwatch.IsRunning)
                {
                    _jobRunStopwatch.Start();
                }
            }
        }

        private void SetStopConveyor()
        {
            if (InvokeRequired)
            {
                Action a = SetStopConveyor;
                Invoke(a);
            }
            else
            {
                btnStart.BackColor = _defaultBackColor;
                btnStart.ForeColor = _defaultForeColor;
                btnStart.Text = "Start";

                _jobRunStopwatch.Stop();
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (_serviceRunning) return;

                _serviceRunning = true;

                SetControlsEnabledTo(false);
                _pvicontroller.SetVariables(GetVariables());

                txtJobStartTime.Text = DateTime.Now.ToString("MM/dd/yyyy   HH:mm:ss");

                _jobRunStopwatch.Reset();
                tmrJobRun.Start();
            }
            catch (Exception ex)
            {
                _log.Error("Error Starting Job");
                _log.Error(ex.Message, ex);
            }
        }



        private PrinterInfoDto GetVariables()
        {

            var dto = new PrinterInfoDto();

            if (cboLabelPlacement.Text == "Front")
            {
                dto.LabelApplyFormat = 2;
            }
            else if (cboLabelPlacement.Text == "Side")
            {
                dto.LabelApplyFormat = 1;

            }
            else if (cboLabelPlacement.Text == "Front and Side")
            {
                dto.LabelApplyFormat = 3;

            }
            else
            {
                dto.LabelApplyFormat = 0;
            }

            if (_serviceRunning)
            {
                dto.StartConveyor = true;
                dto.StopConveyor = null;
            }
            else
            {
                dto.StartConveyor = null;
                dto.StopConveyor = true;
            }

            dto.StartConveyor = _serviceRunning;

            if (Double.TryParse(txtLeftOffset.Text, out var offset))
            {
                dto.SideLabelPosition = offset;
            }

            if (Double.TryParse(txtWidth.Text, out var width))
            {
                dto.BoxDimension = width;
            
            }

            return dto;
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_serviceRunning) return;

                _serviceRunning = false;
                SetControlsEnabledTo(true);

                _pvicontroller.SetVariables(GetVariables());
            }
            catch (Exception ex)
            {
                _log.Error("Error stopping job");
                _log.Error(ex.Message, ex);
            }

        }

        protected virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (sender is TextBox txt)
            {
                var frm = new frmNumpad(txt);
                frm.SetLocation(txt.Right, txt.Top);
                frm.Show();
            }
        }

        private void tmrJobRun_Tick(object sender, EventArgs e)
        {
            txtRunTime.Text =
                $"{_jobRunStopwatch.Elapsed.Hours:00}:{_jobRunStopwatch.Elapsed.Minutes:00}:{_jobRunStopwatch.Elapsed.Seconds:00}";
        }

        private void cboLabelPlacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            if (sender != null)
            {
                if (cb.Text == "Front")
                {
                    txtLabelsPerBox.Text = "1";
                }
                else if (cb.Text == "Side")
                {
                    txtLabelsPerBox.Text = "1";

                }
                else if (cb.Text == "Front and Side")
                {
                    txtLabelsPerBox.Text = "2";
                }
                else
                {
                    txtLabelsPerBox.Text = "0";
                }
            }

            if (_pvicontroller != null)
            {
                _pvicontroller.SetVariables(GetVariables());
            }
        }

        private void groupBox4_VisibleChanged(object sender, EventArgs e)
        {
            txtHeight.Text = Properties.Settings.Default.DefaultBoxHeight;
            txtWidth.Text = Properties.Settings.Default.DefaultBoxWidth;
        }

        private void SetControlsEnabledTo(bool enabled)
        {
            txtLabelsPerBox.Enabled = enabled;
            txtHeight.Enabled = enabled;
            txtWidth.Enabled = enabled;
            txtLeftOffset.Enabled = enabled;
            cboLabelPlacement.Enabled = enabled;
            cboLabelPosition.Enabled = enabled;
            cboLabelSize.Enabled = enabled;
            cboOrientation.Enabled = enabled;
        }

        private void btnChooseLabel_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Properties.Settings.Default.BartenderFilesLocation;
            openFileDialog1.FileName = String.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (sender is Button b)
                {
                    b.BackColor = Color.Green;
                    b.ForeColor = Color.White;
                    tmrButtonPress.Start();
                }

                _currentFile = openFileDialog1.FileName;
                pictureBox1.ImageLocation = String.Empty;

                var service = GetService();
                service.PreviewFileRetrieved += Service_PreviewFileRetrieved;

                Task.Run(() => service.GetPreviewFile(_currentFile, pictureBox1.Width, pictureBox1.Height));
            }
        }

        private void Service_PreviewFileRetrieved(object sender, PreviewFileEventArgs e)
        {
            SetPicture(e.Filename);
        }

        private void SetPicture(string filename)
        {
            if (InvokeRequired)
            {
                Action<string> a = SetPicture;
                Invoke(a, filename);
            }
            else
            {

                if (!String.IsNullOrEmpty(filename) && File.Exists(filename))
                {
                    pictureBox1.ImageLocation = filename;
                }
            }
        }

        private bool _testPrint = false;
        private void btnTestPrint_Click(object sender, EventArgs e)
        {
            _testPrint = true;

            if (!String.IsNullOrEmpty(_currentFile))
            {
                if (sender is Button b)
                {
                    b.BackColor = Color.Green;
                    b.ForeColor = Color.White;
                    tmrButtonPress.Start();
                }
                var orientation = GetOrientation();

                var service = GetService();
                Task.Run(() => service.PrintFile(_currentFile, orientation, "1", true));
            }
        }

        private BartenderService GetService()
        {
            if (_service == null)
            {
                _service = new BartenderService();
                _service.PrintSent += _service_PrintSent;
            }
            return _service;
        }

        private readonly object _syncLock = new Object();
        private void _service_PrintSent(object sender, EventArgs e)
        {
            lock(_syncLock)
            {
                if (_testPrint)
                {
                    _pvicontroller.SetVariable("PVI.Command[12]", 1);
                }
                _testPrint = false;
            }
        }

        private string GetOrientation()
        {

        //Portrait
        //Landscape
        //Portrait 180
        //Landscape 180


            if (cboOrientation.SelectedIndex == 0)
            {
                return "1";
            }
            if (cboOrientation.SelectedIndex == 1)
            {
                return "0";
            }
            if (cboOrientation.SelectedIndex == 2)
            {
                return "2";
            }
            if (cboOrientation.SelectedIndex == 3)
            {
                return "3";
            }

            return "0";

        }


        private void cboOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tmrButtonPress_Tick(object sender, EventArgs e)
        {
            tmrButtonPress.Stop();

            btnTestPrint.ForeColor = _defaultTestForeColor;
            btnTestPrint.BackColor = _defaultTestBackColor;

            btnChooseLabel.BackColor = _defaultTestBackColor;
            btnChooseLabel.ForeColor = _defaultTestForeColor;

            btnResetCounters.BackColor = _defaultTestBackColor;
            btnResetCounters.ForeColor = _defaultTestForeColor;
        }

        private void ucMachineControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                //cboOrientation.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultOrientation;
                //cboLabelPlacement.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultLabelPlacement;
                //txtInfeedSpeed.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultInfeedSpeed;
                //txtPrinterSpeed.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultPrinterSpeed;
                //cboLabelPlacement.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultLabelPlacement;
            }
        }

        private void btnResetCounters_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                b.BackColor = Color.Green;
                b.ForeColor = Color.White;
                tmrButtonPress.Start();
            }

        }
    }
}
