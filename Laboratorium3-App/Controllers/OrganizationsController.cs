using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrganizationsController(AppDbContext context)
        {
            _context = context;
        }
        [Route("filter")]
        public IActionResult GetFilterdOrganizations(string query)
        {
            var result = _context.Organizations
                .Where(o => o.Title.ToUpper().StartsWith(query.ToUpper()))
                .Select(o => new
                {
                    Id = o.Id,
                    Name = o.Title
                })
                .ToList();
            return Ok(result);
        }

        [Route("{id}")]
        public IActionResult GetOrganizationById(int id)
        {
            var result = _context.Organizations.Find(id);
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }



        }
    }
}
