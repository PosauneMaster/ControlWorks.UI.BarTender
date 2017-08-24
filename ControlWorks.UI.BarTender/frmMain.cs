using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            toolStrip1_Resize(this, new EventArgs());
            toolStripLabel2.BackColor = Color.Red;
            tabControl1.BringToFront();

            panel1.Paint += Panel1_Paint;
            panel2.Paint += Panel1_Paint;
            panel3.Paint += Panel1_Paint;
            panel4.Paint += Panel1_Paint;
            panel5.Paint += Panel1_Paint;
        }

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
    }
}
