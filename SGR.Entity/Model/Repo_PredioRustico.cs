using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Repo_PredioRustico
    {
        public string persona_ID { get; set; }
        public string razon_social { get; set; }
        public string documento { get; set; }
        public string DescripcionDocumento { get; set; }
        public string direccion_completa { get; set; }
        public string nombre_predio { get; set; }
        public string este { get; set; }
        public string oeste { get; set; }
        public string norte { get; set; }
        public string sur { get; set; }
        public short Condicion_Rustico { get; set; }
        public string DescripcionCondicionRustico { get; set; }
        public int tipo_predio { get; set; }
        public string DescripcionTipoPredio { get; set; }
        public short Adquisicion_Rustico { get; set; }
        public string DescipcionAdquisicionRustico { get; set; }
        public short clasificacion_rustico { get; set; }
        public string DescripcionClasificacionRustico { get; set; }
        public int estado_predio { get; set; }
        public string DescripcionEstadoPredio { get; set; }
        public string uso_predio { get; set; }
        public string DescripcionUsoPredio { get; set; }
        public int piso_material { get; set; }
        public string DescripcionMaterPredom { get; set; }

        //Datos para Determinancion Impuesto de Reporte Predio Rustico

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

    }
}