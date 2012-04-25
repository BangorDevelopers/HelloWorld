using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.Composition;

namespace HelloWorld.ServiceInterfaces
{
    [InheritedExport]
    public interface ISayHello
    {
        string Name { get; }
        string SayHello();
    }
}