using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public class Client
    {
        public void Main()
        {
            var object1 = new ConcreteFactory1();
            var object2 = new ConcreteFactory2();

            var objectA1 = object1.CreateObjectA();

            Console.WriteLine(objectA1.GetObjectA());

            var objectB1 = object1.CreateObjectB();
            
            Console.WriteLine(objectB1.GetObjectB());

            var objectA2 = object2.CreateObjectA();

            Console.WriteLine(objectA2.GetObjectA());

            var objectB2 = object2.CreateObjectB();

            Console.WriteLine(objectB2.GetObjectB());

        }
    }
}
