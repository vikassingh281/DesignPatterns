using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib.ChainOfResponsibity
{
    public interface IHandler
    {
        void SetHandler(IHandler handler);
        object ProcessRequest(Request request);
    }

}
