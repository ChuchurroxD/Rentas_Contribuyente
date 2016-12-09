using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Frac_FraccionamientoListado2
    {
        public Int32 fraccionamiento_id { get; set; }
        public string convenio { get; set; }
        public String persona_ID { get; set; }
        public String persona { get; set; }
        public string junta { get; set; }
        public string via { get; set; }
        public DateTime fechaAcogida { get; set; }
        public decimal deudaFraccionada { get; set; }
        public int nroCuotas { get; set; }
        public decimal cuota { get; set; }
        public int cuotasVencidas { get; set; }
        public string estado { get; set; }
    }
}
