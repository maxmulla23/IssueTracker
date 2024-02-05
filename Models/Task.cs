using System;

namespace IssueTracker.Models;

public class Todo
{
    public int Id { get; set; }
    public string? TaskTitle { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public virtual Developer? Developer { get; set; }
    
}