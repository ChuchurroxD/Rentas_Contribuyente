using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Trib_FormatoCampos
    {
        public int id { get; set; }
        public string tipo_formato_id { get; set; }
        public string tipo_formato_descripcion { get; set; }
        public Int32 anio { get; set; }
        public string colum1 { get; set; }
        public string colum2 { get; set; }
        public string colum3 { get; set; }
        public string colum4 { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}
