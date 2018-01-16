using log4net;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ControlWorks.ConfigurationProvider;

//string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
//string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
//var keyboardProc = Process.Start(keyboardPath);


namespace ControlWorks.UI.BarTender
{
    public partial class frmMain : Form
    {
        private ucMachineControl _machineControl;
        private ucLabelSettings _labelSettings;
        private ucConfiguration _appConfiguration;

        private ILog _log = LogManager.GetLogger("FileLogger");
        public frmMain()
        {
            InitializeComponent();
        }

        private void SetWindowState()
        {
            switch(Settings.WindowsState)
            {
                case "Maximized":
                    WindowState = FormWindowState.Maximized;
                    break;
                case "Minimized":
                    WindowState = FormWindowState.Minimized;
                    break;
                default:
                    WindowState = FormWindowState.Normal;
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            _log.Info("Loading Main Form");
            SetWindowState();
            _log.Info($"Setting WindowsState to {WindowState}");

            _machineControl = new ucMachineControl();
            _labelSettings = new ucLabelSettings();
            _appConfiguration = new ucConfiguration();

            _machineControl.PropertyChanged += _machineControl_PropertyChanged;


            pnlMachineControl.Controls.Add(_machineControl);
            pnlLabelSettings.Controls.Add(_labelSettings);
            pnlConfiguration.Controls.Add(_appConfiguration);
            pnlLabelSettings.Visible = false;
            pnlConfiguration.Visible = false;

        }

        private void _machineControl_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Status")
            {
                lblStatus.Text = _machineControl.Status;
            }
        }

        private void toolStrip1_Resize(object sender, EventArgs e)
        {
            toolStripLabel2.Width = toolStrip1.ClientSize.Width -10;
        }

        private bool _heartbeat = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_heartbeat)
            {
                toolStripLabel2.Image = Properties.Resources.TransparentLight;
            }
            else
            {
                toolStripLabel2.Image = Properties.Resources.greenlight2;
            }

            _heartbeat = !_heartbeat;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabcontrol = sender as TabControl;

            toolStripLabel2.Text = tabcontrol.SelectedTab.Text;
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (sender is TextBox txt)
            {
                var frm = new frmNumpad(txt) {MaxValue = 100.00M};
                frm.SetLocation(txt.Right, txt.Top);


                Point location = txt.PointToScreen(Point.Empty);

                var x = location.X - frm.Width / 2;
                var y = location.Y + 30;

                frm.Location = new Point(x, y);

                frm.Show();
            }
        }

        private void btnMachineControl_Click(object sender, EventArgs e)
        {
            pnlLabelSettings.Visible = false;
            pnlMachineControl.Visible = true;
            pnlConfiguration.Visible = false;

        }

        private void btnLabelSetup_Click(object sender, EventArgs e)
        {
            pnlLabelSettings.Visible = true;
            pnlMachineControl.Visible = false;
            pnlConfiguration.Visible = false;

        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            pnlLabelSettings.Visible = false;
            pnlMachineControl.Visible = false;
            pnlConfiguration.Visible = true;
        }
    }

}

