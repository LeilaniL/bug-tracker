using System.Collections.Generic;

namespace BugTracker.Models
{
  public class Issue
  {
    public Issue()
    {
      this.Tags = new HashSet<TagIssue>();
    }
    public int IssueId { get; set; }
    public string Description { get; set; }
    public ICollection<TagIssue> Tags { get; set; }
  }
}