using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }

        public abstract MessageType HandleRequest(string data);
    }

    class SpamHandler : Handler
    {
        private string[] spamWord = { "aaaaaaaaaa", "u win 1 billion azn" };

        public SpamHandler(Handler handler) : base(handler) { }
        public override MessageType HandleRequest(string data)
        {
            int res = spamWord.Where(sw => data.Contains(sw)).Count();
            if(res > 0)
            {
                return MessageType.Spam;
            }
            else
            {
                return _next?.HandleRequest(data) ?? MessageType.Other;
            }
        }
    }

    class FansHandler : Handler
    {
        private string[] fansWord = { "i love u", "i kill u" };

        public FansHandler(Handler handler) : base(handler) { }
        public override MessageType HandleRequest(string data)
        {
            int res = fansWord.Where(sw => data.Contains(sw)).Count();
            if (res > 0)
            {
                return MessageType.Fans;
            }
            else
            {
                return _next?.HandleRequest(data) ?? MessageType.Other;
            }
        }
    }

    class SocialHandler : Handler
    {
        private string[] socialWord = { "facebook", "twitter", "youtube"};

        public SocialHandler(Handler handler) : base(handler) { }
        public override MessageType HandleRequest(string data)
        {
            int res = socialWord.Where(sw => data.Contains(sw)).Count();
            if (res > 0)
            {
                return MessageType.Social;
            }
            else
            {
                return _next?.HandleRequest(data) ?? MessageType.Other;
            }
        }
    }

    class HTMLConverter : Handler
    {
        public HTMLConverter(Handler handler) : base(handler)
        {
        }
        public override MessageType HandleRequest(string data)
        {
            throw new NotImplementedException();
        }
    }

    public enum MessageType
    {
        Spam,
        Fans,
        Other,
        Social,
        Promotions
    }
}
