using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Repo_CajaResumenDataService
    {
        Repo_CajaResumenRepository repo_CajaResumenRepository = new Repo_CajaResumenRepository();

        public List<Repo_CajaResumen> ListarDatosTributos(String FechaDesde, String FechaHasta, Int32 idOficina)
        {
            try
            {
                return repo_CajaResumenRepository.ListarDatosTributos(FechaDesde,FechaHasta,idOficina);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_CajaResumen> ListarDatosCaja(String FechaDesde, String FechaHasta, Int32 idOficina)
        {
            try
            {
                return repo_CajaResumenRepository.ListarDatosCaja(FechaDesde, FechaHasta, idOficina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
