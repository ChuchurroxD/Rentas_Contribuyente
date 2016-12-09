using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pago_PagoXDeuda
    {
        public Int32 pagos_id { get; set; }
        public string fechaDeuda { get; set; }
        public Int32 periodo_id { get; set; }
        public string persona_id { get; set; }
        public string pagante { get; set; }
        public decimal montoPago { get; set; }
        public string tipoPago { get; set; }
        public string descripcionTipoPago { get; set; }
        public decimal tasaCambio { get; set; }
        public Int32 nroCopias { get; set; }
        public Int32 cajero_id { get; set; }
        public string cajeroNombre { get; set; }
        public Int32 liquidacion_id { get; set; }
        public Int32 fraccionamiento_id { get; set; }
        public string otroReferencia { get; set; }
        public Boolean estado { get; set; }
    }
}
