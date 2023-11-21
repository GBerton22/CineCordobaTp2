using CineCordobaApi.Services.Interfaz;
using CineCordobaBack.Entidades;
using CineCordobaBack.Fachada.Concretas;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CineCordobaBack.Fachada.Interfaces;

namespace CineCordobaApi.Services.Implementacion
{
    public class FuncionesServices : IFuncionesServices
    {

        private readonly IFuncionesDao _daoFunciones;

        public FuncionesServices(IFuncionesDao funcionesRepository)
        {
            _daoFunciones = funcionesRepository;
        }
        public List<Funciones> ObtenerFuncionesPorPelicula(DateTime fechaDesde, DateTime fechaHasta, int idPelicula)
        {
            return _daoFunciones.ObtenerFuncionesPorPelicula(fechaDesde, fechaHasta, idPelicula);
        }

        public async Task<Funciones> ObtenerDetallesFuncion(int idFuncion)
        {
            try
            {
                var detallesFuncion = _daoFunciones.ObtenerDetallesFuncion(idFuncion);

                if (detallesFuncion == null)
                {
                    return null;
                }

                return detallesFuncion;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener detalles de la función: {ex.Message}");
                return null;
            }
        }
        public List<int> ObtenerIdsFunciones()
        {
            try
            {
                var idsFunciones = _daoFunciones.ObtenerIdsFunciones(); 

                return idsFunciones;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener IDs de funciones: {ex.Message}", ex);
            }
        }
        public Funciones ObtenerFuncionPorId(int idFuncion)
        {
            return _daoFunciones.GetById(idFuncion);
        }
        public void Update(Funciones funcion)
        {
            _daoFunciones.Update(funcion);
        }
        public async Task<bool> EliminarFuncion(int idFuncion)
        {
            try
            {
                return await Task.Run(() => _daoFunciones.EliminarFuncion(idFuncion));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la función: {ex.Message}");
                return false;
            }
        }
    }
}
