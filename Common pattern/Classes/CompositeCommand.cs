using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_pattern.Classes
{
    public class CompositeCommand: ICommand
    {
        private readonly List<ICommand> commands;

        public CompositeCommand(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (var item in commands)
            {
                item.Execute();
            }
        }
    }
}
