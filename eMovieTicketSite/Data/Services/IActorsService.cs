using eMovieTicketSite.Models;

namespace eMovieTicketSite.Data.Services
{
    public interface IActorsService
    {
        // define return types and method names that will be implemented by services.
        // Get all actors from db
        IEnumerable<Actor> GetAll();
        Actor GetById(int id); // get a single actor
        // Add data to db
        void Add(Actor actor);
        // Update data in db
        Actor Update(int id, Actor actor);
        // delete from db
        void Delete(int id);
    }
}
