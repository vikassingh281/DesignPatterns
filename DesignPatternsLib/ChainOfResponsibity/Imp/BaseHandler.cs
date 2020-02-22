using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib.ChainOfResponsibity.Imp
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler Handler { get; private set; }

        protected BaseHandler()
        {
            Handler = null;
        }

        public virtual object ProcessRequest(Request request)
        {
            throw new NotImplementedException();
        }

        public void SetHandler(IHandler handler)
        {
            Handler = handler;
        }
    }
}
