using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class FormasPago
    {
        [Key]
        public int id_formas_pago { get; set; }
        public string FormasDePago { get; set; }

        public FormasPago()
        { 
        }
    }
}
