using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LampServer.Hubs
{
    public class LampHub : Hub
    {
        public static bool TurnOn { get; set; }
    }
}