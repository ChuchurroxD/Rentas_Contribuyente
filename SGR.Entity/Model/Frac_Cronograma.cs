using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Frac_Cronograma
    {
        public int Crono_Fraccionamiento_id { get; set; }
        public int Fraccionamiento_id { get; set; }
        public int NroCuota { get; set; }
        public decimal importe { get; set; }
        public decimal amortizacion { get; set; }
        public decimal interes { get; set; }
        public DateTime FechaVence { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal saldo { get; set; }
        public decimal cuota { get; set; }
        public decimal ajuste { get; set; }
        public decimal ajusteAcumulado { get; set; }
    }
}