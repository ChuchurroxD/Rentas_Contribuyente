using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Pred_ValidacionPredioArbitrioDataService
    {
        Pred_ValidacionPredioArbitrioRepository pred_ValidacionPredioArbitrioRepository = new Pred_ValidacionPredioArbitrioRepository();

        public List<Pred_ValidacionPredioArbitrio> ValidarPredioArbitrio(int idPeriodo)
        {
            try
            {
               return  pred_ValidacionPredioArbitrioRepository.ValidarPredioArbitrio(idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pred_ValidacionPredioArbitrio> buscarPredioArbitrio(int idPeriodo, string busqueda)
        {
            try
            {
                return pred_ValidacionPredioArbitrioRepository.buscarPredioArbitrio(idPeriodo, busqueda);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
