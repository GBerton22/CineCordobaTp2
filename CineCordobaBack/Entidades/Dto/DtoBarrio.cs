using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoBarrio
    {
        public int Id_barrio { get; set; }
        public string NombreBarrio { get; set; }


        public DtoBarrio(int barriosId, string nombreBarrio)
        {
            Id_barrio = barriosId;
            NombreBarrio = nombreBarrio;
        }

        public DtoBarrio()
        {
        }
    }
}
