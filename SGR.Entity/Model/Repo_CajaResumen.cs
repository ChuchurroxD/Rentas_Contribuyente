using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Repo_CajaResumen
    {
        public String tributos_ID { get; set; }
        public String TributoDescripcion { get; set; }
        public Decimal ImporteTotal { get; set; }
        public String CPresupuestal { get; set; }
        public int Caja_id { get; set; }
        public String CajaDescripcion { get; set; }
        public String Fuente { get; set; }
        public Decimal MontoTotal { get; set; }
        public Decimal TasaCambio { get; set; }
        public String TipoPago { get; set; }
        public String DescripcionTipoPago { get; set; }
        public DateTime FechaPago { get; set; }

    }
}
