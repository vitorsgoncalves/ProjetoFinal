using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Alunos.Models {

    public class Reserva {
   
        [Key]        

        public int codr { get; set; }

        public int codd { get; set; }

        public int codob { get; set; }
        
        public int cods { get; set; }

        public int code { get; set; }

        public int codserv { get; set; }

        public decimal valorTotal { get; set; }

        public bool reservaEfetuada { get; set; }
        public ICollection<Servico>? Servicos { get; set; }

        public Equipamento? Equipamentos { get; set; }

        public ICollection<Sala>? Salas { get; set; }

        //public ICollection<Disponibilidade>? Disponibilidades { get; set; }

        public ICollection<Objeto>? Objetos { get; set; }


    }
}
