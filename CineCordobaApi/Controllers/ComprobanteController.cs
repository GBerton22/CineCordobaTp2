using CineCordobaBack.Entidades;
using CineCordobaBack.Fachada.Implementaciones;
using CineCordobaBack.Fachada.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CineCordobaBack.Entidades.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineCordobaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteController : ControllerBase
    {
        private IAplicacion app;

        public ComprobanteController()   //constructor del controller
        {
                app = new Aplicacion();
        }

        
        //END POINT DE FORMAS DE PAGO
        [HttpGet("/formasDePagos")]
        public IActionResult GetformasPago()
        {
            List<DtoFormasPago> lista = null;
            try
            {
                lista = app.TraerFormaPago();
                return Ok(lista);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }


        //END POINT DE FUNCIONES
        [HttpGet("/funcioness")]
        public IActionResult GetFunciones(int idPeli)
        {
            List<DtoFuncion> lista = null;
            try
            {
                lista = app.TraerFunciones(idPeli) ;
                return Ok(lista);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }


        //END POINT DE PELICULAS
        [HttpGet("/peliculass")]
        public IActionResult GetPeliculas()
        {
            List<DtoPelis> lista = null;
            try
            {
                lista = app.TraerPeliculas();
                return Ok(lista);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }


        //END POINT DE PROMOS
        [HttpGet("/promoss")]
        public IActionResult GetPromos()
        {
            List<DtoPromociones> lista = null;
            try
            {
                lista = app.TraerPromociones();
                return Ok(lista);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }


        //END POINT DE SUCURSALES
        [HttpGet("/sucursaless")]
        public IActionResult GetSucursales()
        {
            List<DtoSucursales> lista = null;
            try
            {
                lista = app.TraerSucursales();
                return Ok(lista);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }


        //END POINT DE CLIENTES
        [HttpGet("/clientess")]
        public IActionResult GetClientes()
        {
            List<DtoClientes> lista = null;
            try
            {
                lista = app.TraerClientes();
                return Ok(lista);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }


        //END POINT DE VENDEDORES
        [HttpGet("/vendedoress")]
        public IActionResult GetVendedores()
        {
            List<DtoVendedores> lista = null;
            try
            {
                lista = app.TraerVendedores();
                return Ok(lista);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }


        //END POINT DE salas
        [HttpGet("/salass")]
        public IActionResult GetSalas(int idTipoSalas)
        {
            List<DtoSalas> lista = null;
            try
            {
                lista = app.TraerSalas(idTipoSalas);
                return Ok(lista);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }


        //END POINT DE TIPOS DE SALAS
        [HttpGet("/tipoSalass")]
        public IActionResult GetTipoSalas(int idFuncion)
        {
            List<DtoTipoSalas> lista = null;
            try
            {
                lista = app.TraerTipoSalas(idFuncion);
                return Ok(lista);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }


        //END POINT DE PROX COMPROBANTE
        [HttpGet("/proxComprobantess")]
        public IActionResult GetProximoComprobante()
        {
            int prox = 0;
            try
            {
                prox = app.TraerProximoComprobante();
                return Ok(prox);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }
        //END POINT DE PROX  DETALLE COMPROBANTE
        [HttpGet("/proxDetalleComprobantess")]
        public IActionResult GetProximoDetalle()
        {
            int proxdet = 0;
            try
            {
                proxdet = app.TraerProximoDetalle();
                return Ok(proxdet);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }

        //END POINT DE detales 
        [HttpGet("/ConsultasDetalless")]
        public IActionResult GetDetalles(int numComprobante)
        {
            List<DtoDetalleComprobanteR> lista = null;
            try
            {
                lista = app.TraerDetalles(numComprobante);
                return Ok(lista);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }



        //END POINT DE EXISTENCIA DE DOCUMENTO DE UN CLIENTE
        [HttpGet("/existenciaDocumentos")]
        public IActionResult GetSiExisteDoc(int numDoc)
        {
            bool existe;
            try
            {
                existe = app.ExisteDocumentoCliente(numDoc);
                return Ok(existe);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }

        //END POINT CLIENTE FILTRADO POR NUM DE DOCUMENTO
        [HttpGet("/clienteFiltrdoPorDocs")]
        public IActionResult GetClientePorDocumento(int numDoc)
        {
            List<DtoClientes> lclientes = null;
            try
            {
                lclientes = app.ClientePorDoc(numDoc);
                return Ok(lclientes);

            }
            catch (Exception)
            {

                return StatusCode(500, "ERROR INTERNO!");

            }
        }


        //END POINT INSERT DE COMPROBANTE (TRANSACCION)
        [HttpPost("/insertComprobantes")]
        public IActionResult PostInsertComprobante(DtoComprobantesR oComprobante)
        {
            try
            {
                if(oComprobante == null)
                {
                    return BadRequest("Error! No se pudo insertar comprobante.");
                }
                return Ok(app.CrearComprobante(oComprobante));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente luego");
            }
        }
        [HttpGet("/comprobantesFiltradoss")]

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
