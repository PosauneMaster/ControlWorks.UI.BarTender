using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorks.ConfigurationProvider
{
    public static class Settings
    {
        public static string BartenderTemplatesBaseDirectory => ConfigurationManager.AppSettings["BartenderTemplatesBaseDirectory"];
        public static string PreviewPath => ConfigurationManager.AppSettings["PreviewPath"];
        public static string WindowsState => ConfigurationManager.AppSettings["WindowsState"];

    }
}
