using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_TasaCambio
    {
        public int idTasaCambio { get; set; }
        public DateTime fecha { get; set; }
        public decimal precioVenta { get; set; }
        public decimal precioCompra { get; set; }
        public bool estado { get; set; }
        public DateTime registro_fecha_add{ get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }

        public void compararFecha(string fecha, List<Mant_TasaCambio> lista)
        {
            foreach (Mant_TasaCambio mant_TasaCambio in lista)
                if (fecha.Equals(mant_TasaCambio.fecha.ToString()))
                {
                    throw new Exception("Fecha Existente. Ingrese datos en una Fecha No registrada");
                }
        }
    }
}
