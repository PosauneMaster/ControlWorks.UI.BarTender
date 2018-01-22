﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace ControlWorks.UI.BarTender
{
    public partial class ucConfiguration : UserControl
    {
        private readonly ILog _log = LogManager.GetLogger("FileLogger");

        private Color _defaultBackColor;
        private Color _defaultForeColor;
        public ucConfiguration()
        {
            InitializeComponent();
        }

        private void ucConfiguration_Load(object sender, EventArgs e)
        {
            txtBtFilesLocation.Text = Properties.Settings.Default.BartenderFilesLocation;
            txtTemplateFilesLocation.Text = Properties.Settings.Default.TemplateFilesLocation;

            lblManualSide.Text = String.Empty;
            lblManualFront.Text = String.Empty;

            _defaultBackColor = btnManualFront.BackColor;
            _defaultForeColor = btnManualFront.ForeColor;
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
    }
}
