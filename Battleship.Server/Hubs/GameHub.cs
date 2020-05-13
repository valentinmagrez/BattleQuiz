using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Battleship.Server.Hubs
{
    public class GameHub : Hub<IGameClient>
    {
        public Task JoinGame(string gameToken)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, gameToken);
            //todo use real username
            return Clients.OthersInGroup(gameToken).AddNewPlayer("test");
        }
    }
}