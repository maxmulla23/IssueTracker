using System;
using System.Linq;

namespace IssueTracker.Models;

public class BugIssue
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime ReportedAt { get; set; }
   
    

    public BugIssue()
    {
        ReportedAt = DateTime.Now;
    }
}