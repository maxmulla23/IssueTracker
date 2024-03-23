using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using IssueTracker.Data;

namespace IssueTracker.Models;

public class BugIssue
{
    [Key]
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime ReportedAt { get; set; }
    public Priority Priority { get; set; } 
    public string? UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; } = null!;
    public BugIssue()
    {
        ReportedAt = DateTime.Now;
        Priority = Priority.High;
    }
}