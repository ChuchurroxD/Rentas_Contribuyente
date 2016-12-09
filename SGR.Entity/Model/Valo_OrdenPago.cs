using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Valo_OrdenPago
    {
        public string Tributo { get; set; }
        public Int32 anio { get; set; }
        public Decimal baseImponible { get; set; }
        public string tramo { get; set; }
        public string alicuota { get; set; }
        public Decimal insoluto { get; set; }
        public decimal impuestoPredial { get; set; }
        public decimal formulario { get; set; }
        public decimal total { get; set; }
        public string persona { get; set; }
        public string nombres { get; set; }
        public string ruc { get; set; }
        public string dni { get; set; }
        public string fecha_emision { get; set; }
        public string numero { get; set; }
        public string direccion { get; set; }
        public string baseLegal { get; set; }
        public string motDeter { get; set; }
        public string mensaje { get; set; }
    }
}
