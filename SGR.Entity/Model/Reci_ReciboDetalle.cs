using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Reci_ReciboDetalle
    {
        public int codigo { get; set; }
        public string persona { get; set; }
        public int anio { get; set; }
        public string mes { get; set; }
        public string recibo { get; set; }
        public decimal monto { get; set; }
        public int nromes { get; set; }
    }
}
