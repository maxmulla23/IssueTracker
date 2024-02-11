using System;
using System.Linq;

namespace IssueTracker.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }

        public List<Todo> Todos { get; } = [];
    }
}