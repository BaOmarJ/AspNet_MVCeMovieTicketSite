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
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            // get the actor
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            // remove the restult from db
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var actors = await _context.Actors.ToListAsync();
            return actors;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor actor)
        {
            //actor.Id = id;
            _context.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
        }
    }
}
