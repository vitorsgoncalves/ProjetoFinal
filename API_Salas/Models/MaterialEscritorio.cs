using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class MaterialEscritorio
    {
        [Key]        
        public int codme { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }
    
        public int quantidade { get; set; }
    }
}
