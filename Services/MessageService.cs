
using HelloWorldApp.Models;

namespace HelloWorldApp.Services
{
    public class MessageService
    {
        public Message GetMessage()
        {
            return new Message("Hello World, this is the app for testing the .NET application");
        }
    }
}
