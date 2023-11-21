using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class TipoDoc
    {
        [Key]
        public int id_tipo_documento { get; set; }
        public string TipoDocumento { get; set; }

        public TipoDoc(int tipodocid, string tipoDocumento)
        {
            id_tipo_documento = tipodocid;
            TipoDocumento = tipoDocumento;

        }
        public TipoDoc()
        {
        }
    }
}
