using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override string Operation() => $"ConcreteDecoratorB behaviour - > {base.Operation()}";
    }
}
