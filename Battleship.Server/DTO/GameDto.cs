using System.Collections.Generic;
using Newtonsoft.Json;

namespace Battleship.Server.DTO
{
    public class GameDto
    {
        [JsonProperty]
        public IList<PlayerDto> Players { get; set; }

        [JsonProperty]
        public string UrlId { get; set; }
    }
}
