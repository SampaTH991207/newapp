
using HelloWorldApp.Services;
using HelloWorldApp.Models;
using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageService messageService = new MessageService();
            Message message = messageService.GetMessage();

            Console.WriteLine(message.Content);
        }
    }
}
