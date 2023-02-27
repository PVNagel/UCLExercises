using ObserverPatternAcademy.Interfaces;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAcademy.School
{
    public class Academy : Organization, INotifyPropertyChanged
    {
		private string message;
        public event PropertyChangedEventHandler? PropertyChanged;

        public string Message
		{
			get { return message; }
			set 
			{ 
				message = value;
				PropertyChanged(this, null);
			}
		}

		public Academy(string name, string address) : base(name)
		{
            Address = address;
		}
        public void Attach(IObserver observer)
        {
            PropertyChanged += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            PropertyChanged -= observer.Update;
        }

        public void OnMessagedChanged(object sender, EventArgs e)
        {
            PropertyChanged(this, null);
        }
    }
}
