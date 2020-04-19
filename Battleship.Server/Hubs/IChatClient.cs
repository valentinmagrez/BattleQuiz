using System.Threading.Tasks;

namespace Battleship.Server.Hubs
{
    public interface IChatClient
    {
        Task ReceiveMessage(string user, string message);
    }
}