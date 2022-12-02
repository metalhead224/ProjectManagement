using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ClientController : BaseApiController
    {
        private TaskContext _context;

        public ClientController(TaskContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Client>>> AddClient(Client client)
        {
            _context.Client.Add(client);
            await _context.SaveChangesAsync();
            return Ok(await _context.Client.ToListAsync());
        }
    }
}
