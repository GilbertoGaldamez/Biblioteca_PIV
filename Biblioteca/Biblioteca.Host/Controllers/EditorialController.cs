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
    public class EditorialController : ApiController
    {
        // 2. CONTEXTO / abre conexion
        BibliotecaContext bibliotecaContext = new BibliotecaContext("BibliotecaMaestro");   // Contiene el nombre de la conexion <connectionStrings> en Web.config

        // Destruir el contexto para eliminar conexion
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                bibliotecaContext.Dispose();
            }

            base.Dispose(disposing);
        }

        // 3. Modificar los Verbos
        // GET: api/Editorial
        public IEnumerable<Editorial> Get()
        {
            return bibliotecaContext.Editoriales;
        }

        // GET: api/Editorial/5
        [ResponseType(typeof(Editorial))]           // Indicar a ASP de que tipo es la respuesta que va a devolver
        public IHttpActionResult Get(int id)        // IHttpActionResult retorna codigo; es obligatorio definir que codigo retornara
        {
            var editorial = bibliotecaContext.Editoriales.Find(id);     // Para buscar un editorial especifico
            if(editorial == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(editorial);
            }
        }

        // POST: api/Editorial
        [ResponseType(typeof(Editorial))]
        public IHttpActionResult Post(Editorial nuevoEditorial)
        {
            if(!ModelState.IsValid)                         // Valida el estado del objeto
            {
                return BadRequest(ModelState);
            }

            bibliotecaContext.Editoriales.Add(nuevoEditorial);      // Agregar Editorial
            bibliotecaContext.SaveChanges();
            return Ok(nuevoEditorial);
        }

        // PUT: api/Editorial/5
        [ResponseType(typeof(Editorial))]
        public IHttpActionResult Put(int id, Editorial editorial)       // El Editorial con este ID conviertalo en este objeto
        {
            if(id != editorial.Id)      // Si no encuentra el ID
            {
                return BadRequest(ModelState);
            }

            bibliotecaContext.Entry(editorial).State = System.Data.Entity.EntityState.Modified;     // Le indicamos al contexto que modiicamos

            bibliotecaContext.SaveChanges();
            return Ok(editorial);
        }

        // DELETE: api/Editorial/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var editorial = bibliotecaContext.Editoriales.Find(id);
            if(editorial == null)
            {
                return NotFound();
            }

            bibliotecaContext.Editoriales.Remove(editorial);
            bibliotecaContext.SaveChanges();
            return Ok();
        }
    }
}
