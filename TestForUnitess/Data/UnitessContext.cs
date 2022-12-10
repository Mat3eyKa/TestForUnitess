using Microsoft.EntityFrameworkCore;
using TestForUnitess.Models;

namespace TestForUnitess.Data
{
    public class UnitessContext : DbContext
    {
        public UnitessContext(DbContextOptions<UnitessContext> options)
            : base(options) => Database.EnsureCreated();
        public DbSet<Person> Events { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Person>(entity => entity.ToTable(name: "Persons"));
        }
    }
}
