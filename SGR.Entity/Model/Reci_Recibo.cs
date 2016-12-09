using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Reci_Recibo
    {
        public int Sector_id { get; set; }
        public string junta { get; set; }
        public int anio { get; set; }
        public string mes { get; set; }
        public int nromes { get; set; }
        public int total { get; set; }
        public int emitidos { get; set; }
        public int pendientes { get; set; }
    }
}
