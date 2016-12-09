using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Pred_AnulacionDataService
    {
        private static Pred_AnulacionRepository pred_AnulacionRepository = new Pred_AnulacionRepository();

        public List<Pred_Anulacion> listartodos(String tributos_ID, String persona_id, Int32 periodo)
        {
            return pred_AnulacionRepository.listartodos(tributos_ID, persona_id, periodo);
        }

        public virtual int Insert(Pred_Anulacion pred_Anulacion)
        {
            return pred_AnulacionRepository.Insert(pred_Anulacion);
        }

        public List<Mant_Mes> listarxExoneracion(Int32 anulacion_id)
        {
            return pred_AnulacionRepository.listarxExoneracion(anulacion_id);
        }
    }
}
