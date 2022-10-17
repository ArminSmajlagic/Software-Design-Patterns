using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public class ObserverA : IObserver
    {
        public ObserverA()
        {

        }

        public void Update(ISubject subject)
        {
            if ((subject as Subject).GetState() < 3)
            {
                Console.WriteLine("\nConcrete observer A: Reacted to the event.\n");
            }
        }
    }
}
