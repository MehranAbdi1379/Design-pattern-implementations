using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Classes
{
    public abstract class UIControl
    {
        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void notifyObservers()
        {
            foreach (var item in Observers)
            {
                item.update();
            }
        }
    }
}
