using System;
using System.Linq;

namespace IssueTracker.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string? Description { get; set; }
       public int BugIssueId { get; set; }
       public BugIssue BugIssue {get; set;} = null!;
    
    }
}