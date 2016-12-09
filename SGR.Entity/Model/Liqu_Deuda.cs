using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SGR.Entity.Model
{
    public class Liqu_Deuda
    {
        public String persona_ID { get; set; }
        public String predio_ID { get; set; }
        public String predio { get; set; }
        public String tributo_ID { get; set; }
        public String tributo { get; set; }
        public decimal monto { get; set; }
        public decimal interes { get; set; }
        public decimal total { get; set; }
        public decimal deudaVencida { get; set; }
        public string periodo { get; set; }
        public Int32 anio { get; set; }
        public int cuenta_corriente_ID { get; set; }
    }
}