using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Facade
{
    class FacadeDirectX
    {
        private MyDirectX56 _directX56;

        public FacadeDirectX(MyDirectX56 direct)
        {
            _directX56 = direct;
        }

        public void PlaySound()
        {
            _directX56.PlaySound();
        }
        public void DisturbNotifications()
        {
            _directX56.DisturbNotifications();
        }
    }
}
