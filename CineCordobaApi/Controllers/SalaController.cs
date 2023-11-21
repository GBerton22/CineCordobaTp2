using CineCordobaApi.Services.Interfaz;
using CineCordobaBack.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineCordobaApi.Controllers
{
    [Route("api/salas")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private readonly ISalasServices _salasService;

        public SalaController(ISalasServices salasService)
        {
            _salasService = salasService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Salas>> GetSalas()
        {
            var salas = _salasService.ObtenerSalas();
            return Ok(salas);
        }
    }
}
