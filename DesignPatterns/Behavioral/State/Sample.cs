using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public class Sample
    {
        public static void Start()
        {
            var serverContext = new Server();
            var clientContext = new Client();

            Console.WriteLine("Trying to send messages when TCP hasn't been connected:");
            clientContext.Send("Hello sent from client.");
            serverContext.Send("Hello sent from server.");

            clientContext.Connect(serverContext);
            clientContext.Send("Hello sent from client.");
            serverContext.Send("Hello sent from server.");
            clientContext.Disconnect();

            Console.WriteLine("Trying to send messages when TCP has been disconnected:");
            clientContext.Send("Hello sent from client.");
            serverContext.Send("Hello sent from server.");
        }
    }
}
