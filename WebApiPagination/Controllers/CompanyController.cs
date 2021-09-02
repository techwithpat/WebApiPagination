using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.Json;
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
        public async Task<IActionResult> Get(
            [FromRoute] int companyId,
            [FromQuery] PaginationParams @params)
        {
            var company = await _dbContext.Companies.FindAsync(companyId);
            if (company == null) return NotFound();

            var employees = _dbContext.Employees.Where(p => p.Company.Id == companyId)
                                                .OrderBy(p => p.Id);                                                 

            var paginationMetadata = new PaginationMetadata(employees.Count(), @params.Page, @params.ItemsPerPage);
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetadata));

            var items = await employees.Skip((@params.Page - 1) * @params.ItemsPerPage)
                                       .Take(@params.ItemsPerPage)
                                       .ToListAsync();

            return Ok(items.Select(e => new EmployeeDto
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
