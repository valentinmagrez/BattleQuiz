namespace Battleship.Server.Models
{
    public interface IPlayer
    {
        /// <summary>
        /// Player id from Websocket
        /// </summary>
        public int ConnexionId { get; set; }

        /// <summary>
        /// Player name
        /// </summary>
        public string Name { get; set; }
    }
}