using Microsoft.EntityFrameworkCore;

namespace PracticaMVC.Models
{
    public class equiposContext : DbContext
    {
        public equiposContext(DbContextOptions<equiposContext> dbContext) : base(dbContext)
        {


        }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<equipos> equipos { get; set; }

    }
}
    