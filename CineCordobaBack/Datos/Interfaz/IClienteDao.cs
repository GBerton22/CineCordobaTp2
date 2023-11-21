using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Interfaz
{
    public interface IClienteDao
    {
        int ObtenerProximoCliente();
        bool CrearCliente(DtoCliente oClientes);
        List<DtoBarrio> obtenerBarrio(int idProvincia);
        List<Ciudades> obtenerCiudades();
        List<DtoTipoDoc> obtenerDocumentos();
    }
}
