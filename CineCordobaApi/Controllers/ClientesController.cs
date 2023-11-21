using CineCordobaBack.Entidades;
using CineCordobaBack.Servicios.Implementacion;
using CineCordobaBack.Servicios.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CineCordobaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IServicio oServicio;
        private readonly ILogger<ClientesController> _logger;
        public ClientesController(ILogger<ClientesController> logger)
        {
            oServicio = new CineCordobaBack.Servicios.Implementacion.Servicio();
            _logger = logger;
        }

        [HttpGet("/clientes")]
        public IActionResult GetClientes()
        {
            List<Clientes> lstClientes;
            try
            {
                lstClientes = oServicio.ConsultarClientes();
                return Ok(lstClientes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener clientes");
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpDelete("/eliminarCliente")]
        public IActionResult DelCliente(int id_cliente)
        {
            bool eliminar;
            try
            {
                eliminar = oServicio.EliminarCliente(id_cliente);
                return Ok(eliminar);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }


        [HttpGet("/barrios")]
        public IActionResult getBarrios()
        {
            List<Barrios> lstbarrios;
            try
            {
                lstbarrios = oServicio.ConsultarBarrios();
                return Ok(lstbarrios);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpGet("/tipo_documentos")]
        public IActionResult getTipo_Documento()
        {
            List<TipoDoc> lstTipoDoc;
            try
            {
                lstTipoDoc = oServicio.ConsultarTipo_Documento();
                return Ok(lstTipoDoc);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }


        [HttpGet("/clienteSegunId")]
        public IActionResult GetFacturaSegunId(int idCliente)
        {
            Clientes oCliente;
            try
            {
                oCliente = oServicio.ConsultarClientesId(idCliente);
                return Ok(oCliente);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }
        [HttpPut("/modificarCliente")]
        public IActionResult Put([FromBody] Clientes clientes)
        {
            if (clientes != null)
            {
                bool result = oServicio.ModificarClientes(clientes);
                return Ok(result);
            }
            else
            {
                return BadRequest("Debe ingresar un cliente valido");
            }
        }


    }
}
