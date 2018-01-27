
using System;
using BR.AN.PviServices;
using log4net;
using ControlWorks.ConfigurationProvider;

namespace ControlWorks.Pvi.Service
{

    internal class CpuManager
    {
        private readonly ILog _log = LogManager.GetLogger("FileLogger");
        private readonly byte _sourceStationId = (byte)Settings.SourceStation;
        private BR.AN.PviServices.Service _service;
        public event EventHandler<CpuConnectEventArgs> CpuConnect;

        public CpuManager(BR.AN.PviServices.Service service)
        {
            _service = service;
        }

        public void CreateCpu(string name, string ipAddress)
        {
            _log.Info($"Creating Cpu. Name={name}; IpAddress={ipAddress}");

            Cpu cpu = null;
            if (_service.Cpus.ContainsKey(name))
            {

                _log.Error($"A Cpu with the name {name} already exists. Disconnecting and updating");
                cpu = _service.Cpus[name];
                DisconnectCpu(name);
            }
            else
            {
                cpu = new Cpu(_service, name);
            }

            //192.168.0.101
            cpu.Connection.DeviceType = DeviceType.TcpIp;
            cpu.Connection.TcpIp.SourceStation = _sourceStationId;
            cpu.Connection.TcpIp.DestinationIpAddress = ipAddress;

            cpu.Connected += cpu_Connected;
            cpu.Error += cpu_Error;
            cpu.Disconnected += cpu_Disconnected;

            cpu.Connect();
        }

        public void DisconnectCpu(string name)
        {
            if (_service.Cpus.ContainsKey(name))
            {

                _log.Info($"CpuManager.DisconnectCpu Name={name}");

                Cpu cpu = _service.Cpus[name];

                if (cpu.IsConnected)
                {

                    cpu.Disconnect();

                    _service.Cpus.Remove(cpu.Name);
                }
                else
                {
                    _log.Info($"CpuManager.DisconnectCpu Name={name} Not found");
                }
            }
        }

        private void OnCpuConnect(VariableManager manager)
        {
            var temp = CpuConnect;
            if (temp != null)
            {
                temp(this, new CpuConnectEventArgs() { VariableManager = manager });
            }
        }
    private void cpu_Connected(object sender, PviEventArgs e)
        {
            Cpu cpu = sender as Cpu;

            if (cpu != null)
            {
                _log.Info($"CpuManager.cpu_Connected Name={cpu.Name}");

                var variableManager = new VariableManager(cpu);
                OnCpuConnect(variableManager);
            }
        }

        private void cpu_Error(object sender, PviEventArgs e)
        {
            _log.Error(PviMessage.FormatMessage("Cpu Error", e));

            Cpu cpu = sender as Cpu;
            if (cpu != null)
            {
                cpu.Connected -= cpu_Connected;
                cpu.Error -= cpu_Error;
                cpu.Disconnected -= cpu_Disconnected;
            }
        }

        private void cpu_Disconnected(object sender, PviEventArgs e)
        {
            _log.Error(PviMessage.FormatMessage("Cpu Disconnected", e));

            Cpu cpu = sender as Cpu;
            if (cpu != null)
            {
                cpu.Connected -= cpu_Connected;
                cpu.Error -= cpu_Error;
                cpu.Disconnected -= cpu_Disconnected;
            }
        }
      
    }

    public class CpuConnectEventArgs : EventArgs
    {
        public VariableManager VariableManager { get; set; } 
    }
}