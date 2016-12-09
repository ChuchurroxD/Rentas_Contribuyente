using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity
{
    public class Liqu_Liquidacion
    {
        public Int32 liquidacion_id { get; set; }
        public DateTime fecha { get; set; }
        public decimal importe { get; set; }
        public String estado { get; set; }
        public String tipo { get; set; }
        public String Persona_id { get; set; }
        public decimal Intereses { get; set; }
        public decimal total_final { get; set; }

        public string razon_social { get; set; }
        public String registro_ip { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
    }
}
