using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity
{    public class Mant_Contribuyente
    {
        public String persona_id { get; set; }
        public String razon_social { get; set; }
        public String ruc { get; set; }
        public String TipoDocDescripcion { get; set; }
        public Int32 junta_via_ID { get; set; }
        public String c_num { get; set; }
        public String c_mz { get; set; }
        public String c_lote { get; set; }
        public String c_interior { get; set; }
        public String c_dpto { get; set; }
        public Boolean estado { get; set; }
        public DateTime registro_fecha { get; set; }
        public DateTime fecha_registro { get; set; }
        public string registro_user { get; set; }
        public String Contacto { get; set; }
        public String dniRepresentante { get; set; }
        public String DireccRepresentante { get; set; }
        public String direccCompleta { get; set; }
        public String referencia { get; set; }
        public String c_edificio { get; set; }
        public String c_piso { get; set; }
        public String c_tienda { get; set; }
        public String Ubi_codigo { get; set; }
        public String registro_pc_update { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public bool empresaCOnstrucora { get; set; }
        public bool jubilado { get; set; }
    }
}

