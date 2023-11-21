using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineCordobaBack.Datos;
using CineCordobaBack.Entidades;
using System.Data.SqlClient;
using Microsoft.Identity.Client;
using CineCordobaBack.Fachada.Interfaces;

namespace CineCordobaBack.Fachada.Concretas
{
    public class DaoCliente : IDaoCliente
    {
        public List<Clientes> ConsultarClientes()
        {
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "[spConsultarClientes]";
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<Clientes> lstc = new List<Clientes>();
            foreach (DataRow fila in dt.Rows)
            {
                int clienteId = Convert.ToInt32(fila[0]);
                string nombre = fila[1].ToString();
                string apellido = fila[2].ToString();
                DateTime fecha_nac = Convert.ToDateTime(fila[3]);
                int telefono = Convert.ToInt32(fila[4]);
                string email = fila[5].ToString();

                string calle = fila[7].ToString();
                int altura = Convert.ToInt32(fila[8]);

                int nro_doc = Convert.ToInt32((int)fila[10]);

                Clientes c = new Clientes(clienteId, nombre, apellido, fecha_nac, telefono, email, calle, altura, nro_doc);
                lstc.Add(c);
            }


            cnn.Close();
            return lstc;
        }

        public List<Barrios> ConsultarBarrios()
        {
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "cargarBarrios";
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<Barrios> lstb = new List<Barrios>();
            foreach (DataRow fila in dt.Rows)
            {
                int qbarrioId = Convert.ToInt32(fila[0]);
                string qnombreBarrio = fila[1].ToString();




                Barrios b = new Barrios(qbarrioId, qnombreBarrio);
                lstb.Add(b);
            }


            cnn.Close();
            return lstb;
        }

        public List<TipoDoc> ConsultarTipo_Documento()
        {
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "spCargarTipoDocumento";
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<TipoDoc> lsttb = new List<TipoDoc>();
            foreach (DataRow fila in dt.Rows)
            {
                int qtipodocid = Convert.ToInt32(fila[0]);
                string qtipodocumento = fila[1].ToString();

                TipoDoc td = new TipoDoc(qtipodocid, qtipodocumento);
                lsttb.Add(td);
            }


            cnn.Close();
            return lsttb;
        }
        public bool EliminarCliente(int id_cliente)
        {
            bool aux = false;
            string sp = "SP_ELIMINAR_CLIENTE";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_cliente", id_cliente));
            int filasAfectadas = HelperDao.ObtenerInstancia().EjecutarSp(sp, lst);
            if (filasAfectadas > 0)
            {
                aux = true;
            }
            return aux;
        }


        public Clientes ConsultarClientesId(int idCliente)
        {
            List<Parametro> lstParametros = new List<Parametro>();
            Clientes Clientesq = new Clientes();
            Parametro parametroId = new Parametro("@id_cliente", idCliente);
            lstParametros.Add(parametroId);

            DataTable dt = HelperDao.ObtenerInstancia().ConsultaTabla("sp_consultar_cliente_id", lstParametros);

            foreach (DataRow dr in dt.Rows)
            {
                Clientesq.id_cliente = Convert.ToInt32(dr["id_cliente"].ToString());
                Clientesq.Nombre = dr["nombre"].ToString();
                Clientesq.Apellido = dr["apellido"].ToString();
                Clientesq.FechaNac = Convert.ToDateTime(dr["fecha_nac"].ToString());
                Clientesq.Telefono = Convert.ToInt32(dr["teléfono"].ToString());
                Clientesq.Email = dr["email"].ToString();
                Clientesq.id_barrio = Convert.ToInt32(dr["id_barrio"].ToString());
                Clientesq.Calle = dr["calle"].ToString();
                Clientesq.Altura = Convert.ToInt32(dr["altura"].ToString());
                Clientesq.id_tipo_doc = Convert.ToInt32(dr["id_tipo_doc"].ToString());
                Clientesq.NroDoc = Convert.ToInt32(dr["nro_doc"].ToString());

                // Break out of the loop after setting the values
                break;
            }

            return Clientesq;
        }
        public bool ModificarClientes(Clientes clientes)
        {
            bool ok = true;
            SqlTransaction t = null;
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Transaction = t;
                    cmd.Connection = cnn;
                    cmd.CommandText = "ModificarCliente";
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@id_cliente", clientes.id_cliente);
                    cmd.Parameters.AddWithValue("@nombre", clientes.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", clientes.Apellido);
                    cmd.Parameters.AddWithValue("@fecha_nac", clientes.FechaNac);
                    cmd.Parameters.AddWithValue("@telefono", clientes.Telefono);
                    cmd.Parameters.AddWithValue("@email", clientes.Email);
                    cmd.Parameters.AddWithValue("@id_barrio", clientes.id_barrio);
                    cmd.Parameters.AddWithValue("@calle", clientes.Calle);
                    cmd.Parameters.AddWithValue("@altura", clientes.Altura);
                    cmd.Parameters.AddWithValue("@id_tipo_doc", clientes.id_tipo_doc);
                    cmd.Parameters.AddWithValue("@nro_doc", clientes.NroDoc);

                    cmd.ExecuteNonQuery();
                }

                t.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar Cliente: {ex.Message}");
                t?.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return ok;
        }
    }
}
