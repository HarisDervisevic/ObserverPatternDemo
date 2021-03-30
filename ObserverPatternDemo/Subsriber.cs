using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Observer : IObserver
    {
        public string SubscriberName { get; private set; }

        public Subscriber(string name)
        {
            SubscriberName = name;
        }

        public void Update()
        {
            Console.WriteLine(SubscriberName + ": New content has arrived");
        }
    }
}
