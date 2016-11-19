using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data.Modelos
{
    public class Autor
    {
        public Autor()      // Se inicializa la lista
        {
            this.Libros = new List<Libro>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public IList<Libro> Libros { get; set; }    // El autor tendra muchos libros; relacion: muchos a muchos

        public void AgregarLibro(Libro nuevoLibro)  // Se agrega aqui el metodo para hacer validaciones
        {
            this.Libros.Add(nuevoLibro);
        }
    }
}
