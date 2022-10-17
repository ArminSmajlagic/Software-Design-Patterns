using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    public class Invoker
    {
        private ICommand command;
        public void InvokeExecution()
        {
            if (command == null)
                throw new Exception("Command was not set!");

            command.Execute();
        }

        public void SetCommand(ICommand command) => this.command = command;

    }
}
