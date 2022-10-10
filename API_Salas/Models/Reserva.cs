using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Alunos.Models {

<<<<<<< HEAD
    public class Reserva {   
=======
    public class Reserva {
   
>>>>>>> 378f4e4211e58a277a306e11be0b9ec907da8cbd
        [Key]        

        public int codr { get; set; }

        // public int codd { get; set; }

        // public int codob { get; set; }
        

        // public int code { get; set; }

        // public int codserv { get; set; }

        public decimal valorTotal { get; set; }

        public bool reservaEfetuada { get; set; }

        public ICollection<Servico>? Servicos { get; set; }

<<<<<<< HEAD

        public ICollection<Equipamento>? Equipamentos { get; set; }

        public ICollection<Sala>? Salas { get; set; }

        public ICollection<Horario>? Horarios { get; set; }
=======
        public Equipamento? Equipamentos { get; set; }

        public ICollection<Sala>? Salas { get; set; }

        //public ICollection<Disponibilidade>? Disponibilidades { get; set; }
>>>>>>> 378f4e4211e58a277a306e11be0b9ec907da8cbd

        public ICollection<Objeto>? Objetos { get; set; }


    }
}
