using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class RepoGrandesDeudores
    {
        public int row { get; set; }
        public String persona_id { get; set; }
        public String nombre { get; set; }
        public String documento { get; set; }
        public String tipo { get; set; }
        public String representante { get; set; }
        public String sector { get; set; }
        public String calle { get; set; }
        public int nroCalle { get; set; }
        public String mz { get; set; }
        public String lote { get; set; }
        public String telefono { get; set; }
        public Decimal deudaPredio { get; set; }
        public Decimal deudaArbitrio { get; set; }
        public Decimal deudaTotal { get; set; }
    }
}
