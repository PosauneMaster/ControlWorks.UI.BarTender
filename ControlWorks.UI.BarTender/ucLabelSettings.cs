using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ControlWorks.UI.BarTender
{
    public partial class ucLabelSettings : UserControl
    {

        private readonly string _labelsizesmall = "4 x 4";
        private readonly string _labelsizelarge = "4 x 6";

        private Point _smallLabelCenterLocation; //165, 190
        private Point _largeLabelCenterLocation; //165, 160
        private Point _labelEdgeLocation;   //327, 3

        private LabelService _labelService;

        private CurrentBox _currentBox;


        public ucLabelSettings()
        {
            InitializeComponent();
        }

        private void ucLabelSettings_Load(object sender, EventArgs e)
        {

            _labelService = new LabelService();
            _labelService.LabelSizeChanged += _labelService_LabelSizeChanged;
            _labelService.LabelPositionChanged += _labelService_LabelPositionChanged;

            cboLabelSize.Items.Add(_labelsizesmall);
            cboLabelSize.Items.Add(_labelsizelarge);
            cboLabelSize.SelectedIndex = 1;

            _smallLabelCenterLocation = pb4x4.Location;
            _largeLabelCenterLocation = pb4x6.Location;
            _labelEdgeLocation = new Point(327, 3);

            cboLabelPosition.DataSource = Enum.GetValues(typeof(LabelPositon));
            cboLabelPosition.SelectedIndex = 2;

        }

        private void _currentBox_LabelMoved(object sender, CurrentBoxEventArgs e)
        {
            lblLeftDistance.Text = $"{_currentBox.LabelToLeftCurrentInches.ToString("N2")} inches";
            lblRightDistance.Text = $"{_currentBox.LabelToRightCurrentInches.ToString("N2")} inches";

        }

        protected virtual bool ProcessKey(Keys keyData)
        {
            return false;
        }

    private void _labelService_LabelSizeChanged(object sender, LabelServiceEventArgs e)
        {
            Debug.WriteLine($"Label Size selected = {e.Label.Size}");

            if (e.Label.Size == LabelSize.dimension4x4)
            {
                pb4x4.Visible = true;
                pb4x6.Visible = false;
            }
            else
            {
                pb4x4.Visible = false;
                pb4x6.Visible = true;
            }

            SetCurrentBox();

        }

        private void _labelService_LabelPositionChanged(object sender, LabelServiceEventArgs e)
        {
            btnRight.Enabled = false;
            btnLeft.Enabled = false;

            lblRightDistance.Visible = true;
            lblLeftDistance.Visible = true;

            if (e.Label.Position == LabelPositon.Center)
            {
                pb4x4.Location = _smallLabelCenterLocation;
                pb4x6.Location = _largeLabelCenterLocation;
            }
            else if (e.Label.Position == LabelPositon.Edge)
            {
                pb4x4.Location = _labelEdgeLocation;
                pb4x6.Location = _labelEdgeLocation;
                lblRightDistance.Visible = false;
                lblLeftDistance.Visible = false;

            }
            else
            {
                pb4x4.Location = _smallLabelCenterLocation;
                pb4x6.Location = _largeLabelCenterLocation;
                btnRight.Enabled = true;
                btnLeft.Enabled = true;

            }

        }

        private void SetCurrentBox()
        {
            double boxHeight = Double.Parse(txtHeight.Text);
            double boxWidth = Double.Parse(txtWidth.Text);
            _currentBox = new CurrentBox(boxHeight, boxWidth, GetCurrentPictureBox(), pnlBox);
            _currentBox.LabelMoved += _currentBox_LabelMoved;

            lblLeftDistance.Text = $"{_currentBox.LabelToLeftCurrentInches} inches";
            lblRightDistance.Text = $"{_currentBox.LabelToRightCurrentInches} inches";

        }


        private void cboLabelPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbo = sender as ComboBox;
            if (cbo != null)
            {
                LabelPositon position;

                if (Enum.TryParse<LabelPositon>(cbo.SelectedItem.ToString(), out position))
                {
                    if (_labelService != null)
                    {
                        _labelService.ChangeLabelPosition(position);
                    }
                }
            }

        }

        private void cboLabelSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbo = sender as ComboBox;

            if (cbo != null)
            {
                LabelSize size;
                if (cbo.SelectedItem.ToString() == _labelsizesmall)
                {
                    size = LabelSize.dimension4x4;
                }
                else
                {
                    size = LabelSize.dimension4x6;
                }

                if (_labelService != null)
                {
                    _labelService.ChangeLabelSize(size);
                }
            }
        }

        private PictureBox GetCurrentPictureBox()
        {
            if (pb4x4.Visible)
            {
                return pb4x4;
            }

            return pb4x6;
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            _currentBox.MoveLabelRight();
            tmrMoveRight.Start();
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            tmrMoveRight.Stop();
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            _currentBox.MoveLabelLeft();
            tmrMoveLeft.Start();
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            tmrMoveLeft.Stop();
        }

        private void tmrMoveRight_Tick(object sender, EventArgs e)
        {
            _currentBox.MoveLabelRight();
        }

        private void tmrMoveLeft_Tick(object sender, EventArgs e)
        {
            _currentBox.MoveLabelLeft();
        }
    }
}
