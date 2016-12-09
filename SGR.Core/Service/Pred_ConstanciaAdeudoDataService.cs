using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;
namespace SGR.Core.Service
{
    public class Pred_ConstanciaAdeudoDataService
    {
        Pred_ConstanciaAdeudoRepository Pred_ConstanciaAdeudoRepository = new Pred_ConstanciaAdeudoRepository();
        public virtual List<Mant_Mes> listarDeuda(String persona_ID, String tributo_ID, String predio_ID, String grupo_trib)
        {
            try
            {
                return Pred_ConstanciaAdeudoRepository.listarDeuda(persona_ID, tributo_ID,  predio_ID, grupo_trib);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
