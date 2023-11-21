using CineCordobaBack.Entidades;

namespace CineCordobaApi.Services.Interfaz
{
    public interface IFuncionesServices
    {
        List<Funciones> ObtenerFuncionesPorPelicula(DateTime fechaDesde, DateTime fechaHasta, int idPelicula);
        Task<Funciones> ObtenerDetallesFuncion(int idFuncion);
        List<int> ObtenerIdsFunciones();

        Funciones ObtenerFuncionPorId(int idFuncion);
        void Update(Funciones funcion);
        Task<bool> EliminarFuncion(int idFuncion);
    }

}
