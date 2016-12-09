using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Valo_ValoresCobranza
    {
        public Int32 cod_sector { get; set; }
        public String sector{ get; set; }
        public Int32 nro { get; set; }
        public decimal deuda { get; set; }
    }
}
