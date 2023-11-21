using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Fachada.Interfaces
{
    public interface IDaoCliente
    {
        List<Clientes> ConsultarClientes();
        List<Barrios> ConsultarBarrios();
        List<TipoDoc> ConsultarTipo_Documento();
        Clientes ConsultarClientesId(int idCliente);
        bool EliminarCliente(int id_cliente);
        bool ModificarClientes(Clientes clientes);
    }
}
