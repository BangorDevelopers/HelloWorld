using HelloWorld.ServiceInterfaces;

namespace HelloWorld.Services
{
    public class SayHelloCalvin : ISayHello
    {
        public string Name
        {
            get { return "calvin"; }
        }

        public string SayHello()
        {
            return "Hello, My name is calvin!";
        }
        
    }
}