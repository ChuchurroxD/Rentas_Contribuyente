using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_Fiscalizacion
    {
        public String direccion_completa { get; set; }
        public String predio_ID { get; set; }
        public Decimal area_terreno { get; set; }
        public Decimal area_construida { get; set; }
        public Decimal total_autovaluo { get; set; }
        public int tipo_inmueble { get; set; }
        public String tipo_inmueble_descripcion { get; set; }

    }
}
