using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Proxy
{
    class BusService
    {
        Sender _sender;
        public BusService(Sender sender)
        {
            _sender = sender;
        }

        public void SendRequest(string str)
        {
            _sender.Send(str);
        }
    }
}
