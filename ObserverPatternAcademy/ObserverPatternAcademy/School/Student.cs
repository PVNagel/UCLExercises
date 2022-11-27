using ObserverPatternAcademy.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAcademy.School
{
    public class Student : Observer
    {
        private Academy subject;
        public string Message { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
        }

        public Student(Academy subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            Message = subject.Message;
            Console.WriteLine("Studerende " + Name + " modtog nyheden " + Message + " fra akademiet " + subject.Name);
        }
    }
}
