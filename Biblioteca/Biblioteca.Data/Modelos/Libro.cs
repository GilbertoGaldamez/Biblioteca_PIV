using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data.Modelos
{
    public class Libro
    {
        // Propiedades:
        public int Id { get; set; }     // Id: Framework lo coloca como llave primaria
        public string Nombre { get; set; }
    }
}
