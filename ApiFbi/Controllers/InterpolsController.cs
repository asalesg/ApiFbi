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
    public class InterpolsController : ControllerBase
    {
        private readonly ApiFbiContext _context;

        public InterpolsController(ApiFbiContext context)
        {
            _context = context;
        }

        // GET: api/Interpols
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interpol>>> GetInterpol()
        {
          if (_context.Interpol == null)
          {
              return NotFound();
          }
            return await _context.Interpol.ToListAsync();
        }

        // GET: api/Interpols/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Interpol>> GetInterpol(int id)
        {
          if (_context.Interpol == null)
          {
              return NotFound();
          }
            var interpol = await _context.Interpol.FindAsync(id);

            if (interpol == null)
            {
                return NotFound();
            }

            return interpol;
        }

        // PUT: api/Interpols/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInterpol(int id, Interpol interpol)
        {
            if (id != interpol.EntityId)
            {
                return BadRequest();
            }

            _context.Entry(interpol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InterpolExists(id))
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

        // POST: api/Interpols
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Interpol>> PostInterpol(Interpol interpol)
        {
          if (_context.Interpol == null)
          {
              return Problem("Entity set 'ApiFbiContext.Interpol'  is null.");
          }
            _context.Interpol.Add(interpol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInterpol", new { id = interpol.EntityId }, interpol);
        }

        // DELETE: api/Interpols/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInterpol(int id)
        {
            if (_context.Interpol == null)
            {
                return NotFound();
            }
            var interpol = await _context.Interpol.FindAsync(id);
            if (interpol == null)
            {
                return NotFound();
            }

            _context.Interpol.Remove(interpol);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InterpolExists(int id)
        {
            return (_context.Interpol?.Any(e => e.EntityId == id)).GetValueOrDefault();
        }
    }
}
