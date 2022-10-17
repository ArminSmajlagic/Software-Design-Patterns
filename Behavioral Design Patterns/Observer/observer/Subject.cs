using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public class Subject : ISubject
    {
        public int state { get; set; }

        private List<IObserver> _observers = new List<IObserver>();

        public Subject(int state = 0)
        {
            this.state = state;
        }
        public int GetState()
        {
            return state;
        }

        public void SetState(int newState)
        {
            state = newState;
            Notify();
        }

        public void Notify()
        {
            Console.WriteLine("\nSubject: Notifying observers...\n");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void AddObserver(IObserver observer)
        {
            Console.WriteLine("\nConcreteSubject: AddObserver("+nameof(observer)+ ")\n");
            _observers.Add(observer);
        }

        public void RemoveObserve(IObserver observer)
        {
            Console.WriteLine("\nConcreteSubject: AddObserver(" + nameof(observer) + ")\n");
            _observers.Remove(observer);
        }
    }
}
