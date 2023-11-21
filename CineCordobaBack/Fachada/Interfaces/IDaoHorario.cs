using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Fachada.Interfaces
{
    public interface IDaoHorario : IDaoRepository<Horarios>
    {
        List<Horarios> ObtenerHorarios();
    }
}
