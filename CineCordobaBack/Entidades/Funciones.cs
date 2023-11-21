using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Funciones
    {
        [Key]
        public int id_funcion { get; set; }
        public int id_horario { get; set; }
        public DateTime Fecha { get; set; }
        public bool Subtitulo { get; set; }
        public int id_pelicula { get; set; }
        public int id_sala { get; set; }

        [ForeignKey("id_horario")]
        public Horarios Horario { get; set; }

        [ForeignKey("id_pelicula")]
        public Peliculas Pelicula { get; set; }

        [ForeignKey("id_sala")]
        public Salas Sala { get; set; }

        public string NroFuncion => id_funcion.ToString();
        public string NombrePelicula => Pelicula?.nombre_pelicula;
        public string HorarioString => $"{Horario?.Inicio} - {Horario?.Final}";
        public string SalaId => id_sala.ToString();
        public string SubtituloString => Subtitulo ? "Sí" : "No";

        public Funciones()
        {
            id_funcion = 0;
            Horario = new Horarios();
            Fecha = DateTime.Now;
            Subtitulo = false;
            Pelicula = new Peliculas();
            Sala = new Salas();
        }

    }
}
