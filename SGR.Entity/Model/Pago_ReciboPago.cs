using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pago_ReciboPago
    {
        public string codigoPersona { get; set; }
        public string nombreCompleto { get; set; }
        public string direccion { get; set; }
        public string codigoPago { get; set; }
        public string especifica { get; set; }
        public string  concepto { get; set; }
        public decimal importe { get; set; }
        public string pagoDesc{ get; set; }
    }
}
