using System;

namespace IssueTracker.Models;

public class Recommendation
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime ReportedAt { get; set; }

    public Recommendation()
    {
        ReportedAt = DateTime.Now;
    }
}