using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApiPagination.Data;
using WebApiPagination.Entities.Dtos;

namespace WebApiPagination.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        private readonly CompanyDbContext _dbContext;

        public CompanyController(CompanyDbContext dbContext) => _dbContext = dbContext;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var companies = await _dbContext.Companies.ToListAsync();

            return Ok(companies.Select(e => new CompanyDto
            {
                Name = e.Name,
                Email = e.Email
            }));
        }

        [HttpGet("{companyId}/employees")]
        public async Task<IActionResult> Get([FromRoute] int companyId)
        {
            var company = await _dbContext.Companies.FindAsync(companyId);
            if (company == null) return NotFound();

            var employees = await _dbContext.Employees.Where(p => p.Company.Id == companyId)
                                                  .OrderBy(p => p.Id)
                                                  .ToListAsync();            

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
