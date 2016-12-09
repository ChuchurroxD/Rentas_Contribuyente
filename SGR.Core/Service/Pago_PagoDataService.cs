using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Pago_PagoDataService
    {
        private Pago_PagoRepository Pago_PagoRepository = new Pago_PagoRepository();
        public List<Pago_Pago> consultarPagos()
        {
            try
            {
                return Pago_PagoRepository.consultarPagos();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_PagoDetallado> listarDetallePagos(Int32 pago_ID)
        {
            try
            {
                return Pago_PagoRepository.listarPagoDetalle(pago_ID);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       

        public List<Pago_PagoDetalleTributo> listarDetalleTributo(Int32 pago_ID)
        {
            try
            {
                return Pago_PagoRepository.listarDetalleTributo(pago_ID);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //public List<Pago_PagoDetalleTributo> reporteTributoMontoAnual(Int16 anio)
        //{
        //    try
        //    {
        //        return Pago_PagoRepository.reporteTributoMontoAnual(anio);
        //    }catch(Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public List<Pago_Pago> listarPagoporContribuyenteTipoCajeroCaja(string persona_ID, string cajero_ID, string tipo_pago, Int32 caja_ID,DateTime inicio, DateTime fin)

        {
            try
            {
                return Pago_PagoRepository.listarPagosporContribuyenteFechaTipoCajeroCaja(persona_ID, tipo_pago, cajero_ID, caja_ID,inicio,fin);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Pago_PagoDetalleTributo> listarDetalleTributov2(Int32 pago_ID)
        {
            try
            {
                return Pago_PagoRepository.listarDetalleTributov2(pago_ID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public decimal totalPago(Int32 pago_ID)
        {
            try
            {
                return Pago_PagoRepository.totalPago(pago_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                throw;
            }
        }

        public List<Pago_Pago> consultarPagosPorFechaPago(string fechaInicio, string fechaFin)
        {
            return Pago_PagoRepository.consultarPagosPorFechaPago(fechaInicio, fechaFin);
        }

        public List<Pago_Pago> consultarPagoAnular(string voucher)
        {
            return Pago_PagoRepository.consultarPagoAnular(voucher);
        }

        public List<Pago_PagoXDeuda> consultarPagosPorFechaDeuda(string fechaInicio, string fechaFin)
        {
            return Pago_PagoRepository.consultarPagosPorFechaDeuda(fechaInicio, fechaFin);
        }
    }
}
