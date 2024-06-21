using Microsoft.EntityFrameworkCore;
using Mithril.Models;

namespace Mithril.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Excercise> Excercises { get; set; }
    }

}
