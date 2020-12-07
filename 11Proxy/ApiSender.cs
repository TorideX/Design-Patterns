using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Proxy
{
    public abstract class Sender
    {
        public abstract bool Send(string request);
    }

    class ApiSender : Sender
    {
        public override bool Send(string request)
        {
            Console.WriteLine("Send request to BakuBus " + request);
            return string.IsNullOrEmpty(request);
        }
    }

    class ApiSenderProxy : Sender
    {
        public int numberOfQueries;
        ApiSender apiSender = new ApiSender();
        public override bool Send(string request)
        {
            File.WriteAllText("salam.txt", request);
            numberOfQueries++;
            apiSender.Send(request);
            return true;
            //return true;
        }
    }
}
