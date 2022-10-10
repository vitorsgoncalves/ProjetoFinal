using API_Alunos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Context {
    public class AppDbContext:DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<CoffeeBreak>? CoffeeBreaks { get; set; }
        public DbSet<Equipamento>? Equipamentos { get; set; }
        public DbSet<Sala>? Salas { get; set; }
        public DbSet<Horario>? Horarios { get; set; }
        public DbSet<Impressao>? Impressoes { get; set; }
        public DbSet<Limpeza>? Limpezas { get; set; }
        public DbSet<MaterialEscritorio>? MateriaisEscritorios { get; set; }
<<<<<<< HEAD
        public DbSet<Objeto>? Objetos { get; set; }
        // public DbSet<Disponibilidade>? Disponibilidades { get; set; }
        
=======

        public DbSet<Objeto>? Objetos { get; set; }

>>>>>>> 378f4e4211e58a277a306e11be0b9ec907da8cbd
        public DbSet<Periodo>? Periodos { get; set; }
        public DbSet<Endereco>? Enderecos { get; set; }
        // public DbSet<Disponibilidade>? Disponibilidades { get; set; }   
        public DbSet<Servico>? Servicos { get; set; }
        public DbSet<Reserva>? Reservas { get; set; }

        public DbSet<Foto>? Fotos { get; set; }
    }
}
