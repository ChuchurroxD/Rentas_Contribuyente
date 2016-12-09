using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity
{
    public class Liqu_LiquidacionDetalle
    {
        public Int32 liquidacion_id { get; set; }
        public DateTime fecha { get; set; }
        public Single importe { get; set; }
        public String estado { get; set; }
        public String Persona_id { get; set; }
        public Single Intereses { get; set; }
        public String registro_user { get; set; }
        public String registro_ip { get; set; }
        public DateTime registroFecha { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
    }
}
