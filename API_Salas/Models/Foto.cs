using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Alunos.Models
{
    public class Foto
    {
        [Key]
        public int codFoto { get; set; }

        public int cods { get; set; }
      
        // [StringLength(MAX)]
        public string foto { get; set; }

         [JsonIgnore]
        public Sala? Sala {get; set;}
    }
}
