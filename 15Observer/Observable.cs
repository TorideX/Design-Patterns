using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Observer
{
    public interface IObservable
    {
        void Attach(IObserver obs);
        void Detach(IObserver obs);
        void Notify();
    }

    public class StockInfo
    {
        public decimal USD { get; set; }
        public decimal AZN { get; set; }
    }

    public class StockExchange : IObservable
    {
        private StockInfo _stockInfo;
        public StockInfo StockInfo { 
            get => _stockInfo;
            set
            {
                _stockInfo = value;
                Notify();
            }
        }
        List<IObserver> observers;

        public StockExchange()
        {
            observers = new List<IObserver>();
            StockInfo = new StockInfo();
        }

        public void Attach(IObserver obs)
        {
            observers.Add(obs);
        }

        public void Detach(IObserver obs)
        {
            observers.Remove(obs);
        }

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update(StockInfo);
            }
        }

        public void UpdateRate()
        {
            Random r = new Random();
            StockInfo.AZN = r.Next(100, 200);
            StockInfo.USD = r.Next(1, 1);
            Notify();
        }
    }
}
