﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_pattern.Classes
{
    public class Logger : Handler
    {
        public override void Handle(HttpRequest httpRequest)
        {
            Console.WriteLine("Log");
            HandleNext(httpRequest);
        }

    }
}
