using ObserverPatternAcademy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAcademy.School
{
    public class Student : Person, IObserver
    {
        public string Message { get; set; }

        public Student(string name) : base(name)
        {
        }

        public void Update(object sender, EventArgs e)
        {
            string academyName = ((Academy)sender).Name;
            string academyMessage = ((Academy)sender).Message;
            string academyAddress = ((Academy)sender).Address;

            Console.WriteLine("Studerende " + Name + " modtog nyheden " + academyMessage + " fra akademiet " + academyName + ", " + academyAddress);
        }
    }
}
