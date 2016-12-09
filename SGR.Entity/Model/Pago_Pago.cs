using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pago_Pago
    {
        public Int32 Pagos_ID { get; set; }
        public DateTime FechaPago { get; set; }
        public Int32 idPeriodo { get; set; }
        public string Pagante { get; set; }
        public decimal MontoTotal { get; set; }
        public string TipoPago { get; set; }
        public decimal TasaCambio { get; set; }
        public Int32 NroCopias { get; set; }
        public Int32 CajeroCaja_ID { get; set; }
        public string Persona_ID { get; set; }
        public Int32 liquidacion_ID { get; set; }
        public Int32 fraccionamiento_ID { get; set; }
        public string otroReferencia { get; set; }
        public bool estado { get; set; }
        public string tipoPago_descripcion { get; set; }
        public string CajeroCaja_nombre { get; set; }
        public string nroRecibo { get; set; }
        public string tipo { get; set; }
        public string recibo_usado { get; set; }
        public string hora { get; set; }
    }
}
