using HelloWorld.ServiceInterfaces;

namespace HelloWorld.Services
{
    public class SayHelloCorey : ISayHello
    {
        public string Name
        {
            get { return "Corey"; }
        }

        public string SayHello()
        {
            return "HeyHowYaDoingHowAreYa!";
        }

       
    }
}