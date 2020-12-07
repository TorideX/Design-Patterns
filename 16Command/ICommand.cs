using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Command
{
    interface ICommand
    {
        void Execute(object obj = null);
    }

    public class LightOnCommand : ICommand
    {
        private SmartLight _smartLight;
        public LightOnCommand(SmartLight smartLight)
        {
            _smartLight = smartLight;
        }
        public void Execute(object obj = null)
        {
            _smartLight.On();
        }
    }

    public class LightOffCommand : ICommand
    {
        private SmartLight _smartLight;
        public LightOffCommand(SmartLight smartLight)
        {
            _smartLight = smartLight;
        }
        public void Execute(object obj = null)
        {
            _smartLight.Off();
        }
    }

    public class ConditionerOnCommand : ICommand
    {
        private SmartConditioner _smartConditioner;
        public ConditionerOnCommand(SmartConditioner smartConditioner)
        {
            _smartConditioner = smartConditioner;
        }
        public void Execute(object obj = null)
        {
            _smartConditioner.Start(); 
        }
    }

    public class ConditionerOffCommand : ICommand
    {
        private SmartConditioner _smartConditioner;
        public ConditionerOffCommand(SmartConditioner smartConditioner)
        {
            _smartConditioner = smartConditioner;
        }
        public void Execute(object obj = null)
        {
            _smartConditioner.Stop();
        }
    }

    public class ConditionerSetTempCommand : ICommand
    {
        private SmartConditioner _smartConditioner;
        public ConditionerSetTempCommand(SmartConditioner smartConditioner)
        {
            _smartConditioner = smartConditioner;
        }
        public void Execute(object obj = null)
        {
            int temp = (int)obj;
            _smartConditioner.SetTemp(temp);
        }
    }
}
