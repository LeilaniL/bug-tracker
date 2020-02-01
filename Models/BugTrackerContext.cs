using Microsoft.EntityFrameworkCore;

namespace BugTracker.Models
{
  public class BugTrackerContext : DbContext
  {
    public virtual DbSet<Tag> Tags { get; set; }
    public DbSet<Issue> Issues { get; set; }
    public DbSet<TagIssue> TagIssue { get; set; }

    public BugTrackerContext(DbContextOptions options) : base(options) { }
  }
}