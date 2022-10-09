using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Professores.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ImpressoesController : ControllerBase {

        private readonly AppDbContext _context;
        public ImpressoesController(AppDbContext context) {
            _context = context;
        }

        //Obter todas as informações
        [HttpGet]
        public ActionResult<IEnumerable<Impressao>> Get() {
            var impressoes = _context.Impressoes.ToList();
            if (impressoes is null) {
                return NotFound();
            }
            return Ok(impressoes);
        }

        //obter informação específica peça chave primária
        [HttpGet("{id:int}", Name = "ObterImpressao")]
        public ActionResult<Impressao> Get(int id) {
            var impressao = _context.Impressoes.FirstOrDefault(p => p.codi == id);
            if (impressao is null) {
                return NotFound("impressao não encontrado...");
            }
            return impressao;
        }

        //adiciona informação no banco de dados
        [HttpPost]
        public ActionResult Post(Impressao impressao) {
            if (impressao is null)
                return BadRequest();

            _context.Impressoes.Add(impressao);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterImpressao",
                new { id = impressao.codi }, impressao);
        }

        //edita a informação no banco de dados
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Impressao impressao) {
            if (id != impressao.codi) {
                return BadRequest();
            }

            _context.Entry(impressao).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(impressao);
        }

        //apaga a informação do banco de dados
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            var impressao = _context.Impressoes.FirstOrDefault(p => p.codi == id);
            //var professor = _context.Professores.Find(id);            

            if (impressao is null) {
                return NotFound("Impressoes não localizado...");
            }
            _context.Impressoes.Remove(impressao);
            _context.SaveChanges();

            return Ok(impressao);
        }
    }
}
