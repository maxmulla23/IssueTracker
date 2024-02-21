using System;
using System.Linq;
using IssueTracker.Data;
using IssueTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Controllers
{
    public class DeveloperController : ControllerBase
    {
        public readonly IssueTrackerContext _context;

        public DeveloperController(IssueTrackerContext context)
        {
            _context = context;
        }

        [HttpGet] // get all developers
        public async Task<ActionResult<IEnumerable<Developer>>> GetDeveloper()
        {
            return await _context.Developers.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Developer>> GetDeveloper(int id)
        {
            var developer = await _context.Developers.FindAsync(id);

            if(developer == null)
            {
                return NotFound();
            }

            return developer;
        }

        [HttpPost]
        public async Task<ActionResult<Developer>> PostDeveloper(Developer developer)
        {
            _context.Developers.Add(developer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDeveloper), new { id = developer.Id }, developer);
        }
    }
}