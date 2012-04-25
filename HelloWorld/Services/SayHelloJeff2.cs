using HelloWorld.ServiceInterfaces;

namespace HelloWorld.Services
{
    public class SayHelloJeff2 : ISayHello
    {
        public string Name
        {
            get { return "Jeff2"; }
        }

        public string SayHello()
        {
            return "Hello, This is Jeff Live from the BAND gig!";
        }
        
    }
}