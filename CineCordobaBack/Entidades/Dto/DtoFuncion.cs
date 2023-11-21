using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineCordobaBack.Entidades.Dto;
using CineCordobaBack.Entidades;

namespace CineCordobaBack.Entidades
{
    public class DtoFuncion
    {
        public int FuncionId { get; set; }
        public DtoHorarios HorarioID { get; set; }

        //public Horarios HorarioFinal { get; set; }
        public DateTime Fecha { get; set; }
        public int Subtitulo { get; set; }
        public DtoPelis PeliculaID { get; set; }
        public DtoSalas SalaId { get; set; }

        public string FuncionCompleta
        {
            get { return $"{Fecha.ToString("d")} - {HorarioID.HorarioCompleto} - Sala N°: {SalaId.SalaId.ToString()}"; }
        }
        public DtoFuncion()
        {
            HorarioID = new DtoHorarios();
            PeliculaID = new DtoPelis();
            SalaId = new DtoSalas();
        }

    


    }
}
