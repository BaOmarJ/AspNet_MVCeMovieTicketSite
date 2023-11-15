using eMovieTicketSite.Models;

namespace eMovieTicketSite.Data.Services
{
    public interface IActorsService
    {
        // define return types and method names that will be implemented by services.
        // Get all actors from db
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id); // get a single actor
        // Add data to db
        Task AddAsync(Actor actor);
        // Update data in db
        Task<Actor> UpdateAsync(int id, Actor actor);
        // delete from db
        Task DeleteAsync(int id);
    }
}
