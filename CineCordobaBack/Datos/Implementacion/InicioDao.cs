using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Implementacion
{
    public class InicioDao:IInicioDao
    {
        public int ObtenerUsuario(Usuarios oUsuario)
        {
            List<Parametro> lstParametros = new List<Parametro>();

            Parametro parametroUsuario = new Parametro("@Usuario", oUsuario.Nombre);
            Parametro parametroContraseña = new Parametro("@Contraseña", oUsuario.Contraseña);
            
            lstParametros.Add(parametroUsuario);
            lstParametros.Add(parametroContraseña);
            return HelperDao.ObtenerInstancia().ConsultaEscalarConParametros("SP_INICIO_SESION", "@Resultado", lstParametros);
        }
    }
}
