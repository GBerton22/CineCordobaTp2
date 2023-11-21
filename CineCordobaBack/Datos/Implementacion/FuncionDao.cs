using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Implementacion
{
    public class FuncionDao : IFuncionDao
    {

        public List<DtoTipoSalas> obtenerSalas(int idSucursal)
        {
            List<DtoTipoSalas> lsalas = new List<DtoTipoSalas>();
            List<Parametro> lparam = new List<Parametro>();
            Parametro parametro = new Parametro("@id_sucursal", idSucursal);
            lparam.Add(parametro);
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTabla("sp_salas", lparam);

            foreach (DataRow fila in tabla.Rows)
            {
                int id_sala = int.Parse(fila["id_sala"].ToString());
                string tipo_sala = fila["tipo"].ToString();

                DtoTipoSalas ts = new DtoTipoSalas(id_sala, tipo_sala);
                lsalas.Add(ts);

            }
            return lsalas;
        }
        public List<Sucursales> obtenerSucursales()
        {
            List<Sucursales> lsucursales = new List<Sucursales>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_sucursales");
            foreach (DataRow fila in tabla.Rows)
            {

                int id_sucursal = int.Parse(fila["id_sucursal"].ToString());
                string nombre_sucursal = fila["nombre_sucursal"].ToString();
                Sucursales s = new Sucursales(id_sucursal, nombre_sucursal);
                lsucursales.Add(s);
            }
            return lsucursales;
        }

        public List<Entidades.Dto.DtoHorario> obtenerHorarios()
        {
            List<Entidades.Dto.DtoHorario> lhorario = new List<Entidades.Dto.DtoHorario>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_horarios");
            foreach (DataRow fila in tabla.Rows)
            {                
                    int id_horario = int.Parse(fila["id_horario"].ToString());
                TimeSpan inicio = TimeSpan.Parse(fila["inicio"].ToString());
                TimeSpan final = TimeSpan.Parse(fila["final"].ToString());

                Entidades.Dto.DtoHorario h = new Entidades.Dto.DtoHorario(id_horario, inicio, final);                             


                lhorario.Add(h);
            }
            return lhorario;
        }

        public List<DtoPeliculas> obtenerPeliculas()
        {
            List<DtoPeliculas> lpeliculas = new List<DtoPeliculas>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_peliculas");
            foreach (DataRow fila in tabla.Rows) {

                int numero = int.Parse(fila["id_pelicula"].ToString());
                string nombre = fila["nombre_pelicula"].ToString();
                DtoGenero genero = new DtoGenero();
                genero.Id_genero = int.Parse(fila["id_genero"].ToString());
                DtoPeliculas p = new DtoPeliculas(numero, nombre,genero);
                lpeliculas.Add(p);            
            }
            return lpeliculas;

        }

        public int ObtenerProximaFuncion()
        {
            return HelperDao.ObtenerInstancia().ConsultarEscalar("SP_PROXIMO_ID", "@next");
        }

        public bool CrearFuncion(Entidades.Dto.DtoFunciones oFuncion)
        {
            bool resultado = true;

            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            
            try
            {
                conexion.Open();
                
                SqlCommand comandoInsertar = new SqlCommand("CrearFuncion", conexion);

                comandoInsertar.CommandType = CommandType.StoredProcedure;
               
                comandoInsertar.Parameters.AddWithValue("@id_horario", oFuncion.HorarioID.Id_horario);
                comandoInsertar.Parameters.AddWithValue("@fecha", oFuncion.Fecha);
                bool subtitulo = false;
                if (oFuncion.Subtitulo != null)
                {
                    subtitulo = true;
                }
                comandoInsertar.Parameters.AddWithValue("@subtitulo", subtitulo);
                comandoInsertar.Parameters.AddWithValue("@id_pelicula", oFuncion.PeliculaId.Id_pelicula);
                comandoInsertar.Parameters.AddWithValue("@id_sala", oFuncion.SalasId.SalaId);

                SqlParameter param = new SqlParameter("@id_Funcion", SqlDbType.Int);
                param.Direction= ParameterDirection.Output;
                comandoInsertar.Parameters.Add(param);
                comandoInsertar.ExecuteNonQuery();

                

              
            }
            catch (Exception)
            {
                
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado; 
        }
    }
}
