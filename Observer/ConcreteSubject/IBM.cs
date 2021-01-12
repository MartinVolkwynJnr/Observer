using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ConcreteSubject
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    class IBM : Stock
    {
        // Constructor - symbol for IBM is always same
        public IBM(double price)
            : base("IBM", price)
        {
        }
    }
}
