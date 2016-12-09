using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Pred_PisosFisDataService
    {
        Pred_PisosFisRepository pred_PisosRepository = new Pred_PisosFisRepository();

        public List<Pred_Pisos> listarByPredioID(String predio_id, string periodo)
        {
            try
            {
                return pred_PisosRepository.listarByPredioID(predio_id, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int Insert(Pred_Pisos pisos, int periodo)
        {
            try
            {
                return pred_PisosRepository.Insert(pisos, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_Pisos pisos, int periodo)
        {
            try
            {
                pred_PisosRepository.Update(pisos, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
