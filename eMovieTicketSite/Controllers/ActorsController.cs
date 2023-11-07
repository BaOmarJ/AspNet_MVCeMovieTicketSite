using Microsoft.AspNetCore.Mvc;
using eMovieTicketSite.Data;

namespace eMovieTicketSite.Controllers
{
    public class ActorsController : Controller
    {
        // define app db context for database operations
        private readonly AppDbContext _context;
        // create a contronstructor for dependency injection to be able to use dbcontext
        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // get the data from dbcontext: Synchronously
            var allActors = _context.Actors.ToList();
            // next pass the data to view
            return View(allActors);
        }
    }
}
