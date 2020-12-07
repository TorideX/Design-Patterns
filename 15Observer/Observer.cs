using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Observer
{
    public interface IObserver
    {
        void Update(object obj);
    }

    class Broker : IObserver
    {
        IObservable _stock;
        private string _brokerID;
        public Broker(IObservable stock, string brokerID)
        {
            _brokerID = brokerID;
            _stock = stock;
            stock.Attach(this);
        }
        public void Update(object obj)
        {
            StockInfo temp = (StockInfo)obj;
            Console.WriteLine("I want to buy some AZN " + _brokerID + " " + temp.AZN);
        }

        public void StopBuying()
        {
            _stock.Detach(this);
            _stock = null;
        }
    }

    class Bank : IObserver
    {
        IObservable _stock;
        private string _name;
        public Bank(IObservable stock, string name)
        {
            _name = name;
            _stock = stock;
            stock.Attach(this);
        }
        public void Update(object obj)
        {
            StockInfo temp = (StockInfo)obj;
            Console.WriteLine("WE want to buy some USD " + _name + " " + temp.USD);
        }
    }
}
