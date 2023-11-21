using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Salas
    {
        [Key]
        public int id_sala { get; set; }
        public int id_tipo_sala { get; set; }

        [ForeignKey("id_tipo_sala")]
        public TipoSalas TipoSala { get; set; }


        public Salas()
        {
        }
    }
}
