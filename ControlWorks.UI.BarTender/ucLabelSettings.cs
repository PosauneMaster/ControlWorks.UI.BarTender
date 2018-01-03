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
using ControlWorks.ConfigurationProvider;
using ControlWorks.Bartender.Service;
using Seagull.BarTender.Print;
using System.IO;

namespace ControlWorks.UI.BarTender
{
    public partial class ucLabelSettings : UserControl
    {
        public event EventHandler<UserControlEventArgs> Message;
        private bool _isRotated = false;

        private readonly string _labelsizesmall = "4 x 4";
        private readonly string _labelsizelarge = "4 x 6";

        private Point _smallLabelCenterLocation; //165, 190
        private Point _largeLabelCenterLocation; //165, 160
        private Point _rotatedLabelCenterLocation;
        private Point _labelEdgeLocation;   //327, 3

        private LabelService _labelService;

        private CurrentBox _currentBox;


        public ucLabelSettings()
        {
            InitializeComponent();
        }

        private void ucLabelSettings_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Settings.BartenderTemplatesBaseDirectory;

            Initialize();

        }

        private void Initialize()
        {
            txtConveyorSpeed.Text = String.Empty;
            txtTemplateName.Text = String.Empty;

            txtHeight.Text = "12";
            txtWidth.Text = "12";

            _labelService = new LabelService();
            _labelService.LabelSizeChanged += _labelService_LabelSizeChanged;
            _labelService.LabelPositionChanged += _labelService_LabelPositionChanged;

            cboLabelSize.Items.Clear();

            cboLabelSize.Items.Add(_labelsizesmall);
            cboLabelSize.Items.Add(_labelsizelarge);
            cboLabelSize.SelectedIndex = 1;

            _smallLabelCenterLocation = pb4x4.Location;
            _largeLabelCenterLocation = pb4x6.Location;
            _rotatedLabelCenterLocation = pb6x4.Location;
            _labelEdgeLocation = new Point(310, 3);

            cboLabelPosition.DataSource = Enum.GetValues(typeof(LabelPositon));
            cboLabelPosition.SelectedIndex = 2;

            cboLabelsPerBox.SelectedIndex = 0;
        }

        private void _currentBox_LabelMoved(object sender, CurrentBoxEventArgs e)
        {
            lblLeftDistance.Text = $"{_currentBox.LabelToLeftCurrentInches.ToString("N2")} inches";
            lblRightDistance.Text = $"{_currentBox.LabelToRightCurrentInches.ToString("N2")} inches";
        }


        private void _labelService_LabelSizeChanged(object sender, LabelServiceEventArgs e)
        {
            Debug.WriteLine($"Label Size selected = {e.Label.Size}");

            if (e.Label.Size == LabelSize.dimension4x4)
            {
                pb4x4.Visible = true;
                pb4x6.Visible = false;
                pb6x4.Visible = false;
            }
            else
            {
                pb4x4.Visible = false;
                pb4x6.Visible = !_isRotated;
                pb6x4.Visible = _isRotated;
            }

            SetCurrentBox();
            SetLableDistance();

        }

        private void _labelService_LabelPositionChanged(object sender, LabelServiceEventArgs e)
        {
            SetLabel(e.Label.Position);
        }

