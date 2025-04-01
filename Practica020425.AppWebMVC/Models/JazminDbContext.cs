using Microsoft.EntityFrameworkCore;

namespace Practica020425.AppWebMVC.Models
{
    public class JazminDbContext : DbContext
    {
        public JazminDbContext(DbContextOptions<JazminDbContext> options) : base(options) { }

        public DbSet<Proveedor> Proveedores { get; set; }

    }
}
