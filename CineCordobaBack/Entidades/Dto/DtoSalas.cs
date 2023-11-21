using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoSalas
    {
        public int SalaId { get; set; }
        public DtoTipoSalas TipoSala { get; set; }
        public DtoSalas()
        {
            SalaId = 0;
            TipoSala = new DtoTipoSalas();
        }

        public DtoSalas(int salaId, DtoTipoSalas tiposala)
        {
            this.SalaId = salaId;
            this.TipoSala = tiposala;

        }
    }
}
