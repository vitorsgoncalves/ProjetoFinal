using API_Alunos.Context;
using API_Alunos.Models;
using API_Alunos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;


namespace API_Professores.Controllers
{  



    [Route("[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase {

        private readonly AppDbContext _context;
        public PagamentoController(AppDbContext context) {
            _context = context;
        }

        [HttpPost]    
            //Não consigo achar o formato pra enviar o post pra testar
            //não consigo achar a forma de retornar o troco sem dar erro de tipos de dados
            public ActionResult Post(decimal  valorPago, int codr) {
                
            var reserva = _context.Reservas.FirstOrDefault(p => p.codr == codr);
            if (reserva is null) {
                return NotFound("reserva não encontrada...");
            }

            decimal troco = 0;

            decimal total = reserva.valorTotal;
            if (total <= valorPago){
                troco = valorPago - total;
                reserva.reservaEfetuada = true;

            }

            // _context.Clientes.Add(cliente);
            _context.SaveChanges();

            // return new CreatedAtRouteResult("ObterCliente",
            //     new { id = cliente.codc }, cliente);

            return Ok();
        }

    }
}
