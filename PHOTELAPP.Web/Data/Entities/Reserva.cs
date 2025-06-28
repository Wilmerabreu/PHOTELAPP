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
        public int HabitacionId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Estado { get; set; } = null!;
        public int Total { get; set; }
    }
}
