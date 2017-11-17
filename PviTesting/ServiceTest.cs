using BR.AN.PviServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PviTesting
{
    public class ServiceTest
    {
        public void Connect()
        {
            var service = new Service("service");
            service.Connect();
        }
    }
}
