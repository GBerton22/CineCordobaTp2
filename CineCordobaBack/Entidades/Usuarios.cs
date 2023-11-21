using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Usuarios
    {
        [Key]
        public int id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public Usuarios( string nombre, string contraseña)
        {
            this.Nombre = nombre;
           
            this.Contraseña = contraseña;
        }
    }
}
