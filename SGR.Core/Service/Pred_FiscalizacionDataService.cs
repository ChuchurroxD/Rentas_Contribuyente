using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;
using SGR.Entity;
namespace SGR.Core.Service
{
    public class Pred_FiscalizacionDataService
    {
        Pred_FiscalizacionRepository FiscalizacionRepository = new Pred_FiscalizacionRepository();

        public List<Pred_Predio> listarpredios(string persona_ID, string idPeriodo)
        {
            try
            {
                return FiscalizacionRepository.listarpredios(persona_ID, idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Predio> listarprediosUltiosHistoricos(String per_id, int periodo)
        {
            try
            {
                return FiscalizacionRepository.listarprediosUltiosHistoricos(per_id, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_Depreciacion> verificarArancelDepreciacion(string predio_ID, string periodoini, string periodofin)
        {
            try
            {
                return FiscalizacionRepository.verificarArancelDepreciacion(predio_ID, periodoini, periodofin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void HacerCambios(string periodoini, string periodofin, string persona_ID, string predio_ID, string usser, string año)
        {
            try
            {
                FiscalizacionRepository.HacerCambios(periodoini, periodofin, persona_ID, predio_ID, usser, año);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Depreciacion> verificarParametroParaCalculoInndividual(string persona_ID)
        {
            try
            {
                return FiscalizacionRepository.verificarParametroParaCalculoInndividual(persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Depreciacion> verificarParametroParaPredioNuevo(string periodo, string predio_ID)
        {
            try
            {
                return FiscalizacionRepository.verificarParametroParaPredioNuevo(periodo, predio_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void GenerarCtaCorrienteIniacial(string periodo, string predio_ID)
        {
            try
            {
                FiscalizacionRepository.GenerarCtaCorrienteIniacial(periodo, predio_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
         
        public List<Pred_Predio> listarprediosAcitvoNoActivo(string persona_ID, string idPeriodo)
        {
            try
            {
                return FiscalizacionRepository.listarprediosAcitvoNoActivo(persona_ID, idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
