using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pago_Pagos
    {
        public Int32 Pagos_id { get; set; }
        public DateTime FechaPago { get; set; }
        public Int32 idPeriodo { get; set; }
        public String Pagante { get; set; }
        public Single MontoTotal { get; set; }
        public String TipoPago { get; set; }
        public Single TasaCambio { get; set; }
        public Int32 NroCopias { get; set; }
        public Int32 CajeroCaja_Id { get; set; }
        public String Persona_id { get; set; }
        public Int32 liquidacion_ID { get; set; }
        public Int32 fraccionamiento_ID { get; set; }
        public String OtroReferencia { get; set; }
        public Boolean Estado { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
    }
}
