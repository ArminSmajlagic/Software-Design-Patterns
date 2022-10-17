using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_resp
{
    public class ConcreteHandlerB : IHandler
    {
        private IHandler _nextHandler;
        public string Handle(Request request)
        {

            var respons = "ConcreteHandlerB ";

            if (_nextHandler == null)
            {
                respons += "handeling request : " + request.request;
            }
            else
            {
                respons += "handeling passed to -> " + _nextHandler.Handle(request);
            }

            return respons;

        }
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            return handler;
        }
    }
}
