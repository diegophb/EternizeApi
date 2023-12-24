using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EternizeApi.Context;
using EternizeApi.Models;

namespace EternizeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinosController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public DestinosController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Destinos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destino>>> GetDestinoes()
        {
            return await _context.Destinoes.ToListAsync();
        }

        // GET: api/Destinos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Destino>> GetDestino(int id)
        {
            var destino = await _context.Destinoes.FindAsync(id);

            if (destino == null)
            {
                return NotFound();
            }

            return destino;
        }

        // PUT: api/Destinos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestino(int id, Destino destino)
        {
            if (id != destino.id_destino)
            {
                return BadRequest();
            }

            _context.Entry(destino).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinoExists(id))
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

        // POST: api/Destinos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Destino>> PostDestino(Destino destino)
        {
            _context.Destinoes.Add(destino);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDestino", new { id = destino.id_destino }, destino);
        }

        // DELETE: api/Destinos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestino(int id)
        {
            var destino = await _context.Destinoes.FindAsync(id);
            if (destino == null)
            {
                return NotFound();
            }

            _context.Destinoes.Remove(destino);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinoExists(int id)
        {
            return _context.Destinoes.Any(e => e.id_destino == id);
        }
    }
}
