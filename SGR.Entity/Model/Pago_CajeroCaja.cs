using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity.Model
{
    public  class Pago_CajeroCaja
    {
        public Int32 CajeroCaja_id{ get; set; }
        public Boolean Estado{ get; set; }
        public Int32 Caja_id{ get; set; }
        public String Persona_id{ get; set; }
        public DateTime registro_fecha_add{ get; set; }
        public string registro_user_add{ get; set; }
        public String registro_pc_add{ get; set; }
        public DateTime registro_fecha_update{ get; set; }
        public string registro_user_update{ get; set; }
        public String registro_pc_update{ get; set; }
        public string nombrecompleto { get; set; }
        public string caja_descripcion { get; set; }
    }
}