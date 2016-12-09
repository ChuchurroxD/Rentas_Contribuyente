using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Pred_OtrasIntalacionesDataService
    {
        Pred_OtrasInstalacionesRepository OotrasInstalacionesRepository = new Pred_OtrasInstalacionesRepository();
        public List<Pred_OtrasInstalaciones> listartodos()
        {
            try
            {
                return OotrasInstalacionesRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_OtrasInstalaciones> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return OotrasInstalacionesRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pred_OtrasInstalaciones> listarByPredioId(String predioID)
        {
            try
            {
                return OotrasInstalacionesRepository.listarByPredioID(predioID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//
        public List<Pred_OtrasInstalaciones> listarByPredioIDActivos(String predioID,bool bandera)
        {
            try
            {
                return OotrasInstalacionesRepository.listarByPredioIDActivos(predioID, bandera);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//listarByPredioIDActivos
        public List<Pred_OtrasInstalaciones> GetcoleccionByPredioID(string wheresql, string orderbysql,string PredioID)
        {
            try
            {
                return OotrasInstalacionesRepository.GetcoleccionByPredioID(wheresql, orderbysql,PredioID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Pred_OtrasInstalaciones GetByPrimaryKey(Int32 PrediosOtras_id)
        {
            try
            {
                return OotrasInstalacionesRepository.GetByPrimaryKey(PrediosOtras_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
        public virtual int Insert(Pred_OtrasInstalaciones Pred_OtrasInstalaciones,int priodo)
        {
            try
            {
                return OotrasInstalacionesRepository.Insert(Pred_OtrasInstalaciones, priodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_OtrasInstalaciones Pred_OtrasInstalaciones,int perio)
        {
            try
            {
                OotrasInstalacionesRepository.Update(Pred_OtrasInstalaciones,perio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//
        public virtual void InsertOtrasInstalcionesSubdivision(Pred_OtrasInstalaciones Pred_OtrasInstalaciones)
        {
            try
            {
                OotrasInstalacionesRepository.InsertOtrasInstalcionesSubdivision(Pred_OtrasInstalaciones);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void GuardarOtrasInstalacionEnPredio(String predio_id, string user)
        {
            try
            {
                OotrasInstalacionesRepository.GuardarOtrasInstalacionEnPredio(predio_id, user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//
        public virtual void CancelarOtrasInstalacionEnPredio(string user)
        {
            try
            {
                OotrasInstalacionesRepository.CancelarOtrasInstalacionEnPredio(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void CopiarInstalacionesIndividual(Int32 id, String Predio, int user)
        {
            try
            {
                OotrasInstalacionesRepository.CopiarInstalacionesIndividual( id,  Predio,  user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//
        public int GetExisteNuevo(string clase)
        {
            try
            {
                return OotrasInstalacionesRepository.GetExisteNuevo(clase);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public int GetExisteModificar(string clase, Int32 odigo)
        {
            try
            {
                return OotrasInstalacionesRepository.GetExisteModificar(clase,odigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public virtual int InsertVariosAños(Pred_OtrasInstalaciones Pred_OtrasInstalaciones, int periodo, int periodo_idFin)
        {
            try
            {
                return OotrasInstalacionesRepository.InsertVariosAños(Pred_OtrasInstalaciones, periodo, periodo_idFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
