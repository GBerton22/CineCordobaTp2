//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CineCordobaBack.Entidades.Dto;

//namespace CineCordobaBack.Entidades
//{
//    public class DtoComprobante
//    {
//        public int Comprobanteid { get; set; }
//        public DateTime FechaComprobante { get; set; }
//        public DtoClientes Cliente { get; set; }
//        public DtoSucursales Sucursal { get; set; }
//        public DtoFormasPago FormaPagoId { get; set; }
//        public DtoVendedores Vendedor { get; set; }

//        public List<DtoDetalleComprobantes> lDetallesComprobantes { get; set; }

//        //public double total { get; set; }

//        public DtoComprobante(int id, DateTime fechaCompra, DtoClientes cliente, DtoSucursales suc, DtoFormasPago formPago, DtoVendedores idVend)
//        {
//            this.Comprobanteid = id;
//            this.FechaComprobante = fechaCompra;
//            this.Cliente = cliente;
//            this.Sucursal = suc;
//            this.FormaPagoId = formPago;
//            this.Vendedor = idVend;
//            lDetallesComprobantes = new List<DtoDetalleComprobantes>();

//        }


//        public DtoComprobante()
//        {


//            Cliente = new DtoClientes();
//            Sucursal = new DtoSucursales();
//            FormaPagoId = new DtoFormasPago();
//            Vendedor = new DtoVendedores();
//            lDetallesComprobantes = new List<DtoDetalleComprobantes>();

//        }

//        public void AgregarDetalle(DtoDetalleComprobantes oDetalle)
//        {
//            lDetallesComprobantes.Add(oDetalle);
//        }
//        public void EliminarDetalle(int nroDetalle)
//        {
//            lDetallesComprobantes.RemoveAt(nroDetalle);
//        }
//        public double CalcularTotal()
//        {
//            double total = 0;

//            foreach (DtoDetalleComprobantes oDetalle in lDetallesComprobantes)
//            {
//                total += oDetalle.CalcularSubTotal();

//            }
//            return total;
//        }



//        //public void ModificarDetalles(int cantidad, Insumo oInsumo)
//        //{
//        //    foreach (DetalleComprobante oDetalle in lDetallesComprobantes)
//        //    {
//        //        if (oDetalle.oInsumo == oInsumo)
//        //        {
//        //            oDetalle.Cantidad = oDetalle.Cantidad + cantidad;
//        //        }
//        //    }
//        // }

//    }
//}
