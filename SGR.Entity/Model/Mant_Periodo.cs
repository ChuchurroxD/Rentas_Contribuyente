using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity.Model

{


    public class Mant_Periodo
    {

        public Int32 Peric_canio { get; set; }
        public String Peric_vdescripcion { get; set; }
        public Decimal Peric_euit { get; set; }

        public Decimal Peric_ntasaAlcabala { get; set; }
        public int Peric_iuitAlcabala { get; set; }
        public Decimal Peric_nmoraAlcaba { get; set; }
        public Decimal Interes { get; set; }
        public Decimal FactorOficilizacion { get; set; }
        public Decimal MinimoPredio { get; set; }
        public Decimal TopeUITPension { get; set; }
        public Decimal Formulario { get; set; }
        public bool Peric_bactivo { get; set; }
        public string Tramo1 { get; set; }
        public string Tramo2 { get; set; }
        public string Tramo3 { get; set; }
    }
}

