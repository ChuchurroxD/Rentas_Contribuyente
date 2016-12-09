using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_GrupoImpresion
    {
        public Int32 grupoImpresion_ID { get; set; }
        public String tributo_ID { get; set; }
        public String grupoTipoImpresion { get; set; }
        public Boolean estado { get; set; }
        public Int32 periodo_ID { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
        public string tributo_descripcion { get; set; }
        public string grupoTipoImpresion_descripcion { get; set; }
        public string tipo_tributo { get; set; }
        public string tipo_tributo_descripcion { get; set; }
    }
}
