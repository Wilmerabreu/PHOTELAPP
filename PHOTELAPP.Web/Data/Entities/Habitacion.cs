using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PHOTELAPP.Web.Data.Entities
{
    [Table("Habitaciones")]
    public class Habitacion
    {

        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; } = null!;
        public int Capacidad { get; set; }
        public int PrecioPorNoche { get; set; }
        public bool Disponibilidad { get; set; }

    }
}
