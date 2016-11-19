using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data.Modelos
{
    public class Libro
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int año { get; set; }
        public Editorial Editorial { get; set; }
    }

}
