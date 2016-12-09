using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_ValidacionPredioArbitrio
    {
        public String predio_ID { get; set; }
        public String NombreCompleto { get; set; }
        public String direccion_completa { get; set; }
        public String nombre_predio { get; set; }
        public int tipo_operacion { get; set; }
        public String DescripcionTipoOperacion { get; set; }
        public int tipo_inmueble { get; set; }
        public String DescripcionTipoInmueble { get; set; }
        public int tipo_predio { get; set; }
        public String DescripcionTipoPredio { get; set; }
        public int estado_predio { get; set; }
        public String DescripcionEstadoPredio { get; set; }
        public int idPeriodo { get; set; }
    }
}
