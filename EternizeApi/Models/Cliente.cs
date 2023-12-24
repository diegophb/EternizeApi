
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EternizeApi.Models

{
    [Table("Clientes")]
    public class Cliente
    {
        public Cliente()
        {
            Reservas = new Collection<Reserva>();
        }
            [Key]
        public int id_cliente {  get; set; }
        [Required]
        [StringLength(80)]
        public String? Nome { get; set; }
        [Required]
        [StringLength(80)]
        public String? Telefone {  get; set; }
        [Required]
        [StringLength(80)]
        public String? Email {  get; set; }

        public ICollection<Reserva> Reservas { get; set; }

    }

}