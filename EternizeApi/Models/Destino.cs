using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EternizeApi.Models
{

       [Table("Destinos")]
        public class Destino
        {
        public Destino()
        {
            Reservas = new Collection<Reserva>();
        }

        [Key]
        public int id_destino {  get; set; }
        [Required]
        [StringLength(80)]
        public string? nome { get; set; }
        [Required]
        [StringLength(300)]
        public String? ImagemUrl { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? valor {  get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}
