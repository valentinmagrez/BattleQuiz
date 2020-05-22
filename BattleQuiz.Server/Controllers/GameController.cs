using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleQuiz.Server.DTO;
using BattleQuiz.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BattleQuiz.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly BattleQuizDbContext _context;

        public GameController(BattleQuizDbContext context)
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
                UrlId = game.UrlId,
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

            var result = new GameDto
            {
                UrlId = game.UrlId,
                Players = new List<PlayerDto>()
            };

            return CreatedAtAction(nameof(Get), new {id = game.UrlId}, result);
        }
    }
}
