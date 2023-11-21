using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoFunciones
    {
        public int FuncionId { get; set; }
        public DtoHorario HorarioID { get; set; }
        public DateTime Fecha { get; set; }
        public bool Subtitulo { get; set; }
        public DtoPeliculas PeliculaId { get; set; }
        public DtoSalas SalasId { get; set; }

        public DtoFunciones(int funcionesId, DtoHorario horarioid, DateTime fecha, bool subtitulo, DtoPeliculas peliculaid, DtoSalas salaid)
        {
            FuncionId = funcionesId;
            HorarioID = horarioid;
            Fecha = fecha;
            Subtitulo = subtitulo;
            PeliculaId = peliculaid;
            SalasId = salaid;

        }
        public DtoFunciones()
        {
            FuncionId = 0;
            HorarioID = new DtoHorario();
            Fecha = DateTime.Now;
            Subtitulo = false;
            PeliculaId = new DtoPeliculas();
            SalasId = new DtoSalas();
        }
        public string FuncionCompleta
        {
            get { return $"{Fecha.ToString("d")} - {HorarioID.HorarioCompleto} - Sala N°: {SalasId.SalaId.ToString()}"; }
        }
    }
}
