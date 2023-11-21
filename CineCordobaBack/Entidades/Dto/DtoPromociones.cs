using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class DtoPromociones
    {
        public int PromoId { get; set; }
        public string NombrePromo { get; set; }
        public double Descuento { get; set; }
     

        public DtoPromociones(string nombrePromo, int promoId, double desc)
        {
            this.NombrePromo = nombrePromo;
            this.PromoId = promoId;
            this.Descuento = desc;
            

        }

        public DtoPromociones()
        {     
        }

        
    }
}
