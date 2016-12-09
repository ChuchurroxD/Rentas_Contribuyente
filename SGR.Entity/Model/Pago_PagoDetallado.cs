using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pago_PagoDetallado
    {
        public Int32 pagos_Det_ID { get; set; }
        public Int32 Pagos_ID { get; set; }
        public Int32 FormaPago { get; set; }
        public decimal Pago_Soles { get; set; }
        public decimal Pago_dolares { get; set; }
        public string NroDocumento { get; set; }
        public string FormaPago_descripcion { get; set; }
    }
}
