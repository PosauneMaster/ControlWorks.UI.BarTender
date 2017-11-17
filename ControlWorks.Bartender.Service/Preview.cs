using Seagull.BarTender.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlWorks.ConfigurationProvider;
using System.IO;

namespace ControlWorks.Bartender.Service
{

    public interface IPreview
    {
        string GetImageFile(string filename, string printername, int width, int height);
    }
    public class Preview : IPreview
    {
        private Engine _engine = null; // The BarTender Print Engine.
        private LabelFormatDocument _format = null; // The format that will be exported.

        public Preview(Engine engine)
        {
            _engine = engine;
        }

        public string GetImageFile(string filename, string printername, int width, int height)
        {

           
            var format = _engine.Documents.Open(filename);
            format.PrintSetup.PrinterName = printername;

            var previewPath = Settings.PreviewPath;

            Array.ForEach(Directory.GetFiles(previewPath), File.Delete);
            Messages messages = new Messages();

            format.ExportPrintPreviewToFile(previewPath, "PrintPreview%PageNumber%.jpg", ImageType.JPEG, ColorDepth.ColorDepth24bit, new Resolution(width, height), System.Drawing.Color.White, OverwriteOptions.Overwrite, true, true, out messages);

            return null;
        }
    }
}
