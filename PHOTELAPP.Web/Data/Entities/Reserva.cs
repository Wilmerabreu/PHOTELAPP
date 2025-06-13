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
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }
        public string Estado { get; set; }
        public int Total { get; set; }
    }
}
