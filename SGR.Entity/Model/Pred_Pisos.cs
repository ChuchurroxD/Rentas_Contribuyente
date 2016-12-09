using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
   public class Pred_Pisos
    {
        public Int32 piso_ID { get; set; }
        public Int32 numero { get; set; }
        public String seccion { get; set; }
        public DateTime fecha_construc { get; set; }
        public Int32 antiguedad { get; set; }
        public String muro { get; set; }
        public String techo { get; set; }
        public String piso { get; set; }
        public String puerta { get; set; }
        public String revestimiento { get; set; }
        public String banio { get; set; }
        public String instalaciones { get; set; }
        public Decimal valor_unitario { get; set; }
        public Decimal incremento { get; set; }
        public Decimal porcent_depreci { get; set; }
        public Decimal valor_unit_depreciado { get; set; }
        public Decimal area_construida { get; set; }
        public Decimal valor_construido { get; set; }
        public Decimal area_comun { get; set; }
        public Decimal valor_comun { get; set; }
        public Decimal valor_construido_total { get; set; }
        public Int16 anio { get; set; }
        public Boolean estado { get; set; }
        public String predio_ID { get; set; }
        public Int32 piso_clasificacion { get; set; }
        public Int32 piso_material { get; set; }
        public Int32 piso_estado { get; set; }
        public Int16 condicion { get; set; }
        public String persona_ID { get; set; }
        public Decimal metros_alquilados { get; set; }
        public String clase { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
        //para uso de multitabla
        public String clasificacion_id { get; set; }
        public String clasificacion_descripcion { get; set; }
        public String material_id { get; set; }
        public String material_descripcion { get; set; }
        public String estado_id { get; set; }
        public String estado_descripcion { get; set; }
        public String condicion_id { get; set; }
        public String condicion_descripcion { get; set; }
        public String antiguedad_id { get; set; }
        public String antiguedad_descripcion { get; set; }
        //fin de uso de multitabla
        public String razon_social { get; set; }//razonsocial d e contyribuyente
    }
}
