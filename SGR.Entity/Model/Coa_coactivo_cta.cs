using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Coa_coactivo_cta
    {
        public Int32 coactivo_cta_ID { get; set; }
        public Decimal interes { get; set; }
        public DateTime fecha_emision { get; set; }
        public Decimal monto { get; set; }
        public String persona_ID { get; set; }
        public Int32 contri_coactivo_ID { get; set; }
        public Boolean estado { get; set; }
        public Int16 grupo { get; set; }
        public Int32 anio_ini { get; set; }
        public Int32 anio_fin { get; set; }
        public Decimal interes_mor { get; set; }
        public Decimal monto_tota { get; set; }
        public String razon_social { get; set; }
        public String direccCompleta { get; set; }
        //public String descRipcion_exp { get; set; }
    }
}
