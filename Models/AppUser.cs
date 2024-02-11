using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public ICollection<BugIssue> BugIssues { get; set; } = new List<BugIssue>();
        public ICollection<Recommendation> Recommendations { get; set; } = new List<Recommendation> ();
     }
}