using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Idioma
    {
        [Key]
        public int id_idioma { get; set; }
        public string Idiomas { get; set; }
    }
}
