using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Hubs
{
    //Class that manages connections to the chat system
    public class ChatHub : Hub
    {
        //Displays on console once a chat connection has been made
        public override Task OnConnected()
        {
            return base.OnConnected();
        }
        //Method for creating new message
        public void NewMessage(string username, string message)
        {
            Clients.Others.sentMessage(username, message, DateTime.Now);
        }
    }
}