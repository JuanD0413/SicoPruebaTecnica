using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Estudiante.Datos;
using Estudiante.Models;

namespace Estudiante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteCursosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EstudianteCursosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EstudianteCursos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstudianteCurso>>> GetEstudianteCursos()
        {
            return await _context.EstudianteCursos.ToListAsync();
        }

        // GET: api/EstudianteCursos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstudianteCurso>> GetEstudianteCurso(int id)
        {
            var estudianteCurso = await _context.EstudianteCursos.FindAsync(id);

            if (estudianteCurso == null)
            {
                return NotFound();
            }

            return estudianteCurso;
        }

        // PUT: api/EstudianteCursos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstudianteCurso(int id, EstudianteCurso estudianteCurso)
        {
            if (id != estudianteCurso.Id)
            {
                return BadRequest();
            }

            _context.Entry(estudianteCurso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(); 
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudianteCursoExists(id))
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

        // POST: api/EstudianteCursos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstudianteCurso>> PostEstudianteCurso(EstudianteCurso estudianteCurso)
        {
            _context.EstudianteCursos.Add(estudianteCurso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstudianteCurso", new { id = estudianteCurso.Id }, estudianteCurso);
        }

        // DELETE: api/EstudianteCursos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstudianteCurso(int id)
        {
            var estudianteCurso = await _context.EstudianteCursos.FindAsync(id);
            if (estudianteCurso == null)
            {
                return NotFound();
            }

            _context.EstudianteCursos.Remove(estudianteCurso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstudianteCursoExists(int id)
        {
            return _context.EstudianteCursos.Any(e => e.Id == id);
        }
    }
}
