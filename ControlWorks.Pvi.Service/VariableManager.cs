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

        public event EventHandler<VariableEventArgs> VariablesChanged;
        private Cpu _cpu;
        public VariableCollection Variables { get; private set; }

        public VariableManager(Cpu cpu)
        {
            _cpu = cpu;
            CreateVariables();
        }

        public void SetVariable(string name, object val)
        {
            _log.Info($"VariableManager.SetVariable name={name} val={val}");
            Variables[name].WriteValueAutomatic = false;

            if (val.ToString() == "1")
            {
                Variables[name].Value.Assign((object)true);
            }
            else
            {
                Variables[name].Value.Assign((object)false);
            }

            Variables[name].WriteValue();
        }

        public void CreateVariables()
        {
            CreateVariable(_cpu, "PVI.SideLabelPosition");
            CreateVariable(_cpu, "PVI.StatusText");
            CreateVariable(_cpu, "PVI.Speed[0]");
            CreateVariable(_cpu, "PVI.Speed[1]");
            CreateVariable(_cpu, "PVI.LabelApplyFormat");
            CreateVariable(_cpu, "PVI.Command[0]"); //Start Conveyor
            CreateVariable(_cpu, "PVI.Command[1]"); //Stop Conveyor
            CreateVariable(_cpu, "PVI.Command[2]"); //Reset Conveyor
            CreateVariable(_cpu, "PVI.Command[3]"); //Printer ON/OFF
            CreateVariable(_cpu, "PVI.Command[4]"); //RefreshLabel


            CreateVariable(_cpu, "PVI.Counter[0]"); //Number of Boxes
            CreateVariable(_cpu, "PVI.Counter[1]"); //Number of Front Labels
            CreateVariable(_cpu, "PVI.Counter[2]"); //Number of Side Labels
            CreateVariable(_cpu, "PVI.Counter[3]"); //Total Labels Applied

            CreateVariable(_cpu, "PVI.Command[6]"); //Number of Boxes Reset
            CreateVariable(_cpu, "PVI.Command[7]"); //Number of Front Labels Reset
            CreateVariable(_cpu, "PVI.Command[8]"); //Number of Side Labels Reset
            CreateVariable(_cpu, "PVI.Command[9]"); //Total Labels Applied Reset

            CreateVariable(_cpu, "PVI.Status[0]"); //Conveyors Running
            CreateVariable(_cpu, "PVI.Status[1]"); //Printer is ON and OK


            Variables = _cpu.Variables;
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

        private void Variable_ValueChanged1(object sender, BR.AN.PviServices.VariableEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Variable_Error(object sender, PviEventArgs e)
        {
            string message = PviMessage.FormatMessage("Variable error: ", e);
            _log.Error(message);
        }

        private void Variable_Connected(object sender, PviEventArgs e)
        {
        }

        private void OnVariableChanged(PrinterInfoDto dto)
        {
            var temp = VariablesChanged;
            temp?.Invoke(this, new VariableEventArgs() { PrinterInfo = dto });
        }

        public void SetVariables(PrinterInfoDto dto)
        {
            if (dto.LabelApplyFormat.HasValue)
            {
                Variables["PVI.LabelApplyFormat"].Value.Assign(dto.LabelApplyFormat.Value);
                Variables["PVI.LabelApplyFormat"].WriteValue();
            }
            if (dto.SideLabelPosition.HasValue)
            {
                Variables["PVI.SideLabelPosition"].Value.Assign(dto.SideLabelPosition.Value);
                Variables["PVI.SideLabelPosition"].WriteValue();
            }
            if (dto.InfeedSpeed.HasValue)
            {
                Variables["PVI.Speed[0]"].Value.Assign(dto.InfeedSpeed.Value);
                Variables["PVI.Speed[0]"].WriteValue();
            }
            if (dto.PrinterConveyorSpeed.HasValue)
            {
                Variables["PVI.Speed[1]"].Value.Assign(dto.PrinterConveyorSpeed.Value);
                Variables["PVI.Speed[1]"].WriteValue();
            }
            if (dto.StartConveyor.HasValue)
            {
                Variables["PVI.Command[0]"].Value.Assign(dto.StartConveyor.Value);
                Variables["PVI.Command[0]"].WriteValue();
            }
            if (dto.StopConveyor.HasValue)
            {
                Variables["PVI.Command[1]"].Value.Assign(dto.StopConveyor.Value);
                Variables["PVI.Command1]"].WriteValue();
            }
        }

        private void Variable_ValueChanged(object sender, BR.AN.PviServices.VariableEventArgs e)
        {
            Variable v = sender as Variable;

            if (v != null)
            {
                _log.Info($"Variable={v.Name} Value={v.Value}");

                var printerInfo = new PrinterInfoDto();
                printerInfo.SetProperty(nameof(printerInfo.SideLabelPosition), Variables["PVI.SideLabelPosition"].Value);
                printerInfo.SetProperty(nameof(printerInfo.StatusText), Variables["PVI.StatusText"].Value);
                printerInfo.SetProperty(nameof(printerInfo.InfeedSpeed), Variables["PVI.Speed[0]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.PrinterConveyorSpeed), Variables["PVI.Speed[1]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.LabelApplyFormat), Variables["PVI.LabelApplyFormat"].Value);
                printerInfo.SetProperty(nameof(printerInfo.StartConveyor), Variables["PVI.Command[0]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.StopConveyor), Variables["PVI.Command[1]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.ResetConveyor), Variables["PVI.Command[2]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.PrinterOnOff), Variables["PVI.Command[3]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.NumberOfBoxes), Variables["PVI.Counter[0]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.NumberOfFrontLabels), Variables["PVI.Counter[1]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.NumberOfSideLabels), Variables["PVI.Counter[2]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.TotalLabelsApplied), Variables["PVI.Counter[3]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.ResetNumberOfBoxes), Variables["PVI.Command[0]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.ResetNumberOfFrontLabels), Variables["PVI.Command[1]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.ResetNumberOfSideLabels), Variables["PVI.Command[2]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.ResetTotalLabelsApplied), Variables["PVI.Command[3]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.RefreshLabel), Variables["PVI.Command[4]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.ConyorsRunning), Variables["PVI.Status[0]"].Value);
                printerInfo.SetProperty(nameof(printerInfo.PrinterOnOk), Variables["PVI.Status[1]"].Value);

                OnVariableChanged(printerInfo);

                if (v.Name == "PVI.Command[4]")
                {
                    SetVariable(v.Name, 0);
                }
            }
        }
    }

    public class VariableEventArgs : EventArgs
    {
        public PrinterInfoDto PrinterInfo { get; set; }
    }
}
