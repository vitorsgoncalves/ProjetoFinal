using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace API_Professores.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ObjetosController : ControllerBase {

        private readonly AppDbContext _context;
        public ObjetosController(AppDbContext context) {
            _context = context;
        }

        //Obter todas as informações
        [HttpGet]
        public ActionResult<IEnumerable<Objeto>> Get() {
            var objetos = _context.Objetos.ToList();
            if (objetos is null) {
                return NotFound();
            }
            return Ok(objetos);
        }

        //obter informação específica peça chave primária
        [HttpGet("{id:int}", Name = "ObterObjeto")]
        public ActionResult<Objeto> Get(int id) {
            var objeto = _context.Objetos.FirstOrDefault(p => p.codob == id);
            if (objeto is null) {
                return NotFound("objeto não encontrado...");
            }
            return objeto;
        }

        //adiciona informação no banco de dados
        [HttpPost]
        public ActionResult Post(Objeto objeto) {
            if (objeto is null)
                return BadRequest();

            _context.Objetos.Add(objeto);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterObjeto",
                new { id = objeto.codob }, objeto);
        }

        //edita a informação no banco de dados
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Objeto objeto) {
            if (id != objeto.codob) {
                return BadRequest();
            }

            _context.Entry(objeto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(objeto);
        }

        //apaga a informação do banco de dados
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            var objeto = _context.Objetos.FirstOrDefault(p => p.codob == id);
            //var professor = _context.Professores.Find(id);            

            if (objeto is null) {
                return NotFound("Objeto não localizado...");
            }
            _context.Objetos.Remove(objeto);
            _context.SaveChanges();

            return Ok(objeto);
        }
    }
}
