using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Provincias
    {
        [Key]
        public int id_provincia { get; set; }
        public string provincia { get; set; }
        public Provincias(int id_provincia, string nombre_provincia)
        {
             this.id_provincia= id_provincia;
            provincia = nombre_provincia;
            
        }
        public Provincias()
        {
            
        }
    }
}
