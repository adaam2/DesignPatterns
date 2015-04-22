using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Behavioral.Observer
{
    interface IObserver
    {
        void Update(Subject subject);
    }

    class ConcreteObserver : IObserver
    {
        private string _name;
        private Subject _subject;

        public ConcreteObserver(string name)
        {
            _name = name;
        }
        public void Update(Subject subject)
        {
            Console.WriteLine("Notified {0} of {1}'s genre changing to {2}", _name, subject.BookName, subject.SubjectType);
        }

        public Subject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
