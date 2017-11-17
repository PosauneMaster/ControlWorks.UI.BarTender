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
        private ILog _log = LogManager.GetLogger("FileLogger");
        private PviContext _context;
        private DateTime _connectionTime;

        public PviApplication() { }

        public void Connect()
        {
            _context = new PviContext();
            _connectionTime = DateTime.Now;

            _log.Info($"Creating Pvi Service at {_connectionTime: yyyy-MM-dd HH:mm:ss}");

            System.Threading.Tasks.Task.Run(() => Application.Run(_context));
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
