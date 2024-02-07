using System;
using IssueTracker.Data;

namespace IssueTracker.Models;

public class Recommendation
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime ReportedAt { get; set; }
    public Priority Priority { get; set; }
    public Recommendation()
    {
        ReportedAt = DateTime.Now;
        Priority = Priority.Medium;
        
    }
}