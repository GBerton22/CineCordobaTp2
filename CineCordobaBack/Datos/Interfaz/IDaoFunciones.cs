using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineCordobaBack.Entidades;

namespace CineCordobaBack.Datos.Interfaces
{
    public interface IDaoFunciones : IDaoRepository<Funciones>
    {
        List<Funciones> ObtenerFuncionesPorPelicula(DateTime fechaDesde, DateTime fechaHasta, int idPelicula);
        Funciones ObtenerDetallesFuncion(int idFuncion);
        List<int> ObtenerIdsFunciones();
        
        void Update(Funciones funcion);
        void ActualizarFuncion(Funciones funcion);
        bool EliminarFuncion(int idFuncion);

    }
}
