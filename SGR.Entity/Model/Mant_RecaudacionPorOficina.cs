using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_RecaudacionPorOficina
    {
        public String tributos_ID { get; set; }
        public String ClasificacionDescripcion { get; set; }
        public String TributoDescripcion { get; set; }
        public String TablaDescripcion { get; set; }
        public String Are_Descripcion { get; set; }
        public Decimal monto_pago { get; set; }
        public Int32 PeriodoDesde { get; set; }
        public Int32 PeriodoHasta { get; set; }
        public Int16 anio { get; set; }
        public Int32 oficina_id { get; set; }
        public String clai_codigo { get; set; }
        public String DescripcionOficina { get; set; }

    }
}
