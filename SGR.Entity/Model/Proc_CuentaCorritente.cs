using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Proc_CuentaCorritente
    {
        public Int32 cuenta_corriente_ID { get; set; }
        public String nombre { get; set; }
        public String tributo { get; set; }
        public Int32 anio { get; set; }
        public Int32 mes { get; set; }
        public DateTime fecha_vence { get; set; }
        public Decimal cargo { get; set; }
        public Decimal abono { get; set; }
        public String estado { get; set; }
        public String predioId { get; set; }
    }
}
