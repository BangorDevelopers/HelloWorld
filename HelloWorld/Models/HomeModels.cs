using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloWorld.ServiceInterfaces;

namespace HelloWorld.Models
{
    public class HomeModel
    {
        public IEnumerable<ISayHello> SayHelloProviders { get; set; }
    }
}