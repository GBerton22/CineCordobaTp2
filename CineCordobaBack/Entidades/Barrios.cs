using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Barrios
    {
        [Key]
        public int id_barrio { get; set; }
        public string barrio { get; set; }

        [ForeignKey("id_ciudad")]
        public Ciudades Ciudad { get; set; }

        public Barrios(int barrioId, string nombreBarrio)
        {
            id_barrio = barrioId;
            barrio = nombreBarrio;

        }
        public Barrios()
        {
        }
    }
}
