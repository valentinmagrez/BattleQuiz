using System.Linq;
using System.Threading.Tasks;
using Battleship.Server.DTO;
using Battleship.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Battleship.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly BattleshipDbContext _context;

        public GameController(BattleshipDbContext context)
        {
            _context = context;
        }

        // GET: api/games/unique_identifier
        [HttpGet("{id}")]
        public async Task<ActionResult<GameDto>> Get(string id)
        {
            var game = await _context.Games.FirstOrDefaultAsync(_=>_.UrlId==id);
            var gameDto = new GameDto
            {
                Players = game.Players.Select(_ => new PlayerDto
                {
                    Name = _.Name
                }).ToList()
            };

            return gameDto;
        }

        [HttpPost]
        public async Task<ActionResult<GameDto>> Post()
        {
            var game = Game.Create();
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new {id = game.UrlId}, game);
        }
    }
}
