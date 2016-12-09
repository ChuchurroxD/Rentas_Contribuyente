using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_Anulacion
    {
        public string persona_id { get; set; }
        public string nombrePersona { get; set; }
        public int anulacion_id { get; set; }
        public string tributos_id { get; set; }
        public string tributos_descrip { get; set; }
        public DateTime fecha { get; set; }
        public string observacion { get; set; }
        public Int16 anioInicio { get; set; }
        public Int16 mesInicio { get; set; }
        public Int16 anioFin { get; set; }
        public Int16 mesFin { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_pc_add { get; set; }
        public string registro_user_add { get; set; }
        public string tipoAnulacion { get; set; }
        public string tipoAnul_descrip { get; set; }
        public int detaAnulacion_id { get; set; }
        public int cuentaCorriente_id { get; set; }
        public decimal montoDeuda { get; set; }
        public decimal montoAbono { get; set; }
        public Int16 mes { get; set; }
        public Int16 anio { get; set; }
        public Int32 periodo { get; set; }
        public String predio_id { get; set; }
    }
}
