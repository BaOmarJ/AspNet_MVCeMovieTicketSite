using eMovieTicketSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMovieTicketSite.Controllers
{
    public class CinemasController : Controller
    {// define app db context for database operations
        private readonly AppDbContext _context;
        // create a contronstructor for dependency injection to be able to use dbcontext
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            // get the data from dbcontext: Asynchronously
            var allCinemas = await _context.Cinemas.ToListAsync();
            // next pass the data to view
            return View(allCinemas);
        }
    }
}
