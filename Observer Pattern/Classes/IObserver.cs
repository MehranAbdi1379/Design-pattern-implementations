﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Classes
{
    public interface IObserver
    {
        void Update(int value);
    }
}
