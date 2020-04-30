using Microsoft.AspNetCore.SignalR;
using System;

namespace SignalR
{
    public class ChatHub : Hub
    {
        /// <summary>  
        /// Send the value to the server after every two seconds  
        /// </summary>  
        public void Send()
        {
            Console.WriteLine("jfhsdfhsdljifjsdk");
            Console.ReadLine();
            // Call the broadcastMessage method to update clients.  
            ////for (int i = 0; i <= 100; i++)
            ////{
            ////    //"All" is dynamic, and broadcastMessage is the method that we'll  
            ////    //create in JavaScript at client side.  
            ////    Clients.All.broadcastMessage(i.ToString());
            ////    Thread.Sleep(2000);
            ////}
        }
    }
}
