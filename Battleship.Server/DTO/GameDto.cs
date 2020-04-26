using System.Collections.Generic;
using Battleship.Server.Models;
using Newtonsoft.Json;

namespace Battleship.Server.DTO
{
    public class GameDto
    {
        [JsonProperty]
        public IList<PlayerDto> Players { get; set; }
    }
}
