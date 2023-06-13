using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Classes
{
    public class Button: UIControl
    {
		private bool _isActivated;


		public bool IsActivated
		{
			get { return _isActivated; }
			set { _isActivated = value;
				notifyObservers(); 
			}
		}

	}
}
