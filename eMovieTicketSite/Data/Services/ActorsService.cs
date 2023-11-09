using eMovieTicketSite.Models;
using Microsoft.EntityFrameworkCore;

namespace eMovieTicketSite.Data.Services
{
    public class ActorsService : IActorsService
    {
        // define app db context for database operations
        private readonly AppDbContext _context;
        // create a contronstructor for dependency injection to be able to use dbcontext
        public ActorsService(AppDbContext context)
        {
                _context = context;
        }
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var actors = await _context.Actors.ToListAsync();
            return actors;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
