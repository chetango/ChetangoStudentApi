using AcademiaTangoApp.Data;
using AcademiaTangoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcademiaTangoApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfesoresController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public ProfesoresController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/profesores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesor>>> GetProfesores()
        {
            return await _context.Profesores.ToListAsync();
        }

        // GET: api/profesores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profesor>> GetProfesor(int id)
        {
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor == null) return NotFound();
            return profesor;
        }

        // POST: api/profesores
        [HttpPost]
        public async Task<ActionResult<Profesor>> PostProfesor(Profesor profesor)
        {
            _context.Profesores.Add(profesor);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProfesor), new { id = profesor.Id }, profesor);
        }

        // PUT: api/profesores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesor(int id, Profesor profesor)
        {
            if (id != profesor.Id) return BadRequest();
            _context.Entry(profesor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/profesores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfesor(int id)
        {
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor == null) return NotFound();
            _context.Profesores.Remove(profesor);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
