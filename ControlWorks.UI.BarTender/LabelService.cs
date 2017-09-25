using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorks.UI.BarTender
{
    public enum LabelSize
    {
        dimension4x4,
        dimension4x6,
        dimension6x4
    };

    public enum LabelPositon
    {
        Custom,
        Edge,
        Center
    }

    public class LabelService
    {
        public event EventHandler<LabelServiceEventArgs> LabelSizeChanged;
        public event EventHandler<LabelServiceEventArgs> LabelPositionChanged;


        public Label CurrentLabel { get; set; }

        public LabelService() 
        {
            CurrentLabel = new Label();
        }

        protected virtual void OnLabelSizeChanged(LabelServiceEventArgs e)
        {
            EventHandler<LabelServiceEventArgs> handler = LabelSizeChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnLabelPositionChanged(LabelServiceEventArgs e)
        {
            EventHandler<LabelServiceEventArgs> handler = LabelPositionChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void ChangeLabelPosition(LabelPositon position)
        {
            var nextLabel = CurrentLabel.Copy();

            nextLabel.Position = position;

            CurrentLabel = nextLabel;

            OnLabelPositionChanged(new LabelServiceEventArgs() { Label = nextLabel });
        }

        public void ChangeLabelSize(LabelSize size)
        {
            var nextLabel = CurrentLabel.Copy();

            if (size == LabelSize.dimension4x4)
            {
                nextLabel.Size = LabelSize.dimension4x4;
            }
            else
            {
                nextLabel.Size = LabelSize.dimension4x6;
            }

            CurrentLabel = nextLabel;

            OnLabelSizeChanged(new LabelServiceEventArgs() { Label = nextLabel });
        }
    }

    public class Label
    {
        public LabelSize Size { get; set; }
        public LabelPositon Position { get; set; }
        public decimal OffsetLeft { get; set; }
        public decimal OffsetRight { get; set; }
        public Image LabelImage { get; set; }

        public Label()
        {
            Size = LabelSize.dimension4x4;
            Position = LabelPositon.Center;
        }

        public Label(LabelSize lableSize, LabelPositon lablePositon)
        {
            Size = lableSize;
            Position = lablePositon;
        }
        public Label Copy()
        {
            return new Label()
            {
                Size = this.Size,
                Position = this.Position,
                OffsetLeft = this.OffsetLeft,
                OffsetRight = this.OffsetRight,
                LabelImage = this.LabelImage
            };
        }
    }

    public class LabelServiceEventArgs : EventArgs
    {
        public Label Label { get; set; }
    }
}
