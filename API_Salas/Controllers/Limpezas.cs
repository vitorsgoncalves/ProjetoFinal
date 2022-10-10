using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace API_Professores.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class LimpezasController : ControllerBase {

        private readonly AppDbContext _context;
        public LimpezasController(AppDbContext context) {
            _context = context;
        }

        //Obter todas as informações
        [HttpGet]
        public ActionResult<IEnumerable<Objeto>> Get() {
            var limpezas = _context.Limpezas.ToList();
            if (limpezas is null) {
                return NotFound();
            }
            return Ok(limpezas);
        }

        //obter informação específica peça chave primária
        [HttpGet("{id:int}", Name = "ObterLimpeza")]
        public ActionResult<Limpeza> Get(int id) {
            var limpeza = _context.Limpezas.FirstOrDefault(p => p.codl == id);
            if (limpeza is null) {
                return NotFound("Limpezas não encontrado...");
            }
            return limpeza;
        }

        //adiciona informação no banco de dados
        [HttpPost]
        public ActionResult Post(Limpeza limpeza) {
            if (limpeza is null)
                return BadRequest();

            _context.Limpezas.Add(limpeza);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterLimpeza",
                new { id = limpeza.codl }, limpeza);
        }

        //edita a informação no banco de dados
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Limpeza limpeza) {
            if (id != limpeza.codl) {
                return BadRequest();
            }

            _context.Entry(limpeza).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(limpeza);
        }

        //apaga a informação do banco de dados
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            var limpeza = _context.Limpezas.FirstOrDefault(p => p.codl == id);
            //var professor = _context.Professores.Find(id);            

            if (limpeza is null) {
                return NotFound("Limpeza não localizado...");
            }
            _context.Limpezas.Remove(limpeza);
            _context.SaveChanges();

            return Ok(limpeza);
        }
    }
}
