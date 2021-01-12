using Observer.Events;
using Observer.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Subject
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    abstract class Stock
    {
        protected string symbol;
        protected double price;

        // Constructor
        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        // Event
        public event EventHandler<ChangeEventArgs> Change;

        // Invoke the Change event
        public virtual void OnChange(ChangeEventArgs e)
        {
            if (Change != null)
            {
                Change(this, e);
            }
        }

        public void Attach(IInvestor investor)
        {
            Change += investor.Update;
        }

        public void Detach(IInvestor investor)
        {
            Change -= investor.Update;
        }

        // Gets or sets the price
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnChange(new ChangeEventArgs { Symbol = symbol, Price = price });
                    Console.WriteLine("");
                }
            }
        }
    }
}
