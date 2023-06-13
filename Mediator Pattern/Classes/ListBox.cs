using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Classes
{
    public class ListBox: UIControl
    {
		private string _selection;


		public string Selection
		{
			get { return _selection; }
			set { _selection = value;
				notifyObservers();
			}
		}

	}
}
