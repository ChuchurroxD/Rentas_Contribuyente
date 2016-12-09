using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_Segmentacion_Contribuyente
    {
        public Int32 segmentacion_contribuyente_id { get; set; }
        public Int32 segmentacion_id { get; set; }
        public String persona_id { get; set; }
        public String registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public Boolean estado { get; set; }
        public String nombrecompleto { get; set; }
        public String seg_descripcion { get; set; }
        public Int32 periodo_id { get; set; }
        public Decimal monto_inicio { get; set; }
        public Decimal monto_fin { get; set; }
        public Decimal monto { get; set; }

    }
}
