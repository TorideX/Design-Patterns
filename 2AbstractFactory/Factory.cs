using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AbstractFactory
{
    public abstract class Factory
    {
        public abstract Button CreateButton(string text, int x, int y);
        public abstract CheckBox CreateCheckBox(string text, int x, int y);
    }

    public class RedUIFactory : Factory
    {
        public override Button CreateButton(string text, int x, int y)
        {
            return new RedButton(text, x, y);
        }

        public override CheckBox CreateCheckBox(string text, int x, int y)
        {
            return new RedCheckBox(text, x, y);

        }
    }
    public class LightWayUIFactory : Factory
    {
        public override Button CreateButton(string text, int x, int y)
        {
            return new LightWayButton(text, x, y);
        }

        public override CheckBox CreateCheckBox(string text, int x, int y)
        {
            return new LightWayCheckBox(text, x, y);

        }
    }
}
