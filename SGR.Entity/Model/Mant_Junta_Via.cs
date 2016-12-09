using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity

{
    public class Mant_Junta_Via
    {
        public Int32 junta_via_ID { get; set; }
        public String junta_ID { get; set; }
        public String via_ID { get; set; }
        public Boolean estado { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
        public string descripcion_sector { get; set; }
        public string via_descripcion { get; set; }
    }
}

