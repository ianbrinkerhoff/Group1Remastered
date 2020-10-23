using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Typing.Hubs
{
    public class MessageHub: Hub
    {
        public async Task SendInput(string username, string input)
        {
            await Clients.All.SendAsync("ReceiveMessage", username, input);
        }
    }
}
