using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Command
{
    class RemoteControl
    {
        private List<ICommand> onCommands;
        private List<ICommand> offCommands;

        private ICommand _temp;

        public RemoteControl()
        {
            onCommands = new List<ICommand>();
            offCommands = new List<ICommand>();
        }

        public void SetCommand(ICommand on, ICommand off)
        {
            onCommands.Add(on);
            offCommands.Add(off);
        }

        public void SetCommandTemperature(ICommand temp)
        {
            _temp = temp;
        }

        public void TurnAll()
        {
            foreach (var item in onCommands)
            {
                item.Execute();
            }
        }

        public void TurnOff()
        {
            foreach (var item in offCommands)
            {
                item.Execute();
            }
        }

        public void SetTemperature(int temp)
        {
            _temp?.Execute(temp);
        }

        public void PressOnButton(int index)
        {
            onCommands[index].Execute();
        }
    }
}
