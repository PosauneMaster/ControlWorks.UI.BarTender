using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using ControlWorks.Pvi.Service;

namespace ControlWorks.UI.BarTender
{
    public partial class ucConfiguration : UserControl
    {
        private readonly ILog _log = LogManager.GetLogger("FileLogger");

        private PviController _pviController;

        private Color _defaultBackColor;
        private Color _defaultForeColor;
        public ucConfiguration()
        {
            InitializeComponent();
        }

        private void ucConfiguration_Load(object sender, EventArgs e)
        {

            _pviController = PviController.Controller;
            _pviController.VariablesChanged += _pviController_VariablesChanged;

            txtBtFilesLocation.Text = Properties.Settings.Default.BartenderFilesLocation;
            txtTemplateFilesLocation.Text = Properties.Settings.Default.TemplateFilesLocation;

            lblManualSide.Text = String.Empty;
            lblManualFront.Text = String.Empty;

            _defaultBackColor = btnManualFront.BackColor;
            _defaultForeColor = btnManualFront.ForeColor;

            //cboOrientation.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultOrientation;
            //cboLabelPlacement.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultLabelPlacement;
            //txtInfeedSpeed.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultInfeedSpeed;
            //txtPrinterSpeed.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultPrinterSpeed;
            //cboLabelPlacement.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultLabelPlacement;

        }

        private void _pviController_VariablesChanged(object sender, Pvi.Service.VariableEventArgs e)
        {
            if (e.PrinterInfo.InfeedSpeed.HasValue)
            {
                txtInfeedSpeed.Text = e.PrinterInfo.InfeedSpeed.Value.ToString();
            }

            if (e.PrinterInfo.PrinterConveyorSpeed.HasValue)
            {
                txtPrinterSpeed.Text = e.PrinterInfo.PrinterConveyorSpeed.Value.ToString();
            }

        }

        private void btnBTFilesLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BartenderFilesLocation = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
                txtBtFilesLocation.Text = Properties.Settings.Default.BartenderFilesLocation;
            }
        }

        private void btnTemplateFiles_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.TemplateFilesLocation = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
                txtTemplateFilesLocation.Text = Properties.Settings.Default.TemplateFilesLocation;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (sender is TextBox txt)
            {
                var frm = new frmNumpad(txt);
                frm.SetLocation(txt.Right, txt.Top);

                frm.FormClosed += (s, ea) =>
                {
                    var dto = new PrinterInfoDto();

                    if (!String.IsNullOrEmpty(txtPrinterSpeed.Text))
                    {
                        if (Int32.TryParse(txtPrinterSpeed.Text, out var i))
                        {
                            dto.PrinterConveyorSpeed = i;
                        }
                    }

                    if (!String.IsNullOrEmpty(txtInfeedSpeed.Text))
                    {
                        if (Int32.TryParse(txtInfeedSpeed.Text, out var j))
                        {
                            dto.InfeedSpeed = j;
                        }
                    }

                    _pviController.SetVariables(dto);
                };

                frm.Show();
            }
        }

        private void ucConfiguration_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                //cboOrientation.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultOrientation;
                //cboLabelPlacement.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultLabelPlacement;
                //txtInfeedSpeed.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultInfeedSpeed;
                //txtPrinterSpeed.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultPrinterSpeed;
                //cboLabelPlacement.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultLabelPlacement;
                //txtDefaultBoxHeight.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultBoxHeight;
                //txtDefaultBoxWidth.Text = ControlWorks.UI.BarTender.Properties.Settings.Default.DefaultBoxWidth;

            }
        }

        private void btnManualFront_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button b)
                {
                    b.BackColor = Color.Green;
                    b.ForeColor = Color.White;

                    var controller = PviController.Controller;
                    controller.SetVariable("PVI.Command[10]", true);
                    lblManualFront.Text = "Sent PVI.Command[10] = true";

                    timer1.Start();
                }

            }
            catch (Exception exception)
            {
                _log.Error(exception.Message, exception);
            }

        }

        private void btnManualSide_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button b)
                {
                    b.BackColor = Color.Green;
                    b.ForeColor = Color.White;

                    var controller = PviController.Controller;
                    controller.SetVariable("PVI.Command[11]", true);
                    lblManualSide.Text = "Sent PVI.Command[11] = true";

                    timer1.Start();

                }
            }
            catch (Exception exception)
            {
                _log.Error(exception.Message, exception);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnManualFront.BackColor = _defaultBackColor;
            btnManualFront.ForeColor = _defaultForeColor;
            btnManualSide.BackColor = _defaultBackColor;
            btnManualSide.ForeColor = _defaultForeColor;

            lblManualSide.Text = String.Empty;
            lblManualFront.Text = String.Empty;

            timer1.Stop();
        }

        private void btnClearQueue_Click(object sender, EventArgs e)
        {
            var service = new BartenderService();
            Task.Run(() => service.Cancel());

            //Task.Run(() => service.Cancel("~JA"));

            //^ XA

            //~JA

            //^ XZ


        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                if (b.Text.Contains("Select"))
                {
                    var frm = new frmNumpad(txtPassword) {StartPosition = FormStartPosition.CenterParent};
                    frm.ShowDialog(this);
                    b.Text = "Save Password";
                }
                else
                {
                    if (txtPassword.Text.Length > 0)
                    {
                        ControlWorks.UI.BarTender.Properties.Settings.Default.Password = txtPassword.Text;
                        ControlWorks.UI.BarTender.Properties.Settings.Default.Save();
                        MessageBox.Show($"Password changed to {txtPassword.Text}", "Password Changed",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    b.Text = "Select Password";
                    txtPassword.Text = String.Empty;
                }
            }
        }

        private void btnSavePassword_VisibleChanged(object sender, EventArgs e)
        {
            btnSavePassword.Text = "Select Password";
            txtPassword.Text = String.Empty;
        }
    }
}
