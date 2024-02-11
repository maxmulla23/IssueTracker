using System;
using System.Linq;
using IssueTracker.Data;

namespace IssueTracker.Models;

public class BugIssue
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime ReportedAt { get; set; }
    public Priority Priority { get; set; } 
    
    public Feedback? Feedback { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public BugIssue()
    {
        ReportedAt = DateTime.Now;
        Priority = Priority.High;
    }
}