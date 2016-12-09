using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
namespace SGR.Core.Service
{
    public class Repo_PredioUrbanoDataService
    {
        Repo_PredioUrbanoRepository repo_PredioUrbanoRepository = new Repo_PredioUrbanoRepository();

        public List<Repo_PredioUrbano> ListarDatosContribuyente(string persona_id)
        {
            try
            {
                return repo_PredioUrbanoRepository.ListarDatosContribuyente(persona_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_PredioUrbano> ListarDatosPredio(string predio_ID,int idPeriodo)
        {
            try
            {
                return repo_PredioUrbanoRepository.ListarDatosPredio(predio_ID,idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Repo_PredioUrbano> ListarImpuestoUrbano(string predio_ID, int idPeriodo)
        {
            try
            {
                return repo_PredioUrbanoRepository.ListarImpuestoUrbano(predio_ID,idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Repo_PredioUrbano> ListarImpuestoUrbanoConFormato(string predio_ID, int idPeriodo)
        {
            try
            {
                return repo_PredioUrbanoRepository.ListarImpuestoUrbanoConFormato(predio_ID, idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Pred_Predio DataPredial(string predio_ID, int idPeriodo)
        {
            try
            {
                return repo_PredioUrbanoRepository.DataPredial(predio_ID, idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
