using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Pred_PredioContribuyenteDataService
    {
        Pred_PredioContribuyenteRepository PredioContribuyenteRepository = new Pred_PredioContribuyenteRepository();
        public List<Pred_PredioContribuyente> listartodos()
        {
            try
            {
                return PredioContribuyenteRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_PredioContribuyente> listarByPredioID(String predio_id,Int16 anio)
        {
            try
            {
                return PredioContribuyenteRepository.listarByPredioID(predio_id,anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public virtual Pred_PredioContribuyente GetByPrimaryKey(Int32 Pred_PredioContribuyente_id)
        {
            try
            {
                return PredioContribuyenteRepository.GetByPrimaryKey(Pred_PredioContribuyente_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pred_PredioContribuyente> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return PredioContribuyenteRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Pred_PredioContribuyente Pred_PredioContribuyente)
        {
            try
            {
                return PredioContribuyenteRepository.Insert(Pred_PredioContribuyente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Decimal GetPorcentajexPredio(String PredioId)
        {
            try
            {
                return PredioContribuyenteRepository.GetPorcentajexPredio(PredioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //
        public virtual void Update(Pred_PredioContribuyente Pred_PredioContribuyente)
        {
            try
            {
                PredioContribuyenteRepository.Update(Pred_PredioContribuyente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int InsertParaSubdivision(Pred_PredioContribuyente Pred_PredioContribuyente)
        {
            try
            {
                return PredioContribuyenteRepository.InsertParaSubdivision(Pred_PredioContribuyente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void GuardarPredioContribuyenteEnPredio(String predio_id, string user,Int32 periodo)
        {
            try
            {
                PredioContribuyenteRepository.GuardarPredioContribuyenteEnPredio(predio_id, user,periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//
        public virtual void CancelarPredioContribuyenteEnPredio(string user,Int32 periodo)
        {
            try
            {
                PredioContribuyenteRepository.CancelarPredioContribuyenteEnPredio(user, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool obtenerSISePuedeExonerar(String Predio_id)
        {
            try
            {
                return PredioContribuyenteRepository.obtenerSISePuedeExonerar(Predio_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Pred_PredioContribuyente obtenerSITieneOtroDueño(string Predio_id, string persona_ID,int anio)
        {
            try
            {
                return PredioContribuyenteRepository.obtenerSITieneOtroDueño(Predio_id, persona_ID,anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //public virtual void CopiarPredioContribuyenteMasivo(Int32 periodoantiguo,string user,Int32 periodoactivo)
        //{
        //    try
        //    {
        //        PredioContribuyenteRepository.CopiarPredioContribuyenteMasivo(periodoantiguo, user, periodoactivo);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public List<Pred_PredioContribuyente> listarPorPeriodoContribuyente(int periodo,string persona_ID)
        {
            try
            {
                return PredioContribuyenteRepository.listarPorPeriodoContribuyente(periodo, persona_ID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Pred_Predios detallePredioContribuyente(Int16 periodo, string predio_id)
        {
            try
            {
                return PredioContribuyenteRepository.detallePredioContribuyente(periodo, predio_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Banco> listarPr(string periodo, string persona)
        {
            try
            {
                return PredioContribuyenteRepository.listarPr(periodo, persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int InsertVariosAños(Pred_PredioContribuyente PREDio_COntribuyente, int idPeriodoAntiguo)
        {
            try
            {
                return PredioContribuyenteRepository.InsertVariosAños( PREDio_COntribuyente, idPeriodoAntiguo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void DescargarPredio(string predio, string idPeriodo, string persona, string registro_user)
        {
            try
            {
                PredioContribuyenteRepository.DescargarPredio(predio, idPeriodo, persona, registro_user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
