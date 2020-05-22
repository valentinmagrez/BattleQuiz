using System.Threading.Tasks;

namespace BattleQuiz.Server.Hubs
{
    public interface IGameClient
    {
        Task AddNewPlayer(string username);
    }
}