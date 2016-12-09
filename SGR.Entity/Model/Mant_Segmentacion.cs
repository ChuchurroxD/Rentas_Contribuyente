using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_Segmentacion
    {
        public Int32 segmentacion_id { get; set; }
        public String descripcion { get; set; }
        public String registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public Int32 periodo_id { get; set; }
        public Decimal monto_inicio { get; set; }
        public Decimal monto_fin { get; set; }
        public Int16 tipo { get; set; }
        public String tipo_descripcion { get; set; }
        public Boolean estado { get; set; }
    }
}
