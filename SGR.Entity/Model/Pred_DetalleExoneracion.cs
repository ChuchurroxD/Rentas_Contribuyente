using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_DetalleExoneracion
    {
        public Int32 detalle_exoneracion_id { get; set; }
        public Int32 estado { get; set; }
        public Int32 Cuenta_Corriente_ID { get; set; }
        public Decimal monto_deuda { get; set; }
        public Decimal monto_abono { get; set; }
        public Int16 mes { get; set; }
        public Int16 anio { get; set; }
        public Int32 descuentos_exoneracion_id { get; set; }
    }
}
