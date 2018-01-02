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
    public partial class ucMachineControl : UserControl
    {
        public ucMachineControl()
        {
            InitializeComponent();
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtTemplatePath.Text = openFileDialog1.FileName;
            }
        }

        public void Log(string message)
        {
            lbLog.Items.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        }
    }
}
