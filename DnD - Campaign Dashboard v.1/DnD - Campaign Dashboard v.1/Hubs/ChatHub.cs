using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnected()
        {
            return base.OnConnected();
        }
        public void NewMessage(string username, string message)
        {
            Clients.Others.sentMessage(username, message, DateTime.Now);
        }
    }
}