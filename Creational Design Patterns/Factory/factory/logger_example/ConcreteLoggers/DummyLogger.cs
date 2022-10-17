using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger_example.ConcreteLogger
{
    public class DummyLogger: IMyLogger
    {
        public void Log()
        {
            Console.WriteLine("\nDummy logger\n");
        }
    }
}
