using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity;
using SGR.Entity.Model;
namespace SGR.Core.Service
{
    public class Reci_ReciboDataService
    {
        private static Reci_ReciboRepository reciboDS = new Reci_ReciboRepository();

        public List<Reci_Recibo> listarRecibos(string persona, int anio)
        {
            try
            {
                return reciboDS.listarRecibos(persona, anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_Periodo> listarPeriodosRecibos(string persona)
        {
            try
            {
                return reciboDS.listarPeriodosRecibos(persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Reci_ReciboDetalle> listarRecibosImpresion2(int anio, int mes1)
        {
            try
            {
                return reciboDS.listarRecibosImpresion2(anio, mes1);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Reci_ReciboDetalle> listarRecibosImpresion(int anio, int mes1, int mes2, string junta, string TipoGrupo)
        {
            try
            {
                return reciboDS.listarRecibosImpresion(anio, mes1, mes2, junta, TipoGrupo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Reci_ReciboDetalleReporte> cargarRecibo(int periodo, int recibo_ID, int mesProceso, string persona_ID)
        {
            try
            {
                return reciboDS.cargarRecibo(periodo, recibo_ID, mesProceso, persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Reci_ReciboDetalle listarPorCodigo(int periodo_ID, int nroRecibo)
        {
            try
            {
                return reciboDS.listarPorCodigo(periodo_ID, nroRecibo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Reci_ReciboDetalle> listarTodosDetalle(string persona, int anio, int mes1, int mes2)
        {
            try
            {
                return reciboDS.listarTodosDetalle(persona, anio, mes1, mes2);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Reci_Recibo> listarTodos(string junta, int anio, int mes1, int mes2, string TipoGrupo)
        {
            try
            {
                return reciboDS.listarTodos(junta, anio, mes1, mes2, TipoGrupo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void generarRecibosTotal(string junta, int anio, int mes1, int mes2, int elimina)
        {
            try
            {
                reciboDS.generarRecibosTotal(junta, anio, mes1, mes2, elimina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void generarRecibosDetalle(string persona, int anio, int mes1, int mes2, int elimina)
        {
            try
            {
                reciboDS.generarRecibosDetalle(persona, anio, mes1, mes2, elimina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<string> descripcionContribuyente(string codigo, int periodo, int mes1, int mes2)
        {
            try
            {
                return reciboDS.descripcionContribuyente(codigo, periodo, mes1, mes2);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Reci_ReciboDetalle> listarRecibosporContribuyente(string persona_ID, Int16 mes1, Int16 mes2, Int16 anio)
        {
            try
            {
                return reciboDS.listarRecibosporContribuyente(persona_ID, mes1, mes2, anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
