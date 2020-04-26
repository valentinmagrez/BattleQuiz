using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Battleship.Server.Models
{
    public class Game
    {
        public Game()
        {
            Players = new List<Player>();
        }

        public long Id { get; set; }

        /// <summary>
        /// Identifier from the url
        /// </summary>
        public string UrlId { get; set; }

        /// <summary>
        /// Players in the game
        /// </summary>
        public IList<Player> Players { get; set; }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public static Game Create()
        {
            var game = new Game
            {
                UrlId = Guid.NewGuid().ToString("N")
            };

            return game;
        }
    }
}
