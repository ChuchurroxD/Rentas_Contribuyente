using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity.Model
{
public  class Mant_Depreciacion
{
        public Int32 depreciacion_ID{ get; set; }
        public Int16 anio{ get; set; }
        public Int16 clasificacion{ get; set; }
        public string antiguedad{ get; set; }
        public Int16 anti_inicial { get; set; }
        public Int16 anti_final { get; set; }
        public Int16 material{ get; set; }
        public Int16 estado_piso{ get; set; }
        public Decimal porcentaje{ get; set; }
        public Boolean estado{ get; set; }
        public string clasificacion_descripcion { get; set; }
        public string material_descripcion { get; set; }
        public string estadoPiso_descripcion { get; set; }
        public string antiguedad_descripcion { get; set; }

        public string muyBueno { get; set; }
        public string bueno { get; set; }
        public string regular { get; set; }
        public string malo { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}

