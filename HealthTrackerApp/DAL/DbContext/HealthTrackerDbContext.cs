
using HealthTrackerApp.Models;
using System.Data.Entity;


namespace HealthTrackerApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Health> Healths { get; set; }
    }
}