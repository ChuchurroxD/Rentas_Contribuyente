using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Core.Repository;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Frac_FraccionamientoDataService
    {
        Frac_FraccionamientoRepository frac_Fraccionamiento = new Frac_FraccionamientoRepository();
        public Frac_FraccionamientoDetalle listarParam(int fraccionamiento_ID)
        {
            try
            {
                return frac_Fraccionamiento.listarParam(fraccionamiento_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_CronogramaDetalle> listarFraccTributos(int fraccionamiento_ID)
        {
            try
            {
                return frac_Fraccionamiento.listarFraccTributos(fraccionamiento_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_Cronograma> listarCronograma(int fraccionamiento_ID)
        {
            try
            {
                return frac_Fraccionamiento.listarCronograma(fraccionamiento_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Frac_FraccionamientoDetalle obtenerFraccionamiento(Int32 fraccionamiento_ID)
        {
            try
            {
                return frac_Fraccionamiento.obtenerFraccionamiento(fraccionamiento_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_FraccionamientoListado> listarFraccionamientos(String persona_ID)
        {
            try
            {
                return frac_Fraccionamiento.listarFraccionamientos(persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_Fraccionamiento> listartodos(string persona)
        {
            try
            {
                return frac_Fraccionamiento.listartodos(persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Trib_TipoFraccionamiento> listarFraccionamiento()
        {
            try
            {
                return frac_Fraccionamiento.listarFraccionamiento();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public decimal montoTributo(string persona_ID, int anio_ini, int anio_fin, int mes_ini, int mes_fin, string tributo_ID)
        {
            try
            {
                return frac_Fraccionamiento.montoTributo(persona_ID, anio_ini, anio_fin, mes_ini, mes_fin, tributo_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insertCta(string persona_ID, int anio_ini, int anio_fin, int mes_ini, int mes_fin, string tributo_ID,int fraccionamiento_ID)
        {
            try
            {
                frac_Fraccionamiento.insertCta(persona_ID, anio_ini, anio_fin, mes_ini, mes_fin, tributo_ID, fraccionamiento_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int Insert(Frac_FraccionamientoDetalle fraccionamiento)
        {
            try
            {
                return frac_Fraccionamiento.Insert(fraccionamiento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int InsertDetalle(Frac_Cronograma cronograma)
        {
            try
            {
                return frac_Fraccionamiento.InsertDetalle(cronograma);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int UpdateCouta(Frac_Cronograma cronograma)
        {
            try
            {
                return frac_Fraccionamiento.UpdateCouta(cronograma);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Frac_Fraccionamiento listarPorCodigo(int periodo_ID, int nrConvenio, int NroCuota)
        {
            try
            {
                return frac_Fraccionamiento.listarPorCodigo(periodo_ID, nrConvenio, NroCuota);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Frac_Fraccionamiento listarPorCodigo2(int periodo_ID, int nrConvenio)
        {
            try
            {
                return frac_Fraccionamiento.listarPorCodigo2(periodo_ID, nrConvenio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int validarFraccio(int periodo_ID, int nroConvenio)
        {
            try
            {
                return frac_Fraccionamiento.validarPagoCuota(periodo_ID, nroConvenio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Conf_Multitabla> listarEstadoFraccionamiento()
        {
            try
            {
                Conf_MultitablaDataService Conf_MultitablaDataService = new Conf_MultitablaDataService();
                return Conf_MultitablaDataService.GetCboConf_Multitabla("48");
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_FraccionamientoDetalle> seguimientoFraccionamiento(string contribuyente,Int32 tipofracc,string estadofracc,DateTime fechainicio,DateTime fechafin)
        {
            try
            {
                return frac_Fraccionamiento.seguimientoContribuyente(contribuyente, tipofracc, estadofracc, fechainicio, fechafin);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_FraccionamientoListado2> listarFraccionamientosRecaudacion(int nroCuotas, int nroCuotasVenc, string via,
            int sector, string razonSocial, string estado, int tipoFracc, int periodo, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return frac_Fraccionamiento.listarFraccionamientosRecaudacion( nroCuotas,  nroCuotasVenc,  via,
             sector,  razonSocial,  estado,  tipoFracc,  periodo,  fechaInicio,  fechaFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_FraccionamientoListado2> listarFraccionamientosRecaudacion2(int nroCuotas, int nroCuotasVenc, string via,
            int sector, string razonSocial, string estado, int tipoFracc, int periodo, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return frac_Fraccionamiento.listarFraccionamientosRecaudacion2(nroCuotas, nroCuotasVenc, via,
             sector, razonSocial, estado, tipoFracc, periodo, fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_DeudaFraccionada> listarMontoFraccionado(int nroCuotas, int nroCuotasVenc, string via,
          int sector, string razonSocial, string estado, int tipoFracc, int periodo, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return frac_Fraccionamiento.listarMontoFraccionado(nroCuotas, nroCuotasVenc, via,
             sector, razonSocial, estado, tipoFracc, periodo, fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void anularFraccionamiento(int fraccionamiento_id)
        {
            try
            {
                frac_Fraccionamiento.anularFraccionamiento(fraccionamiento_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_Fraccionamientos> listarfraccinamientoContribuyente(string persona_ID)
        {
            try
            {
                return frac_Fraccionamiento.listarfraccinamientoContribuyente(persona_ID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Frac_Cronogramas> listarCronoContribuyente(Int32 fraccionamiento_ID)
        {
            try
            {
                return frac_Fraccionamiento.listarCronogramaContriFracciona(fraccionamiento_ID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
