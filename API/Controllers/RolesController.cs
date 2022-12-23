using BusinessLogic.Interface;
using BusinessLogic.ViewModel;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RolesController : BaseApiController
    {
        private IRolesServices _context;

        public RolesController(IRolesServices context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Add(RolesVM role)
        {
            try
            {
                if (role == null) return null;

                await _context.Add(role);
                return Ok("Added role successfully!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
