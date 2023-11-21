using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using CineCordobaBack.Fachada.Implementaciones;
using CineCordobaBack.Fachada.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineCordobaApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CineController : ControllerBase
    {
        private IAplicacion app;
        public CineController()
        {
            app = new Aplicacion();
        }


        //Post Usuarios
        [HttpPost("/usuario")]
        public IActionResult GetUsuario(Usuarios oUsuario)
        {
            int usuario;
            try
            {
                usuario = app.ObtenerUsuario(oUsuario);
                return Ok(usuario);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }






        // GET: api/<FuncionesControllers>
        [HttpGet("/peliculas")]
        public IActionResult GetPeliculas()
        {
            List<DtoPeliculas> lpelicula = null;
            try
            {
                lpelicula = app.traerPeliculas();
                return Ok(lpelicula);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno");
                
            }
        }



        [HttpGet("/horarios")]
        public IActionResult getHorario()
        {
            List<CineCordobaBack.Entidades.Dto.DtoHorario> lhorario = null;
            try
            {
                lhorario = app.traerHorarios();
                return Ok(lhorario);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno");

            }
        }
        [HttpGet("/proxFuncion")]
        public IActionResult getProxFuncion()
        {
            int prox = 0;
            try
            {
                prox = app.ProximaFuncion();
                return Ok(prox);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno");

            }
        }
        [HttpGet("/traerSalas")]
        public IActionResult getTraerSalas(int id)
        {
            List<DtoTipoSalas> ltiposalas = null;
            
            try
            {
                ltiposalas = app.traerSalas(id);
                return Ok(ltiposalas);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno");

            }
        }
        [HttpGet("/traerSucursales")]
        public IActionResult getTraerSucursales()
        {
            List<Sucursales> lsucursales = null;

            try
            {
                lsucursales = app.traerSucursales();
                return Ok(lsucursales);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno");

            }
        }

        

        

        // POST api/<FuncionesControllers>
        [HttpPost("/AltaFuncion")]
        public IActionResult PostFuncion(CineCordobaBack.Entidades.Dto.DtoFunciones oFuncion)
        {
            try
            {
                if (oFuncion == null)
                {
                    return BadRequest("Error creando la funcion");
                }
                return Ok(app.CrearFuncion(oFuncion));

            }
            catch (Exception)
            {

                return StatusCode(500, "error interno! Intente luego");
            }
        }
        //gets y put de clientes

        [HttpGet("/traerCiudades")]
        public IActionResult getTraerCiudades()
        {
            List<Ciudades> lciudades = null;

            try
            {
                lciudades = app.TraerCiudades();
                return Ok(lciudades);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno");

            }
        }

        [HttpGet("/traerBarrios")]
        public IActionResult getTraerBarrio(int id)
        {
            List<DtoBarrio> lbarrios = null;

            try
            {
                lbarrios = app.TraerBarrios(id);
                return Ok(lbarrios);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno");

            }
        }
        [HttpGet("/traerTipoDocumentos")]

        public IActionResult getTraerTiposDoc()
        {
            List<DtoTipoDoc> ldoc = null;

            try
            {
                ldoc = app.TraerDocumentos();
                return Ok(ldoc);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno");

            }
        }
        [HttpGet("/proxCliente")]
        public IActionResult getProxCliente()
        {
            int prox = 0;
            try
            {
                prox = app.ObtenerProximoCliente();
                return Ok(prox);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno");

            }
        }


        // POST api/<FuncionesControllers>
        [HttpPost("/AltaCliente")]
        public IActionResult PostCliente(DtoCliente oClientes)
        {
            try
            {
                if (oClientes == null )
                {
                    return BadRequest("Error creando el cliente!");
                }
                return Ok(app.CrearCliente(oClientes));

            }
            catch (Exception)
            {

                return StatusCode(500, "error interno! Intente luego");
            }
        }

        [HttpGet("/comprobantesFiltrados")]

        public IActionResult GetComprobantesFIltrados(DateTime fechaDesde, string ts1, string ts2, string ts3, string ts4,
                                  string ts5, string ts6, string g1, string g2, string g3, string g4, string g5, string g6)
        {
            List<DtoComprobantesR> lComprobante = null;
            try
            {
                lComprobante = app.TraerComprobantes(fechaDesde, ts1, ts2, ts3, ts4, ts5, ts6, g1, g2, g3, g4, g5, g6);
                return Ok(lComprobante);
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno");
            }
        }
    }
}
