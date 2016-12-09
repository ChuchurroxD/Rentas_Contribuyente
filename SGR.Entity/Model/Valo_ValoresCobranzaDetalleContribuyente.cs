using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Valo_ValoresCobranzaDetalleContribuyente
    {
        public String cod_persona { get; set; }
        public String persona { get; set; }
        public String juntaVecinal { get; set; }
        public decimal deuda { get; set; }
    }
}
