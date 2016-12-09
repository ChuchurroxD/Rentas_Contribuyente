using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity

{


    public class Conf_Tarea
    {
        public Int64 Tarec_iCodigo { get; set; }
        public Int64 Grupo_id { get; set; }
        public String Tarec_vNombre { get; set; }
        public String Tarec_vDescripcion { get; set; }
        public String Tarec_vUrl { get; set; }
        public Boolean Tarec_bActivo { get; set; }
        public Int64 Tarec_Padre { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}

