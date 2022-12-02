using BusinessLogic.Interface;
using BusinessLogic.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UsersController : BaseApiController
    {
        private IUsersServices _context;

        public UsersController(IUsersServices context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Add(UsersVM user)
        {
            try
            {
                if (user == null) return null;

                await _context.Add(user);
                return Ok("Added user successfully!");
            }
            catch (Exception ex)
            {

                throw ex;
            }   
        }
    }
}
