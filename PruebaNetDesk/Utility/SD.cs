using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNetDesk.Utility
{
    public class SD
    {
        public static string? PruebaNet { get; set; } = "https://localhost:7001/";

        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE,
        }
    }
}
