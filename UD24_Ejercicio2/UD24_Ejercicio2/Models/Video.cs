using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UD24_Ejercicio2.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public string director { get; set; }

        public int cli_id { get; set; }
    }
}
