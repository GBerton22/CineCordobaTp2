using CineCordobaApi.Services.Interfaz;
using CineCordobaBack.Entidades;
using CineCordobaBack.Fachada.Concretas;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CineCordobaBack.Fachada.Interfaces;

namespace CineCordobaApi.Services.Implementacion
{
    public class SalasServices : ISalasServices
    {
        private readonly IDaoSala _daoSalas;

        public SalasServices(IDaoSala salasRepository)
        {
            _daoSalas = salasRepository;
        }

        public List<Salas> ObtenerSalas()
        {
            return _daoSalas.ObtenerSalas();
        }
    }
}
