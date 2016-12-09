using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_Relacion_Contribuyente
    {
        public Int32 relacion_ID { get; set; }
        public String cod_allegado { get; set; }
        public String razon_social { get; set; }
        public String ruc { get; set; }
        public Int32 tipo_relacion { get; set; }
        public String tipo_relacion_descripcion { get; set; }
        public String persona_ID { get; set; }
        public Boolean estado { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_pc_add { get; set; }
        public String registro_user_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_pc_update { get; set; }
        public String registro_user_update { get; set; }

    }
}
