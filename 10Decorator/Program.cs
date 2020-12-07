using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Notificator a = new SkypeNotificator(null);
            a.Notificate();

            Notificator b = new SkypeNotificator(new WhatsAppNotificator(new TelegrammNotificator(null)));
            b.Notificate();

            List<Notificator> array = new List<Notificator>();
            
            array.Add(new SkypeNotificator(null));
            array.Add(new WhatsAppNotificator(null));
            array.Add(new TelegrammNotificator(null));
            foreach (var item in array)
            {
                item.Notificate();
            }
        }
    }
}
