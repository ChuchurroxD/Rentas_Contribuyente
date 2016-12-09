using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Frac_FraccionamientoDetalle
    {
        public Int32 fraccionamiento_id { get; set; }
        public Int32 idPeriodo { get; set; }
        public Int32 Numero { get; set; }
        public DateTime Fecha_Acogida { get; set; }
        public Int32 idPeriodoInicio { get; set; }
        public Int32 idPeriodoFin { get; set; }
        public decimal Deuda_Total { get; set; }
        public decimal Inicial { get; set; }
        public decimal Saldo { get; set; }
        public decimal Descuento { get; set; }
        public decimal Interes { get; set; }
        public Int32 Cuotas { get; set; }
        public decimal ValorCuota { get; set; }
        public String Estado { get; set; }
        public Int32 tipo_fraccionamiento_ID { get; set; }
        public String Persona_id { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
        public Int32 anio_inicio { get; set; }
        public Int32 anio_fin { get; set; }
    }
}
