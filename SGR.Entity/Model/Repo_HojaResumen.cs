using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Repo_HojaResumen
    {
        public int total_Predios { get; set; }
        public decimal cuota_Trimestral { get; set; }
        public decimal impuesto_Anual { get; set; }
        public decimal baseImponible { get; set; }
        public decimal prediosAfecto { get; set; }
        public int cuota { get; set; }
        public DateTime vencimiento { get; set; }
        public decimal montoinsoluto { get; set; }
        public int derechoemision { get; set; }
        public decimal reajuste { get; set; }
        public decimal totalpagar { get; set; }
    }
}
