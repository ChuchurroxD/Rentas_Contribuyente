using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Pred_Sector
    {
        public Int32 sector_id { get; set; }
        public string descripcion { get; set; }
        public string tipo_Junta { get; set; }
        public bool barrido { get; set; }
        public bool recojo { get; set; }
        public bool jardin { get; set; }
        public bool serenazgo { get; set; }
        public bool estado { get; set; }
        public DateTime sysFecha { get; set; }
        public string sysUser { get; set; }
        public string descripcionTIpo { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
        //public void compararDescripcion(string descripcion1, List<Pred_Sector> lista)
        //{
        //    foreach (Pred_Sector pred_Sector in lista )
        //    if (descripcion1.Trim().Equals(pred_Sector.descripcion.Trim()))
        //    {
        //       throw new Exception("Ingrese otra descripcion, la descripcion se repite");

        //    }
        //}
    }
}
