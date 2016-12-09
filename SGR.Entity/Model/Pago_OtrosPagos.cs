using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pago_OtrosPagos
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public decimal monto { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }
        public int indice{ get; set; }
    }
}
