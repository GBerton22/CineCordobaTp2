using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Generos
    {
        [Key]
        public int id_genero { get; set; }
        public string? Genero { get; set; }
        public Generos()
        {
            id_genero = 0;
            Genero = string.Empty;
        }
        public override string ToString()
        {
            return Genero.ToString();
        }
    }

}
