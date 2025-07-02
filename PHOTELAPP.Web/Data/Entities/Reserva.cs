using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PHOTELAPP.Web.Data.Entities
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Habitacion")]
        public int HabitacionId { get; set; }
        public ICollection<Habitacion> IDHabitacion { get; set; } = null!;
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public ICollection<Cliente> IdCliente { get; set; } = null!;
        public DateTime? FechaEntrada { get; set; } = default;
        public DateTime? FechaSalida { get; set; } = default;
        public int CantidadPersonas { get; set; }
        public bool Estado { get; set; } = false;
        public decimal Total { get; set; } = 0;
    }
}
