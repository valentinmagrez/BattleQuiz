using System.Threading.Tasks;

namespace BattleQuiz.Server.Hubs
{
    public interface IChatClient
    {
        Task ReceiveMessage(string user, string message);
    }
}