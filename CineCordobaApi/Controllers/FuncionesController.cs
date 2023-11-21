using CineCordobaApi.Services.Implementacion;
using CineCordobaApi.Services.Interfaz;
using CineCordobaBack.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CineCordobaApi.Controllers
{
    [Route("api/funciones")]
    [ApiController]
    public class FuncionesController : ControllerBase
    {
        private readonly IFuncionesServices _funcionesServices;

        public FuncionesController(IFuncionesServices funcionesServices)
        {
            _funcionesServices = funcionesServices;
        }

        [HttpGet("ObtenerIds")]
        public IActionResult ObtenerIdsFunciones()
        {
            try
            {
                var idsFunciones = _funcionesServices.ObtenerIdsFunciones();

                return Ok(idsFunciones);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }


        [HttpGet("ObtenerDetalles/{idFuncion}")]
        public IActionResult ObtenerDetalles(int idFuncion)
        {
            try
            {
                var detallesFuncion = _funcionesServices.ObtenerDetallesFuncion(idFuncion);

                if (detallesFuncion == null)
                {
                    return NotFound();
                }

                return Ok(detallesFuncion);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        [HttpPut("Actualizar/{idFuncion}")]
        public IActionResult ActualizarFuncion(int idFuncion, [FromBody] Funciones funcion)
        {
            try
            {
                var funcionExistente = _funcionesServices.ObtenerFuncionPorId(idFuncion);

                if (funcionExistente == null)
                {
                    return NotFound();
                }

                funcionExistente.Fecha = funcion.Fecha;
                funcionExistente.id_pelicula = funcion.id_pelicula;
                funcionExistente.id_horario = funcion.id_horario;
                funcionExistente.id_sala = funcion.id_sala;
                funcionExistente.Subtitulo = funcion.Subtitulo;

                _funcionesServices.Update(funcionExistente);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
        [HttpDelete("{idFuncion}")]
        public IActionResult EliminarFuncion(int idFuncion)
        {
            try
            {
                bool eliminado = _funcionesServices.EliminarFuncion(idFuncion).Result;

                if (eliminado)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la función: {ex.Message}");
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
    }
}
