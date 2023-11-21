using CineCordobaBack.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace CineCordobaApi.Services.Interfaz
{
    public interface IHorariosServices
    {
        List<Horarios> ObtenerHorarios();
    }
}
