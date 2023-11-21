using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoCliente
    {
        public int ClienteId { get; set; }
        public int NroDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public DtoBarrio Barrio { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public DtoTipoDoc TipoDocId { get; set; }

        public DtoCliente(int clienteid, int nrodoc, string nombre, string apelido, DateTime fechaNac, int telefono, string email, DtoBarrio barrio, string Calle, int altura, int nroDoc, DtoTipoDoc tipoDoc)
        {
            ClienteId = clienteid;
            NroDoc = nrodoc;
            Nombre = nombre;
            Apellido = apelido;
            FechaNac = fechaNac;
            Telefono = telefono;
            Email = email;
            Barrio = barrio;
            this.Calle = Calle;
            TipoDocId = tipoDoc;

        }
        public DtoCliente()
        {
            ClienteId = 0;
            NroDoc = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            FechaNac = DateTime.Now;
            Telefono = 0;
            Email = string.Empty;
            Barrio = null;
            Altura = 0;
            TipoDocId = null;

        }
    }
}
