using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class DtoSucursales
    {
        public int SucursalId { get; set; }
        public string NombreSucursal { get; set; }
        //public Barrios BarrioId { get; set; }

        public DtoSucursales(int SucursalId, string NombreSucursal)
        {
            this.SucursalId = SucursalId;
            this.NombreSucursal = NombreSucursal;
        }

        public DtoSucursales()
        {
                
        }
    }
}
