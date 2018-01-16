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

        public event EventHandler<VariableEventArgs> VariablesChanged;
        
        public PviController()
        {
            _application = new PviApplication();
        }

        public void Start()
        {
            //_application.Connect();
            //_application.VariablesChanged += _application_VariablesChanged;
        }

        private void _application_VariablesChanged(object sender, VariableEventArgs e)
        {
            var temp = VariablesChanged;
            temp?.Invoke(this, e);
        }

        public string GetServiceName()
        {
            return _application.GetServiceName();
        }
        
        public bool IsServiceConnected()
        {
            return _application.IsPviServiceConnected();
        }

        public void SetVariable(string name, object val)
        {
            _application.SetVariable(name, val);
        }
    }
}
