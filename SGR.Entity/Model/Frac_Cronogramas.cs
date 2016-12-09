using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Frac_Cronogramas
    {
        public int fraccionamiento_ID { get; set; }
        public int nroCuota { get; set; }
        public decimal saldo { get; set; }
        public decimal amortizacion { get; set; }
        public decimal interes { get; set; }
        public decimal importe { get; set; }
        public DateTime fechaVence { get; set; }
        public string fechaPago { get; set; }
        public string estado { get; set; }
    }
}
