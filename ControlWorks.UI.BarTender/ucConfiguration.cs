using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWorks.UI.BarTender
{
    public partial class ucConfiguration : UserControl
    {
        public ucConfiguration()
        {
            InitializeComponent();
        }

        private void ucConfiguration_Load(object sender, EventArgs e)
        {
            txtBtFilesLocation.Text = Properties.Settings.Default.BartenderFilesLocation;
            txtTemplateFilesLocation.Text = Properties.Settings.Default.TemplateFilesLocation;
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
                    Properties.Settings.Default.DefaultBoxHeight = txtDefaultBoxHeight.Text;
                    Properties.Settings.Default.DefaultBoxWidth = txtDefaultBoxWidth.Text;
                    Properties.Settings.Default.Save();
                };

                frm.Show();
            }
        }

        private void ucConfiguration_VisibleChanged(object sender, EventArgs e)
        {
            txtDefaultBoxHeight.Text = Properties.Settings.Default.DefaultBoxHeight;
            txtDefaultBoxWidth.Text = Properties.Settings.Default.DefaultBoxWidth;
        }
    }
}
