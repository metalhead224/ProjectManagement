using BusinessLogic.Interface;
using BusinessLogic.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class DepartmentController : BaseApiController
    {
        private IDepartmentServices _context;

        public DepartmentController(IDepartmentServices context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Add(DepartmentVM dept)
        {
            try
            {
                if (dept == null) return null;

                await _context.Add(dept);
                return Ok("Successfully added department!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> DepartmentList()
        {

            try
            {
                var dept = await _context.GetAll();
                return Ok(dept);
            }
            catch (Exception)
            {

                throw new Exception("Not Found!");
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
