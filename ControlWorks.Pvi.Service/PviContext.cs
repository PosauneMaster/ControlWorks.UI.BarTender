using System;
using System.Windows.Forms;
using BR.AN.PviServices;
using log4net;

namespace ControlWorks.Pvi.Service
{
    internal class PviContext : ApplicationContext
    {
        private ILog _log = LogManager.GetLogger("FileLogger");

        public event EventHandler<CpuConnectEventArgs> CpuConnect;

        public BR.AN.PviServices.Service PviService { get; set; }
        public CpuManager CpuService { get; private set; }

        public PviContext()
        {
            ConnectPvi();
        }

        private void ConnectPvi()
        {
            var pviManager = new PviManager();
            pviManager.ServiceConnected += PviManager_ServiceConnected;
            pviManager.ConnectPvi();
        }

        private void PviManager_ServiceConnected(object sender, PviEventArgs e)
        {
            PviService = sender as BR.AN.PviServices.Service;

            var cpuService = new CpuManager(PviService);
            cpuService.CpuConnect += CpuService_CpuConnect;
            cpuService.CreateCpu("Cpu1", "192.168.0.101");

        }

        protected void OnCpuConnect(CpuConnectEventArgs a)
        {
            var temp = CpuConnect;
            temp?.Invoke(this, a);
        }

        private void CpuService_CpuConnect(object sender, CpuConnectEventArgs e)
        {
            OnCpuConnect(e);
        }
    }
}
