using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model

{

    public class Trib_ClasificadorIngresos
    {
        public String Tribc_vCodigo { get; set; }
        public String Tribc_vAnio { get; set; }
        public String Tribc_vDescripcion { get; set; }
        public Boolean Tribc_bEstado { get; set; }

        
        public String Tribc_vPresupuesto { get; set; }
        public String Tribc_vContable { get; set; }
        public String Tribc_vContableant { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}
