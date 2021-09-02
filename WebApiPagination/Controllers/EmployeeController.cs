using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApiPagination.Data;
using WebApiPagination.Entities.Dtos;

namespace WebApiPagination.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly CompanyDbContext _dbContext;
        public EmployeeController(CompanyDbContext dbContext) => _dbContext = dbContext;

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] CursorParams @params)
        {
            var employees = await _dbContext.Employees
                .OrderBy(e => e.Id)
                .Where(e => e.Id > @params.Cursor)
                .Take(@params.Count)
                .ToListAsync();

            var nextCursor = employees.Any() 
                ? employees.LastOrDefault()?.Id 
                : 0;

            Response.Headers.Add("X-Pagination", $"Next Cursor={nextCursor}");
          
            return Ok(employees.Select(e => new EmployeeDto
            {
                Title = e.Title,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Gender = e.Gender,
                Email = e.Email
            }));
        }
    }
}
