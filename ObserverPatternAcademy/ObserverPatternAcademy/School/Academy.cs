using ObserverPatternAcademy.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAcademy.School
{
    public class Academy : Subject
    {
		private string name;

		public string Name
		{
			get { return name; }
		}
		private string message;

		public string Message
		{
			get { return message; }
			set 
			{ 
				message = value;
				Notify();
			}
		}

		public Academy(string name)
		{
			this.name = name;
		}
	}
}
