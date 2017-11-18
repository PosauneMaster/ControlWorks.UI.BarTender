using BR.AN.PviServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorks.Pvi.Service
{
    public class PviMessage
    {
        public static string FormatMessage(string message, PviEventArgs e)
        {
            return $"{message}; Action={e.Action}, Address={e.Address}, Error Code={e.ErrorCode}, Error Text={e.ErrorText}, Name={e.Name}";
        }

    }
}
