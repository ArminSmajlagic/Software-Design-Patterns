using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    public class Originator
    {
        private string _state;
        public Originator(string state)
        {
            _state = state;
            Console.WriteLine("\nOriginator: My initial state is: " + state);
        }
        public void SetMemento(Memento memento) => _state = memento.GetState();   
        public Memento CreateMemento() => new Memento(_state);
        public void DoSomething()
        {
            Console.WriteLine("\nOriginator: I'm doing something important.");
            _state = GenerateRandomString(5);
            Console.WriteLine($"\nOriginator: and my state has changed to: {_state}");
        }
        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }
    }
}
