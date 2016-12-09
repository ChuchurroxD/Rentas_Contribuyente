using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity
{
    public class Mant_CuadroValores
    {
        public Int32 cuadro_valores_id { get; set; }
        public Int32 codigo { get; set; }
        public string serie { get; set; }
        public String descripcion { get; set; }
        public decimal monto { get; set; }
        public Int32 anio { get; set; }
        public Int16 estado { get; set; }
        public string codigoDesc { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
    }
}
