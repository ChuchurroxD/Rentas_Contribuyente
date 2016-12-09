using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity

{


    public class Conf_Grupo
    {
        public Int64 Grupc_iCodigo { get; set; }
        public String Grupc_vNombre { get; set; }
        public String Grupc_vDescripcion { get; set; }
        public Boolean Grupc_bActivo { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}

