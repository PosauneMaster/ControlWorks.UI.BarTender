using log4net;
using Seagull.BarTender.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorks.Bartender.Service
{
    public class BartenderService
    {
        private ILog _log = LogManager.GetLogger("FileLogger");

        public string GetPreviewImage(string filename, string printername, int width, int height)
        {
            _log.Debug($"GetPreviewImage for filename={filename}");

            try
            {
                using (var engine = new Engine(true))
                {
                    var preview = new Preview(engine);
                    preview.GetImageFile(filename, printername,  width, height);
                }

            }
            catch (Exception ex)
            {
                _log.Error($"BartenderService.GetPreviewImage error for filename={filename}", ex);
            }

            return null;

        }
    }
}
