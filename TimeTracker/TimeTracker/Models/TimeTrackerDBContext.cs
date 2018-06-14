using System.Data.Entity;

namespace TimeTracker.Models
{
    public class TimeTrackerDBContext : DbContext
    {
        // add dbset
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeCard> TimeCards { get; set; }
    }
}