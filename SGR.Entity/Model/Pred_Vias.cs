using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;

namespace SGR.Entity.Model
{
    public class Pred_Vias
    {
        public string Via_id { get; set; }
        public string Descripcion { get; set; }
        public string TipoVia { get; set; }
        public bool Estado { get; set; }
        public string CodigoAntiguo { get; set; }
        public string descripcionTipoVia { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }


        public void compararDescripcion(string descripcion, List<Pred_Vias> lista)
        {
            foreach (Pred_Vias pred_Vias in lista)
                if (!descripcion.Trim().Equals(pred_Vias.Descripcion.Trim()) && Via_id.Trim().Equals(pred_Vias.Via_id.Trim()))
                {
                    throw new Exception("Ingrese otra descripcion, la descripcion se repite");
                }
        }
        public void compararCodigoVia(string via_id, List<Pred_Vias> lista)
        {
            foreach (Pred_Vias pred_Vias in lista)
                if (via_id.Trim().Equals(pred_Vias.Via_id.Trim()))
                {
                    throw new Exception("Ingrese otro Código, la Código se repite");
                }
        }
    }
}