        private void SetLabel(LabelPositon position)
        {
            btnRight.Enabled = false;
            btnLeft.Enabled = false;

            lblRightDistance.Visible = true;
            lblLeftDistance.Visible = true;

            if (position == LabelPositon.Center)
            {
                pb4x4.Location = _smallLabelCenterLocation;
                pb4x6.Location = _largeLabelCenterLocation;
                pb4x6.Location = _largeLabelCenterLocation;
            }
            else if (position == LabelPositon.Edge)
            {
                pb4x4.Location = _labelEdgeLocation;
                pb4x6.Location = new Point(310, 3);
                pb6x4.Location = new Point(230, 3);
                lblRightDistance.Visible = false;
                lblLeftDistance.Visible = false;

            }
            else
            {
                pb4x4.Location = _smallLabelCenterLocation;
                pb4x6.Location = _largeLabelCenterLocation;
                pb6x4.Location = _rotatedLabelCenterLocation;
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
        }

        private void SetLableDistance()
        {
            lblLeftDistance.Text = $@"{_currentBox.LabelToLeftCurrentInches} inches";
            lblRightDistance.Text = $@"{_currentBox.LabelToRightCurrentInches} inches";
        }


        private void cboLabelPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBox cbo)) return;
            LabelPositon position;

            if (!Enum.TryParse<LabelPositon>(cbo.SelectedItem.ToString(), out position)) return;
            if (_labelService != null)
            {
                SetCurrentBox();
                _labelService.ChangeLabelPosition(position);
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

                _labelService?.ChangeLabelSize(size);
            }
        }

        private PictureBox GetCurrentPictureBox()
        {
            if (pb4x4.Visible)
            {
                return pb4x4;
            }
            if (pb4x6.Visible)
            {
                return pb4x6;
            }


            return pb6x4;
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

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt != null)
            {
                var frm = new frmNumpad(txt);
                frm.FormClosed += (s, ea) =>
                {
                    SetCurrentBox();
                    SetLableDistance();
                };

                Point location = txt.PointToScreen(Point.Empty);

                var x = location.X - frm.Width / 2;
                var y = location.Y + 30;

                frm.Location = new Point(x, y);

                frm.Show();
            }
        }

        private void OnCboMouseClick(object sender, MouseEventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            cbo.DroppedDown = true;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (_labelService.CurrentLabel.Size == LabelSize.dimension4x4)
            {
                pb4x4.Visible = true;
                pb4x6.Visible = false;
                pb6x4.Visible = false;
                _currentBox.CurrentLabel = pb4x4;
            }
            else if (_labelService.CurrentLabel.Size == LabelSize.dimension4x6)
            {
                pb4x4.Visible = false;
                pb4x6.Visible = false;
                pb6x4.Visible = true;
                _labelService.CurrentLabel.Size = LabelSize.dimension6x4;
                _currentBox.CurrentLabel = pb6x4;

            }
            else
            {
                pb4x4.Visible = false;
                pb4x6.Visible = true;
                pb6x4.Visible = false;
                _labelService.CurrentLabel.Size = LabelSize.dimension4x6;
                _currentBox.CurrentLabel = pb4x6;
            }

            Image flipImage = pb4x4.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate270FlipXY);
            pb4x4.Image = flipImage;

            flipImage = pb4x6.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate270FlipXY);
            pb4x6.Image = flipImage;

            flipImage = pb6x4.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate270FlipXY);
            pb6x4.Image = flipImage;

            SetCurrentBox();
            SetLableDistance();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            cboLabelSize.SelectedIndex = 1;
            cboLabelPosition.SelectedIndex = 2;
            pictureBox1.Image = null;
            Initialize();
            SetCurrentBox();
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            var template = new TemplateSettings()
            {
                TemplateName = txtTemplateName.Text,
                LablesPerBox = cboLabelsPerBox.Text,
                ConveyorSpeed = txtConveyorSpeed.Text,
                BoxHeight = txtHeight.Text,
                BoxWidth = txtWidth.Text,
                LabelSize = cboLabelSize.Text,
                LabelPositon = cboLabelPosition.Text,
                LeftOffset = lblLeftDistance.Text,
                RightOffset = lblRightDistance.Text,
                LabelLocation = pictureBox1.ImageLocation
            };

            template.CurrentBox = new BoxSettings()
            {
                LabelToRightStartInches = Math.Round(_currentBox.LabelToRightStartInches, 2, MidpointRounding.ToEven),
                LabelToRightStartPixels = Math.Round(_currentBox.LabelToRightStartPixels, 2, MidpointRounding.ToEven),
                LabelToRightCurrentInches = Math.Round(_currentBox.LabelToRightCurrentInches, 2, MidpointRounding.ToEven),
                PixelsPerTenthInchRight = Math.Round(_currentBox.PixelsPerTenthInchLeft, 2, MidpointRounding.ToEven),
                LabelToLeftStartInches = Math.Round(_currentBox.LabelToLeftStartInches, 2, MidpointRounding.ToEven),
                LabelToLeftStartPixels = Math.Round(_currentBox.LabelToLeftCurrentInches, 2, MidpointRounding.ToEven),
                LabelToLeftCurrentInches = Math.Round(_currentBox.LabelToLeftCurrentInches, 2, MidpointRounding.ToEven),
                PixelsPerTenthInchLeft = Math.Round(_currentBox.PixelsPerTenthInchLeft, 2, MidpointRounding.ToEven),
                FixedPanelRightEdge = Math.Round(_currentBox.FixedPanelRightEdge, 2, MidpointRounding.ToEven),
                FixedPanelLeftEdge = Math.Round(_currentBox.FixedPanelLeftEdge, 2, MidpointRounding.ToEven),
                LablePosition = _currentBox.CurrentLabel.Location
                
            };

            var directory = @"D:\ControlWorks\BarTender\Settings";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var filename = Path.Combine(directory, template.TemplateName);

            var templatefilename = filename;

            var index = 0;
            while (File.Exists(templatefilename))
            {
                index++;

                if (index > 100000) break;

                var f = $"{template.TemplateName.Replace(".xml", String.Empty)}({index}).xml";
                templatefilename = Path.Combine(directory, f);

            }

            File.WriteAllText(templatefilename, template.ToXml());
        }

        private void OnComboboxClicked(object sender, EventArgs e)
        {
            var cbo = sender as ComboBox;

            if (cbo != null)
            {
                cbo.DroppedDown = true;
            }
        }

        private void btnChooseLabel_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = @"Select a label to open...";
            openFileDialog1.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestImages");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }

            //var printers = new Printers();

            //openFileDialog1.Title = @"Select a label to open...";
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.Image = null;

            //    var service = new BartenderService();
            //    service.GetPreviewImage(openFileDialog1.FileName, printers.Default.PrinterName, pictureBox1.Width, pictureBox1.Height);

            //    pictureBox1.Load(@"D:\ControlWorks\BarTender\PreviewPath\PrintPreview1.jpg");

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
            txtTemplateName.Text = $"{DateTime.Now:yyyyMMddHHmmss}.xml";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var xml = File.ReadAllText(openFileDialog1.FileName);
                var template = TemplateSettings.CreateFromXml(xml);

                txtTemplateName.Text = template.TemplateName;
                cboLabelsPerBox.Text = template.LablesPerBox;
                txtConveyorSpeed.Text = template.ConveyorSpeed;
                txtHeight.Text = template.BoxHeight;
                txtWidth.Text = template.BoxWidth;
                cboLabelSize.Text = template.LabelSize;
                cboLabelPosition.Text = template.LabelPositon;
                lblLeftDistance.Text = template.LeftOffset;
                lblRightDistance.Text = template.RightOffset;

                if (!String.IsNullOrEmpty(template.LabelLocation))
                {
                    pictureBox1.Load(template.LabelLocation);
                }


                SetCurrentBox();

                var boxSettings = template.CurrentBox;

                _currentBox.LabelToRightStartInches = boxSettings.LabelToRightStartInches;
                _currentBox.LabelToRightStartPixels = boxSettings.LabelToRightStartPixels;
                _currentBox.PixelsPerTenthInchLeft = boxSettings.PixelsPerTenthInchRight;
                _currentBox.LabelToLeftStartInches = boxSettings.LabelToLeftStartInches;
                _currentBox.LabelToLeftCurrentInches = boxSettings.LabelToLeftStartPixels;
                _currentBox.PixelsPerTenthInchLeft = boxSettings.PixelsPerTenthInchLeft;
                _currentBox.FixedPanelRightEdge = boxSettings.FixedPanelRightEdge;
                _currentBox.FixedPanelLeftEdge = boxSettings.FixedPanelLeftEdge;

                _currentBox.MoveLabel(boxSettings.LablePosition, boxSettings.LabelToLeftCurrentInches, boxSettings.LabelToRightCurrentInches);
            }
        }
    }

    public class UserControlEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
