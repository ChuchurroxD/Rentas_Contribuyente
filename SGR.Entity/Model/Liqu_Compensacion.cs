using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Liqu_Compensacion
    {
        public Int64 row { get; set; }
        public string persona_id { get; set; }
        public string nombrePersona { get; set; }
        public int compensacion_id { get; set; }
        public string tributos_id { get; set; }
        public string tributos_descrip { get; set; }
        public string observacion { get; set; }
        public string expediente { get; set; }
        public decimal montoCompensado { get; set; }
        public DateTime fecha { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_pc_add { get; set; }
        public string registro_user_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
        public int detaCompensacion_id { get; set; }
        public int cuentaCorriente_id { get; set; }
        public decimal montoDeuda { get; set; }
        public decimal montoAbono { get; set; }
        public Int16 mes { get; set; }
        public Int16 anio { get; set; }
        public Int32 periodo { get; set; }

        //PARA TRAER INFO DE LA BD
        public String predio_ID { get; set; }
        public String predio { get; set; }  
        public decimal monto { get; set; }
        public decimal interes { get; set; }
        public decimal total { get; set; }
        public decimal deudaVencida { get; set; }  
    }
}
