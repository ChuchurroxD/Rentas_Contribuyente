using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_TablaArancel
    {
        public int idTablaArancel { get; set; }
        public String Descripcion { get; set; }
        public Decimal Costo { get; set; }
        public Boolean Estado { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public String registro_pc_update { get; set; }

        public void compararDescripcion(string descripcion, List<Mant_TablaArancel> lista)
        {
            foreach (Mant_TablaArancel mant_TablaArancel in lista)
                if (!descripcion.Trim().Equals(mant_TablaArancel.Descripcion.Trim()) && idTablaArancel.Equals(mant_TablaArancel.idTablaArancel))
                {
                    throw new Exception("Ya Existe!!!..,Ingrese otra Descripcion");
                }
        }
    }
}
