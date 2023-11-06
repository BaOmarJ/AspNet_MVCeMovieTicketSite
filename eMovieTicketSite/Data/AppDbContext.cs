using Microsoft.EntityFrameworkCore;

namespace eMovieTicketSite.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
