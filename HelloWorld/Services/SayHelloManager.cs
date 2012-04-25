using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorld.ServiceInterfaces;
using System.ComponentModel.Composition;

namespace HelloWorld.Services
{
    [Export]
    public class SayHelloManager
    {
        [ImportMany]
        public IEnumerable<ISayHello> SayHelloProviders { get; private set; }
    }
}