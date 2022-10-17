using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class StrategyB : IStrategy
    {
        public void ExecuteOperation()
        {
            Console.WriteLine("Opeartion from strategy B has executed");
        }
    }
}
