using CineCordobaApi.Services.Interfaz;
using CineCordobaBack.Entidades;
using CineCordobaBack.Fachada.Concretas;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CineCordobaBack.Fachada.Interfaces;

namespace CineCordobaApi.Services.Implementacion
{
    public class HorariosServices : IHorariosServices
    {
        private readonly IDaoHorario _daoHorarios;
        public HorariosServices(IDaoHorario horariosRepository)
        {
            _daoHorarios = horariosRepository;
        }
        public List<Horarios> ObtenerHorarios()
        {
            return _daoHorarios.ObtenerHorarios();
        }
    }
}
