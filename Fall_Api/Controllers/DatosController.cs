using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fall_Api.Models;

namespace Fall_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosController : ControllerBase
    {
        private readonly ContextoBD _context;

        public DatosController(ContextoBD context)
        {
            _context = context;
        }

        // GET: api/Datos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dato>>> GetDatos()
        {
            return await _context.Datos.ToListAsync();
        }

        // GET: api/Datos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dato>> GetDato(long id)
        {
            var dato = await _context.Datos.FindAsync(id);

            if (dato == null)
            {
                return NotFound();
            }

            return dato;
        }

        // PUT: api/Datos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDato(long id, Dato dato)
        {
            if (id != dato.Id)
            {
                return BadRequest();
            }

            _context.Entry(dato).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DatoExists(id))
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

        // POST: api/Datos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dato>> PostDato(Dato dato)
        {
            _context.Datos.Add(dato);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetDato", new { id = dato.Id }, dato);
            return CreatedAtAction(nameof(GetDato), new { id = dato.Id}, dato);
        }

        // DELETE: api/Datos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDato(long id)
        {
            var dato = await _context.Datos.FindAsync(id);
            if (dato == null)
            {
                return NotFound();
            }

            _context.Datos.Remove(dato);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DatoExists(long id)
        {
            return _context.Datos.Any(e => e.Id == id);
        }
    }
}
