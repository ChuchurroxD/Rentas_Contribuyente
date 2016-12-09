using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Pred_ConstanciaNoDebeDataService
    {

        Pred_ConstanciaNoDebeRepository Pred_ConstanciaNoDebeRepository = new Pred_ConstanciaNoDebeRepository();

        public List<Pred_ConstanciaNoDebe> listartodos(string persona, int idPeriodo, int tipo)
        {
            try
            {
                return Pred_ConstanciaNoDebeRepository.listartodos(persona, idPeriodo, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int InsertP(Pred_ConstanciaNoDebe ConstanciaNoDebe)
        {
            try
            {
                return Pred_ConstanciaNoDebeRepository.InsertP(ConstanciaNoDebe);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int InsertA(Pred_ConstanciaNoDebe ConstanciaNoDebe)
        {
            try
            {
                return Pred_ConstanciaNoDebeRepository.InsertA(ConstanciaNoDebe);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_ConstanciaNoDebe ConstanciaNoDebe)
        {
            try
            {
                Pred_ConstanciaNoDebeRepository.Update(ConstanciaNoDebe);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update2(Pred_ConstanciaNoDebe ConstanciaNoDebe)
        {
            try
            {
                Pred_ConstanciaNoDebeRepository.Update2(ConstanciaNoDebe);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pred_ConstanciaNoDebe> listarbyPersona(String IdPersona)
        {
            try
            {
                return Pred_ConstanciaNoDebeRepository.listarbyPersona(IdPersona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Pred_ConstanciaNoDebe getByPrimaryKey(int idconstancia)
        {
            try
            {
                return Pred_ConstanciaNoDebeRepository.getByPrimaryKey(idconstancia);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public String getTransferencia()
        {
            try
            {
                return Pred_ConstanciaNoDebeRepository.getTransferencia();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
