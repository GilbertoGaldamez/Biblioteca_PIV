using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca.Data.Modelos
{
    public class Libro
    {
        public Libro()
        {
            this.Autores = new List<Autor>() ;
        }
        // Propiedades:
        public int Id { get; set; }     // Id: Framework lo coloca como llave primaria
        public string Nombre { get; set; }
        public int Año { get; set; }
        public Editorial Editorial { get; set; }

        public IList<Autor> Autores { get; set; }       // Se agrega Autores

        public void AgregarAutor(Autor nuevoAutor)
        {
            this.Autores.Add(nuevoAutor);
        }
    }
}
