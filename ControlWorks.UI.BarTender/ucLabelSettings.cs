using ControlWorks.ConfigurationProvider;
using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ControlWorks.UI.BarTender
{
    public partial class ucLabelSettings : UserControl
    {
        private static readonly ILog _log = LogManager.GetLogger("FileLogger");

        //private Engine engine = null; // The BarTender Print Engine
        //private LabelFormatDocument format = null; // The currently open Format

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

        private string _selectedLabelPath = null;


        public ucLabelSettings()
        {
            InitializeComponent();
        }

        private void ucLabelSettings_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Settings.BartenderTemplatesBaseDirectory;

            Initialize();
            Reset();

        }

        private void Initialize()
        {
            txtConveyorSpeed.Text = String.Empty;

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

            LabelSize labelSize = LabelSize.dimension4x4;
            int labelRotation = 0;

            if (_currentBox != null)
            {
                labelSize = _currentBox.LabelSize;
                labelRotation = _currentBox.CurrentLabelRotation;
            }
            _currentBox = new CurrentBox(boxHeight, boxWidth, GetCurrentPictureBox(), pnlBox);
            _currentBox.LabelSize = labelSize;
            _currentBox.CurrentLabelRotation = labelRotation;
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

                if (_currentBox != null)
                {
                    _currentBox.LabelSize = size;
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
            _currentBox.CurrentLabelRotation = (_currentBox.CurrentLabelRotation + 1) % 4;
            SetRotation(_labelService.CurrentLabel.Size);
        }

        private void SetRotation(LabelSize size)
        {
            pb4x4.Visible = false;
            pb4x6.Visible = false;
            pb6x4.Visible = false;


            if (size == LabelSize.dimension4x4)
            {
                pb4x4.Visible = true;
                _currentBox.CurrentLabel = pb4x4;
            }
            else if (size == LabelSize.dimension4x6)
            {
                pb6x4.Visible = true;
                _labelService.CurrentLabel.Size = LabelSize.dimension6x4;
                _currentBox.CurrentLabel = pb6x4;
            }
            else
            {
                pb4x6.Visible = true;
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
            this.pb4x6.Image = Properties.Resources._112_UpArrowLong_Blue_24x24_72;
            this.pb4x4.Image = Properties.Resources._112_UpArrowLong_Blue_24x24_72;
            this.pb6x4.Image = Properties.Resources._112_UpArrowLong_Blue_24x24_72;

            txtTemplateName.Text = $"{DateTime.Now:yyyyMMddHHmmss}.xml";
            _currentBox.CurrentLabel = pb4x4;
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
                LabelLocation = _selectedLabelPath
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
                LablePosition = _currentBox.CurrentLabel.Location,
                LabelSize = _currentBox.LabelSize,
                CurrentLabelRotation =_currentBox.CurrentLabelRotation

    };

            var directory = Properties.Settings.Default.TemplateFilesLocation;

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

            openFileDialog1.InitialDirectory = Properties.Settings.Default.BartenderFilesLocation;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var b = sender as Button;
                if (b != null)
                {
                    b.Enabled = false;
                }
                pictureBox1.ImageLocation = String.Empty;
                _selectedLabelPath = openFileDialog1.FileName;
                var service = new BartenderService();
                var previewImagePath = service.GetPreviewFile(openFileDialog1.FileName, pictureBox1.Width, pictureBox1.Height).Result;               

                var path = service.GetMessage(previewImagePath);
                if (!String.IsNullOrEmpty(path) && File.Exists(path))
                {
                    pictureBox1.ImageLocation = path;
                }

                if (b != null)
                {
                    b.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Template Files(*.xml)| *.xml | All files(*.*) | *.*";
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

                for (int i = 0; i < template.CurrentBox.CurrentLabelRotation; i++)
                {
                    SetRotation(_currentBox.LabelSize);
                }
            }
        }

        private void btnTestPrint_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_selectedLabelPath))
            {
                var b = sender as Button;
                if (b != null)
                {
                    b.Enabled = false;
                }

                var service = new BartenderService();
                service.PrintFile(_selectedLabelPath).ConfigureAwait(false);

                if (b != null)
                {
                    b.Enabled = true;
                }

            }
        }
    }

    public class UserControlEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
