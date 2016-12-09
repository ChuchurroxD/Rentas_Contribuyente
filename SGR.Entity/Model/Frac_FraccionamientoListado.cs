using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Frac_FraccionamientoListado
    {
        public Int32 fraccionamiento_id { get; set; }
        public string codigo { get; set; }
        public string base_legal { get; set; }
        public DateTime fecha_acogida { get; set; }
        public Int32 Cuotas { get; set; }
        public decimal deuda_fraccionada { get; set; }        
        public string estado { get; set; }
    }
}
