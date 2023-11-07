using eMovieTicketSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMovieTicketSite.Controllers
{
    public class MoviesController : Controller
    {
        // define app db context for database operations
        private readonly AppDbContext _context;
        // create a contronstructor for dependency injection to be able to use dbcontext
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            // get the data from dbcontext: Asynchronously
            var allMovies = await _context.Movies.ToListAsync();
            // next pass the data to view
            return View();
        }
    }
}
