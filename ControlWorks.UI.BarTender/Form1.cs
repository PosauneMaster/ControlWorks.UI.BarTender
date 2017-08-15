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

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Label_Sample;
            lblTemplateName.Text = "Sample_Temple_Name_Example";

            var id = 2528;
            var timestamp = DateTime.Now;
            var boxcount = 106;

            for (int i=1;i<20;i++)
            {
                timestamp = timestamp.AddSeconds(-2000);
                id = id - 1;

                listBox1.Items.Add($"Job Id:\t\t20170814-{id}");
                listBox1.Items.Add($"Template:\tExample Template {i + id}");
                listBox1.Items.Add($"Start Time:\t{timestamp:yyyy-MM-dd HH:mm:ss}");
                listBox1.Items.Add($"Box Count:\t{boxcount-i}");
                listBox1.Items.Add($"Labels per Box:\t2");
                listBox1.Items.Add("__________________________________________________");
            }

            label7.Text = "Sample_Temple_Name_Example";
            label8.Text = "20170814-2795";
            label9.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            label10.Text = "2";
            label11.Text = "98";
            label13.Text = "Running";

            timer1.Enabled = true;


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

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            label13.Text = "Stopped";
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 100;
            progressBar1.Visible = false;
            label2.Visible = true;


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            label13.Text = "Running";
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 50;
            progressBar1.Visible = true;
            label2.Visible = false;

            //string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            //string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            //var keyboardProc = Process.Start(keyboardPath);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = !pictureBox2.Visible;
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = flipImage;
        }
    }
}
