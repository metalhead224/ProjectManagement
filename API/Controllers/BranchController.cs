using DataLayer.Data;
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

        [HttpGet]

    }
}
