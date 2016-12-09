using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Repo_CompensacionFaltante
    {
        public int compensacionFaltante_id { get; set; }
        public string persona_id { get; set; }
        public string razon_social { get; set; }
        public string predio_id { get; set; }
        public string tributos_id { get; set; }
        public string trib_descripcion { get; set; }
        public decimal montoFaltante { get; set; }
        public string observacion { get; set; }
        public string expediente { get; set; }
        public int anio { get; set; }
        public int mes { get; set; }
    }
}
