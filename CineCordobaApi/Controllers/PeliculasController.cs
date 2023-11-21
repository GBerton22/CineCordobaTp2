using CineCordobaApi.Services.Implementacion;
using CineCordobaApi.Services.Interfaz;
using CineCordobaBack.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CineCordobaApi.Controllers
{
    [ApiController]
    [Route("api/peliculas")]
    public class PeliculasController : ControllerBase
    {
        private readonly IPeliculaService _peliculasService;

        public PeliculasController(IPeliculaService peliculasService)
        {
            _peliculasService = peliculasService;
        }

        [HttpGet("consulta")]
        public ActionResult<IEnumerable<Peliculas>> GetPeliculas()
        {
            var peliculas = _peliculasService.ObtenerPeliculas();
            return Ok(peliculas);
        }
        [HttpGet("modificacion")]
        public ActionResult<IEnumerable<Peliculas>> GetPelicula()
        {
            var peliculas = _peliculasService.ObtenerPeliculas();
            return Ok(peliculas);
        }
    }
}
