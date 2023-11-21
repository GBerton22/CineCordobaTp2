using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Interfaz
{
    public interface IReporteDao
    {
        List<DtoComprobantesR> ObtenerConsultaUnoFiltrada(DateTime fechaDesde, string ts1, string ts2, string ts3, string ts4,
                                   string ts5, string ts6, string g1, string g2, string g3, string g4, string g5, string g6);
    }
}
