using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component)
        {
        }

        public override string Operation() => $"ConcreteDecoratorA behaviour - > {base.Operation()}";
    }
}
