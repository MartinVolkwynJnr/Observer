using Observer.ConcreteObserver;
using Observer.ConcreteSubject;
using System;

namespace Observer
{
    /// <summary>
    /// MainApp startup class for .NET optimized 
    /// Observer Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create IBM stock and attach investors
            var ibm = new IBM(120.00);

            var investor1 = new Investor { Name = "Sorros" };
            var investor2 = new Investor { Name = "Berkshire" };

            // Attach 'listeners', i.e. Investors
            ibm.Attach(investor1);
            ibm.Attach(investor2);

            // Fluctuating prices will notify listening investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            var investor3 = new Investor { Name = "Martin" };

            ibm.Attach(investor3);

            ibm.Detach(investor1);

            ibm.Price = 122.10;
            ibm.Price = 123.00;
            ibm.Price = 124.50;
            ibm.Price = 125.75;

            // Wait for user
            Console.ReadKey();
        }
    }
}
