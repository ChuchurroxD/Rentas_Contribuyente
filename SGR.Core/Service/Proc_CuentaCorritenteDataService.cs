using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Proc_CuentaCorritenteDataService
    {
        private static Proc_CuentaCorritenteRepository Proc_CuentaCorritenteRepository = new Proc_CuentaCorritenteRepository();
        public List<Proc_CuentaCorritente> listarPredialArbIndiv(String persona, string tributo_ID,int tipo,string predio_id)
        {
            try
            {
                return Proc_CuentaCorritenteRepository.listarPredialArbIndiv(persona, tributo_ID, tipo, predio_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Proc_CuentaCorritente> listarPredialArbxPersona(String persona, string tributo_ID)
        {
            try
            {
                return Proc_CuentaCorritenteRepository.listarPredialArbxPersona(persona, tributo_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Decimal VerificarExisteCtaCTeIndividual(String persona, string tributo_ID, int tipo,string predio_id)
        {
            try
            {
                return Proc_CuentaCorritenteRepository.VerificarExisteCtaCTeIndividual(persona, tributo_ID, tipo, predio_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Decimal VerificarExisteCtaCTe(int anio, int tipo)
        {
            try
            {
                return Proc_CuentaCorritenteRepository.VerificarExisteCtaCTe(anio, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Decimal VerificarExisteCtaCTeEntreAnios(int anioini, int aniofin)
        {
            try
            {
                return Proc_CuentaCorritenteRepository.VerificarExisteCtaCTeEntreAnios(anioini, aniofin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
