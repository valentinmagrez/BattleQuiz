using Microsoft.AspNetCore.SignalR;

namespace Battleship.Server.Hubs
{
    public class GameHub : Hub<IGameClient>
    {
        public void JoinGame(string gameToken)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, gameToken);
            //todo use real username
            Clients.OthersInGroup(gameToken).AddNewPlayer("test");
        }
    }
}