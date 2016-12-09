using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Repo_DetallePagos
    {
        public Int32 nro_Recibo { get; set; }
        public String Pagante { get; set; }
        public Int32 Caja_id { get; set; }
        public String CajaDescripcion { get; set; }
        public String TipoPago { get; set; }
        public String DescripcionTipoPago { get; set; }
        public DateTime FechaPago { get; set; }
        public Decimal MontoTotal { get; set; }
    }
}
