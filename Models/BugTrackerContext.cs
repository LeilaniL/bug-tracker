using Microsoft.EntityFrameworkCore;

namespace BugTracker.Models
{
  public class BugTrackerContext : DbContext
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    
    public BugTrackerContext(DbContextOptions options) : base(options) { }
  }
}