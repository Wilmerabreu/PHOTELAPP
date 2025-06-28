using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PHOTELAPP.Web.Data.Entities
{
    [Table("Clientes")]
    public class Cliente
    {
       [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public required string Cedula { get; set; }
        public int Telefono { get; set; }


    }
}
