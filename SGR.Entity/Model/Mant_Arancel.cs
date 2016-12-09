using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_Arancel
    {
        public int arancel_ID { get; set; }
        public int anio { get; set; }
        public decimal arancel_monto { get; set; }
        public int junta_via_ID { get; set; }
        public int cuadra { get; set; }
        public int lado { get; set; }
        public bool activo { get; set; }
        public string SectorDescripcion { get; set; }
        public int Sector_id { get; set; }
        public string Via_id { get; set; }
        public string ViaDescripcion { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}
