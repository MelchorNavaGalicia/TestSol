using Microsoft.EntityFrameworkCore;
using PruebaNet.Models;

namespace PruebaNet.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options) { }

        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Area> Area { get; set; }


    }
}
