using HelloWorld.ServiceInterfaces;

namespace HelloWorld.Services
{
    public class SayHelloBugsBunny : ISayHello
    {
        public string Name
        {
            get { return "Bugs Bunny"; }
        }

        public string SayHello()
        {
            return "What's Up Doc!";
        }

       
    }
}