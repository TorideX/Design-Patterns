using _2AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Builder
{
    public abstract class ButtonBuilder
    {
        public abstract Button BuildButton();
        public abstract ButtonBuilder WithX(int value);
        public abstract ButtonBuilder WithY(int value);
        public abstract ButtonBuilder WithHeight(int value);
        public abstract ButtonBuilder WithWidth(int value);
        public abstract ButtonBuilder WithText(string value);
    }

    public class RedButtonBuilder : ButtonBuilder
    {
        private RedButton redButton;
        public RedButtonBuilder()
        {
            redButton = new RedButton();
        }
        public override Button BuildButton()
        {
            return redButton;
        }

        public override ButtonBuilder WithHeight(int value)
        {
            redButton.Height = value;
            return this;
        }

        public override ButtonBuilder WithText(string value)
        {
            redButton.Text = value;
            redButton.Tooltip = value;
            return this;
        }

        public override ButtonBuilder WithWidth(int value)
        {
            redButton.Width = value;
            return this;
        }

        public override ButtonBuilder WithX(int value)
        {
            redButton.x = value;
            return this;
        }

        public override ButtonBuilder WithY(int value)
        {
            redButton.y = value;
            return this;
        }
    }

    public class LightWayButtonBuilder : ButtonBuilder
    {
        private LightWayButton lightButton;
        public LightWayButtonBuilder()
        {
            lightButton = new LightWayButton();
        }
        public override Button BuildButton()
        {
            return lightButton;
        }

        public override ButtonBuilder WithHeight(int value)
        {
            lightButton.Height = value;
            return this;
        }

        public override ButtonBuilder WithText(string value)
        {
            lightButton.Text = value;
            lightButton.Tooltip = value;
            return this;
        }

        public override ButtonBuilder WithWidth(int value)
        {
            lightButton.Width = value;
            return this;
        }

        public override ButtonBuilder WithX(int value)
        {
            lightButton.x = value;
            return this;
        }

        public override ButtonBuilder WithY(int value)
        {
            lightButton.y = value;
            return this;
        }
    }
}
