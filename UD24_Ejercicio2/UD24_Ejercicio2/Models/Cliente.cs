using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UD24_Ejercicio2.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int dni { get; set; }
        public DateTime fecha { get; set; }

    }
}
