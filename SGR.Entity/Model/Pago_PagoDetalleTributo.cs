using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pago_PagoDetalleTributo
    {
        public Int32 pagos_det_ID { get; set; }
        public Int32 pagos_ID { get; set; }
        public decimal monto_pago { get; set; }
        public string tributos_ID { get; set; }
        public Int32 cuenta_corriente_ID { get; set; }
        public Int16 anio { get; set; }
        public Int32 mes { get; set; }
        public Int16 cantidad { get; set; }
        public string tributo_descripcion { get; set; }
        public string ene { get; set; }
        public string feb { get; set; }
        public string mar { get; set; }
        public string abr { get; set; }
        public string may { get; set; }
        public string jun { get; set; }
        public string jul { get; set; }
        public string ago { get; set; }
        public string set { get; set; }
        public string oct { get; set; }
        public string nov { get; set; }
        public string dic { get; set; }
    }
}
