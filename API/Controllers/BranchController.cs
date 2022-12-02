using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BranchController : BaseApiController
    {
        private TaskContext _context;

        public BranchController(TaskContext context)
        {
            _context = context;
        }

        [HttpPost]

        public async Task<ActionResult<List<Branch>>> AddBranch(Branch branch)
        {
            _context.Branch.Add(branch);
            await _context.SaveChangesAsync();
            return Ok(await _context.Branch.ToListAsync());

        }

    }
}
