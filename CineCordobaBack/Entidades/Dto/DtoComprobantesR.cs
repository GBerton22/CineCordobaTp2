using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoComprobantesR
    {
        public int ComprobanteId { get; set; }
        public DateTime FechaComprobante { get; set; }
        public DtoClientes Cliente { get; set; }
        public DtoSucursales Sucursal { get; set; }
        public DtoFormasPago FormaPagoId { get; set; }
        public DtoVendedores Vendedor { get; set; }
        public DtoDetalleComprobanteR Detalle { get; set; }

        public List<DtoDetalleComprobanteR> lDetallesComprobantes { get; set; }

        
        public DtoComprobantesR(int id, DateTime fechaCompra, DtoClientes cliente, DtoSucursales suc, DtoFormasPago formPago, DtoVendedores idVend)
        {
            this.ComprobanteId = id;
            this.FechaComprobante = fechaCompra;
            this.Cliente = cliente;
            this.Sucursal = suc;
            this.FormaPagoId = formPago;
            this.Vendedor = idVend;

            lDetallesComprobantes = new List<DtoDetalleComprobanteR>();

        }


        public DtoComprobantesR()
        {


            Cliente = new DtoClientes();
            Sucursal = new DtoSucursales();
            FormaPagoId = new DtoFormasPago();
            Vendedor = new DtoVendedores();
            Detalle = new DtoDetalleComprobanteR();
            lDetallesComprobantes = new List<DtoDetalleComprobanteR>();

        }

        public void AgregarDetalle(DtoDetalleComprobanteR oDetalle)
        {
            lDetallesComprobantes.Add(oDetalle);
        }
        public void EliminarDetalle(int nroDetalle)
        {
            lDetallesComprobantes.RemoveAt(nroDetalle);
        }
        public double CalcularTotal()
        {
            double total = 0;

            foreach (DtoDetalleComprobanteR oDetalle in lDetallesComprobantes)
            {
                total += oDetalle.CalcularSubTotal();

            }
            return total;
        }
    }
}
