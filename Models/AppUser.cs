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
        public string? FullName { get; set; }
        
        public UserType UserType { get; set; }


        
    }
}