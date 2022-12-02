using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RolesController : BaseApiController
    {
        private TaskContext _context;

        public RolesController(TaskContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Roles>>> AddRole(Roles role)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return Ok(await _context.Roles.ToListAsync());
        }
    }
}
