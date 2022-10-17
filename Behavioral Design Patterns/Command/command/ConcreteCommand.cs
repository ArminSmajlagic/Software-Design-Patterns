using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    public class ConcreteCommand : ICommand
    {
        private Receiver receiver;
        private List<string> states;

        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
            states = new List<string>();
            states.Add("Initial state");
        }
        public void Execute()
        {
            states.Add(receiver.Operatrion());
        }

        public void Undo()
        {
            states.RemoveAt(states.Count - 1);
        }

        public string GetCurrentState()
        {
            return states[states.Count - 1];
        }
    }
}
