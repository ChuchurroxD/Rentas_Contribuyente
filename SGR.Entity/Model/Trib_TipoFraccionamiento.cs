using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Trib_TipoFraccionamiento
    {
        public Int32 TiFr_tipo_fraccionamiento_ID { get; set; }
        public Int32 TiFr_max_cuotas { get; set; }
        public decimal TiFr_cuota_inicial { get; set; }
        public decimal TiFr_porce_inicial { get; set; }
        public decimal TiFr_cuota_minima { get; set; }
        public DateTime TiFr_fecha_inicio { get; set; }
        public DateTime TiFr_fecha_fin { get; set; }
        public Int32 TiFr_anio_inicio { get; set; }
        public Int32 TiFr_anio_fin { get; set; }
        public Boolean TiFr_interes_moratorio { get; set; }
        public decimal TiFr_interes_compensa { get; set; }
        public decimal TiFr_descuento { get; set; }
        public String TiFr_base_legal { get; set; }
        public decimal TiFr_monto_derecho { get; set; }
        public String TiFr_modalidad { get; set; }
        public String TiFr_tipo_f { get; set; }
        public Boolean TiFr_estado { get; set; }
        public Int32 TiFr_max_uit { get; set; }

        public String TiFr_modalidadDesc { get; set; }
        public String TiFr_tipo_fDesc { get; set; }
    }
}
