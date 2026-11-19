using Microsoft.AspNetCore.Mvc;
using gestion_biblioteca_api.Models;

namespace gestion_biblioteca_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibrosController : ControllerBase
    {
        private static List<Libro> libros = new List<Libro>
        {
            new Libro { Id = 1, Titulo = "Inteligencia artificial: un enfoque moderno", Autor = "Stuart Russell y Peter Norvig", Disponible = true },
            new Libro { Id = 2, Titulo = "Aprendizaje profundo", Autor = "Ian Goodfellow, Yoshua Bengio y Aaron Courville", Disponible = true },
            new Libro { Id = 3, Titulo = "Aprendizaje automático con Scikit-Learn, Keras y TensorFlow", Autor = "Aurélien Géron", Disponible = false }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(libros);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);

            if (libro == null)
            {
                return NotFound();
            }

            return Ok(libro);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Libro nuevoLibro)
        {
            nuevoLibro.Id = libros.Count + 1;
            libros.Add(nuevoLibro);

            return Created("", nuevoLibro);
        }
    }
}
