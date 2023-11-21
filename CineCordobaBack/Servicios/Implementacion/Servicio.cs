using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineCordobaBack.Entidades;
using CineCordobaBack.Servicios.Interfaz;
using CineCordobaBack.Fachada.Concretas;
using System.Data;
using CineCordobaBack.Fachada.Interfaces;
using CineCordobaBack.Datos.Implementacion;
using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Entidades.Dto;

namespace CineCordobaBack.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IDaoCliente dao;
        private IFuncionDao funcionDao;

        public Servicio()
        {
            dao = new DaoCliente();
            funcionDao = new FuncionDao();
        }
        public int ProximaFuncion()
        {
            return funcionDao.ObtenerProximaFuncion();
        }

        public List<Entidades.Dto.DtoHorario> traerHorarios()
        {
            return funcionDao.obtenerHorarios();
        }

        public List<DtoPeliculas> traerPeliculas()
        {
            return funcionDao.obtenerPeliculas();
        }

        public List<DtoTipoSalas> traerSalas(int idSucursal)
        {
            return funcionDao.obtenerSalas(idSucursal);
        }

        public List<Sucursales> traerSucursales()
        {
            return funcionDao.obtenerSucursales();
        }

        //

        public List<Clientes> ConsultarClientes()
        {
            return dao.ConsultarClientes();
        }

        public List<Barrios> ConsultarBarrios()
        {
            return dao.ConsultarBarrios();
        }
        public List<TipoDoc> ConsultarTipo_Documento()
        {
            return dao.ConsultarTipo_Documento();


        }

        public bool EliminarCliente(int id_cliente)
        {
            return dao.EliminarCliente(id_cliente);
        }

        public Clientes ConsultarClientesId(int id_cliente)
        {
            return dao.ConsultarClientesId(id_cliente);
        }

        public bool ModificarClientes(Clientes clientes)
        {
            return dao.ModificarClientes(clientes);

        }
    }
}

