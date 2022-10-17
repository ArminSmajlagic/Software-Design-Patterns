using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class Director
    {
        public IBuilder _builder { private get; set; }

        public void BuildMinimalObject()
        {
            _builder.BuildPartA();
        }

        public void BuildFullObject()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
        
    }
}
