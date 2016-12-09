using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;
using SGR.Entity;
namespace SGR.Core.Service
{
    public class Pred_FiscalizacionCtaCteDataService
    {
        Pred_FiscalizacionCtaCteRepository FiscalizacionCtaCteRepository = new Pred_FiscalizacionCtaCteRepository();
        public void GenerarCtaCorrienteParaUnredioFiscaNuevo(string periodoini, string periodofin, string predio_ID, string registro_user, int tipo)
        {
            try
            {
                FiscalizacionCtaCteRepository.GenerarCtaCorrienteParaUnredioFiscaNuevo(periodoini, periodofin, predio_ID, registro_user, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void GenerarCtaCorrienteParaPersonaFiscaNuevo(string periodoini, string periodofin, string persona_ID, string registro_user, int tipo)
        {
            try
            {
                FiscalizacionCtaCteRepository.GenerarCtaCorrienteParaPersonaFiscaNuevo(periodoini, periodofin, persona_ID, registro_user, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
