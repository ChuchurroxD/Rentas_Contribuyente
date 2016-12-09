using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_ValoresArbitrios
    {
        public int idValoresArbitrio { get; set; }
        public int idTablaArancel { get; set; }
        public String descripcionTablaArancel { get; set; }
        public int idPeriodo { get; set; }
        public decimal Costo { get; set; }
        public String idCodificador { get; set; }
        public String Rubro { get; set; }
        public String Recurso { get; set; }
        public Boolean Estado { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}
