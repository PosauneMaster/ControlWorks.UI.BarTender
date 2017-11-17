using ControlWorks.Pvi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorks.UI.BarTender
{
    public class PviController
    {
        private PviApplication _application;
        
        public PviController()
        {
            _application = new PviApplication();
        }

        public void Start()
        {
            _application.Connect();
        }

        public string GetServiceName()
        {
            return _application.GetServiceName();
        }
        
        public bool IsServiceConnected()
        {
            return _application.IsPviServiceConnected();
        }
    }
}
