using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWorks.UI.BarTender
{
    public class CurrentBox
    {
        public event EventHandler<CurrentBoxEventArgs> LabelMoved;

        public double Height { get; set; }
        public double Width { get; set; }
        public double LabelToRightStartInches { get; set; }
        public double LabelToRightStartPixels { get; set; }
        public double LabelToRightCurrentInches { get; set; }
        public double PixelsPerTenthInchRight { get; set; }
        public double LabelToLeftStartInches { get; set; }
        public double LabelToLeftStartPixels { get; set; }
        public double LabelToLeftCurrentInches { get; set; }
        public double PixelsPerTenthInchLeft { get; set; }
        public double FixedPanelRightEdge { get; set; }
        public double FixedPanelLeftEdge { get; set; }
        public PictureBox CurrentLabel { get; set; }
        public Panel FixedPanel { get; set; }
        public int LabelInchWidth { get; set; }


        public CurrentBox() { }
        public CurrentBox(double height, double width, PictureBox label, Panel fixedPanel)
        {
            Height = height;
            Width = width;
            CurrentLabel = label;
            FixedPanel = fixedPanel;

            LabelInchWidth = 4;
            if (label.Tag != null)
            {
                int w;
                Int32.TryParse(label.Tag.ToString(), out w);
                LabelInchWidth = w;
            }
            SetLabel();
        }

        private void SetLabel()
        {
            LabelToRightStartInches = Math.Round(Width / 2 - LabelInchWidth / 2, 2, MidpointRounding.ToEven);
            LabelToRightCurrentInches = Math.Round(Width / 2 - LabelInchWidth / 2, 2, MidpointRounding.ToEven);
            LabelToRightStartPixels = Math.Round((double)FixedPanel.Right - (double)CurrentLabel.Right ,2, MidpointRounding.ToEven);
            PixelsPerTenthInchRight = Math.Round(LabelToRightStartPixels / LabelToRightStartInches / 10, MidpointRounding.ToEven);
            FixedPanelRightEdge = Math.Round((double)FixedPanel.Right - (double)FixedPanel.Left - PixelsPerTenthInchRight * 2, 2, MidpointRounding.ToEven);

            LabelToLeftStartInches = Math.Round(Width / 2 - LabelInchWidth / 2, 2, MidpointRounding.ToEven);
            LabelToLeftCurrentInches = Math.Round(Width / 2 - LabelInchWidth / 2, 2, MidpointRounding.ToEven);
            LabelToLeftStartPixels = Math.Round((double)FixedPanel.Right - (double)CurrentLabel.Right, 2, MidpointRounding.ToEven);
            PixelsPerTenthInchLeft = Math.Round(LabelToLeftStartPixels / LabelToLeftStartInches / 10, MidpointRounding.ToEven);
        }

        protected void OnLabelMoved()
        {
            EventHandler<CurrentBoxEventArgs> handler = LabelMoved;
            if (handler != null)
            {
                handler(this, new CurrentBoxEventArgs());
            }
        }

        public void MoveLabelRight()
        {
            if (CurrentLabel.Right  < FixedPanelRightEdge)
            {
                int maxX = Math.Min((int)(CurrentLabel.Location.X + PixelsPerTenthInchRight), (int)FixedPanelRightEdge);
                var location = new Point(maxX, CurrentLabel.Location.Y);

                CurrentLabel.Location = location;

                LabelToRightCurrentInches -= 0.1D;
                LabelToLeftCurrentInches += 0.1D;

                OnLabelMoved();
            }
        }

        public void MoveLabelLeft()
        {
            if (CurrentLabel.Left > FixedPanelLeftEdge)
            {
                var location = new Point(CurrentLabel.Location.X - (int)PixelsPerTenthInchLeft, CurrentLabel.Location.Y);
                CurrentLabel.Location = location;
                LabelToRightCurrentInches += 0.1D;
                LabelToLeftCurrentInches -= 0.1D;

                OnLabelMoved();
            }
        }

        public void MoveLabel(Point location, double left, double right)
        {
            if (CurrentLabel.Left > FixedPanelLeftEdge)
            {
                CurrentLabel.Location = location;
                LabelToRightCurrentInches = right;
                LabelToLeftCurrentInches = left;

                OnLabelMoved();
            }
        }

        public void RotateLabel(double height, double width, PictureBox label, Panel fixedPanel)
        {
            //Image flipImage = CurrentLabel.Image;
            //flipImage.RotateFlip(RotateFlipType.Rotate270FlipXY);
            //CurrentLabel.Image = flipImage;

            Height = height;
            Width = width;
            CurrentLabel = label;
            FixedPanel = fixedPanel;

            SetLabel();

            OnLabelMoved();
        }
    }

    public class CurrentBoxEventArgs : EventArgs
    {

    }
}
