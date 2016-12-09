using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_ConstanciaNoDebe
    {
        public Int32 idConstancia { get; set; }
        public Int32 idPeriodo { get; set; }
        public String Expediente { get; set; }
        public String IdPersona { get; set; }
        public String Transferencia { get; set; }
        public String TramiteRecibo { get; set; }
        public Decimal TramiteImporte { get; set; }
        public String ImpuestoRecibo { get; set; }
        public Decimal ImpuestoImporte { get; set; }
        public String Obligacion { get; set; }
        public String Descripcion { get; set; }
        public Int32 Tipo { get; set; }
        public Decimal Valuo { get; set; }
        public Decimal CompraVenta { get; set; }
        public Decimal UIT { get; set; }
        public Decimal Saldo { get; set; }
        public Decimal Impuesto { get; set; }
        public Boolean estado { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_pc_add { get; set; }
        public String registro_pc_update { get; set; }
        public String registro_user_add { get; set; }
        public String registro_user_update { get; set; }
        public Int32 idAlcabala { get; set; }
        public String Persona { get; set; }
        public String idPredio { get; set; }
    }
}
