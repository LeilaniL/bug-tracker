namespace BugTracker.Models
{
  public class TagIssue
  {
    public int TagIssueId { get; set; }
    public int IssueId { get; set; }
    public int TagId { get; set; }
    public Issue Issue { get; set; }
    public Tag Tag { get; set; }
  }
}