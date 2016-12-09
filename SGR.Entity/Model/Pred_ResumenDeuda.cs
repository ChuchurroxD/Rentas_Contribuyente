using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_ResumenDeuda
    {
        public String NombreCompleto { get; set; }
        public String tributo { get; set; }
        public Int32 anio { get; set; }
        public Int32 mes { get; set; }
        public Decimal cargo { get; set; }
        public Decimal ABONO { get; set; }
        public Decimal DEUDA { get; set; }
        public Decimal interes_cobrado { get; set; }
        public String OBSERVACIONES { get; set; }
        public DateTime fecha_vence { get; set; }
        public String direccion_completa { get; set; }
        public String predio_ID { get; set; }
        public String persona_ID { get; set; }
    }
}
