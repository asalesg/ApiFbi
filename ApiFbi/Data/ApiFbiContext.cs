using ApiFbi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

namespace ApiFbi.Data
{
    public class ApiFbiContext : DbContext
    {
        public ApiFbiContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Fbi> Fbi { get; set; }

        public DbSet<ApiFbi.Models.Interpol> Interpol { get; set; } = default!;
    }
}
