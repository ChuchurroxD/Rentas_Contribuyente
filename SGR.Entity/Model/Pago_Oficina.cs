using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity
{
    public  class Pago_Oficina
    {
        public Int32 oficina_id{ get; set; }
        public String Descripcion{ get; set; }
        public bool Estado{ get; set; }
        public bool principal{ get; set; }
        public DateTime registro_fecha_add{ get; set; }
        public string registro_user_add{ get; set; }
        public String registro_pc_add{ get; set; }
        public DateTime registro_fecha_update{ get; set; }
        public string registro_user_update{ get; set; }
        public String registro_pc_update{ get; set; }
    }
}

