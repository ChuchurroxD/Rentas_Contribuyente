using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pago_CuentaCorriente
    {
        public Int32 cuenta_corriente_ID { get; set; }
        public String persona_ID { get; set; }
        public String predio_ID { get; set; }
        public String tributo_ID { get; set; }
        public Int32 anio { get; set; }
        public Int32 mes { get; set; }
        public DateTime fecha_vence { get; set; }
        public decimal cargo { get; set; }
        public decimal abono { get; set; }
        public DateTime fecha_cancelacion { get; set; }
        public String observaciones { get; set; }
        public String estado { get; set; }
        public Boolean activo { get; set; }
        public DateTime fecha_generacion { get; set; }
        public Int32 tipo_opera { get; set; }
        public DateTime fecha_anula_descarga { get; set; }
        public Int32 num_operacion { get; set; }
        public String registro_user_add { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_pc_add { get; set; }
        public String registro_user_update { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_pc_update { get; set; }
        public Decimal interes_cobrado { get; set; }
        public decimal total { get; set; }
        public string tributo { get; set; }
        public string tipo_tributo { get; set; }
        public decimal pagado { get; set; }
        public decimal pendiente { get; set; }
        public decimal pendiente_total { get; set; }
        public decimal pagado_total { get; set; }
    }
}
