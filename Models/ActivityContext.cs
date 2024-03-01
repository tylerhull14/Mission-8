using Microsoft.EntityFrameworkCore;

namespace Mission08_Practice.Models
{
    public class ActivityContext : DbContext
    {
        public ActivityContext(DbContextOptions<ActivityContext> options) : base(options) { }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}