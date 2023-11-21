using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Promociones
    {
        [Key]
        public int id_promo { get; set; }
        public string NombrePromo { get; set; }
        public decimal Descuento { get; set; }

        public Promociones()
        {
        }
    }
}
