using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Pred_PrredioArbitrioDataService
    {
        private static Pred_PrredioArbitrioRepository Pred_PrredioArbitrioRepository = new Pred_PrredioArbitrioRepository();
        public List<Pred_PrredioArbitrio> listartodos(String idpre, String idPeriodo)
        {
            try
            {
                return Pred_PrredioArbitrioRepository.listartodos(idpre, idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Pred_PrredioArbitrio GetByPrimaryKey()
        {
            try
            {
                return Pred_PrredioArbitrioRepository.GetByPrimaryKey();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pred_PrredioArbitrio> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return Pred_PrredioArbitrioRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Pred_PrredioArbitrio Pred_PrredioArbitrio)
        {
            try
            {
                return Pred_PrredioArbitrioRepository.Insert(Pred_PrredioArbitrio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_PrredioArbitrio Pred_PrredioArbitrio)
        {
            try
            {
                Pred_PrredioArbitrioRepository.Update(Pred_PrredioArbitrio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void GuardarArbitriosEnPredio(String predio_id, String user)
        {
            try
            {
                Pred_PrredioArbitrioRepository.GuardarArbitriosEnPredio(predio_id, user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void CancelarArbitriosEnPredio(String user)
        {
            try
            {
                Pred_PrredioArbitrioRepository.CancelarArbitriosEnPredio(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void GenerarCalculoIndividual(String predio_id, String user, String per_id)
        {
            try
            {
                Pred_PrredioArbitrioRepository.GenerarCalculoIndividual(predio_id, user, per_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void GenerarCalculoXPersona(String user, String per_id)
        {
            try
            {
                Pred_PrredioArbitrioRepository.GenerarCalculoXPersona(user, per_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void GenerarCalculoMasivo(String user, int anio)
        {
            try
            {
                Pred_PrredioArbitrioRepository.GenerarCalculoMasivo(user, anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void copiarArbitriosDePadreaHijo(String predio_hijo, String predio_padre, String usser)
        {
            try
            {
                Pred_PrredioArbitrioRepository.copiarArbitriosDePadreaHijo(predio_hijo, predio_padre, usser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void copiarArbitrioANteriores(String Predio_id, String usser)
        {
            try
            {
                Pred_PrredioArbitrioRepository.copiarArbitrioANteriores(Predio_id, usser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void copiarArbitriomASIVO(int idPeriodoViejo, int idPeriodonUEVO, String usser)
        {
            try
            {
                Pred_PrredioArbitrioRepository.copiarArbitriomASIVO(idPeriodoViejo, idPeriodonUEVO, usser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void copiarArbitrioPersona(String usser, string per_id)
        {
            try
            {
                Pred_PrredioArbitrioRepository.copiarArbitrioPersona(usser, per_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual List<Mant_TablaArancel> verificarArbitrioANteriores(String Predio_id)
        {
            try
            {
                return Pred_PrredioArbitrioRepository.verificarArbitrioANteriores(Predio_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual List<Mant_TablaArancel> verificarArbitriomASIVO(int idPeriodoViejo, int idPeriodonUEVO)
        {
            try
            {
                return Pred_PrredioArbitrioRepository.verificarArbitriomASIVO(idPeriodoViejo, idPeriodonUEVO);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual List<Mant_TablaArancel> verificarArbitrioPersona(string per_id)
        {
            try
            {
                return Pred_PrredioArbitrioRepository.verificarArbitrioPersona(per_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        public virtual int cantidadArbitrioANteriores(String Predio_id)
        {
            try
            {
                return Pred_PrredioArbitrioRepository.cantidadArbitrioANteriores(Predio_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //public virtual List<Mant_TablaArancel> cantidadArbitriomASIVO(int idPeriodoViejo)
        //{
        //    try
        //    {
        //        return Pred_PrredioArbitrioRepository.cantidadArbitriomASIVO(idPeriodoViejo);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public virtual List<Mant_TablaArancel> cantidadArbitrioPersona(string per_id)
        {
            try
            {
                return Pred_PrredioArbitrioRepository.cantidadArbitrioPersona(per_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int InsertVariosAños(Pred_PrredioArbitrio Pred_PrredioArbitrio, string periodfin)
        {
            try
            {
                return Pred_PrredioArbitrioRepository.InsertVariosAños(Pred_PrredioArbitrio, periodfin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
