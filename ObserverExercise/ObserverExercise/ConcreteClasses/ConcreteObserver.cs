using ObserverExercise.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExercise.ConcreteClasses
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        public int State { get; set; }

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            State = subject.State;
        }
    }
}
