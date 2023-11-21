using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CineCordobaBack.Entidades.Dto;
using System.Threading.Tasks;

namespace CineCordobaFront.Servicios.Interfaz
{
    public interface IServicio
    {
        int TraerProximoComprobante();
        List<DtoClientes> TraerClientes();
        List<DtoVendedores> TraerVendedores();
        List<DtoFormasPago> TraerFormasPago();
        List<DtoSucursales> TraerSucursales();
        List<DtoPelis> TraerPeliculas();
        List<DtoFuncion> TraerFunciones();
        List<DtoSalas> TraerSalas();
        List<DtoTipoSalas> TraerTipoSalas();
        List<DtoPromociones> TraerPromociones();

        bool CrearComprobante(DtoComprobantesR oComprobantes);
    }
}
