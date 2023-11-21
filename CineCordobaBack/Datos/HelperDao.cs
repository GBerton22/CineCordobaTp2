using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace CineCordobaBack.Datos
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection cnn;


        private HelperDao()
        {
            cnn = new SqlConnection("Data Source=DESKTOP-KI5LVF5\\SQLEXPRESS;Initial Catalog=Cordoba_Cine_GRUPO_N9;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }

        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public SqlConnection ObtenerConexion()
        { return cnn; }

        public int EjecutarSp(string spNombre, List<Parametro> listaParametros)
        {
            int filasAfectadas = 0;
            SqlTransaction t = null;

            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();


            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(spNombre, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;

                if (listaParametros != null)
                {
                    foreach (Parametro oParametro in listaParametros)
                    {
                        cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                    }
                }
                filasAfectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null)
                { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return filasAfectadas;
        }

        public DataTable ConsultaTabla(string spNombre, List<Parametro> listaParametros)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (listaParametros != null)
            {
                foreach (Parametro oParametro in listaParametros)
                {
                    cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                }
            }
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }
        public DataTable Consultar(string nombreSP)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public int ConsultarEscalar(string nombreSP, string nombreParamOut)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombreParamOut;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            cnn.Close();

            return (int)parametro.Value;
        }

        public int ConsultaEscalarConParametros(string spNombre, string pOutNombre, List<Parametro> listaParámetros)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (listaParámetros != null)
            {
                foreach (Parametro oParametro in listaParámetros)
                {
                    cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                }
            }

            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = pOutNombre;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)pOut.Value;
        }




    }
}
