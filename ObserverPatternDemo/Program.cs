using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Subscriber peter = new Subscriber("peter");
            subject.Subscribe(peter);

            subject.Inventory++;

            Console.ReadLine();
        }
    }
}
