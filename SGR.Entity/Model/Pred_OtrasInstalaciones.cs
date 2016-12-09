using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity
{
    public class Pred_OtrasInstalaciones
    {
        
        public Int32 PrediosOtras_id { get; set; }
        public String Predio_id { get; set; }
        public Int32 OtrasValor_id { get; set; }
        public String OtrasValor_descripcion { get; set; }
        public String Observacion { get; set; }
        public Decimal ValorOtras { get; set; }
        public Decimal CantidadValor { get; set; }
        public bool Estado { get; set; }
        public String registro_user_add { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_pc_add { get; set; }
        public String registro_user_update { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_pc_update { get; set; }
    }
}
