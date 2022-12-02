using ObserverPatternAcademy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAcademy.School
{
    public class Academy : Organization
    {
        //private List<IObserver> observers = new List<IObserver>();
        public NotifyHandler MessageChanged;
		private string message;

		public string Message
		{
			get { return message; }
			set 
			{ 
				message = value;
				MessageChanged();
			}
		}

		public Academy(string name, string address) : base(name)
		{
            Address = address;
		}
        public void Attach(IObserver observer)
        {
            MessageChanged += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            MessageChanged -= observer.Update;
        }

        public void OnMessagedChanged()
        {
            MessageChanged();
        }
    }
}
