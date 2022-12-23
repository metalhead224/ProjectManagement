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

        [HttpGet]
        public async Task<IActionResult> UsersList()
        {
            try
            {
                var users = await _context.GetAll();
                return Ok(users);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> User(int Id)
        {
            try
            {
                var user = await _context.GetById(Id);
                return Ok(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                await _context.Delete(Id);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
