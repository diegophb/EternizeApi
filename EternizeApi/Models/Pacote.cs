using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EternizeApi.Models
{
    [Table("Pacotes")]
    public class Pacote
    {
        public Pacote()
        {
            Reservas = new Collection<Reserva>();
        }
        [Key]
        public int id_pacote { get; set; }


        [Required]
        [StringLength(80)]
        public string? nome { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
         public decimal? valor { get; set; }

        public ICollection<Reserva> Reservas { get; set; }
    }
}
