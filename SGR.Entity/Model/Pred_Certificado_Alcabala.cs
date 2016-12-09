using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_Certificado_Alcabala
    {
        public Int32 certalcabala_id { get; set; }
        public String persona_id { get; set; }
        public String comprador { get; set; }
        public String predio_id { get; set; }
        public String tipo_alcabala { get; set; }
        public String tipo_adquisicion { get; set; }
        public String tipo_posesion { get; set; }
        public Int32 anioGeneracion { get; set; }
        public DateTime fecha_tramite { get; set; }
        public Decimal condomino { get; set; }
        public Decimal valor_venta { get; set; }
        public Decimal valuo { get; set; }
        public Decimal base_imponible { get; set; }
        public Decimal uits { get; set; }
        public Decimal valor_afecto { get; set; }
        public Decimal alcabala { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public String registro_pc_add { get; set; }
        public String registro_user_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_pc_update { get; set; }
        public String registro_user_update { get; set; }
        public Boolean estado { get; set; }
        public Decimal tasaAlcabala { get; set; }
        public Int32 anio { get; set; }
        public String comprador_name { get; set; }
        public String adquisicion_descripcion { get; set; }
        public String posesion_descripcion { get; set; }
        public String direccion_completa { get; set; }
        public String vendedor_name { get; set; }
        public String observacion { get; set; }
        public Decimal valorTerreno { get; set; }
        public int usopredio { get; set; }
        public int tipo_inmueble { get; set; }
        public String documento { get; set; }
        public String OtraDireccion { get; set; }
        public int caso { get; set; }
        public decimal area { get; set; }
        public DateTime fecha_alcabala { get; set; }
    }
}
