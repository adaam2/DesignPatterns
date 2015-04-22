using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Behavioral.Observer
{
    abstract class Subject
    {
        private string _bookName;
        private string _subjectType;

        private List<IObserver> _observers = new List<IObserver>();

        protected Subject(string bookName, string subjectType)
        {
            _bookName = bookName;
            _subjectType = subjectType;
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }
        /// <summary>
        /// Notify each of the observers in the collection about changes to the subject
        /// </summary>
        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
        /// <summary>
        /// Getter and setter for Subject Type - notifies observers when value changes from previous value
        /// </summary>
        public string SubjectType
        {
            get { return _subjectType; }
            set
            {
                // first check that the value has changed
                if (_subjectType != value)
                {
                    _subjectType = value;
                    Notify();
                }
            }
        }

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
    }
    /// <summary>
    /// Concrete version of abstract class above
    /// Just for testing purposes
    /// </summary>
    class BookSubject : Subject
    {
        public BookSubject(string bookName, string subjectType) : base(bookName, subjectType)
        {
            
        }
    }
}
