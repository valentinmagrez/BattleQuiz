using System.Threading.Tasks;

namespace Battleship.Server.Hubs
{
    public interface IGameClient
    {
        Task AddNewPlayer(string username);
    }
}