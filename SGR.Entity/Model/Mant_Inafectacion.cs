using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_Inafectacion
    {
        public Int32 inafectado_id { get; set; }
        public String persona_id { get; set; }
        public String nombre { get; set; }
        public String exp_descripcion { get; set; }
        public Int32 exp_anio { get; set; }
        public String resolucion { get; set; }
        public String observacion { get; set; }
        public String registro_user_add { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_add { get; set; }
        public String registro_pc_update { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public Boolean estado { get; set; }
    }
}
