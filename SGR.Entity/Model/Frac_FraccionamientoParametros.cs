using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Frac_FraccionamientoParametros
    {
        public string persona_ID { get; set; }
        public int anio_ini { get; set; }
        public int anio_fin { get; set; }
        public int mes_ini { get; set; }
        public int mes_fin { get; set; }
        public string tributo_ID { get; set; }
        public int fraccionamiento_ID { get; set; }
    }
}