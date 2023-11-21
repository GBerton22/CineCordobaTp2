using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Horarios
    {
        [Key]
        public int id_horario { get; set; }
        public TimeSpan Inicio { get; set; }
        public TimeSpan Final { get; set; }
        public ICollection<Funciones> Funciones { get; set; }

        public Horarios(int id_horario, TimeSpan inicio, TimeSpan final)
        {
            this.id_horario = id_horario;
            Inicio = inicio;
            Final = final;
        }

        public Horarios()
        {
            id_horario = 0;
        }

        public string HorarioCompleto
        {
            get { return $"{Inicio} - {Final}"; }
        }


        public override string ToString()
        {
            return HorarioCompleto;
        }
    }
}
