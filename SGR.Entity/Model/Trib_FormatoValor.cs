using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity
{
    public class Trib_FormatoValor
    {
        public Int32 Valoc_iformato_valores_ID { get; set; }
        public String Valoc_vdescripcion { get; set; }
        public String Valoc_vmot_determ { get; set; }
        public String Valoc_vmensaje { get; set; }
        public String Valoc_vbase_legal { get; set; }
        public String Valoc_vpie_pag { get; set; }
        public Int32 Valoc_ianio { get; set; }
        public String Valoc_vtipodoc { get; set; }
        public String Valoc_vtipodocDec { get; set; }
        public bool Valoc_bactivo { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}
