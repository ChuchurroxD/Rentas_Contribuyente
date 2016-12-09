using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Rep_Estadistico1
    {
        public string mes { get; set; }
        public decimal CargoPredio { get; set; }
        public decimal AbonoPredio { get; set; }
        public decimal SaldoPredio { get; set; }
        public decimal CargoArbitrio { get; set; }
        public decimal AbonoArbitrio { get; set; }
        public decimal SaldoArbitrio { get; set; }
        public decimal CargoOtros { get; set; }
        public decimal AbonoOtros { get; set; }
        public decimal SaldoOtros { get; set; }
        public decimal TotalCargo { get; set; }
        public decimal TotalAbono { get; set; }
        public decimal TotalSaldo { get; set; }
        public decimal Cobrado { get; set; }
        public decimal Morosidad { get; set; }
        public decimal CobradoPredio { get; set; }
        public decimal MorosidadPredio { get; set; }
        public decimal CobradoArbitrio { get; set; }
        public decimal MorosidadArbitrio { get; set; }
        public Int32 nro { get; set; }
        public Int32 Periodo { get; set; }
        public decimal ImpuestoPredial { get; set; }
        public decimal ArbitriosMunicipales { get; set; }
        public decimal ImpuestoAlcabala { get; set; }
        public decimal Multas { get; set; }

        public decimal Predial { get; set; }
        public decimal PredialAnterior { get; set; }
        public decimal Arbitrios { get; set; }
        public decimal Alcabala { get; set; }
        public decimal TotalMes { get; set; }

    }
}
