using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Frac_DeudaFraccionada
    {
        public int fraccionamiento_ID { get; set; }
        public string junta { get; set; }
        public string via { get; set; }
        public decimal total { get; set; }
        public decimal pagado { get; set; }
        public decimal vencido { get; set; }
        public decimal anulado { get; set; }
        public decimal pendiente { get; set; }
    }
}
