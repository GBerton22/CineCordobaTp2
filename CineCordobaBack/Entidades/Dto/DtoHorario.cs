using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoHorario
    {
        public int Id_horario { get; set; }
        public TimeSpan Inicio { get; set; }
        public TimeSpan Final { get; set; }





        public DtoHorario(int id_horario, TimeSpan inicio, TimeSpan final)
        {
            Id_horario = id_horario;
            Inicio = inicio;
            Final = final;
        }

        public DtoHorario()
        {
            Id_horario = 0;
        }

        public string HorarioCompleto
        {
            get { return $"{Inicio} - {Final}"; }
        }
        //public static TimeSpan ConvertirStringATimeSpan(string cadena)
        //{
        //    TimeSpan resultado;
        //    if (TimeSpan.TryParseExact(cadena, "hh\\:mm", CultureInfo.InvariantCulture, out resultado))
        //    {
        //        return resultado;
        //    }
        //    else
        //    {
        //        // Manejar el caso en que la cadena no tenga el formato correcto
        //        throw new FormatException("La cadena no tiene el formato correcto para TimeSpan.");
        //    }
        //}

        public override string ToString()
        {
            return HorarioCompleto;
        }
    }
}
