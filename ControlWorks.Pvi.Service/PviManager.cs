using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR.AN.PviServices;

namespace ControlWorks.Pvi.Service
{
    internal interface IPviManager
    {
        void ConnectPvi();
    }

    internal class PviManager : IPviManager, IDisposable
    {
        private ILog _log = LogManager.GetLogger("FileLogger");

        public BR.AN.PviServices.Service PviService { get; set; }

        public event EventHandler<PviEventArgs> ServiceConnected;

        public PviManager() { }
        public void ConnectPvi()
        {
            var serviceName = Guid.NewGuid().ToString();
            PviService = new BR.AN.PviServices.Service(serviceName);
            PviService.Connected += PviService_Connected;
            PviService.Disconnected += PviService_Disconnected;
            PviService.Error += PviService_Error;
            PviService.Connect();
        }

        private void PviService_Error(object sender, PviEventArgs e)
        {
            var pviEventMsg = FormatPviEventMessage("PviService_Error", e);
        }

        private void PviService_Disconnected(object sender, PviEventArgs e)
        {
            var pviEventMsg = FormatPviEventMessage("PviService_Disconnected", e);
            _log.Error(pviEventMsg);
        }

        private void PviService_Connected(object sender, PviEventArgs e)
        {
            var pviEventMsg = FormatPviEventMessage("PviService._service_Connected", e);
            _log.Error(pviEventMsg);

            OnServiceConnected(sender, e);
        }

        private void OnServiceConnected(object sender, PviEventArgs e)
        {
            if (sender is BR.AN.PviServices.Service service)
            {
                ServiceConnected?.Invoke(sender, e);
            }
        }

        private string FormatPviEventMessage(string message, BR.AN.PviServices.PviEventArgs e)
        {
            return $"{message}; Action={e.Action}, Address={e.Address}, Error Code={e.ErrorCode}, Error Text={e.ErrorText}, Name={e.Name}";
        }


        #region IDisposable

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (PviService != null)
                    {
                        PviService.Disconnect();
                        PviService.Dispose();
                    }
                }
            }
            disposed = true;
        }

        #endregion

    }
}
