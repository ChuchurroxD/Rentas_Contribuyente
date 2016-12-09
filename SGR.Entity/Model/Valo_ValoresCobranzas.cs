using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Valo_ValoresCobranzas
    {
        public string documento { get; set; }
        public string numero { get; set; }
        public string predio { get; set; }
        public string ubicacion { get; set; }
        public String fecha_recep { get; set; }
        public String fecha_vence { get; set; }
        public decimal deuda { get; set; }
        public string estado { get; set; }
    }
}
