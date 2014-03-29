using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Chat
{

    [HubName("/system/chat")]
    public class ChatHub : Hub
    {
        static int counter = 0;
        public void SendAll(string text)
        {
            counter++;
            Clients.All.Receive(counter + ":" + text);
        }
    }

    [HubName("/system/chat2")]
    public class ChatHub2 : Hub
    {
        static int counter = 0;
        public void SendAll(string text, int num)
        {
            counter++;
            Clients.All.Receive(counter + ":" + text + "*" + num, "hogehgoe");
        }
    }

    [HubName("echo")]
    public class EchoHub : Hub
    {
        public void Send(string text)
        {
            Clients.All.Receive(text);
        }
    }
}