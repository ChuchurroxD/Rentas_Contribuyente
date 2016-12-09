using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Mant_ValoresArbitriosDataService
    {
        Mant_ValoresArbitriosRepository mant_ValoresArbitriosRepository = new Mant_ValoresArbitriosRepository();
        public List<Mant_ValoresArbitrios> listarTodos(Int32 idPeriodo)
        {
            try
            {
                return mant_ValoresArbitriosRepository.listarTodos(idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int ExisteElementosPeriodoAnterior(int tipoConsulta)
        {
            try
            {
                return mant_ValoresArbitriosRepository.ExisteElementosPeriodoAnterior(tipoConsulta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void CopiarElementosPeriodoAnterior(string ussr)
        {
            try
            {
                mant_ValoresArbitriosRepository.CopiarElementosPeriodoAnterior(ussr);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Insert(Mant_ValoresArbitrios mant_ValoresArbitrios)
        {
            mant_ValoresArbitriosRepository.Insert(mant_ValoresArbitrios);
        }

        public void Update(Mant_ValoresArbitrios mant_ValoresArbitrios)
        {
            mant_ValoresArbitriosRepository.Update(mant_ValoresArbitrios);
        }

        public void deletebyprimarykey(int idValorArbitrio)
        {
            mant_ValoresArbitriosRepository.DeleteByPrimaryKey(idValorArbitrio);
        }

    }
}
