using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using IssueTracker.Data;

namespace IssueTracker.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public UserType UserType { get; set; }
        public ICollection<BugIssue> BugIssues { get; set; } = new List<BugIssue>();
        public ICollection<Recommendation> Recommendations { get; set; } = new List<Recommendation> ();

        public static implicit operator User(User v)
        {
            throw new NotImplementedException();
        }
    }
}