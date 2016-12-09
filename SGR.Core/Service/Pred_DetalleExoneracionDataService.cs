using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Pred_DetalleExoneracionDataService
    {
        Pred_DetalleExoneracionRepository pred_DetalleExoneracionRepository = new Pred_DetalleExoneracionRepository();

        public List<Mant_Mes> listarxExoneracion(Int32 ID)
        {
            try
            {
                return pred_DetalleExoneracionRepository.listarxExoneracion(ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Pred_DetalleExoneracion GetByPrimaryKey(Int32 detalle_exoneracion_id)
        {
            try
            {
                return pred_DetalleExoneracionRepository.GetByPrimaryKey(detalle_exoneracion_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pred_DetalleExoneracion> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return pred_DetalleExoneracionRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Pred_DetalleExoneracion pred_DetalleExoneracion)
        {
            try
            {
                return pred_DetalleExoneracionRepository.Insert(pred_DetalleExoneracion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_DetalleExoneracion pred_DetalleExoneracion)
        {
            try
            {
                pred_DetalleExoneracionRepository.Update(pred_DetalleExoneracion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
