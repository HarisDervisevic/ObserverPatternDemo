using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Subject : ISubject
    {
        private List<Observer> subscribers = new List<Observer>();
        private int _int;

        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }

        public void Subscribe(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update();
            }
        }
    }
}
