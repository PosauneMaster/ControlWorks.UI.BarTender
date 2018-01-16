using ControlWorks.Pvi.Service;
using log4net;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ControlWorks.UI.BarTender
{
    public partial class ucMachineControl : UserControl, INotifyPropertyChanged
    {

        private static readonly ILog _log = LogManager.GetLogger("FileLogger");

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
            _pvicontroller.SetVariable("PVI.Command[0]", 1);

            this.btnStart.BackColor = Color.Green;
            this.btnStart.ForeColor = Color.White;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _pvicontroller.SetVariable("PVI.Command[1]", 1);
            btnStart.BackColor = _defaultBackColor;
            btnStart.ForeColor = _defaultForeColor;

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



    }
}
