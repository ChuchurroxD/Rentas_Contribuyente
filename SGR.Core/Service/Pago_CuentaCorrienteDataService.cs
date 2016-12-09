using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Pago_CuentaCorrienteDataService
    {
        Pago_CuentaCorrienteRepository Pago_CuentaCorrienteRepository = new Pago_CuentaCorrienteRepository();

        public List<Pago_CuentaCorriente> listartodos()
        {
            try
            {
                return Pago_CuentaCorrienteRepository.listartodos();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_CuentaCorriente> estadoCuentaContri(string persona_ID)
        {
            try
            {
                return Pago_CuentaCorrienteRepository.estadoCuentaContribuyente(persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Pago_CuentaCorriente estadoCuentaTotal(string persona_ID)
        {
            try
            {
                return Pago_CuentaCorrienteRepository.estadoCuentaTotales(persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_CuentaCorriente> estadoCuentaPorPeriodoTributoCompleto(string persona_ID, string tributo_ID, int periodo, byte tipoConsulta)
        {
            try
            {
                return Pago_CuentaCorrienteRepository.estadoCuentaPorPeriodoTributoCompleto(persona_ID, tributo_ID, periodo, tipoConsulta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_CuentaCorriente> estadoCuentaPorPeriodoTributo(string persona_ID, string tributo_ID, int periodo, byte tipoConsulta)
        {
            try
            {
                return Pago_CuentaCorrienteRepository.estadoCuentaPorPeriodoTributo(persona_ID, tributo_ID, periodo, tipoConsulta);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Pago_CuentaCorriente listaTotalesPorPeriodoTributo(string persona_ID,string tributo_ID,Int32 periodo,byte tipoconsulta)
        {
            try
            {
                return Pago_CuentaCorrienteRepository.listarTotalesPorPeriodoTributo(persona_ID, tributo_ID, periodo, tipoconsulta);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_CuentaCorriente> estadoCuentaCompleto(string persona_ID, string predio_id, string tributo_IDPredio, string tributo_IDArbitrio, string tributo_IDAlcabala, string tributo_IDFormulario, string tributo_IDtodos, int periodo, byte tipoconsulta)
        {
            return Pago_CuentaCorrienteRepository.estadoCuentaCompleto(persona_ID, predio_id, tributo_IDPredio, tributo_IDArbitrio, tributo_IDAlcabala, tributo_IDFormulario, tributo_IDtodos, periodo, tipoconsulta);
        }
        public List<Pago_CuentaCorriente> estadoCuentaPendiente(string persona_ID, string predio_id, string tributo_IDPredio, string tributo_IDArbitrio, string tributo_IDAlcabala, string tributo_IDFormulario, string tributo_IDtodos, int periodo, byte tipoconsulta)
        {
            return Pago_CuentaCorrienteRepository.estadoCuentaPendiente(persona_ID, predio_id, tributo_IDPredio, tributo_IDArbitrio, tributo_IDAlcabala, tributo_IDFormulario, tributo_IDtodos, periodo, tipoconsulta);
        }

        public List<Pago_CuentaCorriente> estadoCuentaValores(string persona_ID)
        {
            return Pago_CuentaCorrienteRepository.estadoCuentaValores(persona_ID);
        }
        public List<Pago_CuentaCorriente> estadoDeuda(string persona_ID)
        {

            //return Pago_CuentaCorrienteRepository.estadoCuentaValores(persona_ID);
            return Pago_CuentaCorrienteRepository.estadoDeuda(persona_ID);
        }

        public List<Pago_CuentaCorriente> estadoDeudaTributos(string persona_ID, string tributo_ID, Int32 anio)
        {
            //return Pago_CuentaCorrienteRepository.estadoCuentaValores(persona_ID);
            return Pago_CuentaCorrienteRepository.estadoDeudaTributos(persona_ID, tributo_ID, anio);
        }

        public List<Pago_CuentaCorriente> estadoCuentaValoresPeriodo(string persona_ID, Int32 periodo)
        {
            return Pago_CuentaCorrienteRepository.estadoCuentaValoresPeriodo(persona_ID, periodo);
        }

        public List<Pred_Predio> listarPrediosxPersona(String per_id, Int32 anio)
        {
            return Pago_CuentaCorrienteRepository.listarPrediosxPersona(per_id, anio);
        }
    }
}
