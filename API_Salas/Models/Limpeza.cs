using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models
{
    public class Limpeza
    { 
        [Key]       
        public int codl { get; set; }
         
        [StringLength(40)]
        public string tipo { get; set; }
        [StringLength(100)]
        public decimal descricao { get; set; }
    }
}
