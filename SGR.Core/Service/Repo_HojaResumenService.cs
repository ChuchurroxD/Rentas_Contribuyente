using SGR.Core.Repository;
using SGR.Entity;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Repo_HojaResumenService
    {
        Repo_HojaResumenRepository repo_HojaResumenRepository = new Repo_HojaResumenRepository();
        public List<Repo_HojaResumen> listarMontosPagar(string persona_id,int periodo)
        {
            try
            {
                return repo_HojaResumenRepository.listarMontosPagar(persona_id,periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Repo_HojaResumen> listarMontosPagarConFormato(string persona_id, int periodo)
        {
            try
            {
                return repo_HojaResumenRepository.listarMontosPagarConFormato(persona_id, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Repo_HojaResumen> listarDeterminacionImpuesto(string persona_id,int periodo)
        {
            try
            {
                return repo_HojaResumenRepository.listarDeterminacionImpuesto(persona_id,periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pred_Predio> listarPrediosxPerContribuyente(String persona_id, int periodo)
        {
            try
            {
                return repo_HojaResumenRepository.listarPrediosxPerContribuyente(persona_id, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Predio> listarPrediosxPerContribuyenteConFormato(String persona_id, int periodo)
        {
            try
            {
                return repo_HojaResumenRepository.listarPrediosxPerContribuyenteConFormato(persona_id, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
