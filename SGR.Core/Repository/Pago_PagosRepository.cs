using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Entity;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace SGR.Core.Repository
{
    public class Pago_PagosRepository
    {
        private const String nombreprocedimiento = "_Pago_Pagos";
        private Database db = DatabaseFactory.CreateDatabase();

        public void anularPago(string pago_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "cod_voucher", DbType.String, pago_id);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 46);
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public decimal cargarCaja(int anio, int recibo_ID)
        {
            try
            {
                decimal resultado = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "recibo_ID", DbType.String, recibo_ID);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 38);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        resultado = lector.GetDecimal(lector.GetOrdinal("cargo"));
                    }
                }
                SQL.Dispose();
                return resultado;
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
                decimal resultado = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "recibo_ID", DbType.String, recibo_ID);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 38);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        resultado = lector.GetDecimal(lector.GetOrdinal("cargo"));
                    }
                }
                SQL.Dispose();
                return resultado;
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
                string resultado = "";
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "recibo_ID", DbType.String, recibo_ID);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 37);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        resultado = lector.GetString(lector.GetOrdinal("razon_social"));
                    }
                }
                SQL.Dispose();
                return resultado;
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
                decimal resultado = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_ID", DbType.String, codigo);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 36);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        resultado = lector.GetDecimal(lector.GetOrdinal("cargo"));
                    }
                }
                SQL.Dispose();
                return resultado;
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
                var coleccion = new List<Mant_Periodo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 35);
                db.AddInParameter(SQL, "persona_ID", DbType.String, codigo);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                //modificar de acuerdo a tipo de  consulta

                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Periodo
                        {
                            Peric_vdescripcion = lector.GetString(lector.GetOrdinal("predio"))
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
        public List<Mant_Periodo> listarPeriodosAlcabala(string codigo)
        {
            try
            {
                var coleccion = new List<Mant_Periodo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 34);
                db.AddInParameter(SQL, "persona_ID", DbType.String, codigo);
                //modificar de acuerdo a tipo de  consulta

                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Periodo
                        {
                            Peric_canio = lector.GetInt32(lector.GetOrdinal("anioGeneracion"))
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
        public string cargarContribuyente(string codigo)
        {
            try
            {
                string resultado = "";
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_ID", DbType.String, codigo);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 33);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        resultado = lector.GetString(lector.GetOrdinal("razon_social"));
                    }
                }
                SQL.Dispose();
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int validarPersona(string nombres, string paterno, string materno, string documento)
        {
            try
            {
                int resultado = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "nombres", DbType.String, nombres);
                db.AddInParameter(SQL, "paterno", DbType.String, paterno);
                db.AddInParameter(SQL, "materno", DbType.String, materno);
                db.AddInParameter(SQL, "documento", DbType.String, documento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 25);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        resultado = lector.GetInt32(lector.GetOrdinal("resultado"));
                    }
                }
                SQL.Dispose();
                return resultado;
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
                var coleccion = new List<Frac_DeudaFraccionadaDetallada>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 24);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.String, fraccionamiento_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_DeudaFraccionadaDetallada
                        {
                            numeroCuota = lector.GetInt32(lector.GetOrdinal("NroCuota")),
                            valorCuota = lector.GetDecimal(lector.GetOrdinal("Importe")),
                            fechaVencimiento = lector.GetDateTime(lector.GetOrdinal("FechaVence"))
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
        public List<Frac_FraccionamientoListado2> listadoFraccionamientos(string persona_ID)
        {
            try
            {

                var coleccion = new List<Frac_FraccionamientoListado2>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 23);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_FraccionamientoListado2
                        {
                            fraccionamiento_id = lector.GetInt32(lector.GetOrdinal("fraccionamiento_id")),
                            fechaAcogida = lector.GetDateTime(lector.GetOrdinal("Fecha_Acogida")),
                            nroCuotas = lector.GetInt32(lector.GetOrdinal("Cuotas")),
                            cuota = lector.GetDecimal(lector.GetOrdinal("ValorCuota")),
                            cuotasVencidas = lector.GetInt32(lector.GetOrdinal("cuotasVencidas"))
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
        public virtual Pago_Parametros obtenerParametros()
        {
            try
            {
                Pago_Parametros elemento = new Pago_Parametros();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 1);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        elemento = (new Pago_Parametros
                        {
                            fecha = lector.GetDateTime(lector.GetOrdinal("fecha")),
                            precioVenta = lector.GetDecimal(lector.GetOrdinal("precioVenta"))
                        });
                    }
                }
                SQL.Dispose();
                return elemento;
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
                decimal importe = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributo", DbType.String, trib);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 31);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        importe = lector.GetDecimal(lector.GetOrdinal("importe"));
                    }
                }
                SQL.Dispose();
                return importe;
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
                decimal importe = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributo", DbType.String, trib);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 19);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        importe = lector.GetDecimal(lector.GetOrdinal("importe"));
                    }
                }
                SQL.Dispose();
                return importe;
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
                var coleccion = new List<Conf_Multitabla>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 18);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Conf_Multitabla
                        {
                            Multc_cValor = lector.GetString(lector.GetOrdinal("codigo")),
                            Multc_vDescripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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

        public List<Conf_Multitabla> listarConceptosPlanilla()
        {
            try
            {
                var coleccion = new List<Conf_Multitabla>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 49);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Conf_Multitabla
                        {
                            Multc_cValor = lector.GetString(lector.GetOrdinal("codigo")),
                            Multc_vDescripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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

        public virtual int registrarPagoRecibo(int recibo_ID,
            string Pagante, decimal MontoTotal, string TipoPago, decimal TasaCambio, int NroCopias,
            int CajeroCaja_Id, bool Estado)
        {
            try
            {
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "recibo_ID", DbType.Int32, recibo_ID);
                db.AddInParameter(SQL, "Pagante", DbType.String, Pagante);
                db.AddInParameter(SQL, "MontoTotal", DbType.Decimal, MontoTotal);
                db.AddInParameter(SQL, "TipoPago", DbType.String, TipoPago);
                db.AddInParameter(SQL, "TasaCambio", DbType.Decimal, TasaCambio);
                //db.AddInParameter(SQL, "NroCopias", DbType.Int32, NroCopias);
                db.AddInParameter(SQL, "CajeroCaja_Id", DbType.Int32, CajeroCaja_Id);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, Estado);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 15);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
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
                List<Liqu_LiquidacionTributos> coleccion = new List<Liqu_LiquidacionTributos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacio_ID);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 44);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_LiquidacionTributos
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("Cuenta_Corriente_ID")),
                            detalleLiquidacion = lector.GetInt32(lector.GetOrdinal("DetalleLiquidacion")),
                            montoPago = lector.GetDecimal(lector.GetOrdinal("MontoPago")),
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

        public virtual int registrarPagoLiquidacion(int liquidacio_ID,
            string Pagante, decimal MontoTotal, string TipoPago, decimal TasaCambio, int NroCopias,
            int CajeroCaja_Id, string Persona_id, bool Estado)
        {
            try
            {
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacio_ID);
                db.AddInParameter(SQL, "Pagante", DbType.String, Pagante);
                db.AddInParameter(SQL, "MontoTotal", DbType.Decimal, MontoTotal);
                db.AddInParameter(SQL, "TipoPago", DbType.String, TipoPago);
                db.AddInParameter(SQL, "TasaCambio", DbType.Decimal, TasaCambio);
                //db.AddInParameter(SQL, "NroCopias", DbType.Int32, NroCopias);
                db.AddInParameter(SQL, "CajeroCaja_Id", DbType.Int32, CajeroCaja_Id);
                db.AddInParameter(SQL, "Persona_id", DbType.String, Persona_id);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, Estado);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
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
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Pagante", DbType.String, Pagante);
                db.AddInParameter(SQL, "MontoTotal", DbType.Decimal, MontoTotal);
                db.AddInParameter(SQL, "TipoPago", DbType.String, TipoPago);
                db.AddInParameter(SQL, "TasaCambio", DbType.Decimal, TasaCambio);
                //db.AddInParameter(SQL, "NroCopias", DbType.Int32, NroCopias);
                db.AddInParameter(SQL, "CajeroCaja_Id", DbType.Int32, CajeroCaja_Id);
                db.AddInParameter(SQL, "Persona_id", DbType.String, Persona_id);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, Estado);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 20);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
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
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Pagante", DbType.String, Pagante);
                db.AddInParameter(SQL, "MontoTotal", DbType.Decimal, MontoTotal);
                db.AddInParameter(SQL, "TipoPago", DbType.String, TipoPago);
                db.AddInParameter(SQL, "TasaCambio", DbType.Decimal, TasaCambio);
                //db.AddInParameter(SQL, "NroCopias", DbType.Int32, NroCopias);
                db.AddInParameter(SQL, "CajeroCaja_Id", DbType.Int32, CajeroCaja_Id);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, Estado);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 42);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
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
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Pagante", DbType.String, Pagante);
                db.AddInParameter(SQL, "MontoTotal", DbType.Decimal, MontoTotal);
                db.AddInParameter(SQL, "TipoPago", DbType.String, TipoPago);
                db.AddInParameter(SQL, "TasaCambio", DbType.Decimal, TasaCambio);
                db.AddInParameter(SQL, "CajeroCaja_Id", DbType.Int32, CajeroCaja_Id);
                db.AddInParameter(SQL, "Persona_id", DbType.String, Persona_id);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, Estado);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 39);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
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
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "documento", DbType.String, documento);
                db.AddInParameter(SQL, "paterno", DbType.String, paterno);
                db.AddInParameter(SQL, "materno", DbType.String, materno);
                db.AddInParameter(SQL, "nombres", DbType.String, nombres);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 22);
                db.AddInParameter(SQL, "usuario", DbType.String, usuario);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
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
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pago_ID);
                db.AddInParameter(SQL, "formaPago", DbType.String, formaPago);
                db.AddInParameter(SQL, "pagoSoles", DbType.Decimal, pagoSoles);
                db.AddInParameter(SQL, "pagoDolares", DbType.Decimal, pagoDolares);
                db.AddInParameter(SQL, "NroDocumento", DbType.String, NroDocumento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 3);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pago_ID);
                db.AddInParameter(SQL, "detalleLiquidacion", DbType.Int32, detalleLiquidacion);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 45);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al Registrar Pago");
                }
                SQL.Dispose();
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pago_ID);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al Registrar Pago");
                }
                SQL.Dispose();
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 5);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al Registrar Pago");
                }
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void actualizarCuentaCorrienteFraccionamiento(int fraccionamiento_ID, int nroCuota, int pagos_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.Int32, fraccionamiento_ID);
                db.AddInParameter(SQL, "nroCuota", DbType.Int32, nroCuota);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pagos_ID);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 9);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al Registrar Pago");
                }
                SQL.Dispose();
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "recibo_ID", DbType.Int32, recibo_ID);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pagos_ID);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 16);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al Registrar Pago");
                }
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void actualizarCuentaCorrientePagosOtros(string tributo_ID, int pagos_ID, string concepto, decimal monto, int cantidad)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributo", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "MontoTotal", DbType.Decimal, monto);
                db.AddInParameter(SQL, "concepto", DbType.String, concepto);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pagos_ID);
                db.AddInParameter(SQL, "cantidad", DbType.Int32, cantidad);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 21);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al Registrar Pago");
                }
                SQL.Dispose();
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pagos_ID);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 41);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al Registrar Pago");
                }
                SQL.Dispose();
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributo", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pagos_ID);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 32);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al Registrar Pago");
                }
                SQL.Dispose();
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "MontoTotal", DbType.Decimal, MontoTotal);
                db.AddInParameter(SQL, "pago_ID", DbType.Int32, pagos_ID);
                db.AddInParameter(SQL, "recibo_ID", DbType.Int32, recibo_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "TIPO", DbType.Int32, 43);
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
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
                var coleccion = new List<Mant_Periodo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 6);//modificar de acuerdo a tipo de  consulta

                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Periodo
                        {
                            Peric_canio = lector.GetInt16(lector.GetOrdinal("idPeriodo"))
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

        public int validarPagoCuota(int periodo_ID, int nroConvenio, int nroCuota)
        {
            try
            {
                int resultado = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 7);
                db.AddInParameter(SQL, "periodo_ID", DbType.Int32, periodo_ID);
                db.AddInParameter(SQL, "nroConvenio", DbType.Int32, nroConvenio);
                db.AddInParameter(SQL, "nroCuota", DbType.Int32, nroCuota);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        resultado = lector.GetInt32(lector.GetOrdinal("resultado"));
                    }
                }
                SQL.Dispose();
                return resultado;
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
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.Int32, fraccionamiento_ID);
                db.AddInParameter(SQL, "Pagante", DbType.String, Pagante);
                db.AddInParameter(SQL, "MontoTotal", DbType.Decimal, MontoTotal);
                db.AddInParameter(SQL, "TipoPago", DbType.String, TipoPago);
                db.AddInParameter(SQL, "TasaCambio", DbType.Decimal, TasaCambio);
                //db.AddInParameter(SQL, "NroCopias", DbType.Int32, NroCopias);
                db.AddInParameter(SQL, "CajeroCaja_Id", DbType.Int32, CajeroCaja_Id);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, Estado);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 10);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual List<Pago_ReciboPago> listarReciboOtrosPagos(int pago_id)
        {
            try
            {
                var coleccion = new List<Pago_ReciboPago>();
                DbCommand SQL = db.GetStoredProcCommand("_Repo_ReciboIngreso");
                db.AddInParameter(SQL, "pago_id", DbType.Int32, pago_id);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 2);//modificar de acuerdo a tipo de  consulta

                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_ReciboPago
                        {
                            codigoPersona = lector.GetString(lector.GetOrdinal("CÓDIGO PERSONA")).Trim(),
                            nombreCompleto = lector.IsDBNull(lector.GetOrdinal("NOMBRE COMPLETO")) ? default(String) : lector.GetString(lector.GetOrdinal("NOMBRE COMPLETO")),
                            direccion = lector.IsDBNull(lector.GetOrdinal("DIRECCIÓN")) ? default(String) : lector.GetString(lector.GetOrdinal("DIRECCIÓN")),
                            codigoPago = lector.GetString(lector.GetOrdinal("CÓDIGO PAGO")),
                            especifica = lector.IsDBNull(lector.GetOrdinal("ESPECIFICA")) ? default(String) : lector.GetString(lector.GetOrdinal("ESPECIFICA")),
                            concepto = lector.IsDBNull(lector.GetOrdinal("CONCEPTO")) ? default(String) : lector.GetString(lector.GetOrdinal("CONCEPTO")),
                            importe = lector.GetDecimal(lector.GetOrdinal("IMPORTE")),
                            pagoDesc = lector.GetString(lector.GetOrdinal("pagoDesc"))
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
        public virtual List<Pago_ReciboPago> listarRecibo(int pago_id)
        {
            try
            {
                var coleccion = new List<Pago_ReciboPago>();
                DbCommand SQL = db.GetStoredProcCommand("_Repo_ReciboIngreso");
                db.AddInParameter(SQL, "pago_id", DbType.Int32, pago_id);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 1);//modificar de acuerdo a tipo de  consulta

                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_ReciboPago
                        {
                            codigoPersona = lector.GetString(lector.GetOrdinal("CÓDIGO PERSONA")).Trim(),
                            nombreCompleto = lector.IsDBNull(lector.GetOrdinal("NOMBRE COMPLETO")) ? default(String) : lector.GetString(lector.GetOrdinal("NOMBRE COMPLETO")),
                            direccion = lector.IsDBNull(lector.GetOrdinal("DIRECCIÓN")) ? default(String) : lector.GetString(lector.GetOrdinal("DIRECCIÓN")),
                            codigoPago = lector.GetString(lector.GetOrdinal("CÓDIGO PAGO")),
                            especifica = lector.IsDBNull(lector.GetOrdinal("ESPECIFICA")) ? default(String) : lector.GetString(lector.GetOrdinal("ESPECIFICA")),
                            concepto = lector.IsDBNull(lector.GetOrdinal("CONCEPTO")) ? default(String) : lector.GetString(lector.GetOrdinal("CONCEPTO")),
                            importe = lector.GetDecimal(lector.GetOrdinal("IMPORTE")),
                            pagoDesc = lector.GetString(lector.GetOrdinal("pagoDesc"))
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
