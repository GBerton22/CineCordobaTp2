using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Peliculas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_pelicula { get; set; }
        public string nombre_pelicula { get; set; }
        public int id_genero { get; set; }
        public int id_clasificacion { get; set; }
        public int id_idioma { get; set; }
        public string duracion { get; set; }

        [ForeignKey("id_genero")]
        public Generos Genero { get; set; }
        [ForeignKey("id_clasificacion")]
        public Clasificacion Clasificacion { get; set; }
        [ForeignKey("id_idioma")]
        public Idioma Idioma { get; set; }

        public Peliculas()
        {
            id_pelicula = 0;
            nombre_pelicula = string.Empty;

            Genero = new Generos();

        }
    }

}
