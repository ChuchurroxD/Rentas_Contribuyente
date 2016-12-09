using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Valo_ValoresCobranzaDetalleJunta
    {
        public int recibo_id { get; set; }
        public int periodo { get; set; }
        public string tributo_ID{ get; set; }
        public string abrev { get; set; }
        public decimal DeudaAnt{ get; set; }
        public string mes { get; set; }
        public string tipo { get; set; }
        public string peri { get; set; }
        public string Peri2 { get; set; }
        public string nombres { get; set; }
        public string domicilio { get; set; }
        public string junta { get; set; }
        public string fechaEmision { get; set; }
        public string FechaVence { get; set; }
    }
}
