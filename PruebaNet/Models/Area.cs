using System.ComponentModel.DataAnnotations;

namespace PruebaNet.Models
{
    public class Area
    {
        [Key]
        public int IdArea { get; set; }
        [Required]
        public string NombreArea { get; set; }
    }
}
