using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace API_Alunos.Models
{
    public class Equipamento
    {
        [Key]
        public int code { get; set; }

        [Required]
        [StringLength(40)]
        public string nome { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        //[IntegerLength(3)]
        public decimal voltagemVolts { get; set; }

        //[IntLength(5)]
        public decimal pesoKg { get; set; }

        public int volume { get; set; }
        //[IntLength(20)]
        public decimal custoTotal { get; set; }

        //[IntLength(20)]
        public decimal custoSeguro { get; set; }

        //[IntLength(20)]
        public decimal custoHora { get; set; }

        [JsonIgnore]
        public Reserva? Reserva {get; set;}
    }
}
