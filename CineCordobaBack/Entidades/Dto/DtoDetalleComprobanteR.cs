using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineCordobaBack.Entidades.Dto;
using Microsoft.Identity.Client;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoDetalleComprobanteR
    {
        public int DetalleComprobanteId { get; set; }
        public DtoFuncion FuncionId { get; set; }
        //public Comprobantes ComprobantesId { get; set; }
        public double Precio { get; set; }
        public DtoPromociones PromocionesId { get; set; }
        public DtoDetalleComprobanteR()
        {
            FuncionId = new DtoFuncion();
            PromocionesId = new DtoPromociones();


        }

        public DtoDetalleComprobanteR(int id, DtoFuncion f, DtoPromociones p, double precio)
        {
            DetalleComprobanteId = id;
            FuncionId = f;
            PromocionesId = p;
            Precio = precio;

        }


        public double CalcularSubTotal()
        {

            return FuncionId.SalaId.TipoSala.Precio;
        }
        public DtoDetalleComprobanteR(DtoFuncion f, DtoPromociones p)
        {
            FuncionId = f;
            PromocionesId = p;



        }
    }
}
