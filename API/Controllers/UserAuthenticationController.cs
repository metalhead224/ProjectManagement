using BusinessLogic.Interface;
using BusinessLogic.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserAuthenticationController : BaseApiController
    {
        private IUserAuthenticationServices _context;

        public UserAuthenticationController(IUserAuthenticationServices context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserAuthenticationVM userAuth)
        {
            try
            {
                if (userAuth == null) return null;

                await _context.Add(userAuth);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> UserAuthList()
        {
            try
            {
                var data = await _context.GetAll();
                return Ok(data);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                var data = await _context.GetById(Id);
                return Ok(data);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
