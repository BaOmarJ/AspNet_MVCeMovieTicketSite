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
            var allActors = await _service.GetAllAsync();
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
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        // Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            // Check if actor details is null
            if(actorDetails == null) 
            {
                return View("Not Found");
            }
            return View(actorDetails);
        }
        // Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            // Check if actor details is null
            if (actorDetails == null)
            {
                return View("Not found");
            }
            return View(actorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, ProfilePictureURL,FullName, Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }
        // Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            // Check if actor details is null
            if (actorDetails == null)
            {
                return View("Not found");
            }
            return View(actorDetails);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            // Check if actor details is null
            if (actorDetails == null)
            {
                return View("Not found");
            }
            await _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
