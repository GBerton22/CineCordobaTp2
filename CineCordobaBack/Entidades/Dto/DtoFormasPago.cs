using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class DtoFormasPago
    {
        public int FormasPagoId { get; set; }
        public string FormasDePago { get; set; }

        public DtoFormasPago(int id, string formaPago)
        { 
            this.FormasPagoId = id;
            this.FormasDePago = formaPago;
        }

        public DtoFormasPago()
        {
            FormasPagoId = 0;
            
                
        }

        public override string ToString()
        {
            return "Id: " + FormasPagoId + "Forma de pago: "+ FormasDePago;
        }
    }

}
