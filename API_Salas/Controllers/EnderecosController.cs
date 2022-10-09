using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnderecosController : ControllerBase
    {

        private readonly AppDbContext _context;
        public EnderecosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Endereco>> Get()
        {
            var enderecos = _context.Enderecos.ToList();
            if (enderecos is null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpGet("{id:int}", Name = "ObterEndereco")]
        public ActionResult<Endereco> Get(int id)
        {
            var enderecos = _context.Enderecos.FirstOrDefault(p => p.codend == id);
            if (enderecos is null)
            {
                return NotFound("Endereco não encontrado...");
            }
            return enderecos;
        }

        [HttpPost]
        public ActionResult Post(Endereco endereco)
        {
            if (endereco is null)
                return BadRequest();

            _context.Enderecos.Add(endereco);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterEndereco",
                new { id = endereco.codend }, endereco);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Endereco endereco)
        {
            if (id != endereco.codend)
            {
                return BadRequest();
            }

            _context.Entry(endereco).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(endereco);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(p => p.codend == id);
            //var professor = _context.Professores.Find(id);            

            if (endereco is null)
            {
                return NotFound("Endereco não localizado...");
            }
            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();

            return Ok(endereco);
        }
    }
}
