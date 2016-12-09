using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_Historial
    {
        public Int32 idHistorial { get; set; }
        public String idPredio { get; set; }
        public String idPersona { get; set; }
        public Int32 tipo { get; set; }
        public Int32 idPeriodo { get; set; }
        public String Descripcion { get; set; }
        public String Obligacion { get; set; }
        public String Expediente { get; set; }
        public Int32 TipoOperacion { get; set; }
        public String tipoOperDescrip { get; set; }
        public String registro_user_add { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_add { get; set; }
        public String registro_pc_update { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public Boolean estado { get; set; }
        public DateTime fecha { get; set; }
        public string tipoDocumento { get; set; }
        public String tipodocDescrip { get; set; }
    }
}
