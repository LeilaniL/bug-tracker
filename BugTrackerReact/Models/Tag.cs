using System.Collections.Generic;

namespace BugTracker.Models
{
  public class Tag
  {
    public Tag()
    {
      this.Issues = new HashSet<TagIssue>();
    }

    public int TagId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<TagIssue> Issues { get; set; }
  }
}