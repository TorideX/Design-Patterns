using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Decorator
{
    public abstract class Notificator
    {
        public abstract void Notificate();
    }

    public class SkypeNotificator : Notificator
    {
        Notificator _notificator;
        public SkypeNotificator(Notificator notificator)
        {
            _notificator = notificator;
        }
        public override void Notificate()
        {
            Console.WriteLine("Pop-up to skype");
            _notificator?.Notificate();
        }
    }

    public class TelegrammNotificator : Notificator
    {
        Notificator _notificator;
        public TelegrammNotificator(Notificator notificator)
        {
            _notificator = notificator;
        }
        public override void Notificate()
        {
            Console.WriteLine("Pop-up to Telegramm");
            _notificator?.Notificate();
        }
    }

    public class WhatsAppNotificator : Notificator
    {
        Notificator _notificator;
        public WhatsAppNotificator(Notificator notificator)
        {
            _notificator = notificator;
        }
        public override void Notificate()
        {
            Console.WriteLine("Pop-up to WhatsApp");
            _notificator?.Notificate();
        }
    }
}
