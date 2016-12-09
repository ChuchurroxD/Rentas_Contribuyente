using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity

{


    public class Conf_Ubicacion
    {
        public String Ubicacion_id { get; set; }
        public String Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}

