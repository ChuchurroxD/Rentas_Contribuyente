using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Mant_RecaudacionPorOficinaDataService
    {
        Mant_RecaudacionPorOficinaRepository mant_RecaudacionPorOficinaRepository = new Mant_RecaudacionPorOficinaRepository();
        public List<Mant_RecaudacionPorOficina> listarTodos(String oficina_id)
        {
            try
            {
                return mant_RecaudacionPorOficinaRepository.listarTodos(oficina_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_RecaudacionPorOficina> listarPorPeriodoDesdeHasta(int PeriodoDesde,int PeriodoHasta,int oficina_id)
        {
            try
            {
                return mant_RecaudacionPorOficinaRepository.listarPorPeriodoDesdeHasta(PeriodoDesde,PeriodoHasta, oficina_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
