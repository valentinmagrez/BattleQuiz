namespace BattleQuiz.Server.Models
{
    public class Player : IPlayer
    {
        public long Id { get; set; }

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