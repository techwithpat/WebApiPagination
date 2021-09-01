using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApiPagination.Data;
using WebApiPagination.Entities.Dtos;

namespace WebApiPagination.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamController : ControllerBase
    {

        private readonly PlayerDbContext _dbContext;

        public TeamController(PlayerDbContext dbContext) => _dbContext = dbContext;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var teams = await _dbContext.Teams.ToListAsync();

            return Ok(teams.Select(t => new TeamDto
            {
                Name = t.Name,
                Slug = t.Slug,
                City = t.City
            }));
        }

        [HttpGet("{teamId}/players")]
        public async Task<IActionResult> Get([FromRoute] long teamId)
        {
            var team = await _dbContext.Teams.FindAsync(teamId);
            if (team == null) return NotFound();

            var players = await _dbContext.Players.Where(p => p.Team.Id == teamId)
                                                  .OrderBy(p => p.Id)
                                                  .ToListAsync();            

            return Ok(players.Select(i => new PlayerDto
            {
                FirstName = i.FirstName,
                LastName = i.LastName,
                Country = i.Country
            }));
        }
    }
}
