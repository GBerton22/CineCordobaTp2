using CineCordobaApi.Services.Interfaz;
using CineCordobaBack.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineCordobaApi.Controllers
{
    [Route("api/horarios")]
    [ApiController]
    public class HorarioController : ControllerBase
    {
        private readonly IHorariosServices _horarioService;

        public HorarioController(IHorariosServices horarioService)
        {
            _horarioService = horarioService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Horarios>> GetHorarios()
        {
            var horario = _horarioService.ObtenerHorarios();
            return Ok(horario);
        }
    }
}
