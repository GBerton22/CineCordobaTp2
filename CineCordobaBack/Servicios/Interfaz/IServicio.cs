using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Servicios.Interfaz
{
    public interface IServicio
    {
        List<DtoPeliculas> traerPeliculas();
        int ProximaFuncion();
        List<Entidades.Dto.DtoHorario> traerHorarios();
        List<Sucursales> traerSucursales();
        List<DtoTipoSalas> traerSalas(int idSucursal);
        //
        List<Clientes> ConsultarClientes();
        List<Barrios> ConsultarBarrios();
        List<TipoDoc> ConsultarTipo_Documento();
        bool EliminarCliente(int id_cliente);
        Clientes ConsultarClientesId(int id_cliente);
        bool ModificarClientes(Clientes clientes);

    }
}
