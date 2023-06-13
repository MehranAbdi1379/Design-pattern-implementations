using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Classes
{
    public class SelectListBoxObserver : IObserver
    {
        public void update()
        {
            titleTextBox.Content = articleListBox.Selection;
            saveButton.IsActivated = true;
        }
    }
}
