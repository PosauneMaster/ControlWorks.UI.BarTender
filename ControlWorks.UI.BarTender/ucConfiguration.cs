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
    }
}
