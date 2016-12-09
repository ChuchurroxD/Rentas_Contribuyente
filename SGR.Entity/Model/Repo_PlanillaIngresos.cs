using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Repo_PlanillaIngresos
    {
        public String Pagante { get; set; }
        public String Recurso { get; set; }
        public String Fuente { get; set; }
        public String clai_codigo { get; set; }
        public String clai_descripcion { get; set; }
        public Int32 nro_Recibo { get; set; }
        public Decimal monto_pago { get; set; }
        public Decimal MontoTotal { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
