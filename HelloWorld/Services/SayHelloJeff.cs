using HelloWorld.ServiceInterfaces;

namespace HelloWorld.Services
{
    public class SayHelloJeff : ISayHello
    {
        public string Name
        {
            get { return "Jeff"; }
        }

        public string SayHello()
        {
            return "Hello, My name is Jeff!";
        }
        
    }
}