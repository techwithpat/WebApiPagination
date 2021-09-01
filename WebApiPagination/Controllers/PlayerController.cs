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
    public class PlayerController : ControllerBase
    {
        private readonly PlayerDbContext _dbContext;
        public PlayerController(PlayerDbContext dbContext) => _dbContext = dbContext;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var players = await _dbContext.Players       
                .ToListAsync();
          
            return Ok(players.Select(p => new PlayerDto
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Country = p.Country
            }));
        }
    }
}
