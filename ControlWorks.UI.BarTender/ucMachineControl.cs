using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlWorks.Pvi.Service;
using System.IO;

namespace ControlWorks.UI.BarTender
{
    public partial class ucMachineControl : UserControl
    {
        private Color _defaultBackColor;
        private Color _defaultForeColor;
        private TemplateSettings _currentTemplate;


        private PviController _pvicontroller;
        public ucMachineControl()
        {
            InitializeComponent();
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtTemplatePath.Text = openFileDialog1.FileName;

                var xml = File.ReadAllText(openFileDialog1.FileName);

                _currentTemplate = TemplateSettings.CreateFromXml(xml);

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
                var start = dto.StartConveyor.HasValue ? dto.StartConveyor.Value.ToString() : String.Empty;
                var stop = dto.StopConveyor.HasValue ? dto.StopConveyor.Value.ToString() : String.Empty;
                txtStatus.Text = dto.StatusText;
                txtInfeedSpeed.Text = dto.InfeedSpeed.HasValue ? dto.InfeedSpeed.Value.ToString() : String.Empty;
                txtPrinterSpeed.Text = dto.PrinterConveyorSpeed.HasValue ? dto.PrinterConveyorSpeed.Value.ToString() : String.Empty;
                txtBoxCount.Text = dto.NumberOfBoxes.HasValue ? dto.NumberOfBoxes.Value.ToString() : String.Empty;
                txtFrontLabels.Text = dto.NumberOfFrontLabels.HasValue ? dto.NumberOfFrontLabels.Value.ToString() : String.Empty;
                txtSideLabels.Text = dto.NumberOfSideLabels.HasValue ? dto.NumberOfSideLabels.Value.ToString() : String.Empty;
                txtTotalLabels.Text = dto.TotalLabelsApplied.HasValue ? dto.TotalLabelsApplied.Value.ToString() : String.Empty;

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
    }
}
