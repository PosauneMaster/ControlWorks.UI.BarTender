using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ControlWorks.UI.BarTender
{
    public class TemplateSettings
    {
        public string TemplateName { get; set; }
        public string LabelPlacement { get; set; }
        public string InfeedSpeed { get; set; }
        public string PrinterSpeed { get; set; }
        public string BoxHeight {get; set;}
        public string BoxWidth { get; set; }
        public string LabelSize { get; set; }
        public string LabelPositon { get; set; }
        public string LeftOffset { get; set; }
        public string RightOffset { get; set; }
        public string LabelLocation { get; set; }
        public BoxSettings CurrentBox { get; set; }

        public string ToXml()
        {
            using (var writer = new StringWriter())
            {
                var serializer = new XmlSerializer(GetType());
                serializer.Serialize(writer, this);
                return writer.ToString();
            }
        }

        public static TemplateSettings CreateFromXml(string xml)
        {
            TemplateSettings result;
            var serializer = new XmlSerializer(typeof(TemplateSettings));
            using (var reader = new StringReader(xml))
            {
                result = serializer.Deserialize(reader) as TemplateSettings;
            }

            return result;

        }
    }
}
