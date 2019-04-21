using AppPruebaAspCore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AppPruebaAspCore.API.Data
{
    public class DataContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Value> Values { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
    }
}