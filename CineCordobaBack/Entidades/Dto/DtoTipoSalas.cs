using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoTipoSalas
    {
        public int Id_sala { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }

        public DtoTipoSalas(string tipo, int id, double precio)
        {
            Tipo = tipo;
            Id_sala = id;
            Precio = precio;
        }
        public DtoTipoSalas(int id_sala, string tipo)
        {
            Id_sala = id_sala;
            Tipo = tipo;
        }
        public DtoTipoSalas()
        {
            Id_sala = 0;
            Tipo = string.Empty;
            Precio = 0;

        }


    }
}
