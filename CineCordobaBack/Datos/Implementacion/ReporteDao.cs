using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Implementacion
{
    public class ReporteDao:IReporteDao
    {

        public List<DtoComprobantesR> ObtenerConsultaUnoFiltrada(DateTime fechaDesde, string ts1, string ts2, string ts3, string ts4,
                                 string ts5, string ts6, string g1, string g2, string g3, string g4, string g5, string g6)
        {
            List<DtoComprobantesR> lComprobantes = new List<DtoComprobantesR>();
            List<Parametro> lParam = new List<Parametro>();

            //--------------------------parametro de fecha----------------------------------------
            Parametro pFechaDesde = new Parametro("@fechaDesde", fechaDesde);

            //--------------------------parametros de tipos de salas------------------------------- 
            Parametro pTipoSala1 = new Parametro("@2d", ts1);
            Parametro pTipoSala2 = new Parametro("@2dComfort", ts2);
            Parametro pTipoSala3 = new Parametro("@3d", ts3);
            Parametro pTipoSala4 = new Parametro("@3dComfort", ts4);
            Parametro pTipoSala5 = new Parametro("@premium", ts5);
            Parametro pTipoSala6 = new Parametro("@imax", ts6);

            //--------------------------parametros de generos discriminados en la consulta-----------
            Parametro pGenero1 = new Parametro("@accion", g1);
            Parametro pGenero2 = new Parametro("@comedia", g2);
            Parametro pGenero3 = new Parametro("@terror", g3);
            Parametro pGenero4 = new Parametro("@drama", g4);
            Parametro pGenero5 = new Parametro("@documental", g5);
            Parametro pGenero6 = new Parametro("@cienciaFiccion", g6);


            //--------------------------carga de parametros------------------------------------------
            lParam.Add(pFechaDesde);
            lParam.Add(pTipoSala1);
            lParam.Add(pTipoSala2);
            lParam.Add(pTipoSala3);
            lParam.Add(pTipoSala4);
            lParam.Add(pTipoSala5);
            lParam.Add(pTipoSala6);
            lParam.Add(pGenero1);
            lParam.Add(pGenero2);
            lParam.Add(pGenero3);
            lParam.Add(pGenero4);
            lParam.Add(pGenero5);
            lParam.Add(pGenero6);


            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTabla("SP_CONSULTA_CLARI", lParam);

            foreach (DataRow fila in tabla.Rows)
            {
                DtoComprobantesR oComprobantes = new DtoComprobantesR();

                DtoDetalleComprobanteR oDetalle = new DtoDetalleComprobanteR();

                oComprobantes.Vendedor.Nombre = fila["Vendedor"].ToString();
                oComprobantes.Cliente.Nombre = fila["Cliente"].ToString();

                oDetalle.FuncionId.SalaId.TipoSala.Tipo = fila["Sala"].ToString();
                oDetalle.FuncionId.PeliculaID.NombrePelicula= fila["Pelicula"].ToString();
                oDetalle.FuncionId.Fecha = Convert.ToDateTime(fila["Funcion"].ToString());
                oDetalle.FuncionId.PeliculaID.Genero.Genero = fila["Genero"].ToString();

                oComprobantes.Detalle = oDetalle;

                lComprobantes.Add(oComprobantes);


            }


            return lComprobantes;
        }
    }
}
