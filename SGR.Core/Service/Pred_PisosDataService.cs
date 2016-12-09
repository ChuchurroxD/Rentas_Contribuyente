using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Pred_PisosDataService
    {
        Pred_PisosRepository pred_PisosRepository = new Pred_PisosRepository();
        public List<Pred_Pisos> listartodos()
        {
            try
            {
                return pred_PisosRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Pisos> listarByPredioID(String predio_id)
        {
            try
            {
                return pred_PisosRepository.listarByPredioID(predio_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Pisos> listarByPredioIDActivos(String predio_ID, Boolean bandera)
        {
            try
            {
                return pred_PisosRepository.listarByPredioIDActivos(predio_ID, bandera);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //listarByPredioIDActivos(String predio_ID,Boolean bandera)
        public virtual Pred_Pisos GetByPrimaryKey(Int32 piso_ID)
        {
            try
            {
                return pred_PisosRepository.GetByPrimaryKey(piso_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pred_Pisos> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return pred_PisosRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Pred_Pisos pisos,int periodo)
        {
            try
            {
                return pred_PisosRepository.Insert(pisos,periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_Pisos pisos,int periodo)
        {
            try
            {
                pred_PisosRepository.Update(pisos,periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
            public virtual void InsertPisoSubdivision(Pred_Pisos pisos)
        {
            try
            {
                 pred_PisosRepository.InsertPisoSubdivision(pisos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void GuardarPisosEnPredio(String predio_id, String user)
        {
            try
            {
                pred_PisosRepository.GuardarPisosEnPredio(predio_id, user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//
        public virtual void CancelarPisosEnPredio(String user)
        {
            try
            {
                pred_PisosRepository.CancelarPisosEnPredio(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//
        public virtual void CopiarPisoIndividual(int piso_id, String Predio, decimal areaComun, String persona_id, string user)
        {
            try
            {
                pred_PisosRepository.CopiarPisoIndividual(piso_id, Predio, areaComun, persona_id, user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//CopiarPisoIndividual(int piso_id,String Predio,decimal areaComun,String persona_id,int user)
        public List<Pred_Pisos> pisoPredioContribuyente(Int16 periodo, string predio_ID)
        {
            try
            {
                return pred_PisosRepository.listarPisosPredioContribuyente(periodo, predio_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int InsertVariosAños(Pred_Pisos pisos, int periodo, int periodo_idFin)
        {
            try
            {
                return pred_PisosRepository.InsertVariosAños(pisos, periodo, periodo_idFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
