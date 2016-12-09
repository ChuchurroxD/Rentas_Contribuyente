using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_Predios
    {
        public string predio_ID { get; set; }
        public string tipo_predio { get; set; }
        public decimal area_terreno { get; set; }
        public decimal valor_construccion { get; set; }
        public string tipo_adquisicion { get; set; }
        public string tipo_inmueble { get; set; }
        public decimal area_construida { get; set; }
        public decimal valor_otra_instalacion { get; set; }
        public DateTime fecha_adquisicion { get; set; }
        public string direccion { get; set; }
        public string estado_predio { get; set; }
        public decimal frente_metros { get; set; }
        public decimal valor_area_comun { get; set; }
        public string posesion { get; set; }
        public string sector { get; set; }
        public string uso_predio { get; set; }
        public decimal valor_terreno { get; set; }
        public decimal total_autovaluo { get; set; }
        public string estado { get; set; }
    }
}
