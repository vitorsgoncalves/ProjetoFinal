using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models
{
    public class Objeto
    { 
        [Key]       
        public int codob { get; set; }
         
        [StringLength(50)]
        public string nome { get; set; }
        [StringLength(100)]
        public decimal descricao { get; set; }
    }
}
