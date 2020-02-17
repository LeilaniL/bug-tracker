using System.Collections.Generic;
using System;

namespace BugTracker.Models
{
  public class Issue
  {
    public Issue()
    {
      this.Tags = new HashSet<TagIssue>();
    }
    public Issue(string description) : this()
    {
      Description = description;
    }
    public int IssueId { get; set; }
    public string Description { get; set; }
    public string WrongSteps { get; set; }

    public string RightSteps { get; set; }
    public DateTime Timestamp { get; set; }
    public ICollection<TagIssue> Tags { get; set; }
  }
}