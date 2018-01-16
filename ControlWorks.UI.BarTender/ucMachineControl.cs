using ControlWorks.Pvi.Service;
using log4net;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ControlWorks.UI.BarTender
{
    public partial class ucMachineControl : UserControl, INotifyPropertyChanged
    {

        private readonly ILog _log = LogManager.GetLogger("FileLogger");

        private readonly Stopwatch _jobRunStopwatch = new Stopwatch();
        private readonly string _labelsizesmall = "4 x 4";
        private readonly string _labelsizelarge = "4 x 6";

        private bool _serviceRunning = false;


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
        private TemplateSettings _currentTemplate;
        public event PropertyChangedEventHandler PropertyChanged;


        private PviController _pvicontroller;
        public ucMachineControl()
        {
            InitializeComponent();
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtTemplatePath.Text = openFileDialog1.FileName;

                    var xml = File.ReadAllText(openFileDialog1.FileName);

                    _currentTemplate = TemplateSettings.CreateFromXml(xml);

                    var service = new BartenderService();
                    var previewImagePath = service.GetPreviewFile(_currentTemplate.LabelLocation, pictureBox1.Width, pictureBox1.Height).Result;

                    pictureBox1.ImageLocation = String.Empty;

                    var path = service.GetMessage(previewImagePath);
                    if (!String.IsNullOrEmpty(path) && File.Exists(path))
                    {
                        pictureBox1.ImageLocation = path;
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

            cboLabelSize.Items.Add(_labelsizesmall);
            cboLabelSize.Items.Add(_labelsizelarge);
            cboLabelSize.SelectedIndex = 1;

            cboLabelPosition.DataSource = Enum.GetValues(typeof(LabelPositon));
            cboLabelPosition.SelectedIndex = 2;

            _defaultBackColor = btnStart.BackColor;
            _defaultForeColor = btnStart.ForeColor;

            this.btnStop.BackColor = Color.Red;
            this.btnStop.ForeColor = Color.White;

            _pvicontroller = new PviController();
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
                Action<PrinterInfoDto> a = new Action<PrinterInfoDto>(HandleVariableUpdate);
                Invoke(a);
            }
            else
            {
                Status = dto.StatusText;
                txtInfeedSpeed.Text = dto.InfeedSpeed?.ToString() ?? String.Empty;
                txtPrinterSpeed.Text = dto.PrinterConveyorSpeed?.ToString() ?? String.Empty;
                txtBoxCount.Text = dto.NumberOfBoxes?.ToString() ?? String.Empty;
                txtFrontLabels.Text = dto.NumberOfFrontLabels?.ToString() ?? String.Empty;
                txtSideLabels.Text = dto.NumberOfSideLabels?.ToString() ?? String.Empty;
                txtTotalLabels.Text = dto.TotalLabelsApplied?.ToString() ?? String.Empty;

                if (dto.RefreshLabel.HasValue && _currentTemplate != null)
                {
                    if (dto.RefreshLabel.Value)
                    {
                        var service = new BartenderService();
                        service.PrintFile(_currentTemplate.LabelLocation).ConfigureAwait(false);
                    }
                }
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_serviceRunning) return;

            _serviceRunning = true;

            SetControlsEnabledTo(false);
            //_pvicontroller.SetVariable("PVI.Command[0]", 1);

            this.btnStart.BackColor = Color.Green;
            this.btnStart.ForeColor = Color.White;

            txtJobStartTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            _jobRunStopwatch.Reset();
            _jobRunStopwatch.Start();
            tmrJobRun.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!_serviceRunning) return;

            _serviceRunning = false;
            SetControlsEnabledTo(true);

            //_pvicontroller.SetVariable("PVI.Command[1]", 1);
            btnStart.BackColor = _defaultBackColor;
            btnStart.ForeColor = _defaultForeColor;

            _jobRunStopwatch.Stop();

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
            if (cb != null)
            {
                if (cb.Text == "Front and Side")
                {
                    txtLabelsPerBox.Text = "2";
                }
                else
                {
                    txtLabelsPerBox.Text = "1";
                }
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
            txtInfeedSpeed.Enabled = enabled;
            txtPrinterSpeed.Enabled = enabled;
            cboLabelPlacement.Enabled = enabled;
            cboLabelPosition.Enabled = enabled;
            cboLabelSize.Enabled = enabled;
            cboOrientation.Enabled = enabled;
            cboLabelsPerBox.Enabled = enabled;
        }
    }
}
