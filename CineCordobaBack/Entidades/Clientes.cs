using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Clientes
    {
        [Key]
        public int id_cliente { get; set; }
        public int NroDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public int id_barrio { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public int id_tipo_doc { get; set; }

        [ForeignKey("id_barrio")]
        public Barrios Barrio { get; set; }

        [ForeignKey("id_tipo_documento")]
        public TipoDoc TipoDoc { get; set; }

        public Clientes(int clienteid, string nombre, string apellido, DateTime fechanac, int telefono, string email, string calle, int altura, int nrodoc)
        {
            id_cliente = clienteid;
            NroDoc = nrodoc;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechanac;
            Telefono = telefono;
            Email = email;
            Calle = calle;
            Altura = altura;


        }

        public Clientes()
        {

            id_cliente = 0;
            NroDoc = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            FechaNac = DateTime.Now;
            Telefono = 0;
            Email = string.Empty;
            id_barrio = 0;
            Calle = string.Empty;
            Altura = 0;
            id_tipo_doc = 0;

        }



        public override string ToString()
        {
            return id_cliente.ToString();
        }

    }
}
