using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_PrredioArbitrio
    {
        public Int32 idPredioArbitrio { get; set; }
        public String Predio_id { get; set; }
        public Int32 idTablaArancel { get; set; }
        public String TablaArancel_Descripcion { get; set; }
        public String idPeriodo { get; set; }
        public Decimal FechaRegistro { get; set; }
        public bool Estado { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
        public Decimal costo { get; set; }
    }
}
