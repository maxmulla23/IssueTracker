using System;
using System.Collections.Generic;
using System.Linq;
using IssueTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace IssueTracker.Data
{
    public class IssueTrackerContext : IdentityDbContext<User>
    {
        protected readonly IConfiguration Configuration;
        public IssueTrackerContext (IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString"));
        }

        public DbSet<BugIssue> BugIssues { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<User>()
            .HasMany(e => e.BugIssues)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId);
            
            modelbuilder.Entity<User>()
            .HasMany(e => e.Recommendations)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId);

        }
    }
}