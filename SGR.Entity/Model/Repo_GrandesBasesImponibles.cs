using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Repo_GrandesBasesImponibles
    {
        public string persona_id { get; set; }
        public Int32 periodo_id { get; set; }
        public string razon_social { get; set; }
        public string direccion_completa { get; set; }
        public decimal base_imponible { get; set; }
    }
}
