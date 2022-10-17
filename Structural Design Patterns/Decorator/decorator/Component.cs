using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class Component : IComponent
    {
        public string Operation() => "Base component behaviour";
    }
}
