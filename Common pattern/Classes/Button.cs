using Common_pattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_pattern.Classes
{
    public class Button
    {
        private readonly ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public string Label { get; set; }

        public void Click()
        {
            command.Execute();
        }
    }
}
