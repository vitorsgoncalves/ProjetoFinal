using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class Objeto {
        [Key]        
        public int codob { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

    }
}
