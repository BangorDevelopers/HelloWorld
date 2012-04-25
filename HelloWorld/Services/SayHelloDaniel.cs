using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloWorld.ServiceInterfaces;

namespace HelloWorld.Services
{
    public class SayHelloDaniel : ISayHello
    {
        public string Name
        {
            get { return "Daniel Pratt"; }
        }

        public string SayHello()
        {
            return "I am Jeff's puppet!";
        }
    }
}