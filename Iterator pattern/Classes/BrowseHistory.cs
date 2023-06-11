using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_pattern.Classes
{
    public class BrowseHistory<T>
    {
        public List<T> History { get; set; }

        public void Push(T item)
        {
            History.Add(item);
        }

        public T Pop()
        {
            var last = History.Last();
            History.Remove(History.Last());
            return last;
        }
    }
}
