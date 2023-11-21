using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Ciudades
    {
        [Key]
        public int id_ciudad { get; set; }
        public string ciudad{ get; set; }
        [ForeignKey("id_provincia")]
        public Provincias Provincias { get; set; }

        public Ciudades(int id_ciudad, string nombre)
        {

            this.id_ciudad = id_ciudad;
            ciudad = nombre;
        }

        public override string ToString()
        {
            return ciudad;
        }
    }
}
