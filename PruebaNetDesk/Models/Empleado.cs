using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNetDesk.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public int IdArea { get; set; }
        public Area? Area { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public double Sueldo { get; set; }
    }
}
