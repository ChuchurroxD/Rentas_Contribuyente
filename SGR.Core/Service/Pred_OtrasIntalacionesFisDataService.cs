using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Pred_OtrasIntalacionesFisDataService
    {
        Pred_OtrasInstalacionesFisRepository OotrasInstalacionesRepository = new Pred_OtrasInstalacionesFisRepository();

        public List<Pred_OtrasInstalaciones> listarByPredioID(String predioID, string periodo)
        {
            try
            {
                return OotrasInstalacionesRepository.listarByPredioID(predioID, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//

        public virtual int Insert(Pred_OtrasInstalaciones Pred_OtrasInstalaciones, int priodo)
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

        public virtual void Update(Pred_OtrasInstalaciones Pred_OtrasInstalaciones, int perio)
        {
            try
            {
                OotrasInstalacionesRepository.Update(Pred_OtrasInstalaciones, perio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//

    }
}
