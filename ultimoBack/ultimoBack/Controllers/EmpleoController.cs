using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ultimoBack.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ultimoBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleoController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public EmpleoController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<EmpleoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            try
            {
                var lsita_trabajos= await _context.Empleo.ToListAsync();
                return Ok(lsita_trabajos);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
        // POST api/<EmpleoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Empleo empleo)
        {
            try
            {
                _context.Add(empleo);
                await _context.SaveChangesAsync();
                return Ok(empleo);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<EmpleoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Empleo empleo)
        {
            try
            {
                if (id != empleo.id)
                {
                    return NotFound();
                }

                _context.Update(empleo);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El empleo fue actualizado con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<EmpleoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var empleo = await _context.Empleo.FindAsync(id);
                if (empleo == null)
                {
                    return NotFound();
                }

                _context.Empleo.Remove(empleo);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El empleo fue eliminado con exito" });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
