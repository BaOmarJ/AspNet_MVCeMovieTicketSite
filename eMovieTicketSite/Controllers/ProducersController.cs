using eMovieTicketSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMovieTicketSite.Controllers
{
    public class ProducersController : Controller
    {
        // define app db context for database operations
        private readonly AppDbContext _context;
        // create a contronstructor for dependency injection to be able to use dbcontext
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            // get the data from dbcontext: Asynchronously
            var allProducers = await _context.Producers.ToListAsync();
            // next pass the data to view
            return View();
        }
    }
}
