using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoPeliculas
    {

        public int Id_pelicula { get; set; }
        public string Nombre_pelicula { get; set; }
        public DtoGenero Genero { get; set; }


        public DtoPeliculas()
        {
            Id_pelicula = 0;
            Nombre_pelicula = string.Empty;

            Genero = new DtoGenero();

        }

        public DtoPeliculas(int peliculaid, string nombrepelicula, DtoGenero genero)
        {
            Id_pelicula = peliculaid;
            Nombre_pelicula = nombrepelicula;
            Genero = genero;

        }

        public DtoPeliculas(int peliculaid, string nombrepelicula)
        {
            Id_pelicula = peliculaid;
            Nombre_pelicula = nombrepelicula;
        }


        public override string ToString()
        {
            return Nombre_pelicula;
        }
    }
}
