using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Coa_expediente_coactivo
    {
        public int expediente_coactivo_ID { get; set; }
        public String persona_id { get; set; }
        public String razon_social { get; set; }
        public String direccCompleta { get; set; }
        public String estadoDescripcion { get; set; }
        public Int32 anio_expediente { get; set; }
        public Int16 tipo_exp { get; set; }
        public Int32 folios { get; set; }
        public String nro_resolucion { get; set; }
        public DateTime fecha_emision { get; set; }
        public DateTime fecha_notificacion { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public String descripcion_exp { get; set; }
        public Int32 coactivo_cta_ID { get; set; }
        public Int16 exp_estado { get; set; }
        public String exp_alias { get; set; }
        public Decimal monto_recauda_retencion { get; set; }
        public Decimal monto_recauda_inscripcion { get; set; }
        public Decimal monto_recauda_secuestro { get; set; }
        public Decimal monto_recauda_total { get; set; }
        public Decimal interes { get; set; }
        public String exp_file { get; set; }
        public String observacion { get; set; }
    }
}
