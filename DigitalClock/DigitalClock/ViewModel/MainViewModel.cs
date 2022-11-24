using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock.ViewModel
{
	public class MainViewModel : INotifyPropertyChanged
	{
		private string time = "00:00:00";

		public string Time
		{
			get { return time; }
			set 
			{ 
				time = value;
				OnPropertyChanged("Time"); 
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string time)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if ( handler != null)
			{
				handler(this, new PropertyChangedEventArgs(time));
			}
		}
	}
}
		


	
