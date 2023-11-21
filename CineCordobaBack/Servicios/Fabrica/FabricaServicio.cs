using CineCordobaBack.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Servicios.Fabrica
{
    public abstract class FabricaServicio
    {
        public abstract IServicio CrearServicio();
    }
}
