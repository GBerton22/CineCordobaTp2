using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Comprobantes
    {
        [Key]
        public int id_comprobante { get; set; }
        public DateTime FechaComprobante { get; set; }
        public int id_cliente { get; set; }
        public int id_sucursal { get; set; }
        public int id_formas_pago { get; set; }
        public int id_vendedor { get; set; }

        //
        public DetalleComprobante Detalle { get; set; }
        //

        [ForeignKey("id_cliente")]
        public Clientes Cliente { get; set; }

        [ForeignKey("id_sucursal")]
        public Sucursales Sucursales { get; set; }

        [ForeignKey("id_formas_pago")]
        public FormasPago FormasPago { get; set; }

        [ForeignKey("id_vendedor")]
        public Vendedores Vendedor { get; set; }

        public Comprobantes()
        { 
        }
    }
}
