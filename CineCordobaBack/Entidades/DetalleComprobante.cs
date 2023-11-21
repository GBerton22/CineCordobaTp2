using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class DetalleComprobante
    {
        [Key]
        public int id_detalle_comprobante { get; set; }
        public int id_funcion { get; set; }
        public int id_comprobante { get; set; }
        public decimal Precio { get; set; }
        public int id_promo { get; set; }

        [ForeignKey("id_funcion")]
        public Funciones Funciones { get; set; }

        [ForeignKey("id_comprobante")]
        public Comprobantes Comprobante { get; set; }

        [ForeignKey("id_promo")]
        public Promociones Promociones { get; set; }

        public DetalleComprobante()
        { 

        }
    }
}
