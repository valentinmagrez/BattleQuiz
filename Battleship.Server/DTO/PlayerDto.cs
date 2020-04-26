using Newtonsoft.Json;

namespace Battleship.Server.DTO
{
    public class PlayerDto
    {
        [JsonProperty]
        public string Name { get; set; }
    }
}