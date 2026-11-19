using Microsoft.AspNetCore.Mvc;
using gestion_biblioteca_api.Models;

namespace gestion_biblioteca_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private static List<Categoria> categorias = new List<Categoria>
        {
            new Categoria { Id = 1, Nombre = "Programación" },
            new Categoria { Id = 2, Nombre = "Inteligencia Artificial" },
            new Categoria { Id = 3, Nombre = "Desarrollo de Software" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(categorias);
        }
    }
}
