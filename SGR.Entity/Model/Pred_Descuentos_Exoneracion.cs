using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_Descuentos_Exoneracion
    {
        public Int32 des_exo_ID { get; set; }
        //public String codigo_exo { get; set; }
        public Int16 tipo_operacion { get; set; }
        public Int16 tipo { get; set; }
        public DateTime fecha { get; set; }
        public String expediente { get; set; }
        public String resolucion { get; set; }
        public String resol_imagen { get; set; }
        public Int16 anio { get; set; }
        //public DateTime fecha_inicio { get; set; }
        //public DateTime fecha_fin { get; set; }
        public Int16 anioInicio { get; set; }
        public Int16 mesInicio { get; set; }
        public Int16 anioFin { get; set; }
        public Int16 mesFin { get; set; }
        public Decimal porcentaje_dcto { get; set; }
        public Decimal efec_descuento { get; set; }
        public String observaciones { get; set; }
        public bool estado { get; set; }
        public Int16 condicion { get; set; }
        public String contribuyente_ID { get; set; }
        public String predio_ID { get; set; }
        public String tributo_ID { get; set; }
        public Int16 motivo { get; set; }
        public Decimal base_imponible { get; set; }
        public Decimal deduccion { get; set; }
        public Decimal monto_afectado { get; set; }
        public Decimal impuesto_anual { get; set; }
        public Decimal formularios { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_pc_add { get; set; }
        public String registro_user_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_pc_update { get; set; }
        public String registro_user_update { get; set; }
        //multitabla
        public String tipo_descripcion { get; set; }
        public String tipo_operacion_descripcion { get; set; }
        public String motivo_descripcion { get; set; }
        public String condicion_descripcion { get; set; }

        public String predio_descripcion { get; set; }
        public String tributo_descripcion { get; set; }


    }
}
