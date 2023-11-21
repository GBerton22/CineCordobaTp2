using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class DtoHorarios
    {
        public int HorarioId { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }

        public string HorarioCompleto 
        {
            get { return $"{Inicio.ToString("hh:mm tt")} "; }
            
        }


        public DtoHorarios(int id, DateTime inicio, DateTime final)
        {
            HorarioId = id;
            Inicio = inicio;
            Final = final;

        }

        public DtoHorarios()
        {
           
            
        }
    }
}
