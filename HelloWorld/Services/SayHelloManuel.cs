using HelloWorld.ServiceInterfaces;

namespace HelloWorld.Services
{
    public class SayHelloManuel : ISayHello
    {
        public string Name
        {
            get { return "Manuel"; }
        }

        public string SayHello()
        {
            return "Hola Mundo!";
        }
        
    }
}