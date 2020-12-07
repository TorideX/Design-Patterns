using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl control = new RemoteControl();
            SmartLight light = new SmartLight();
            control.SetCommand(new LightOnCommand(light), new LightOffCommand(light));
            SmartConditioner conditioner = new SmartConditioner();
            control.SetCommand(new ConditionerOnCommand(conditioner), new ConditionerOffCommand(conditioner));


            control.SetCommandTemperature(new ConditionerSetTempCommand(conditioner));

            Console.ReadLine();
            control.TurnAll();

            Console.ReadLine();
            control.SetTemperature(67);

            Console.ReadLine();
            control.TurnOff();

            Console.ReadLine();

        }
    }
}
