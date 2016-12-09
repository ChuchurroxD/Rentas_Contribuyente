using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_PredioContribuyente
    {
        public Int32 predio_contribuyente_id { get; set; }
        public Int16 idPeriodo { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Porcentaje_Condomino { get; set; }
        public Boolean ExonAutoValuo { get; set; }
        public Int32 AnioCompra { get; set; }
        public Boolean estado { get; set; }
        public String Predio_id { get; set; }
        public String persona_ID { get; set; }
        public Int32 tipo_adquisicion { get; set; }
        public Int32 tipo_posesion { get; set; }
        public String expediente { get; set; }
        public String observaciones { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
        public String adq_descripcion { get; set; }
        public String pose_descripcion { get; set; }
        public String razon_social { get; set; }//razonsocial d e contyribuyente
        public int total_Predios { get; set; }
        public decimal cuota_Trimestral { get; set; }
        public decimal impuesto_Anual { get; set; }
    }
}
