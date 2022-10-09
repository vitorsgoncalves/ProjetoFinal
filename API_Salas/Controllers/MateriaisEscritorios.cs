using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Professores.Controllers
{  
    [Route("[controller]")]
    [ApiController]
    public class MateriaisEscritoriosController : ControllerBase {

        private readonly AppDbContext _context;
        public MateriaisEscritoriosController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]     
        public ActionResult<IEnumerable<MaterialEscritorio>> Get() {
            var materiaisescritorios = _context.MateriaisEscritorios.ToList();
            if (materiaisescritorios is null) {
                return NotFound();
            }
            return Ok(materiaisescritorios);
        }

        [HttpGet("{id:int}", Name = "ObterMaterialEscritorio")]      
        public ActionResult<MaterialEscritorio> Get(int id) {
            var materialescritorio = _context.MateriaisEscritorios.FirstOrDefault(p => p.codme == id);
            if (materialescritorio is null) {
                return NotFound("materiaisescritorios não encontrado...");
            }
            return materialescritorio;
        }

        [HttpPost]     
        public ActionResult Post(MaterialEscritorio materialescritorio) {
            if (materialescritorio is null)
                return BadRequest();

            _context.MateriaisEscritorios.Add(materialescritorio);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterMaterialEscritorio",
                new { id = materialescritorio.codme }, materialescritorio);
        }
        [HttpPut("{id:int}")]       
        public ActionResult Put(int id, MaterialEscritorio materialescritorio) {
            if (id != materialescritorio.codme) {
                return BadRequest();
            }

            _context.Entry(materialescritorio).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(materialescritorio);
        }
        [HttpDelete("{id:int}")]    
        public ActionResult Delete(int id) {
            var materialescritorio = _context.MateriaisEscritorios.FirstOrDefault(p => p.codme == id);
            //var professor = _context.Professores.Find(id);            

            if (materialescritorio is null) {
                return NotFound("MaterialEscritorio não localizado...");
            }
            _context.MateriaisEscritorios.Remove(materialescritorio);
            _context.SaveChanges();

            return Ok(materialescritorio);
        }
    }
}
