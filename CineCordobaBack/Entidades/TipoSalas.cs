using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class TipoSalas
    {
        [Key]
        public int id_tipo_sala { get; set; }
        public string tipo { get; set; }
        public decimal Precio { get; set; }

        public TipoSalas(int id_sala, string tipo)
        {
            id_tipo_sala = id_sala;
            this.tipo = tipo;
        }
        public TipoSalas()
        {
            id_tipo_sala = 0;
            tipo = string.Empty;
            Precio = 0;

        }
    }
}
