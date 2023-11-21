using CineCordobaBack.Datos.Implementacion;
using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Entidades;
using CineCordobaFront.Servicios.Interfaz;
using CineCordobaBack.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaFront.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IComprobanteDao dao;

        public Servicio()                 //constructor con definicion de dao
        {
            dao= new ComprobanteDao();
               
        }



        public bool CrearComprobante(DtoComprobantesR oComprobantes)
        {
            throw new NotImplementedException();
        }

        public List<DtoClientes> TraerClientes()
        {
            throw new NotImplementedException();
        }

        public List<DtoFormasPago> TraerFormasPago()
        {
            return dao.ObtenerFormaPago();
        }

        public List<DtoFuncion> TraerFunciones()
        {
            throw new NotImplementedException();
        }

        public List<DtoPelis> TraerPeliculas()
        {
            throw new NotImplementedException();
        }

        public List<DtoPromociones> TraerPromociones()
        {
            throw new NotImplementedException();
        }

        public int TraerProximoComprobante()
        {
            throw new NotImplementedException();
        }

        public List<DtoSalas> TraerSalas()
        {
            throw new NotImplementedException();
        }

        public List<DtoSucursales> TraerSucursales()
        {
            throw new NotImplementedException();
        }

        public List<DtoTipoSalas> TraerTipoSalas()
        {
            throw new NotImplementedException();
        }

        public List<DtoVendedores> TraerVendedores()
        {
            throw new NotImplementedException();
        }
    }
}
