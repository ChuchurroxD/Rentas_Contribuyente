using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_Banco
    {
        public Int32 banco_ID { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_pc_update { get; set; }
        public string registro_user_update { get; set; }
    }
}
