using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades.Dto
{
    public class DtoTipoDoc
    {
        public int TipoDocId { get; set; }
        public string TipoDocumento { get; set; }

        public DtoTipoDoc(int tipoDocId, string tipodoc)
        {
            TipoDocId = tipoDocId;
            TipoDocumento = tipodoc;
        }

        public DtoTipoDoc()
        {
        }
    }
}
