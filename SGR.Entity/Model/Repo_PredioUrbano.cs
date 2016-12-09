using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Repo_PredioUrbano
    {
        public String persona_id { get; set; }
        public String razon_social { get; set; }
        public String documento { get; set; }
        public String DescripcionDocumento { get; set; }
        public String direccion_completa { get; set; }
        public String clasificacion { get; set; }
        public String mater_predom { get; set; }
        public String uso_predio { get; set; }
        public String DescripcionUsoPredio { get; set; }
        public Int32 estado_predio { get; set; }
        public String DescripcionEstadoPredio { get; set; }
        public Int32 tipo_predio { get; set; }
        public String DescripcionTipoPredio { get; set; }
        public Int32 frente_a { get; set; }
        public Int32 piso_material { get; set; }
        public String DescripcionMaterPredom { get; set; }

        // determinacion impuesto

        public String predio_ID { get; set; }
        public int numero { get; set; } // PIS 
        public int antiguedad { get; set; } // ANT 
        public string DescripcionAntiguedad { get; set; } // dep_id = 71
        public DateTime fecha_construc { get; set; }
        public int piso_clasificacion { get; set; }
        public string DescripcionPisoClasificacion { get; set; }
        public decimal valor_unitario { get; set; }
        public decimal porcent_depreci { get; set; }
        public decimal ValorUnitarioDepreciacion { get; set; }
        public decimal area_construida { get; set; }
        public decimal valor_comun { get; set; }
        public decimal valor_construido_total { get; set; }
        public Int32 tipo_inmueble { get; set; }
    }
}
