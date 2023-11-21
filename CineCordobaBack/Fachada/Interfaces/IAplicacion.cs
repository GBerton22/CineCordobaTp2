using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Fachada.Interfaces
{
    public interface IAplicacion
    {
        List<DtoPeliculas> traerPeliculas();
        int ProximaFuncion();

        List<DtoHorario> traerHorarios();
        List<Sucursales> traerSucursales();
        List<DtoTipoSalas> traerSalas(int idSucursal);


        List<DtoBarrio> TraerBarrios(int idProvincia);
        List<DtoTipoDoc> TraerDocumentos();
        List<Ciudades> TraerCiudades();
        bool CrearCliente(DtoCliente oClientes);
        bool CrearFuncion(Entidades.Dto.DtoFunciones oFuncion);

        int ObtenerProximoCliente();

        int ObtenerUsuario(Usuarios oUsuario);
        List<DtoComprobantesR>? TraerComprobantes(DateTime fechaDesde, string ts1, string ts2, string ts3, string ts4, string ts5, string ts6, string g1, string g2, string g3, string g4, string g5, string g6);


        //

        List<DtoFormasPago> TraerFormaPago();
        int TraerProximoComprobante();
        List<DtoClientes> TraerClientes();
        List<DtoVendedores> TraerVendedores();
        List<DtoSucursales> TraerSucursales();
        List<DtoPelis> TraerPeliculas();
        List<Entidades.DtoFuncion> TraerFunciones(int idPeli);
        List<DtoSalas> TraerSalas(int idTipoSalas);
        List<DtoTipoSalas> TraerTipoSalas(int idFuncion);
        List<DtoPromociones> TraerPromociones();

        bool CrearComprobante(DtoComprobantesR oComprobantes);

        bool ExisteDocumentoCliente(int numDoc);
        List<DtoClientes> ClientePorDoc(int numDoc);
        int TraerProximoDetalle();

        List<DtoDetalleComprobanteR> TraerDetalles(int numComprobante);
    }
}
