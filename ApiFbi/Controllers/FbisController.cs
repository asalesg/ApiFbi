using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiFbi.Data;
using ApiFbi.Models;

namespace ApiFbi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FbisController : ControllerBase
    {
        private readonly ApiFbiContext _context;

        public FbisController(ApiFbiContext context)
        {
            _context = context;
        }

        // GET: api/Fbis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fbi>>> GetFbi()
        {
          if (_context.Fbi == null)
          {
              return NotFound();
          }
            return await _context.Fbi.ToListAsync();
        }

        // GET: api/Fbis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fbi>> GetFbi(string id)
        {
          if (_context.Fbi == null)
          {
              return NotFound();
          }
            var fbi = await _context.Fbi.FindAsync(id);

            if (fbi == null)
            {
                return NotFound();
            }

            return fbi;
        }

        // PUT: api/Fbis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFbi(string id, Fbi fbi)
        {
            if (id != fbi.Title)
            {
                return BadRequest();
            }

            _context.Entry(fbi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FbiExists(id))
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

        // POST: api/Fbis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fbi>> PostFbi(Fbi fbi)
        {
          if (_context.Fbi == null)
          {
              return Problem("Entity set 'ApiFbiContext.Fbi'  is null.");
          }
            _context.Fbi.Add(fbi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FbiExists(fbi.Title))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFbi", new { id = fbi.Title }, fbi);
        }

        // DELETE: api/Fbis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFbi(string id)
        {
            if (_context.Fbi == null)
            {
                return NotFound();
            }
            var fbi = await _context.Fbi.FindAsync(id);
            if (fbi == null)
            {
                return NotFound();
            }

            _context.Fbi.Remove(fbi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FbiExists(string id)
        {
            return (_context.Fbi?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
