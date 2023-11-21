using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using CineCordobaBack.Entidades.Dto;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Implementacion
{
    public class ComprobanteDao: IComprobanteDao
    {
        public bool CrearComprobante(DtoComprobantesR oComprobante)
        {
            bool aux = true;
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                //INSERT DE COMPROBANTE
                SqlCommand cmdComprobante = new SqlCommand("SP_INSERTAR_COMPROBANTE", cnn, t);
                cmdComprobante.CommandType = CommandType.StoredProcedure;
                cmdComprobante.Parameters.AddWithValue("@fecha", oComprobante.FechaComprobante);
                cmdComprobante.Parameters.AddWithValue("@idCliente", oComprobante.Cliente.ClienteId);
                cmdComprobante.Parameters.AddWithValue("@idSucursal", oComprobante.Sucursal.SucursalId);
                cmdComprobante.Parameters.AddWithValue("@idFormaPago", oComprobante.FormaPagoId.FormasPagoId);
                cmdComprobante.Parameters.AddWithValue("@idVendedor", oComprobante.Vendedor.VendedorId);

                SqlParameter param = new SqlParameter("@id_comprobante", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmdComprobante.Parameters.Add(param);
                cmdComprobante.ExecuteNonQuery();

                int ultimoID = Convert.ToInt32(param.Value);



                

                //INSERT DETALLES
                int cantDetalles = 1;
                foreach (DtoDetalleComprobanteR dt in oComprobante.lDetallesComprobantes)
                {
                    SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE_COMPROBANTE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    //cmdDetalle.Parameters.AddWithValue("@idDetalle", nroDetalle);
                    cmdDetalle.Parameters.AddWithValue("@idfuncion", dt.FuncionId.FuncionId);
                    cmdDetalle.Parameters.AddWithValue("@idComprobante", ultimoID);
                    cmdDetalle.Parameters.AddWithValue("@precio", dt.Precio);
                    cmdDetalle.Parameters.AddWithValue("@idPromo", dt.PromocionesId.PromoId);


                    SqlParameter parame = new SqlParameter("@id_detalle_comprobante", SqlDbType.Int);
                    parame.Direction = ParameterDirection.Output;
                    cmdDetalle.Parameters.Add(parame);
                    cmdDetalle.ExecuteNonQuery();

                    int idProxDet =Convert.ToInt32(parame.Value);

                    cantDetalles++;
                }

                t.Commit();

            }
            catch (Exception)
            {

                t.Rollback();
                aux = false;
            }
            finally 

            { if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return aux;

        }

        public List<DtoClientes> ObtenerClientes()
        {
            List<DtoClientes> lClientes = new List<DtoClientes>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CLIENTES");

            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_cliente"].ToString());
                string nombre = fila["nombre"].ToString();
                string apellido = fila["apellido"].ToString();
                int documento = int.Parse(fila["nro_doc"].ToString());
                

                DtoClientes oCliente = new DtoClientes(id, nombre,apellido,documento);
                lClientes.Add(oCliente);
            }
            return lClientes;
        }


        //aca desarrolamos los metodos que necesitamos de nuestro recurso(CRUD)

        public List<DtoFormasPago> ObtenerFormaPago()
        {
            List<DtoFormasPago> lFormaPagos = new List<DtoFormasPago>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_F_PAGOS");

            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_formas_pago"].ToString());
                string formaP = fila["formas_pago"].ToString();
                DtoFormasPago oFP = new DtoFormasPago(id, formaP);
                lFormaPagos.Add(oFP);
            }
            return lFormaPagos;
            
        }

        public List<Entidades.DtoFuncion> ObtenerFunciones(int IdPelicula)
        {
            List<Entidades.DtoFuncion> lFunciones = new List<Entidades.DtoFuncion>();
            List<Parametro> lParam = new List<Parametro>();
            Parametro parametro = new Parametro("@IdPeli", IdPelicula);
            lParam.Add(parametro);

            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTabla("SP_FUNCIONES_FILTRADAS", lParam );

            foreach (DataRow fila in tabla.Rows)
            {
                Entidades.DtoFuncion oFuncion = new Entidades.DtoFuncion();

                //creo un objeto horario para pasarselo a funcion con las properties necesarias
                DtoHorarios oH = new DtoHorarios();
                oH.Inicio = Convert.ToDateTime(fila["inicio"].ToString());
                oH.Final = Convert.ToDateTime(fila["final"].ToString());
                oH.HorarioId = int.Parse(fila["id_horario"].ToString());
                oFuncion.HorarioID= oH;


                DtoPelis oP = new DtoPelis();
                oP.NombrePelicula = fila["nombre_pelicula"].ToString();
                oP.PeliculaId= int.Parse(fila["id_pelicula"].ToString()) ;
                oFuncion.PeliculaID = oP; 

                oFuncion.FuncionId= int.Parse(fila["id_funcion"].ToString());
                oFuncion.Fecha = Convert.ToDateTime(fila["fecha"].ToString());
                oFuncion.Subtitulo = Convert.ToInt32( fila["subtitulo"]);
                DtoSalas oS = new DtoSalas();
                oS.SalaId = int.Parse(fila["id_sala"].ToString());
               
                oFuncion.SalaId = oS;
                
                DtoTipoSalas oTS = new DtoTipoSalas();
                oTS.Tipo = fila["tipo"].ToString();
                oTS.Precio = double.Parse(fila["precio"].ToString());
                oTS.Id_sala = int.Parse(fila["id_tipo_sala"].ToString());
                oFuncion.SalaId.TipoSala = oTS;




                lFunciones.Add(oFuncion);
            }
            return lFunciones;
        }

        public List<DtoPelis> ObtenerPeliculas()
        {
           
            List<DtoPelis> lPeliculas = new List<DtoPelis>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_PELICULAS");
            foreach (DataRow fila in tabla.Rows) {

                int PeliculaId = int.Parse(fila["id_pelicula"].ToString());
                string NombrePelicula = fila["nombre_pelicula"].ToString();
                DtoPelis p = new  DtoPelis(PeliculaId, NombrePelicula);
                lPeliculas.Add(p);            

            }
            return lPeliculas;

        }

        

        public List<DtoPromociones> ObtenerPromociones()
        {
            List<DtoPromociones> lPromociones = new List<DtoPromociones>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_PROMOS");
            foreach (DataRow fila in tabla.Rows)
            {

                
                string nombrePromo = fila["nombre_promo"].ToString();
                int id = int.Parse( fila["id_promo"].ToString());
                double desc = Convert.ToDouble(fila["descuento"].ToString());
                
                DtoPromociones promo = new DtoPromociones( nombrePromo, id, desc);
                lPromociones.Add(promo);

            }
            return lPromociones;

        }

        public int ObtenerProxComprobante()
        {
            return HelperDao.ObtenerInstancia().ConsultarEscalar("SP_PROXIMO_COMPROBANTE", "@next");


        }

        public bool ExisteNumDocumentoCliente(int numDoc)
        {
            List<Parametro> lparam = new List<Parametro>();
            Parametro p = new Parametro("@numDoc",numDoc);
            lparam.Add(p);
            bool existe;
            int aux;

            
             aux = HelperDao.ObtenerInstancia().ConsultaEscalarConParametros("SP_EXISTE_DOCUMENTO", "@siExiste", lparam);
            if (aux == 1)
            {
                existe = true;
            }
            else
            {
                existe = false;
            }
            return existe;
            
        }

        public List<DtoSalas> ObtenerSalas(int idTipoSala)
        {
            List<DtoSalas> lSalas = new List<DtoSalas>();
            List<Parametro> lparam = new List<Parametro>();
            Parametro p = new Parametro("@IdTipoSala", idTipoSala);
            lparam.Add(p);

            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTabla("SP_SALAS_FILTRADAS", lparam);
            foreach (DataRow fila in tabla.Rows)
            {

                int id = int.Parse(fila["id_sala"].ToString());

                
                DtoTipoSalas oTS = new DtoTipoSalas();
                
                oTS.Id_sala = int.Parse(fila["id_tipo_sala"].ToString());
                oTS.Tipo = fila["tipo"].ToString();
                oTS.Precio = Convert.ToDouble(fila["precio"].ToString());

                

                
                DtoSalas sala = new DtoSalas(id,oTS);
                lSalas.Add(sala);

            }
            return lSalas;
        }

        public List<DtoSucursales> ObtenerSucursales()
        {
            List<DtoSucursales> lSucursales = new List<DtoSucursales>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_sucursales");
            foreach (DataRow fila in tabla.Rows)
            {

                int idSucursal = int.Parse(fila["id_sucursal"].ToString());
                string nombreSucursal = fila["nombre_sucursal"].ToString();
                DtoSucursales s = new DtoSucursales(idSucursal, nombreSucursal);
                lSucursales.Add(s);
            }
            return lSucursales;
        }

       

        public List<DtoTipoSalas> ObtenerTipoSala(int idFuncion)
        {
            List<DtoTipoSalas> lTipoSalas = new List<DtoTipoSalas>();
            List<Parametro> lparam = new List<Parametro>();
            Parametro p = new Parametro("@IdFuncion", idFuncion);
            lparam.Add(p);


            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTabla("SP_SALA_FILT_POR_FUNCION", lparam);
            foreach (DataRow fila in tabla.Rows)
            {

                string tipo = fila["tipo"].ToString();
                int idTipoSala = int.Parse(fila["id_tipo_sala"].ToString());
                double precio = Convert.ToDouble(fila["precio"].ToString());

                DtoTipoSalas oTipoSala = new DtoTipoSalas( tipo, idTipoSala,precio );
                lTipoSalas.Add(oTipoSala);
            }
            return lTipoSalas;
        }


       


        public List<DtoVendedores> ObtenerVendedores()
        {
            List<DtoVendedores> lVendedores = new List<DtoVendedores>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_VENDEDORES");

            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_vendedor"].ToString());
                string nombre = fila["nombre"].ToString();
                string apellido = fila["apellido"].ToString();


                DtoVendedores oVendedor = new DtoVendedores (id, nombre, apellido);
                lVendedores.Add(oVendedor);
            }
            return lVendedores;
        }

        public List<DtoClientes> ClientePorDocumento(int numDoc)
        {
            List<Parametro> lparam = new List<Parametro>();
            Parametro p = new Parametro("@numDoc", numDoc);
            lparam.Add(p);
            List<DtoClientes> lclientes = new List<DtoClientes>();
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTabla("SP_CLIENTE_POR_DOCUMENTO", lparam);
            foreach (DataRow fila in tabla.Rows)
            {

                string nombre = fila["nombre"].ToString();
                string apellido = fila["apellido"].ToString ();


                DtoClientes oCliente = new DtoClientes(nombre,apellido);
                lclientes.Add(oCliente);
            }
            return lclientes;

           
        }

        public List<DtoDetalleComprobanteR> ObtenerDetallesComprobante(int idComprobante)
        {
            List<Parametro> lparam = new List<Parametro>();
            Parametro p = new Parametro("@id_comprobante", idComprobante);
            lparam.Add(p);
            List<DtoDetalleComprobanteR> ldetalles = new List<DtoDetalleComprobanteR>();
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTabla("SP_CONSULTAR_DETALLES", lparam);
            foreach (DataRow fila in tabla.Rows)
            {
                
                int id =int.Parse(fila["id_detalle_comprobante"].ToString());
                int idComprob = int.Parse(fila["id_comprobante"].ToString());
                double precio = double.Parse(fila["precio"].ToString());

                DtoFuncion f = new DtoFuncion();
                f.FuncionId = int.Parse(fila["id_funcion"].ToString());               


                DtoPromociones promo = new DtoPromociones();
                promo.PromoId = int.Parse(fila["id_promo"].ToString()) ;    



                DtoDetalleComprobanteR oDet = new DtoDetalleComprobanteR(id,f,promo,precio);
                ldetalles.Add(oDet);
            }
            return ldetalles;
        }
      
        public int ObtenerProxDetalle()
        {
            return HelperDao.ObtenerInstancia().ConsultarEscalar("SP_PROXIMO_DETALLE_COMPROBANTE", "@proxDetalle");
        }

        
    }
}
