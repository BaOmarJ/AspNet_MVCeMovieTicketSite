using Microsoft.AspNetCore.Mvc;
using eMovieTicketSite.Data;
using eMovieTicketSite.Data.Services;
using eMovieTicketSite.Models;

namespace eMovieTicketSite.Controllers
{
    public class ActorsController : Controller
    {
        // service interface for database operations
        private readonly IActorsService _service;
        // create a contronstructor for dependency injection to be able to use dbcontext
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            // get the data from dbcontext: Synchronously
            var allActors = await _service.GetAll();
            // next pass the data to view
            return View(allActors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName, Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
