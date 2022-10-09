using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Professores.Controllers
{  
    [Route("[controller]")]
    [ApiController]
    public class CoffeeBreaksController : ControllerBase {

        private readonly AppDbContext _context;
        public CoffeeBreaksController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]     
        public ActionResult<IEnumerable<CoffeeBreak>> Get() {
            var coffeebreaks = _context.CoffeeBreaks.ToList();
            if (coffeebreaks is null) {
                return NotFound();
            }
            return Ok(coffeebreaks);
        }

        [HttpGet("{id:int}", Name = "ObterCoffeeBreak")]      
        public ActionResult<CoffeeBreak> Get(int id) {
            var coffeebreak = _context.CoffeeBreaks.FirstOrDefault(p => p.codcb == id);
            if (coffeebreak is null) {
                return NotFound("coffeebreaks não encontrado...");
            }
            return coffeebreak;
        }

        [HttpPost]     
        public ActionResult Post(CoffeeBreak coffeebreak) {
            if (coffeebreak is null)
                return BadRequest();

            _context.CoffeeBreaks.Add(coffeebreak);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCoffeeBreak",
                new { id = coffeebreak.codcb }, coffeebreak);
        }
        [HttpPut("{id:int}")]       
        public ActionResult Put(int id, CoffeeBreak coffeebreak) {
            if (id != coffeebreak.codcb) {
                return BadRequest();
            }

            _context.Entry(coffeebreak).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(coffeebreak);
        }
        [HttpDelete("{id:int}")]    
        public ActionResult Delete(int id) {
            var coffeebreak = _context.CoffeeBreaks.FirstOrDefault(p => p.codcb == id);
            //var professor = _context.Professores.Find(id);            

            if (coffeebreak is null) {
                return NotFound("CoffeeBreak não localizado...");
            }
            _context.CoffeeBreaks.Remove(coffeebreak);
            _context.SaveChanges();

            return Ok(coffeebreak);
        }
    }
}
