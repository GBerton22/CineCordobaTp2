using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class DtoVendedores
    {
        public int VendedorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string NombreCompleto
        {
            get { return $"{Nombre}, {Apellido}"; }
        }

        public DtoVendedores(int id, string nombre, string apellido)
        {
            this.VendedorId = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public DtoVendedores()
        {
                
        }
    }
}
