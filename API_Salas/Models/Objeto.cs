<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

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
=======
﻿using System.ComponentModel.DataAnnotations;

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
>>>>>>> 378f4e4211e58a277a306e11be0b9ec907da8cbd
