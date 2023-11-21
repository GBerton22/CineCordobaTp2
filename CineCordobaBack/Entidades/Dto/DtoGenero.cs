using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoGenero
    {
        public int Id_genero { get; set; }
        public string Genero { get; set; }


        public DtoGenero(int id_genero, string genero)
        {
            Id_genero = id_genero;
            Genero = genero;
        }

        public DtoGenero()
        {
            Id_genero = 0;
            Genero = string.Empty;
        }

        public override string ToString()
        {
            return Genero.ToString();
        }
    }
}
