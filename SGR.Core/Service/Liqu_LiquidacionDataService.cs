using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Core.Repository;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Liqu_LiquidacionDataService
    {

        Liqu_LiquidacionRepository Liqu_deuda = new Liqu_LiquidacionRepository();
        public virtual int Insert(Liqu_Liquidacion liquidacion)
        {
            try
            {
                return Liqu_deuda.Insert(liquidacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Liqu_Liquidacion Insert2(Liqu_Liquidacion liquidacion,string tributo_ID)
        {
            try
            {
                return Liqu_deuda.Insert2(liquidacion,tributo_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void InsertDetalle3(int liquidacion_ID, string persona_ID, string predio_ID,
                    int mes, int anio,string grupo)
        {
            try
            {
                 Liqu_deuda.InsertDetalle3(liquidacion_ID, persona_ID, predio_ID,  mes, anio,grupo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void InsertDetalle4(int liquidacion_ID, string persona_ID, string predio_ID,
                   int mes, int anio, string grupo,decimal restante)
        {
            try
            {
                Liqu_deuda.InsertDetalle4(liquidacion_ID, persona_ID, predio_ID, mes, anio, grupo,restante);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void InsertDetalle5(int liquidacion_ID, string persona_ID, string predio_ID,
                   int mes, int anio, string tributo)
        {
            try
            {
                Liqu_deuda.InsertDetalle5(liquidacion_ID, persona_ID, predio_ID, mes, anio, tributo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void InsertarDetalles(int liquidacion_ID, string persona_ID)
        {
            try
            {
                Liqu_deuda.InsertarDetalles(liquidacion_ID,persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual string InsertDetalle2(int liquidacion_ID,string persona_ID, string predio_ID,
                    string tributo_ID, int mes, int anio, decimal monto)
        {
            try
            {
                return Liqu_deuda.InsertDetalle2(liquidacion_ID,persona_ID, predio_ID, tributo_ID, mes, anio, monto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_Liquidacion> listartodos(string persona)
        {
            try
            {
                return Liqu_deuda.listartodos(persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Liqu_Liquidacion listarPorCodigo(int liquidacion_ID)
        {
            try
            {
                return Liqu_deuda.listarPorCodigo(liquidacion_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        
        public List<Liqu_TributosAfectos> listarTributosAfectos(string persona)
        {
            try
            {
                return Liqu_deuda.listarTributosAfectos(persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Int32> listarRango(string personaID)
        {
            try
            {
                return Liqu_deuda.listarRango(personaID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool eliminarLiquidacion(int liquidacion_ID)
        {
            try
            {
                return Liqu_deuda.eliminarLiquidacion(liquidacion_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool eliminarLiquidacionPendiente()
        {
            try
            {
                return Liqu_deuda.eliminarLiquidacionPendiente();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        
        public virtual void modificarEstado(int liquidacion_ID)
        {
            try
            {
                Liqu_deuda.modificarEstado(liquidacion_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void modificarEstadoFinal(int liquidacion_ID)
        {
            try
            {
                Liqu_deuda.modificarEstadoFinal(liquidacion_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_Liquidacion> listadoLiquidaciones()
        {
            try
            {
                return Liqu_deuda.listadoLiquidaciones();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_Liquidacion> listadoLiquidacionesBusqueda(DateTime fecha_ini, DateTime fecha_fin,
           string estado, string tipo_liqui, string contribuyente)
        { 
            try
            {
                return Liqu_deuda.listadoLiquidacionesBusqueda(fecha_ini,fecha_fin,estado,tipo_liqui,contribuyente);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
}
        }
        public List<Liqu_Deuda> verificarLiquidacio(string persona_ID)
        {
            try
            {
                return Liqu_deuda.verificacionLiquidacion(persona_ID);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_Deuda> verificarLiquidacio2(string persona_ID,string predio_ID)
        {
            try
            {
                return Liqu_deuda.verificacionLiquidacion2(persona_ID,predio_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_Deuda> verificarLiquidacio3(string persona, string predio, string tributos,
            int anio_ini, int anio_fin, int mes_ini, int mes_fin)
        {
            try
            {
                return Liqu_deuda.verificacionLiquidacion3( persona,predio,tributos,anio_ini,anio_fin,mes_ini,mes_fin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_Deuda> mostrarLiquidacion(int liquidacion_ID)
        {
            try
            {
                return Liqu_deuda.mostrarLiquidacion(liquidacion_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_Liquidacion> listarLiquiContribuyente(string persona_ID, Int16 mes, Int16 anio)
        {
            try
            {
                return Liqu_deuda.listarLiquiContribuyente(persona_ID, mes, anio);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Liqu_Liquidacion listarTotalContribuyente(string persona_ID, Int16 mes,Int16 anio)
        {
            try
            {
                return Liqu_deuda.listarTotalesContribuyente(persona_ID, mes, anio);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_Deuda> mostrarLiquidacionTodos(int liquidacion_ID)
        {
            try
            {
                return Liqu_deuda.mostrarLiquidacionTodos(liquidacion_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
