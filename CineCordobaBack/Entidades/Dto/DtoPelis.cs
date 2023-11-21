using CineCordobaBack.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class DtoPelis
    {
        public int PeliculaId { get; set; }
        public string NombrePelicula { get; set; }
        public DtoGenero Genero { get; set; }

        public DtoPelis()
        {
            Genero = new DtoGenero();
        }

        public DtoPelis(int peliId, string nombre)
        {
            this.PeliculaId = peliId;
            this.NombrePelicula = nombre;
            Genero = new DtoGenero();

        }
    }
}
