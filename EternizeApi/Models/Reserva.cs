using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EternizeApi.Models
{

    [Table("Reservas")]
    public class Reserva
    {
        [Key]
        public int id_reserva { get; set; }

        public int ClienteId { get; set;}
        [JsonIgnore]    
        public Cliente? cliente  { get; set; }

        public int DestinoId { get; set; }
        [JsonIgnore]
        public Destino? destino {  get; set; }
        
        public int PacoteId {  get; set; }
        [JsonIgnore]
        public Pacote? pacote { get; set; }

       
        public DateTime Data_reserva { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? valor { get; set; }

    }
}
