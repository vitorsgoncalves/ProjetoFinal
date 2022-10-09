using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Professores.Controllers
{  
    [Route("[controller]")]
    [ApiController]
    public class FotosController : ControllerBase {

        private readonly AppDbContext _context;
        public FotosController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]     
        public ActionResult<IEnumerable<Foto>> Get() {
            var fotos = _context.Fotos.ToList();
            if (fotos is null) {
                return NotFound();
            }
            return Ok(fotos);
        }

        [HttpGet("{id:int}", Name = "ObterFoto")]      
        public ActionResult<Foto>Get(int id) {
            var fotos = _context.Fotos.FirstOrDefault(p => p.codFoto == id);
            if (fotos is null) {
                return NotFound("cliente não encontrado...");
            }
            return fotos;
        }

        [HttpPost]     
        public ActionResult Post(Foto foto) {
            if (foto is null)
                return BadRequest();

            _context.Fotos.Add(foto);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCliente",
                new { id = foto.codFoto }, foto);
        }
        [HttpPut("{id:int}")]       
        public ActionResult Put(int id, Foto foto) {
            if (id != foto.codFoto) {
                return BadRequest();
            }

            _context.Entry(foto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(foto);
        }
        [HttpDelete("{id:int}")]    
        public ActionResult Delete(int id) {
            var foto = _context.Fotos.FirstOrDefault(p => p.codFoto == id);
            //var professor = _context.Professores.Find(id);            

            if (foto is null) {
                return NotFound("Foto não localizada...");
            }
            _context.Fotos.Remove(foto);
            _context.SaveChanges();

            return Ok(foto);
        }
    }
}
