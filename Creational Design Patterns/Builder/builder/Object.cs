using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class Object
    {
        public List<object> parts = new List<object>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public string GetParts()
        {
            string result = string.Empty;

            foreach (var part in parts)
            {
                result += part+", ";
            }

            return "Object parts are : "+result;
        }

    }
}
