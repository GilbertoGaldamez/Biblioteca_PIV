using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Biblioteca.Data.Modelos;

namespace Biblioteca.Data
{
    public class BibliotecaContext: DbContext
    {
        public BibliotecaContext() { }
        public BibliotecaContext(string ConnectionName):base(ConnectionName)//creamos este constructor porque nos tiraba error en Program.cs* y llamamos al contructor padre.
        {
            
        }
        public DbSet<Libro> Libros { get; set; }    // Tabla de Libros | <Libro>: Objeto de tipo Libro
        public DbSet<Editorial> Editoriales { get; set; }

        public DbSet<Autor> Autores { get; set; }
    }
}
