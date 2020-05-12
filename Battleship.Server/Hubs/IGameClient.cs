namespace Battleship.Server.Hubs
{
    public interface IGameClient
    {
        void AddNewPlayer(string username);
    }
}