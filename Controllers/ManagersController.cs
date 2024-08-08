using ARSENAL_API_2.Core;
using ARSENAL_API_2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ARSENAL_API_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManagersController : ControllerBase
    {
        private readonly ArsenalContext _context;

        public ManagersController(ArsenalContext context)
        {
            _context = context;
        }

        // GET: /Manager
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manager>>> GetManagers()
        {
            return await _context.Managers.ToListAsync();
        }

      
    }
}