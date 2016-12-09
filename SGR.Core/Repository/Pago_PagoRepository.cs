using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using System.Data.Common;
using System.Data;

namespace SGR.Core.Repository
{
    public class Pago_PagoRepository
    {
        private const String nombreprocedimiento = "_Pago_Pagos";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Pago_Pago> consultarPagos()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 12);
                var coleccion = new List<Pago_Pago>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Pago
                        {
                            Pagos_ID = lector.GetInt32(lector.GetOrdinal("Pagos_ID")),
                            FechaPago = lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            idPeriodo = lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Pagante = lector.GetString(lector.GetOrdinal("Pagante")),
                            MontoTotal = lector.GetDecimal(lector.GetOrdinal("MontoTotal")),
                            TipoPago = lector.GetString(lector.GetOrdinal("TipoPago")),
                            TasaCambio = lector.GetDecimal(lector.GetOrdinal("TasaCambio")),
                            NroCopias = lector.GetInt32(lector.GetOrdinal("NroCopias")),
                            CajeroCaja_ID = lector.GetInt32(lector.GetOrdinal("CajeroCaja_ID")),
                            CajeroCaja_nombre = lector.GetString(lector.GetOrdinal("CajeroNombre")),
                            Persona_ID = lector.GetString(lector.GetOrdinal("Persona_ID")),
                            liquidacion_ID = lector.GetInt32(lector.GetOrdinal("liquidacion_ID")),
                            fraccionamiento_ID = lector.GetInt32(lector.GetOrdinal("fraccionamiento_ID")),
                            otroReferencia = lector.GetString(lector.GetOrdinal("otroReferencia")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            tipoPago_descripcion = lector.GetString(lector.GetOrdinal("tipoPago_descripcion"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_PagoDetallado> listarPagoDetalle(Int32 pagos_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 13);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pagos_ID);
                var coleccion = new List<Pago_PagoDetallado>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_PagoDetallado
                        {
                            pagos_Det_ID = lector.GetInt32(lector.GetOrdinal("pagos_Det_ID")),
                            Pagos_ID = lector.GetInt32(lector.GetOrdinal("pagos_ID")),
                            FormaPago = lector.GetInt32(lector.GetOrdinal("FormaPago")),
                            FormaPago_descripcion = lector.GetString(lector.GetOrdinal("FormaPago_descripcion")),
                            Pago_Soles = lector.GetDecimal(lector.GetOrdinal("Pago_Soles")),
                            Pago_dolares = lector.GetDecimal(lector.GetOrdinal("Pago_dolares")),
                            NroDocumento = lector.GetString(lector.GetOrdinal("NroDocumento"))

                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_PagoDetalleTributo> listarDetalleTributo(Int32 pago_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 14);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pago_ID);
                var coleccion = new List<Pago_PagoDetalleTributo>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_PagoDetalleTributo
                        {
                            pagos_det_ID = lector.GetInt32(lector.GetOrdinal("pagos_det_ID")),
                            pagos_ID = lector.GetInt32(lector.GetOrdinal("pagos_ID")),
                            monto_pago = lector.GetDecimal(lector.GetOrdinal("monto_pago")),
                            tributos_ID = lector.GetString(lector.GetOrdinal("tributos_ID")),
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            anio = lector.GetInt16(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            cantidad = lector.GetInt16(lector.GetOrdinal("cantidad")),
                            tributo_descripcion = lector.GetString(lector.GetOrdinal("tributo_descripcion"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //public List<Pago_PagoDetalleTributo> reporteTributoMontoAnual(Int16 anio)
        //{
        //    try
        //    {
        //        DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
        //        db.AddInParameter(SQL, "anio", DbType.Int16, anio);
        //        db.AddInParameter(SQL, "tipo", DbType.Byte, 17);
        //        var coleccion = new List<Pago_PagoDetalleTributo>();
        //        using(var lector = db.ExecuteReader(SQL))
        //        {
        //            while (lector.Read())
        //            {
        //                coleccion.Add(new Pago_PagoDetalleTributo
        //                {
        //                    monto_pago = lector.GetDecimal(lector.GetOrdinal("total")),
        //                    tributo_descripcion = lector.GetString(lector.GetOrdinal("tributo"))
        //                });
        //            }
        //        }
        //        SQL.Dispose();
        //        return coleccion;
        //    }catch(Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //}
        public List<Pago_Pago> listarPagosporContribuyenteFechaTipoCajeroCaja(string persona_ID, string tipo_pago, string cajero_Id, Int32 caja_ID, DateTime inicio, DateTime fin)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 26);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "TipoPago", DbType.String, tipo_pago);
                db.AddInParameter(SQL, "cajero_ID", DbType.String, cajero_Id);
                db.AddInParameter(SQL, "caja_ID", DbType.Int32, caja_ID);
                db.AddInParameter(SQL, "fecha_inicio", DbType.Date, inicio);
                db.AddInParameter(SQL, "fecha_fin", DbType.Date, fin);
                var coleccion = new List<Pago_Pago>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Pago
                        {
                            Pagos_ID = lector.GetInt32(lector.GetOrdinal("Pagos_id")),
                            nroRecibo = lector.GetString(lector.GetOrdinal("nro_Recibo")),
                            FechaPago = lector.GetDateTime(lector.GetOrdinal("fechaPago")),
                            hora = lector.GetString(lector.GetOrdinal("hora")),
                            tipo = lector.GetString(lector.GetOrdinal("tipo")),
                            MontoTotal = lector.GetDecimal(lector.GetOrdinal("MontoTotal")),
                            recibo_usado = lector.GetString(lector.GetOrdinal("recibo_usado")),
                            NroCopias = lector.GetInt32(lector.GetOrdinal("NroCopias"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 27);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pago_ID);
                var coleccion = new List<Pago_PagoDetalleTributo>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_PagoDetalleTributo
                        {
                            monto_pago = lector.GetDecimal(lector.GetOrdinal("total")),
                            anio = lector.GetInt16(lector.GetOrdinal("anio")),
                            tributos_ID = lector.GetString(lector.GetOrdinal("tributos_ID")),
                            tributo_descripcion = lector.GetString(lector.GetOrdinal("tributo_descripcion")),
                            ene = lector.GetString(lector.GetOrdinal("enero")),
                            feb = lector.GetString(lector.GetOrdinal("febrero")),
                            mar = lector.GetString(lector.GetOrdinal("marzo")),
                            abr = lector.GetString(lector.GetOrdinal("abril")),
                            may = lector.GetString(lector.GetOrdinal("mayo")),
                            jun = lector.GetString(lector.GetOrdinal("junio")),
                            jul = lector.GetString(lector.GetOrdinal("julio")),
                            ago = lector.GetString(lector.GetOrdinal("agosto")),
                            set = lector.GetString(lector.GetOrdinal("setiembre")),
                            oct = lector.GetString(lector.GetOrdinal("octubre")),
                            nov = lector.GetString(lector.GetOrdinal("noviembre")),
                            dic = lector.GetString(lector.GetOrdinal("diciembre"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 28);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pago_ID);
                decimal total = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total = lector.GetDecimal(lector.GetOrdinal("total"));
                    }
                }
                SQL.Dispose();
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pago_Pago> consultarPagosPorFechaPago(string fechaInicio, string fechaFin)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "fecha_inicio", DbType.String, fechaInicio);
                db.AddInParameter(SQL, "fecha_fin", DbType.String, fechaFin);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 29);
                var coleccion = new List<Pago_Pago>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Pago
                        {
                            Pagos_ID = lector.GetInt32(lector.GetOrdinal("Pagos_ID")),
                            FechaPago = lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            idPeriodo = lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Pagante = lector.GetString(lector.GetOrdinal("Pagante")),
                            MontoTotal = lector.GetDecimal(lector.GetOrdinal("MontoTotal")),
                            TipoPago = lector.GetString(lector.GetOrdinal("TipoPago")),
                            TasaCambio = lector.GetDecimal(lector.GetOrdinal("TasaCambio")),
                            NroCopias = lector.GetInt32(lector.GetOrdinal("NroCopias")),
                            CajeroCaja_ID = lector.GetInt32(lector.GetOrdinal("CajeroCaja_ID")),
                            CajeroCaja_nombre = lector.GetString(lector.GetOrdinal("CajeroNombre")),
                            Persona_ID = lector.GetString(lector.GetOrdinal("Persona_ID")),
                            liquidacion_ID = lector.GetInt32(lector.GetOrdinal("liquidacion_ID")),
                            fraccionamiento_ID = lector.GetInt32(lector.GetOrdinal("fraccionamiento_ID")),
                            otroReferencia = lector.GetString(lector.GetOrdinal("otroReferencia")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            tipoPago_descripcion = lector.GetString(lector.GetOrdinal("tipoPago_descripcion")),
                            recibo_usado = lector.GetString(lector.GetOrdinal("voucher"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pago_Pago> consultarPagoAnular(string voucher)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "cod_voucher", DbType.String, voucher);               
                db.AddInParameter(SQL, "tipo", DbType.Byte, 50);
                var coleccion = new List<Pago_Pago>();
                SQL.CommandTimeout = 600;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Pago
                        {
                            Pagos_ID = lector.GetInt32(lector.GetOrdinal("Pagos_ID")),
                            FechaPago = lector.GetDateTime(lector.GetOrdinal("FechaPago")),                            
                            Pagante = lector.GetString(lector.GetOrdinal("Pagante")),
                            MontoTotal = lector.GetDecimal(lector.GetOrdinal("MontoTotal")),                                                                                                                                            
                            recibo_usado = lector.GetString(lector.GetOrdinal("voucher"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pago_PagoXDeuda> consultarPagosPorFechaDeuda(string fechaInicio, string fechaFin)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "fecha_inicio", DbType.String, fechaInicio);
                db.AddInParameter(SQL, "fecha_fin", DbType.String, fechaFin);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 30);
                var coleccion = new List<Pago_PagoXDeuda>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_PagoXDeuda
                        {
                            pagos_id = lector.GetInt32(lector.GetOrdinal("Pagos_ID")),
                            fechaDeuda = lector.GetString(lector.GetOrdinal("fecha")),
                            periodo_id = lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            persona_id = lector.GetString(lector.GetOrdinal("Persona_id")),
                            pagante = lector.GetString(lector.GetOrdinal("Pagante")),
                            montoPago = lector.GetDecimal(lector.GetOrdinal("monto_pago")),
                            tipoPago = lector.GetString(lector.GetOrdinal("TipoPago")).Trim(),
                            descripcionTipoPago = lector.GetString(lector.GetOrdinal("tipoPago_descripcion")),
                            tasaCambio = lector.GetDecimal(lector.GetOrdinal("TasaCambio")),
                            nroCopias = lector.GetInt32(lector.GetOrdinal("NroCopias")),
                            cajero_id = lector.GetInt32(lector.GetOrdinal("CajeroCaja_ID")),
                            cajeroNombre = lector.GetString(lector.GetOrdinal("CajeroNombre")),                            
                            liquidacion_id = lector.GetInt32(lector.GetOrdinal("liquidacion_ID")),
                            fraccionamiento_id = lector.GetInt32(lector.GetOrdinal("fraccionamiento_ID")),
                            otroReferencia = lector.GetString(lector.GetOrdinal("OtroReferencia")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
