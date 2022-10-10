using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models
{
    public class Servico
    { 
        [Key]       
        public int codserv { get; set; }
         
        [StringLength(100)]
        public string descricao { get; set; }

        public decimal custo { get; set; }

        public ICollection<Impressao>? Impressaos { get; set; }

        public ICollection<MaterialEscritorio>? MaterialEscritorios { get; set; }

        public ICollection<CoffeeBreak>? CoffeeBreaks { get; set; }

        public ICollection<Objeto>? Objetos { get; set; }

        //public ICollection<Limpeza>? Limpezas { get;set; }
    }
}
