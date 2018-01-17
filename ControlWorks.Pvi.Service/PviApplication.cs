using log4net;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Dynamic;
using BR.AN.PviServices;

namespace ControlWorks.Pvi.Service
{
    public interface IPivApplication
    {

    }

    public class PviApplication : IPivApplication
    {
        private readonly ILog _log = LogManager.GetLogger("FileLogger");

        public event EventHandler<VariableEventArgs> VariablesChanged;

        private PviContext _context;
        private DateTime _connectionTime;
        private VariableManager _variableManager;


        public PviApplication() { }

        public void Connect()
        {
            _context = new PviContext();
            _context.CpuConnect += _context_CpuConnect;
            _connectionTime = DateTime.Now;

            _log.Info($"Creating Pvi Service at {_connectionTime: yyyy-MM-dd HH:mm:ss}");

            System.Threading.Tasks.Task.Run(() => Application.Run(_context));
        }

        public void SetVariable(string name, object val)
        {
            _variableManager.SetVariable(name, val);
        }

        public void SetVariables(PrinterInfoDto dto)
        {
            _variableManager.SetVariables(dto);
        }

        private void _context_CpuConnect(object sender, CpuConnectEventArgs e)
        {
            if (e.VariableManager != null)
            {
                _variableManager = e.VariableManager;
                _variableManager.VariablesChanged += _variableManager_VariablesChanged;
            }
        }

        private void _variableManager_VariablesChanged(object sender, VariableEventArgs e)
        {
            var temp = VariablesChanged;
            temp?.Invoke(this, e);
        }

        public string GetServiceName()
        {
            return _context.PviService.Name;
        }
        public bool IsPviServiceConnected()
        {
            return _context.PviService.IsConnected;
        }

        public List<Tuple<string, bool>> GetCpuStatuses()
        {
            var list = new List<Tuple<string, bool>>();
            foreach (Cpu cpu in _context.PviService.Cpus)
            {
                var tuple = new Tuple<string, bool>(cpu.Name, cpu.IsConnected);
            }

            return list;
        }
    }
}
