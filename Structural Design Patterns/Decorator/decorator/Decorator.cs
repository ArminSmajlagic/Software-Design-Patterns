using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public abstract class Decorator : IComponent
    {
        protected IComponent _component { private get; set; }
        public Decorator(IComponent component)
        {
            _component = component;
        }

        public virtual string Operation()
        {
            if (_component != null)
            {
                return _component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
