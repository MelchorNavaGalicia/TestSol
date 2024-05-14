using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNet.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido_Paterno { get; set;}
        [Required]
        public string Apellido_Materno { get; set; }

        [ForeignKey("Area")]
        public int IdArea { get; set; }
        public  Area? Area { get; set; }
        [Required]
        public System.DateTime Fecha_Nacimiento { get; set; }
        [Required]
        public double Sueldo { get; set; }
    }

}
