using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_resp
{
    public class Request
    {
        public int id { get; set; }
        public string request { get; set; }

        public Request(string request, int id = 0)
        {
            this.request = request;
            this.id = id;
        }
    }
}
