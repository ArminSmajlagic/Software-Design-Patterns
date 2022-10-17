using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Object obj = new Object();
        public ConcreteBuilder()
        {

        }

        public void ResetObject()
        {
            obj = new Object();
        }
        public void BuildPartA()
        {
            obj.AddPart("Part A");
        }

        public void BuildPartB()
        {
            obj.AddPart("Part B");
        }

        public void BuildPartC()
        {
            obj.AddPart("Part C");
        }

        public Object GetObject()
        {
            var result = obj;

            ResetObject();

            return result;
        }
    }
}
