using HelloWorld.ServiceInterfaces;

namespace HelloWorld.Services
{
    public class SayHelloShara : ISayHello
    {
        public string Name
        {
            get { return "Shara"; }
        }

        public string SayHello()
        {
            return "Hello, My name is Shara!";
        }
        
    }
}