using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity
{
    public class Mant_ParametroMes
    {
        public Int32 parametro_mes_ID { get; set; }
        public Int32 tipo { get; set; }
        public String tipoDescripcion { get; set; }
        public String tipoAbreviatura { get; set; }
        public Int16 mes { get; set; }
        public Int16 periodo_id { get; set; }
        public Boolean estado { get; set; }
        public DateTime fecha_emision { get; set; }
        public DateTime fecha_vence { get; set; }
        public string registro_user_add { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_pc_add { get; set; }
        public string registro_user_update { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_pc_update { get; set; }

        public void compararMes(string via_id, List<Mant_ParametroMes> lista)
        {
            foreach (Mant_ParametroMes mant_ParametroMes in lista)
                if (via_id.Trim().Equals(mant_ParametroMes.mes))
                {
                    throw new Exception("Mes ya existe, ingrese mes no registrado");
                }
        }
    }
}
