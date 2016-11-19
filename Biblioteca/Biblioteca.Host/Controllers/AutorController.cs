using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// 1. Se agrega estos using
using Biblioteca.Data;
using Biblioteca.Data.Modelos;
using System.Web.Http.Description;

namespace Biblioteca.Host.Controllers
{
    public class AutorController : ApiController
    {
        // 2. CONTEXTO / abre conexion
        BibliotecaContext bibliotecaContext = new BibliotecaContext("BibliotecaMaestro");   // Contiene el nombre de la conexion <connectionStrings> en Web.config

        // Destruir el contexto para eliminar conexion
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                bibliotecaContext.Dispose();
            }

            base.Dispose(disposing);
        }

        // 3. Modificar los Verbos
        [Route("api/Autor/(idAutor)/{idAutor}/libro")]              // Modifica un Libro
        [HttpPut]
        public IHttpActionResult AgregarLibro(int idAutor, Libro nuevoLibro)
        {
            Autor autor = bibliotecaContext.Autores.Find(idAutor);
            if (autor == null)
            {
                return NotFound();
            }

            autor.AgregarLibro(nuevoLibro);
            bibliotecaContext.SaveChanges();

            return Ok(autor);
        }

        // GET: api/Autor
        public IEnumerable<Autor> Get()
        {
            return bibliotecaContext.Autores;
        }

        // GET: api/Autor/5
        [ResponseType(typeof(Autor))]
        public IHttpActionResult Get(int id)
        {
            //  En el Dbset de Autores incluya la propiedad libros y luego hace un query que devuelve el autor actual
            var autor = bibliotecaContext.Autores
                .Include("Libros")
                .First(a => a.Id == id);     // First: similar a un For que recorre los autores (id)
            if(autor == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(autor);
            }
        }

        // POST: api/Autor
        [ResponseType(typeof(Autor))]
        public IHttpActionResult Post(Autor nuevoAutor)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bibliotecaContext.Autores.Add(nuevoAutor);
            bibliotecaContext.SaveChanges();
            return Ok(nuevoAutor);
        }

        // PUT: api/Autor/5
        [ResponseType(typeof(Autor))]
        public IHttpActionResult Put(int id, Autor autor)
        {
            if(id != autor.Id)
            {
                return BadRequest(ModelState);
            }

            bibliotecaContext.Entry(autor).State = System.Data.Entity.EntityState.Modified;

            bibliotecaContext.SaveChanges();
            return Ok(autor);
        }

        // DELETE: api/Autor/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var autor = bibliotecaContext.Autores.Find(id);
            if(autor == null)
            {
                return NotFound();
            }

            bibliotecaContext.Autores.Remove(autor);
            bibliotecaContext.SaveChanges();
            return Ok();
        }
    }
}
