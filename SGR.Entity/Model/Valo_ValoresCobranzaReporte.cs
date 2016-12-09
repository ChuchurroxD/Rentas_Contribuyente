using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Valo_ValoresCobranzaReporte
    {
        public int valor_ID { get; set; }
        public int tipo_valor { get; set; }
        public string tipo_valor_desc { get; set; }
        public int nroValor { get; set; }
        public int anioValor { get; set; }
        public int anioCurso { get; set; }
        public string mensaje { get; set; }
        public string baseLegal { get; set; }
    }
}
