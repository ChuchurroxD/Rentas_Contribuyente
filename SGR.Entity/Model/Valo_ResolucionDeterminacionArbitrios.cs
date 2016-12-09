using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Valo_ResolucionDeterminacionArbitrios
    {
        public int valor_ID { get; set; }
        public int tipo_valor { get; set; }
        public string tipo_valor_desc { get; set; }
        public string persona { get; set; }
        public int nroValor { get; set; }
        public int anioValor { get; set; }
        public int anioCurso { get; set; }
        public decimal monto { get; set; }
    }
}
