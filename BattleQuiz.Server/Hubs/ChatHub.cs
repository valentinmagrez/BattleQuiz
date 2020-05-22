using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BattleQuiz.Server.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public Task SendMessage(string user, string message)
        {
            return Clients.All.ReceiveMessage(user, message);
        }

        public override Task OnConnectedAsync()
        {
            Console.WriteLine($"New connection {Context.ConnectionId} {Context.UserIdentifier}");
            return base.OnConnectedAsync();
        }
    }
}