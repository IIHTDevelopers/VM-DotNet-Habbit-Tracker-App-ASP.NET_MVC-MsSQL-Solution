
using HabitTrackerApp.Models;
using System.Data.Entity;

namespace HabitTrackerApp.DAL
{
    public class HabitTrackerDbContext : DbContext
    {
        public HabitTrackerDbContext()
            : base("name=HabitTrackerConnectionString")
        {
        }
        public DbSet<Habit> Habits { get; set; }
    }
}