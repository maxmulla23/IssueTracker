using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IssueTracker.Data;
using IssueTracker.Models;

namespace IssueTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugIssueController : ControllerBase
    {
        private readonly IssueTrackerContext _context;

        public BugIssueController(IssueTrackerContext context)
        {
            _context = context;
        }

        // GET: api/BugIssue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BugIssue>>> GetBugIssues()
        {
            return await _context.BugIssues.ToListAsync();
        }

        // GET: api/BugIssue/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BugIssue>> GetBugIssue(int id)
        {
            var bugIssue = await _context.BugIssues.FindAsync(id);

            if (bugIssue == null)
            {
                return NotFound();
            }

            return bugIssue;
        }

        // PUT: api/BugIssue/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBugIssue(int id, BugIssue bugIssue)
        {
            if (id != bugIssue.Id)
            {
                return BadRequest();
            }

            _context.Entry(bugIssue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BugIssueExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BugIssue
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostBugIssue([FromBody] BugIssue model)
        {
            BugIssue bugIssue = new BugIssue()
            {
                Description = model.Description,
                Priority = model.Priority
            };
            _context.BugIssues.Add(bugIssue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBugIssue", new { id = bugIssue.Id }, bugIssue);
        }

        // DELETE: api/BugIssue/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBugIssue(int id)
        {
            var bugIssue = await _context.BugIssues.FindAsync(id);
            if (bugIssue == null)
            {
                return NotFound();
            }

            _context.BugIssues.Remove(bugIssue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BugIssueExists(int id)
        {
            return _context.BugIssues.Any(e => e.Id == id);
        }
    }
}
