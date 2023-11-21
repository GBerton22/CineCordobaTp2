using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Interfaz
{
    public interface IFuncionDao
    {
        List<Sucursales> obtenerSucursales();
        List<Entidades.Dto.DtoHorario> obtenerHorarios();
        List<DtoPeliculas> obtenerPeliculas();
        int ObtenerProximaFuncion();
        List<DtoTipoSalas> obtenerSalas(int idSucursal);
        bool CrearFuncion(Entidades.Dto.DtoFunciones oFuncion);
    }
}
