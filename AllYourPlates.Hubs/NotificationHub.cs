﻿using Microsoft.AspNetCore.SignalR;

namespace AllYourPlates.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendUpdate(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}