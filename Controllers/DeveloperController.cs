using System;
using System.Linq;
using IssueTracker.Data;
using IssueTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Controllers
{
    [Route("api/controller")]
    [ApiController]
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

        [HttpGet("{id}")] // get by id

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

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeveloper(int id, Developer developer)
        {
            if (id != developer.Id)
            {
                return BadRequest();
            }
            _context.Entry(developer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!DeveloperExists(id))
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
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeveloper(int id)
        {
            var developer = await _context.Developers.FindAsync(id);
            if (developer == null)
            {
                return NotFound();
            }
            _context.Developers.Remove(developer);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool DeveloperExists(int id)
        {
            return _context.Developers.Any(e => e.Id == id);
        }
    }
}