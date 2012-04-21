using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.ServiceInterfaces
{
    public interface ISayHello
    {
        string Name { get; }
        string SayHello();
    }
}