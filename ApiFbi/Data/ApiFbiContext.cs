using ApiFbi.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFbi.Data
{
    public class ApiFbiContext : DbContext
    {
        public ApiFbiContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Fbi> Fbi { get; set; }

        public DbSet<Interpol> Interpol { get; set; } = default!;
    }
}
