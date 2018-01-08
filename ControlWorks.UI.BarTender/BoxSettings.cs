using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorks.UI.BarTender
{
    public class BoxSettings
    {
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
        public int LabelInchWidth { get; set; }
        public Point LablePosition { get; set; }
        public LabelSize LabelSize { get; set; }
        public int CurrentLabelRotation { get; set; }

    }
}
