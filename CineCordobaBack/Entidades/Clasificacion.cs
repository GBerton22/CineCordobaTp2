using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Clasificacion
    {
        [Key]
        public int id_clasificacion { get; set; }
        public string Clasificaciones { get; set; }
    }
}
