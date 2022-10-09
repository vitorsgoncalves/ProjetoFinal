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

        //na tabela que tem muitosna relação de 1 pra muitos,
        //vai colocar como nesse modelo
         [JsonIgnore]
        public Sala? Salas {get; set;}
    }
}
