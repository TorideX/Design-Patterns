using _2AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Builder
{
    class Director
    {
        private ButtonBuilder _buttonBuilder;

        public Director(ButtonBuilder buttonBuilder)
        {
            _buttonBuilder = buttonBuilder;
        }

        public Button GetButton()
        {
            return _buttonBuilder.WithText("asd").WithHeight(12).WithWidth(4).BuildButton();
        }

        public ButtonBuilder GetBuilderReference() => _buttonBuilder;
    }
}
