using CineCordobaBack.Datos.Implementacion;
using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using CineCordobaBack.Fachada.Interfaces;
using CineCordobaBack.Fachada.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Fachada.Implementaciones
{
    public class Aplicacion : IAplicacion
    {
        private IFuncionDao funcionDao;
        private IClienteDao clienteDao;
        private IInicioDao inicioDao;
        private IReporteDao ReporteDao;
        private IComprobanteDao dao;
        public Aplicacion()
        {
            funcionDao = new FuncionDao();
            clienteDao = new ClienteDao();
            inicioDao = new InicioDao();
            ReporteDao= new ReporteDao();
            dao = new ComprobanteDao();
        }

        public bool CrearFuncion(DtoFunciones oFuncion) //no ta
        {
            return funcionDao.CrearFuncion(oFuncion);
        }
        public bool CrearCliente(DtoCliente oClientes)//ta
        {
            return clienteDao.CrearCliente(oClientes);
        }

        public int ProximaFuncion()  //ta
        {
           return funcionDao.ObtenerProximaFuncion();
        }


        public List<DtoHorario> traerHorarios()//ta
        {
           return funcionDao.obtenerHorarios();
        }

        public List<DtoPeliculas> traerPeliculas()//ta
        {
           return funcionDao.obtenerPeliculas();
        }

        public List<DtoTipoSalas> traerSalas(int idSucursal)//ta
        {
            return funcionDao.obtenerSalas(idSucursal);
        }

        public List<Sucursales> traerSucursales() //ta
        {
           return funcionDao.obtenerSucursales();
        }
        
        public List<Ciudades> TraerCiudades()//ta
        {
            return clienteDao.obtenerCiudades();
        }

        public List<DtoTipoDoc> TraerDocumentos()//ta
        {
            return clienteDao.obtenerDocumentos();
        }

        public List<DtoBarrio>TraerBarrios(int idProvincia)//ta
        {
            return clienteDao.obtenerBarrio(idProvincia);
        }


        public int ObtenerProximoCliente()//ta
        {
            return clienteDao.ObtenerProximoCliente();
        }

        public int ObtenerUsuario(Usuarios oUsuario)//ta
        {
            return inicioDao.ObtenerUsuario(oUsuario);
        }

        public List<DtoComprobantesR>? TraerComprobantes(DateTime fechaDesde, string ts1, string ts2, string ts3, string ts4, string ts5, string ts6, string g1, string g2, string g3, string g4, string g5, string g6)
        {
            return ReporteDao.ObtenerConsultaUnoFiltrada(fechaDesde, ts1, ts2, ts3, ts4, ts5, ts6, g1, g2, g3, g4, g5, g6);
        }

        //
        public bool CrearComprobante(DtoComprobantesR oComprobante)    //FALTA FALTA FALTA 
        {
            return dao.CrearComprobante(oComprobante);
        }

        public List<DtoFormasPago> TraerFormaPago()      //listo
        {
            return dao.ObtenerFormaPago();
        }

        public List<DtoClientes> TraerClientes()        //listo
        {
            return dao.ObtenerClientes();
        }


        public List<Entidades.DtoFuncion> TraerFunciones(int idPeli)      //listo
        {
            return dao.ObtenerFunciones(idPeli);
        }

        public List<DtoPelis> TraerPeliculas()     //listo
        {
            return dao.ObtenerPeliculas();
        }

        public List<DtoPromociones> TraerPromociones()    //listo
        {
            return dao.ObtenerPromociones();
        }

        public int TraerProximoComprobante()          //listo

        {
            return dao.ObtenerProxComprobante();
        }

        public List<DtoSalas> TraerSalas(int idTipoSala)               //listo
        {
            return dao.ObtenerSalas(idTipoSala);
        }

        public List<DtoSucursales> TraerSucursales()     //listo
        {
            return dao.ObtenerSucursales();
        }

        public List<DtoTipoSalas> TraerTipoSalas(int idFuncion)     //listo
        {
            return dao.ObtenerTipoSala(idFuncion);
        }

        public List<DtoVendedores> TraerVendedores()    //listo
        {
            return dao.ObtenerVendedores();
        }

        public bool ExisteDocumentoCliente(int numDoc)
        {
            return dao.ExisteNumDocumentoCliente(numDoc);
        }

        public List<DtoClientes> ClientePorDoc(int numDoc)
        {
            return dao.ClientePorDocumento(numDoc);
        }

        public int TraerProximoDetalle()
        {
            return dao.ObtenerProxDetalle();
        }

        public List<DtoDetalleComprobanteR> TraerDetalles(int numComprobante)
        {
            return dao.ObtenerDetallesComprobante(numComprobante);
        }
    }
}
