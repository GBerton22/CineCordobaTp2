using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Vendedores
    {
        [Key]
        public int id_vendedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Vendedores()
        {
        }
    }
}
