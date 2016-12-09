using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity
{
    public class Frac_Fraccionamiento
    {
        public String persona_ID { get; set; }
        public int anio { get; set; }
        public decimal predial { get; set; }
        public decimal predialI { get; set; }
        public decimal arbitrios { get; set; }
        public decimal arbitriosI { get; set; }
        public decimal alcabala { get; set; }
        public decimal alcabalaI { get; set; }
        public decimal multas { get; set; }
        public decimal multasI { get; set; }
        public decimal fincas { get; set; }
        public decimal fincasI { get; set; }
        public decimal alquileres { get; set; }
        public decimal alquileresI { get; set; }
        public decimal tasas { get; set; }
        public decimal tasasI { get; set; }
        public decimal total { get; set; }
    }
}
