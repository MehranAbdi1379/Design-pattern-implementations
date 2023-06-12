using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Classes
{
    public class DataSource
    {
        List<IObserver> observers = new List<IObserver>();

        public DataSource( int value)
        {
            index = value;
        }

        private int index;

        public int Index
        {
            get { return index; }
            set { index = value;
                foreach (var item in observers)
                {
                    item.Update(value);
                }
            }

        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer); 
        }

    }
}
