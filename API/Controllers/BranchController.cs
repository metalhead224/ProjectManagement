using BusinessLogic.Interface;
using BusinessLogic.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BranchController : BaseApiController
    {
        private IBranchServices _context;

        public BranchController(IBranchServices context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult>  Add(BranchVM branch)
        {
            try
            {
                if (branch == null) return null;

                await _context.Add(branch);
                return Ok("Added branch successfully");
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
