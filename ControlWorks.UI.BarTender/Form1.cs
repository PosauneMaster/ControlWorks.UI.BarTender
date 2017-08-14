using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWorks.UI.BarTender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            var keyboardProc = Process.Start(keyboardPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Label_Sample;
            lblTemplateName.Text = "Sample_Temple_Name_Example";
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            try
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                               Color.White,
                                                                               Color.LightBlue,
                                                                               90F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
            catch (Exception ex) { }
        }
    }
}
