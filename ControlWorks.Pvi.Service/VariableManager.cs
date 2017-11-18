using BR.AN.PviServices;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorks.Pvi.Service
{
    public class VariableManager
    {
        private readonly ILog _log = LogManager.GetLogger("FileLogger");
        private Cpu _cpu;

        public VariableManager(Cpu cpu)
        {
            _cpu = cpu;
            CreateVariables();
        }

        public void CreateVariables()
        {
            CreateVariable(_cpu, "PVI.SideLabelPosition");
            CreateVariable(_cpu, "PVI.StatusText");
            CreateVariable(_cpu, "PVI.Status");
            CreateVariable(_cpu, "PVI.Speed");
            CreateVariable(_cpu, "PVI.LabelApplyFormat");
            CreateVariable(_cpu, "PVI.Command");
        }

        private Variable CreateVariable(Cpu cpu, string name)
        {
            Variable variable = new Variable(cpu, name);
            variable.UserTag = name;
            variable.UserData = cpu.UserData;
            variable.ValueChanged += Variable_ValueChanged;
            variable.Connected += Variable_Connected;
            variable.Error += Variable_Error;
            variable.Active = true;
            variable.Connect();
            return variable;
        }

        private void Variable_Error(object sender, PviEventArgs e)
        {
            string message = PviMessage.FormatMessage("Variable error: ", e);
            _log.Error(message);
        }

        private void Variable_Connected(object sender, PviEventArgs e)
        {
        }

        private void Variable_ValueChanged(object sender, VariableEventArgs e)
        {
            Variable v = sender as Variable;

            if (v != null)
            {
                _log.Info($"Variable={v.Name} Value={v.Value}");

            }
        }




    }
}
