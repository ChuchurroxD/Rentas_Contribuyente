using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity
{
    public class Repo_FacturadoCobrado
    {
        public String tributos_ID { get; set; }
        public String TributoDescripcion { get; set; }
        public Decimal abono { get; set; }
        public Decimal cargo { get; set; }
        public Decimal Saldo { get; set; }
        public Decimal Cobrado { get; set; }
        public Decimal Morosidad { get; set; }
        public int anio { get; set; }
        public int mes { get; set; }
        public int oficina_id { get; set; }
    }
}
