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

//string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
//string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
//var keyboardProc = Process.Start(keyboardPath);



namespace ControlWorks.UI.BarTender
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            cboLabelsPerBox.SelectedIndex = 0;

            toolStrip1_Resize(this, new EventArgs());
            toolStripLabel2.BackColor = Color.Red;
            tabControl1.BringToFront();

            panel1.Paint += Panel1_Paint;
            panel2.Paint += Panel1_Paint;
            panel4.Paint += Panel1_Paint;
            panel5.Paint += Panel1_Paint;

            var id = 2528;
            var timestamp = DateTime.Now;
            var boxcount = 106;

            for (int i = 1; i < 20; i++)
            {
                timestamp = timestamp.AddSeconds(-2000);
                id = id - 1;

                listBox1.Items.Add($"Job Id:\t\t20170814-{id}");
                listBox1.Items.Add($"Template:\tExample Template {id}");
                listBox1.Items.Add($"Start Time:\t{timestamp:yyyy-MM-dd HH:mm:ss}");
                listBox1.Items.Add($"Box Count:\t{boxcount - i}");
                listBox1.Items.Add($"Labels per Box:\t2");
                listBox1.Items.Add("__________________________________________________");
            }






            //_labelService = new LabelService();
            //_labelService.LabelSizeChanged += _labelService_LabelSizeChanged;
            //_labelService.LabelPositionChanged += _labelService_LabelPositionChanged;

            //SetCurrentBox();

        }


        private void PnlBox_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black))
            {
                try
                {
                    //Point pLeft = new Point(0, pnlBox.Height / 2);
                    //Point pRight = new Point(pb4x4.Left, pnlBox.Height / 2);

                    //Point pLeft2 = new Point(pb4x4.Right, pnlBox.Height / 2);
                    //Point pRight2 = new Point(pnlBox.Right, pnlBox.Height / 2);

                    //e.Graphics.DrawLine(pen, pLeft, pRight);
                    //e.Graphics.DrawLine(pen, pLeft2, pRight2);

                }
                catch (Exception ex) { }
            }
        }

        //private void _labelService_LabelPositionChanged(object sender, LabelServiceEventArgs e)
        //{
        //    if (e.Label.Position == LabelPositon.Center)
        //    {
        //        pb4x4.Location = _smallLabelCenterLocation;
        //        pb4x6.Location = _largeLabelCenterLocation;
        //    }
        //    else if(e.Label.Position == LabelPositon.Edge)
        //    {
        //        pb4x4.Location = _labelEdgeLocation;
        //        pb4x6.Location = _labelEdgeLocation;
        //    }
        //    else
        //    {
        //        pb4x4.Location = _smallLabelCenterLocation;
        //        pb4x6.Location = _largeLabelCenterLocation;
        //    }
        //}

        //private void _labelService_LabelSizeChanged(object sender, LabelServiceEventArgs e)
        //{
        //    Debug.WriteLine($"Label Size selected = {e.Label.Size}");

        //    if (e.Label.Size == LabelSize.dimension4x4)
        //    {
        //        pb4x4.Visible = true;
        //        pb4x6.Visible = false;
        //    }
        //    else
        //    {
        //        pb4x4.Visible = false;
        //        pb4x6.Visible = true;
        //    }

        //    SetCurrentBox();

        //}

        //private void SetCurrentBox()
        //{
        //    double boxHeight = Double.Parse(txtHeight.Text);
        //    double boxWidth = Double.Parse(txtWidth.Text);
        //    _currentBox = new CurrentBox(boxHeight, boxWidth, GetCurrentPictureBox(), pnlBox);
        //}

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(panel2.ClientRectangle, Color.White, Color.LightBlue, 90F))
                {
                    e.Graphics.FillRectangle(brush, panel2.ClientRectangle);
                }

            }
            catch (Exception ex) { }
        }

        private void toolStrip1_Resize(object sender, EventArgs e)
        {
            toolStripLabel2.Width = toolStrip1.ClientSize.Width -10;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);
            _tabBounds.Width = _tabBounds.Width - 10;
            _textBrush = new SolidBrush(Color.Black);

            if (e.State == DrawItemState.Selected)
            {
                try
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, Color.White, Color.LightBlue, 90F))
                    {
                        e.Graphics.FillRectangle(brush, e.Bounds);
                    }
                }
                catch (Exception ex) { }
            }
            else
            {
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)14.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
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
            TextBox txt = sender as TextBox;

            if (txt != null)
            {
                var frm = new frmNumpad(txt);
                frm.MaxValue = 100.00M;

                Point location = txt.PointToScreen(Point.Empty);

                var x = location.X - frm.Width / 2;
                var y = location.Y + 30;

                frm.Location = new Point(x, y);

                frm.Show();
            }
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblTemplatePath.Text = openFileDialog1.FileName;
            }
        }
    }

}

