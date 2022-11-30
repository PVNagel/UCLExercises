using ObserverPatternAcademy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAcademy.School
{
    public class Academy : Organization, ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

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

		public Academy(string name, string address) : base(name)
		{
            Address = address;
		}
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}
