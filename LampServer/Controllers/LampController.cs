using LampServer.Hubs;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LampServer.Controllers
{
    public class LampController : ApiController
    {
        public void Get(bool turnOn)
        {
            var lampContext = GlobalHost.ConnectionManager.GetHubContext<LampHub>();
            LampHub.TurnOn = turnOn;
            lampContext.Clients.All.OnSwitch(turnOn);
        }
    }
}
