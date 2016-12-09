using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Frac_Fraccionamientos
    {
        public Int32 fraccionamiento_id { get; set; }
        public string base_legal { get; set; }
        public string fecha_acogida { get; set; }
        public string periodos { get; set; }
        public decimal deuda_total { get; set; }
        public decimal inicial { get; set; }
        public decimal saldo { get; set; }
        public decimal valorCuota { get; set; }
        public Int32 nroCuotas { get; set; }
        public string estado { get; set; }
    }
}
