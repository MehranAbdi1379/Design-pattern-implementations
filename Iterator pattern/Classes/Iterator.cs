using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_pattern.Classes
{
    public interface Iterator<T>
    {
         T Current();
         bool HasNext();
         void Next();
    }
}
