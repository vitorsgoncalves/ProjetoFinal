using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class CoffeeBreak
    {
        [Key]        
        public int codcb { get; set; }

        [Required]
        [StringLength(50)]
        public string tipo { get; set; }
        [StringLength(100)]
        public string nome { get; set; }

        public int quantidade { get; set; }

        [StringLength(50)]
        public string recheio { get; set; }
    }
}
