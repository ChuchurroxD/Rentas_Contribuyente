using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity;
using SGR.Entity.Model;
namespace SGR.Core.Service
{
    public class Valo_ValoresCobranzaDataService
    {
        private static Valo_ValoresCobranzaRepository valoresDS = new Valo_ValoresCobranzaRepository();
        public void insertarValores3(string persona, int anio1, int anio2, int tipovalor, string usuario)
        {
            try
            {
                valoresDS.insertarValores3(persona, anio1, anio2, tipovalor, usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void enviarCoactivo(int valor, string registro_user_update)
        {
            try
            {
                valoresDS.enviarCoactivo(valor, registro_user_update);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void anular(int valor, string registro_user_update)
        {
            try
            {
                valoresDS.anular(valor, registro_user_update);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void notificar(int valor, string registro_user_update)
        {
            try
            {
                valoresDS.notificar(valor, registro_user_update);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Valo_ResolucionDeterminacionArbitrios> listarGenerados()
        {
            try
            {
                return valoresDS.listarGenerados();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Valo_ResolucionDeterminacionArbitrios> listarNotificados()
        {
            try
            {
                return valoresDS.listarNotificados();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Valo_ResolucionDeterminacionArbitrios> listarVencidos()
        {
            try
            {
                return valoresDS.listarVencidos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Periodo> listarPeriodos(string persona_ID)
        {
            try
            {
                return valoresDS.listarPeriodos(persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Valo_ValorTipoValor> listarValores(string persona_ID, int anio)
        {
            try
            {
                return valoresDS.listarValores(persona_ID, anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Valo_ListadoDeudores> listarMorosidad(int junta, int anio1, int anio2, int nro)
        {
            try
            {
                return valoresDS.listarMorosidad(junta, anio1, anio2, nro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Valo_ValoresCobranza> listarMonto(int junta, int anio1, int anio2, int anio1_, int anio2_, decimal monto1, decimal monto2)
        {
            try
            {
                return valoresDS.listarMonto(junta, anio1, anio2, anio1_, anio2_, monto1, monto2);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Conf_Multitabla> listarTipos()
        {
            try
            {
                return valoresDS.listarTipos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insertarValores(int junta, int anio1, int anio2, int anio1_, int anio2_, decimal monto1,
            decimal monto2, int tipovalor, string usuario)
        {
            try
            {
                valoresDS.insertarValores(junta, anio1, anio2, anio1_, anio2_, monto1, monto2, tipovalor, usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insertarValores2(int junta, int anio1, int anio2, int tipovalor, string usuario, int numero)
        {
            try
            {
                valoresDS.insertarValores2(junta, anio1, anio2, tipovalor, usuario, numero);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Valo_ValoresCobranzas> listarporContribuyente(string persona_ID)
        {
            try
            {
                return valoresDS.listarporContribuyente(persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Valo_ValoresCobranzas> listarporContribuyentePeriodo(string persona_ID, Int32 periodo)
        {
            try
            {
                return valoresDS.listarporContribuyentePeriodo(persona_ID, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Valo_OrdenPago> generarReporte(int anioCurso, string persona_ID, string tipo_valor)
        {
            return valoresDS.generarReporte(anioCurso, persona_ID, tipo_valor);
        }

        public List<RepoGrandesDeudores> listarGrandesDeudores(int junta, int anio1, int anio2, int nro)
        {
            return valoresDS.listarGrandesDeudores(junta, anio1, anio2, nro);
        }
    }
}
