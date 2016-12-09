using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Entity;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Pred_Descuentos_ExoneracionDataService
    {
        private static Pred_Descuentos_ExoneracionRepository Pred_Descuentos_ExoneracionRepository = new Pred_Descuentos_ExoneracionRepository();
        public List<Pred_Descuentos_Exoneracion> listartodos(Int32 periodo, String contribuyente_ID)
        {
            try
            {
                return Pred_Descuentos_ExoneracionRepository.listartodos(periodo, contribuyente_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Pred_Descuentos_Exoneracion GetByPrimaryKey(Int32 des_exo_ID)
        {
            try
            {
                return Pred_Descuentos_ExoneracionRepository.GetByPrimaryKey(des_exo_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public virtual int Insert(Pred_Descuentos_Exoneracion Pred_Descuentos_Exoneracion)
        {
            try
            {
                return Pred_Descuentos_ExoneracionRepository.Insert(Pred_Descuentos_Exoneracion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_Descuentos_Exoneracion Pred_Descuentos_Exoneracion)
        {
            try
            {
                Pred_Descuentos_ExoneracionRepository.Update(Pred_Descuentos_Exoneracion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void UpdateCondicion(int condicion, string user, int id)
        {
            try
            {
                Pred_Descuentos_ExoneracionRepository.UpdateCondicion(condicion, user, id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Int32 ExisteCuentaCorrienteParaExoneracion(int mesInicio, int anioInicio, int mesFin, int anioFin, String contribuyente_ID, String tributo_ID)
        {
            try
            {
                return Pred_Descuentos_ExoneracionRepository.ExisteCuentaCorrienteParaExoneracion(mesInicio, anioInicio, mesFin, anioFin, contribuyente_ID, tributo_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual String ExisteParametroParaExoneracion()
        {
            try
            {
                return Pred_Descuentos_ExoneracionRepository.ExisteParametroParaExoneracion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Descuentos_Exoneracion> listarPreExon(string periodo, string razon_social, String tipo_operacion, bool todosAnios)
        {
            try
            {
                return Pred_Descuentos_ExoneracionRepository.listarPreExon(periodo, razon_social, tipo_operacion, todosAnios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
