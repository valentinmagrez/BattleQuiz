using Newtonsoft.Json;

namespace BattleQuiz.Server.DTO
{
    public class PlayerDto
    {
        [JsonProperty]
        public string Name { get; set; }
    }
}