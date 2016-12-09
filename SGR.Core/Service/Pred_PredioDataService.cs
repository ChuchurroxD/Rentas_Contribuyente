using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Pred_PredioDataService
    {
        Pred_PredioRepository pred_PredioRepository = new Pred_PredioRepository();
        public List<Pred_Predio> listartodos()
        {
            try
            {
                return pred_PredioRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Pred_Predio GetByPrimaryKey(String predio_ID)
        {
            try
            {
                return pred_PredioRepository.GetByPrimaryKey(predio_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pred_Predio> listarbuscados(String per_id, int periodo)
        {
            try
            {
                return pred_PredioRepository.listarbuscados(per_id, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int GetExisteDescripcionNuevo(String nombre)
        {
            try
            {
                return pred_PredioRepository.GetExisteDescripcionNuevo(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int GetExisteDescripcionModificar(String nombre, String id)
        {
            try
            {
                return pred_PredioRepository.GetExisteDescripcionModificar(nombre, id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool GetExisteId(String id)
        {
            try
            {//si es=0 significa q no existe
                return (pred_PredioRepository.GetExisteId(id) == 0) ? false : true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //
        public virtual string Insert(Pred_Predio Predio, int periodo)
        {
            try
            {
                return pred_PredioRepository.Insert(Predio, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual string InsertTemporal(Pred_Predio Predio, int periodo)
        {
            try
            {
                return pred_PredioRepository.InsertTemporal(Predio, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool DeleteByPrimaryKey(String Predio_id)
        {
            try
            {
                return pred_PredioRepository.DeleteByPrimaryKey(Predio_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void Update(Pred_Predio Predio, int periodo)
        {
            try
            {
                pred_PredioRepository.Update(Predio, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual string InsertPredioSUbdividido(Pred_Predio Predio, String IdPadre)
        {
            try
            {
                return pred_PredioRepository.InsertPredioSUbdividido(Predio, IdPadre);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void EliminarPredioSUbdividido(String id, int tipo)
        {
            try
            {
                pred_PredioRepository.EliminarPredioSUbdividido(id, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Predio> listarerrores(Int32 periodo)
        {
            try
            {
                return pred_PredioRepository.listarerrores(periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void COpiarPredio_Piso_predContribuyente(int anioviejo, int anionuevo, string registro_user)
        {
            try
            {
                pred_PredioRepository.COpiarPredio_Piso_predContribuyente(anioviejo, anionuevo, registro_user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void GenerarPredioMasivo(Int32 periodoantiguo, Int32 periodoactivo, string user)
        {
            try
            {
                pred_PredioRepository.GenerarPredioMasivo(periodoantiguo, periodoactivo, user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Predio> listarPrediosxPersona(String persona)
        {
            try
            {
                return pred_PredioRepository.listarPrediosxPersona(persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pred_Predio> listarPrediosxPerContribuyente(String persona_id)
        {
            try
            {
                return pred_PredioRepository.listarPrediosxPerContribuyente(persona_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int existeDireccion(int junta_via_ID, String num_via, String interior, String mz, String lote, String edificio, String piso, String dpto, String tienda, String cuadra, String km)
        {
            try
            {
                return pred_PredioRepository.existeDireccion(junta_via_ID, num_via, interior, mz, lote, edificio, piso, dpto, tienda, cuadra, km);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int existeDireccionModificar(String predio_id, int junta_via_ID, String num_via, String interior, String mz, String lote, String edificio, String piso, String dpto, String tienda, String cuadra, String km)
        {
            try
            {
                return pred_PredioRepository.existeDireccionModificar(predio_id, junta_via_ID, num_via, interior, mz, lote, edificio, piso, dpto, tienda, cuadra, km);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int existeDireccionSubdividido(String predio_id, String num_via, String interior, String mz, String lote, String edificio, String piso, String dpto, String tienda,string kilometro)
        {
            try
            {
                return pred_PredioRepository.existeDireccionSubdividido(predio_id, num_via, interior, mz, lote, edificio, piso, dpto, tienda,kilometro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Predio> listarPredioSubdividos(String idPadre)
        {
            try
            {
                return pred_PredioRepository.listarPredioSubdividos(idPadre);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Decimal GetArancelSubdividido(String Predio_Global)
        {
            try
            {
                return pred_PredioRepository.GetArancelSubdividido(Predio_Global);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int GenerarCalculoPredialIndividual(String ppersona_id, string registro_user)
        {
            try
            {
                return pred_PredioRepository.GenerarCalculoPredialIndividual(ppersona_id, registro_user);
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }
        public virtual void iniciarTransaccion()
        {
            try
            {
                pred_PredioRepository.iniciarTransaccion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public virtual void comitTransaccion()
        {
            try
            {
                pred_PredioRepository.comitTransaccion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void rollbackTransaccion()
        {
            try
            {
                pred_PredioRepository.rollbackTransaccion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void disposeTransaccion()
        {
            try
            {
                pred_PredioRepository.disposeTransaccion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int ContarPredioContribuyente(String predio_ID)
        {
            try
            {
                return pred_PredioRepository.ContarPredioContribuyente(predio_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual List<Pred_ResumenDeuda> ListarResumenDeuda(String anioIni, String anioFin, String mesIni, String mesFin,
            String cad1, String cad2, String cad3, String cad4, int clase)
        {
            try
            {
                return pred_PredioRepository.ListarResumenDeuda(anioIni, anioFin, mesIni, mesFin, cad1, cad2, cad3, cad4, clase);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Predio> listarHistorialDeUnPRedio(String predio_ID, int periodo)
        {
            try
            {
                return pred_PredioRepository.listarHistorialDeUnPRedio(predio_ID, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual string InsertVariosAños(Pred_Predio Predio, int periodo, int periodoFin)
        {
            try
            {
                return pred_PredioRepository.InsertVariosAños(Predio, periodo, periodoFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void CancelTemporal(string predio_ID_Temporal)//delte el predio temporal
        {
            try
            {
                pred_PredioRepository.CancelTemporal(predio_ID_Temporal);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Predio> listarParaCtaAdeudo(int tipo, string persona, string periodo)
        {
            try
            {
                return pred_PredioRepository.listarParaCtaAdeudo(tipo, persona, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
