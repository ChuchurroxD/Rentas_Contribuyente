using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mult_Multas
    {

        public int mult_id { get; set; }
        public String persona_id { get; set; }
        public String mult_direccion { get; set; }
        public int TipoMulta_id { get; set; }
        public decimal mult_monto { get; set; }
        public String mult_nro_resolucion { get; set; }
        public String mult_anio_resolucion { get; set; }
        public DateTime mult_fecha_resol { get; set; }
        public String mult_archivo { get; set; }
        public String mult_observacion { get; set; }
        public DateTime fecha_genera { get; set; }
        public DateTime fecha_notifica { get; set; }
        public DateTime fecha_vence { get; set; }
        public String registro_user { get; set; }
        public DateTime fecha_elimina { get; set; }
        public string mult_estado { get; set; }
        public int tp_recurso { get; set; }
        public String resol_resuelve { get; set; }
        public DateTime fech_recurso { get; set; }
        public int tp_declaro { get; set; }
        public string persona { get; set; }
        public string recursod { get; set; }
        public string declarod { get; set; }
        public string tipomultad { get; set; }
        public int clase_Multa { get; set; }
        public string clase_Descripcion { get; set; }
    }
}
