using AcademiaTangoApp.Data;
using AcademiaTangoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcademiaTangoApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClasesController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public ClasesController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/clases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clase>>> GetClases()
        {
            return await _context.Clases
                .Include(c => c.Estudiante)
                .Include(c => c.Profesor)
                .ToListAsync();
        }

        // GET: api/clases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clase>> GetClase(int id)
        {
            var clase = await _context.Clases
                .Include(c => c.Estudiante)
                .Include(c => c.Profesor)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (clase == null) return NotFound();
            return clase;
        }

        // POST: api/clases
        [HttpPost]
        public async Task<ActionResult<Clase>> PostClase(Clase clase)
        {
            _context.Clases.Add(clase);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetClase), new { id = clase.Id }, clase);
        }

        // PUT: api/clases/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClase(int id, Clase clase)
        {
            if (id != clase.Id) return BadRequest();

            _context.Entry(clase).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/clases/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClase(int id)
        {
            var clase = await _context.Clases.FindAsync(id);
            if (clase == null) return NotFound();

            _context.Clases.Remove(clase);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
