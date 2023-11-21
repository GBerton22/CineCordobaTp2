//using CineCordobaBack.Entidades.Dto;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CineCordobaBack.Entidades
//{
//    public class DtoDetalleComprobantes
//    {
//        public int DetalleComprobanteId { get; set; }
//        public DtoFuncion FuncionId { get; set; }
//        //public Comprobantes Comprobantes { get; set; }
//        public decimal Precio { get; set; }
//        public DtoPromociones PromocionesId { get; set; }

//        public DtoDetalleComprobantes()
//        {
//            FuncionId = new DtoFuncion();
//            PromocionesId = new DtoPromociones();
           
            
//        }

//        public DtoDetalleComprobantes(int id, DtoFuncion f, DtoPromociones p , decimal precio)
//        {
//            DetalleComprobanteId = id;
//            FuncionId= f;
//            PromocionesId= p;
//            Precio = precio;
             
//        }


//        public double CalcularSubTotal()
//        {
           
//            return FuncionId.SalaId.TipoSala.Precio;
//        }
//        public DtoDetalleComprobantes(DtoFuncion f, DtoPromociones p)
//        {
//            FuncionId = f;
//            PromocionesId = p;



//        }
//    }
//}
