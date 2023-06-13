using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Classes
{
	public class TextBox : UIControl
    {
		private string _content;


		public string Content
		{
			get { return _content; }
			set { _content = value;
				notifyObservers();
			}
		}
	}
}
