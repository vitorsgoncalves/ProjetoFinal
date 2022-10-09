using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Alunos.Models {
<<<<<<< HEAD
    public class Reserva {

        // public Reserva() {
        //     Servico = new Collection<Servico>();
        // }

        
        [Required]
=======
    public class Reserva {   
        [Key]        
>>>>>>> 9825d81cc8e452c8921c4f6c7ab865856e8ccbcc
        public int codr { get; set; }

        public int codd { get; set; }

        public int codob { get; set; }
        
        public int cods { get; set; }

        public int code { get; set; }

        public int codserv { get; set; }

        public decimal valorTotal { get; set; }

        public bool reservaEfetuada { get; set; }
<<<<<<< HEAD

        // public ICollection<Servico>? Servicos { get; set; }
=======
        public ICollection<Servico>? Servicos { get; set; }
>>>>>>> 31e6bb8ca5ef3189941ba9579db8e7e52b0e0c84

<<<<<<< HEAD
        public Equipamento? Equipamentos { get; set; }

        public ICollection<Sala>? Salas { get; set; }

        public ICollection<Disponibilidade>? Disponibilidades { get; set; }

        public ICollection<Objeto>? Objetos { get; set; }

=======
>>>>>>> 9825d81cc8e452c8921c4f6c7ab865856e8ccbcc
    }
}
