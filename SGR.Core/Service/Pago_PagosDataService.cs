using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Pago_PagosDataService
    {
        Pago_PagosRepository pagos_Pago = new Pago_PagosRepository();
        public void anularPago(string pago_id)
        {
            try
            {
                pagos_Pago.anularPago(pago_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public decimal cargarMontoR(int anio, int recibo_ID)
        {
            try
            {
                return pagos_Pago.cargarMontoR(anio, recibo_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string cargarPaganteR(int anio, int recibo_ID)
        {
            try
            {
                return pagos_Pago.cargarPaganteR(anio, recibo_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public decimal cargarMontoAlcabala(string codigo, int anio, string predio)
        {
            try
            {
                return pagos_Pago.cargarMontoAlcabala(codigo, anio, predio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Periodo> listarPrediosAlcabala(string codigo, int anio)
        {
            try
            {
                return pagos_Pago.listarPrediosAlcabala(codigo, anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Periodo> listarPeriodosAlcabala(string codigo)
        {
            try
            {
                return pagos_Pago.listarPeriodosAlcabala(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string cargarContribuyente(string codigo)
        {
            try
            {
                return pagos_Pago.cargarContribuyente(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int validarPersona(string nombres, string paterno, string materno, string documento)
        {
            return pagos_Pago.validarPersona(nombres, paterno, materno, documento);
        }
        public List<Frac_FraccionamientoListado2> listadoFraccionamientos(string persona_ID)
        {
            try
            {
                return pagos_Pago.listadoFraccionamientos(persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_DeudaFraccionadaDetallada> obtenerCuotas(Int32 fraccionamiento_ID)
        {
            try
            {
                return pagos_Pago.obtenerCuotas(fraccionamiento_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Pago_Parametros obtenerParametros()
        {
            try
            {
                return pagos_Pago.obtenerParametros();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Conf_Multitabla> listarConceptos()
        {
            try
            {
                return pagos_Pago.listarConceptos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        public List<Conf_Multitabla> listarConceptosPlanilla()
        {
            try
            {
                return pagos_Pago.listarConceptosPlanilla();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public decimal valor2(string trib)
        {
            try
            {
                return pagos_Pago.valor2(trib);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public decimal valor(string trib)
        {
            try
            {
                return pagos_Pago.valor(trib);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int registrarPagoRecibo(int recibo_ID,
           string Pagante, decimal MontoTotal, string TipoPago, decimal TasaCambio, int NroCopias,
           int CajeroCaja_Id, bool Estado)
        {
            try
            {
                return pagos_Pago.registrarPagoRecibo(recibo_ID, Pagante, MontoTotal, TipoPago, TasaCambio, NroCopias,
                    CajeroCaja_Id, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual List<Liqu_LiquidacionTributos> cargarTributosPago(int liquidacio_ID)
        {
            try
            {
                return pagos_Pago.cargarTributosPago(liquidacio_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int registrarPagoLiquidacion(int liquidacio_ID,
            string Pagante, decimal MontoTotal, string TipoPago, decimal TasaCambio, int NroCopias,
            int CajeroCaja_Id, string Persona_id, bool Estado)
        {
            try
            {
                return pagos_Pago.registrarPagoLiquidacion(liquidacio_ID, Pagante, MontoTotal, TipoPago, TasaCambio, NroCopias,
                    CajeroCaja_Id, Persona_id, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int registrarPagosOtrosReg(string Pagante, decimal MontoTotal, string TipoPago, decimal TasaCambio, int NroCopias,
                    int CajeroCaja_Id, string Persona_id, bool Estado)
        {
            try
            {
                return pagos_Pago.registrarPagosOtrosReg(Pagante, MontoTotal, TipoPago, TasaCambio, NroCopias,
                    CajeroCaja_Id, Persona_id, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int registrarPagoAlcabala(string Pagante, decimal MontoTotal, string TipoPago, decimal TasaCambio, int NroCopias,
            int CajeroCaja_Id, string Persona_id, bool Estado)
        {
            try
            {
                return pagos_Pago.registrarPagoAlcabala(Pagante, MontoTotal, TipoPago, TasaCambio, NroCopias,
                    CajeroCaja_Id, Persona_id, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int registrarPagosOtros(string Pagante, decimal MontoTotal, string TipoPago, decimal TasaCambio, int NroCopias,
            int CajeroCaja_Id, string Persona_id, bool Estado)
        {
            try
            {
                return pagos_Pago.registrarPagosOtros(Pagante, MontoTotal, TipoPago, TasaCambio, NroCopias,
                    CajeroCaja_Id, Persona_id, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int registrarPagoLiquidacionDetalle(int pago_ID, int formaPago, decimal pagoSoles,
            decimal pagoDolares, string NroDocumento)
        {
            try
            {
                return pagos_Pago.registrarPagoLiquidacionDetalle(pago_ID, formaPago, pagoSoles, pagoDolares, NroDocumento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void actualizarCuentaCorrienteRec(int recibo_ID, int pagos_ID)
        {
            try
            {
                pagos_Pago.actualizarCuentaCorrienteRec(recibo_ID, pagos_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int registrarPersona(string documento, string paterno, string materno, string nombres, string usuario)
        {
            try
            {
                return pagos_Pago.registrarPersona(documento, paterno, materno, nombres, usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void actualizarCuentaCorrienteAlcabala(string predio_ID, string persona_ID, int anio,
            int pagos_ID)
        {
            try
            {
                pagos_Pago.actualizarCuentaCorrienteAlcabala(predio_ID, persona_ID, anio, pagos_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void actualizarCuentaCorrientePagosRegistro(decimal MontoTotal, int pagos_ID,
            int recibo_ID, int anio)
        {
            try
            {
                pagos_Pago.actualizarCuentaCorrientePagosRegistro(MontoTotal, pagos_ID, recibo_ID, anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void actualizarCuentaCorrientePagosOtros(string tributo_ID, int pagos_ID, string concepto, decimal montoTotal, int cantidad)
        {
            try
            {
                pagos_Pago.actualizarCuentaCorrientePagosOtros(tributo_ID, pagos_ID, concepto, montoTotal, cantidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void actualizarCuentaCorrientePagosConceptoAgrupado(string tributo_ID, int pagos_ID)
        {
            try
            {
                pagos_Pago.actualizarCuentaCorrientePagosConceptoAgrupado(tributo_ID, pagos_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void registrarPagoLiquidacionDetalleTributoNuevo(int pago_ID, int detalleLiquidacion)
        {
            try
            {
                pagos_Pago.registrarPagoLiquidacionDetalleTributoNuevo(pago_ID, detalleLiquidacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void registrarPagoLiquidacionDetalleTributo(int liquidacion_ID, int pago_ID)
        {
            try
            {
                pagos_Pago.registrarPagoLiquidacionDetalleTributo(liquidacion_ID, pago_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void actualizarCuentaCorriente(int liquidacion_ID)
        {
            try
            {
                pagos_Pago.actualizarCuentaCorriente(liquidacion_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void actualizarCuentaCorrienteFracc(int fraccionamiento_ID, int nroCuota, int pagos_ID)
        {
            try
            {
                pagos_Pago.actualizarCuentaCorrienteFraccionamiento(fraccionamiento_ID, nroCuota, pagos_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Periodo> listarPeriodos()
        {
            try
            {
                return pagos_Pago.listarPeriodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int validarPagoCuota(int periodo_ID, int nroConvenio, int nroCuota)
        {
            try
            {
                return pagos_Pago.validarPagoCuota(periodo_ID, nroConvenio, nroCuota);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int registrarPagoCuota(int periodo_ID, int nroConvenio, int nroCuota)
        {
            try
            {
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int registrarPagoCuotaInicial(int periodo_ID, int nroConvenio, int nroCuota)
        {
            try
            {
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int registrarPagoFraccionamiento(int fraccionamiento_ID,
         string Pagante, decimal MontoTotal, string TipoPago, decimal TasaCambio, int NroCopias,
         int CajeroCaja_Id, bool Estado)
        {
            try
            {
                return pagos_Pago.registrarPagoFraccionamiento(fraccionamiento_ID, Pagante, MontoTotal, TipoPago, TasaCambio, NroCopias,
                    CajeroCaja_Id, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual List<Pago_ReciboPago> listarRecibo(int pago_id)
        {
            return pagos_Pago.listarRecibo(pago_id);
        }
        public virtual List<Pago_ReciboPago> listarReciboOtrosPagos(int pago_id)
        {
            return pagos_Pago.listarReciboOtrosPagos(pago_id);
        }
    }
}
