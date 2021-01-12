using Observer.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observer
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    interface IInvestor
    {
        void Update(object sender, ChangeEventArgs e);
    }
}
