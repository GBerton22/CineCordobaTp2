using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using CineCordobaBack.Entidades.Dto;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Interfaz
{
    public interface IComprobanteDao
    {
        public List<DtoFormasPago> ObtenerFormaPago();
        List<DtoClientes> ObtenerClientes();
        List<DtoFuncion> ObtenerFunciones(int idPeli);
        List<DtoPelis> ObtenerPeliculas();
        List<DtoPromociones> ObtenerPromociones();
        int ObtenerProxComprobante();
        List<DtoSalas> ObtenerSalas(int idTipoSala);
        List<DtoSucursales> ObtenerSucursales();
        List<DtoTipoSalas> ObtenerTipoSala(int idFuncion);
        List<DtoVendedores> ObtenerVendedores();
        bool CrearComprobante(DtoComprobantesR oComprobante);

        bool ExisteNumDocumentoCliente(int numDoc);

        List<DtoClientes> ClientePorDocumento(int numDoc);
        int ObtenerProxDetalle();

        List<DtoDetalleComprobanteR> ObtenerDetallesComprobante(int numComprobante);
    }
}
