using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Orga_Area
    {
        public String Areac_vCodigo { get; set; }
        public String Areac_vDescripcion { get; set; }
        public String Areac_vProy { get; set; }
        public Int32 Areac_iDep { get; set; }
        public string Areac_vDepDesc { get; set; }
        public String Areac_vTipoArea { get; set; }
        public String Areac_vCodAnterior { get; set; }
        public Boolean Areac_bactivo { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}
