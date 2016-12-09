using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Pred_CalculoPorPersonaAniosDataService
    {
        Pred_CalculoPorPersonaAniosRepository Pred_CalculoPorPersonaAniosRepository = new Pred_CalculoPorPersonaAniosRepository();
        public List<Pred_UsoGeneral> VerificarParametros(string periodoini, string periodofin, string persona_ID)
        {
            try
            {
                return Pred_CalculoPorPersonaAniosRepository.VerificarParametros(periodoini, periodofin, persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<Pred_UsoGeneral> VerificarParametrosPredial(string periodoini, string periodofin, string persona_ID)
        {
            try
            {
                return Pred_CalculoPorPersonaAniosRepository.VerificarParametrosPredial(periodoini, periodofin, persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<Pred_UsoGeneral> VerificarParametrosArb(string periodoini, string periodofin, string persona_ID)
        {
            try
            {
                return Pred_CalculoPorPersonaAniosRepository.VerificarParametrosArb(periodoini, periodofin, persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void CalculoArbitrioPredial(string periodoini, string periodofin, string persona_ID, string ussser)
        {
            try
            {
                Pred_CalculoPorPersonaAniosRepository.CalculoArbitrioPredial(periodoini, periodofin, persona_ID, ussser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void CalculoArbitrio(string periodoini, string periodofin, string persona_ID, string ussser)
        {
            try
            {
                Pred_CalculoPorPersonaAniosRepository.CalculoArbitrio(periodoini, periodofin, persona_ID, ussser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void CalculoPredial(string periodoini, string periodofin, string persona_ID, string ussser)
        {
            try
            {
                Pred_CalculoPorPersonaAniosRepository.CalculoPredial(periodoini, periodofin, persona_ID, ussser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
