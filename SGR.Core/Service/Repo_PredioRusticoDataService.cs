using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Repo_PredioRusticoDataService
    {
        Repo_PredioRusticoRepository repo_PredioRusticoRepository = new Repo_PredioRusticoRepository();
        public List<Repo_PredioRustico> listarContribuyenteRustico(string persona_id)
        {
            try
            {
                return repo_PredioRusticoRepository.listarContribuyenteRustico(persona_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_PredioRustico> listarPredioRustico(string predio_ID, int idPeriodo)
        {
            try
            {
                return repo_PredioRusticoRepository.ListarPredioRustico(predio_ID,idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_PredioRustico> ListarImpuestoRustico(string predio_ID, int idPeriodo)
        {
            try
            {
                return repo_PredioRusticoRepository.ListarImpuestoRustico(predio_ID,idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Repo_PredioRustico> ListarImpuestoRusticoConFormato(string predio_ID, int idPeriodo)
        {
            try
            {
                return repo_PredioRusticoRepository.ListarImpuestoRusticoConFormato(predio_ID, idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
