using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class StrategyA : IStrategy
    {
        public void ExecuteOperation()
        {
            Console.WriteLine("Opeartion from strategy A has executed");
        }
    }
}
