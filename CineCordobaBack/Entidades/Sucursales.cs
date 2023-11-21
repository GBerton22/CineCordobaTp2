using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Sucursales
    {
        [Key]
        public int id_sucursal { get; set; }
        public string NombreSucursal { get; set; }
        public int id_barrio { get; set; }

        [ForeignKey("id_barrio")]
        public Barrios Barrios { get; set; }
        public Sucursales()
        {
        }
        public Sucursales(int id_sucursal, string nombresucursal)
        {
            this.id_sucursal = id_sucursal;
            NombreSucursal = nombresucursal;
        }
    }
}
