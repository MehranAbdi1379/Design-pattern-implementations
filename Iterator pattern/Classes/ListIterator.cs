using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_pattern.Classes
{
    public class ListIterator<T> : Iterator<T>
    {
        private BrowseHistory<T> browseHistory;
        private T CurrentValue;
        public ListIterator(BrowseHistory<T> browseHistory)
        {
            this.browseHistory = browseHistory;
        }
        public T Current()
        {
            return CurrentValue;
        }

        public bool HasNext()
        {
            var index = browseHistory.History.IndexOf(CurrentValue);

            if(browseHistory.History.Count-1>index)
                return true;
            return false;
        }

        public void Next()
        {
            var index =browseHistory.History.IndexOf(CurrentValue);

            CurrentValue = browseHistory.History[index+1];
        }
    }
}
