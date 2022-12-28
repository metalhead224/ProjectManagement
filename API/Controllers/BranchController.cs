using BusinessLogic.Interface;
using BusinessLogic.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

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
        public async Task<IActionResult> Add(BranchVM branch)
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

        [HttpGet]
        public async Task<IActionResult> BranchList()
        {
            try
            {
                var branch = await _context.GetAll();
                return Ok(branch);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Branch(int Id)
        {
            try
            {
                var branch = await _context.GetById(Id);
                return Ok(branch);
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

        [HttpPut]

        public async Task<IActionResult> UpdateBranch(BranchVM branch)
        {
            try
            {
                await _context.UpdateBranch(branch);
                return Ok("branch added successfully!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
