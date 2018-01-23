using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorks.Pvi.Service
{
    public class PrinterInfoDto : InternalBase
    {
        public bool? StartConveyor { get; set; }
        public bool? StopConveyor { get; set; }
        public bool? ResetConveyor { get; set; }
        public bool? PrinterOnOff { get; set; }
        public double? SideLabelPosition { get; set; }
        public int? InfeedSpeed { get; set; }
        public int? PrinterConveyorSpeed { get; set; }
        public string StatusText { get; set; }
        public int? LabelApplyFormat { get; set; }
        public bool? NumberOfBoxes { get; set; }
        public bool? NumberOfFrontLabels { get; set; }
        public bool? NumberOfSideLabels { get; set; }
        public bool? TotalLabelsApplied { get; set; }
        public bool? ResetNumberOfBoxes { get; set; }
        public bool? ResetNumberOfFrontLabels { get; set; }
        public bool? ResetNumberOfSideLabels { get; set; }
        public bool? ResetTotalLabelsApplied { get; set; }
        public bool? ConyorsRunning { get; set; }
        public bool? PrinterOnOk { get; set; }
        public bool? RefreshLabel { get; set; }
        public double? BoxDimension { get; set; }

    }

    public class InternalBase
    {
        public void SetProperty(string name, string value)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);
            PropertyDescriptor prop = props[name];

            if (prop.Converter.IsValid(value))
            {
                prop.SetValue(this, prop.Converter.ConvertFromInvariantString(value));
            }
        }
    }

}
