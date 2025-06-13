using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PHOTELAPP.Web.Data.Entities
{
    [Table("Clientes")]
    public class Cliente
    {
       [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }  
        public string Apellido { get; set; }
        public int Telefono { get; set; }


    }
}
