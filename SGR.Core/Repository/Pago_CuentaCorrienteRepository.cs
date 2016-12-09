using Microsoft.Practices.EnterpriseLibrary.Data;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using SGR.Entity;

namespace SGR.Core.Repository
{
    public class Pago_CuentaCorrienteRepository
    {
        private const String nombreprocedimiento = "_Pago_CuentaCorriente";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Pago_CuentaCorriente> listartodos()
        {
            try
            {
                var coleccion = new List<Pago_CuentaCorriente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_CuentaCorriente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.IsDBNull(lector.GetOrdinal("predio_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            cargo = lector.GetDecimal(lector.GetOrdinal("cargo")),
                            abono = lector.GetDecimal(lector.GetOrdinal("abono")),
                            fecha_cancelacion = lector.IsDBNull(lector.GetOrdinal("fecha_cancelacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_cancelacion")),
                            observaciones = lector.IsDBNull(lector.GetOrdinal("observaciones")) ? default(String) : lector.GetString(lector.GetOrdinal("observaciones")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            activo = lector.GetBoolean(lector.GetOrdinal("activo")),
                            fecha_generacion = lector.IsDBNull(lector.GetOrdinal("fecha_generacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_generacion")),
                            tipo_opera = lector.IsDBNull(lector.GetOrdinal("tipo_opera")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_opera")),
                            fecha_anula_descarga = lector.IsDBNull(lector.GetOrdinal("fecha_anula_descarga")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_anula_descarga")),
                            num_operacion = lector.IsDBNull(lector.GetOrdinal("num_operacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("num_operacion")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            interes_cobrado = lector.IsDBNull(lector.GetOrdinal("interes_cobrado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("interes_cobrado"))

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
        public List<Pago_CuentaCorriente> estadoCuentaContribuyente(string persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                var coleccion = new List<Pago_CuentaCorriente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_CuentaCorriente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            pagado = lector.GetDecimal(lector.GetOrdinal("pagado")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            pendiente = lector.GetDecimal(lector.GetOrdinal("pendiente"))
                            //pendiente_total = lector.GetDecimal(lector.GetOrdinal("pendiente_total")),
                            //pagado_total = lector.GetDecimal(lector.GetOrdinal("pagado_total"))
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
        public Pago_CuentaCorriente estadoCuentaTotales(string persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                var Pago_CuentaCorriente = new Pago_CuentaCorriente();
                using (var lector = db.ExecuteReader(SQL))
                {
                    if (lector.Read())
                    {
                        Pago_CuentaCorriente.total = lector.GetDecimal(lector.GetOrdinal("total"));
                        Pago_CuentaCorriente.pendiente_total = lector.GetDecimal(lector.GetOrdinal("pendiente_total"));
                        Pago_CuentaCorriente.pagado_total = lector.GetDecimal(lector.GetOrdinal("pagado_total"));
                    }
                }
                SQL.Dispose();
                return Pago_CuentaCorriente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_CuentaCorriente> estadoCuentaPorPeriodoTributoCompleto(string persona_ID, string tributo_ID, int periodo, byte tipoconsulta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 13);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo);

                var coleccion = new List<Pago_CuentaCorriente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_CuentaCorriente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            pagado = lector.GetDecimal(lector.GetOrdinal("pagado")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            pendiente = lector.GetDecimal(lector.GetOrdinal("pendiente"))
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
        public List<Pago_CuentaCorriente> estadoCuentaPorPeriodoTributo(string persona_ID, string tributo_ID, int periodo, byte tipoconsulta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo);

                var coleccion = new List<Pago_CuentaCorriente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_CuentaCorriente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            pagado = lector.GetDecimal(lector.GetOrdinal("pagado")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            pendiente = lector.GetDecimal(lector.GetOrdinal("pendiente"))
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
        public Pago_CuentaCorriente listarTotalesPorPeriodoTributo(string persona_ID, string tributo_ID, Int32 periodo, byte tipoconsulta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                if (tipoconsulta == 10)
                {
                    db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 10);
                    db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                    db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                    db.AddInParameter(SQL, "anio", DbType.Int32, periodo);
                }
                else if (tipoconsulta == 11)
                {
                    db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 11);
                    db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                    db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                }
                else if (tipoconsulta == 12)
                {
                    db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 12);
                    db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                    db.AddInParameter(SQL, "anio", DbType.Int32, periodo);
                }
                var pago_CuentaCorriente = new Pago_CuentaCorriente();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        pago_CuentaCorriente.total = lector.GetDecimal(lector.GetOrdinal("total"));
                        pago_CuentaCorriente.pendiente_total = lector.GetDecimal(lector.GetOrdinal("pendiente_total"));
                        pago_CuentaCorriente.pagado_total = lector.GetDecimal(lector.GetOrdinal("pagado_total"));
                    }
                }
                SQL.Dispose();
                return pago_CuentaCorriente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_CuentaCorriente> estadoCuentaCompleto(string persona_ID, string predio_id, string tributo_IDPredio, string tributo_IDArbitrio, string tributo_IDAlcabala, string tributo_IDFormulario, string tributo_IDtodos, int periodo, byte tipoconsulta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 15);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_id);
                db.AddInParameter(SQL, "tributo_IDPredio", DbType.String, tributo_IDPredio);
                db.AddInParameter(SQL, "tributo_IDArbitrio", DbType.String, tributo_IDArbitrio);
                db.AddInParameter(SQL, "tributo_IDFormulario", DbType.String, tributo_IDFormulario);
                db.AddInParameter(SQL, "tributo_IDAlcabala", DbType.String, tributo_IDAlcabala);
                db.AddInParameter(SQL, "tributo_IDTodos", DbType.String, tributo_IDtodos);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo);

                var coleccion = new List<Pago_CuentaCorriente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_CuentaCorriente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            pagado = lector.GetDecimal(lector.GetOrdinal("pagado")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            pendiente = lector.GetDecimal(lector.GetOrdinal("pendiente"))
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

        public List<Pago_CuentaCorriente> estadoCuentaValores(string persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 16);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);

                var coleccion = new List<Pago_CuentaCorriente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_CuentaCorriente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            pagado = lector.GetDecimal(lector.GetOrdinal("pagado")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            pendiente = lector.GetDecimal(lector.GetOrdinal("pendiente"))
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

        public List<Pago_CuentaCorriente> estadoDeuda(string persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 18);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);

                var coleccion = new List<Pago_CuentaCorriente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_CuentaCorriente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            pagado = lector.GetDecimal(lector.GetOrdinal("pagado")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            pendiente = lector.GetDecimal(lector.GetOrdinal("pendiente"))
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

        public List<Pago_CuentaCorriente> estadoDeudaTributos(string persona_ID, string tributo_ID, Int32 anio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 19);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "anio", DbType.String, anio);
                var coleccion = new List<Pago_CuentaCorriente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_CuentaCorriente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            pagado = lector.GetDecimal(lector.GetOrdinal("pagado")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            pendiente = lector.GetDecimal(lector.GetOrdinal("pendiente"))
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

        public List<Pago_CuentaCorriente> estadoCuentaValoresPeriodo(string persona_ID, Int32 periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 17);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo);
                var coleccion = new List<Pago_CuentaCorriente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_CuentaCorriente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            pagado = lector.GetDecimal(lector.GetOrdinal("pagado")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            pendiente = lector.GetDecimal(lector.GetOrdinal("pendiente"))
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

        public List<Pago_CuentaCorriente> estadoCuentaPendiente(string persona_ID, string predio_id, string tributo_IDPredio, string tributo_IDArbitrio, string tributo_IDAlcabala, string tributo_IDFormulario, string tributo_IDtodos, int periodo, byte tipoconsulta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 14);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_id);
                db.AddInParameter(SQL, "tributo_IDPredio", DbType.String, tributo_IDPredio);
                db.AddInParameter(SQL, "tributo_IDArbitrio", DbType.String, tributo_IDArbitrio);
                db.AddInParameter(SQL, "tributo_IDFormulario", DbType.String, tributo_IDFormulario);
                db.AddInParameter(SQL, "tributo_IDAlcabala", DbType.String, tributo_IDAlcabala);
                db.AddInParameter(SQL, "tributo_IDTodos", DbType.String, tributo_IDtodos);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo);

                var coleccion = new List<Pago_CuentaCorriente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_CuentaCorriente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            pagado = lector.GetDecimal(lector.GetOrdinal("pagado")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            pendiente = lector.GetDecimal(lector.GetOrdinal("pendiente"))
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

        public List<Pred_Predio> listarPrediosxPersona(String per_id, Int32 anio)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 21);
                db.AddInParameter(SQL, "persona_ID", DbType.String, per_id);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Predio
                        {
                            predio_ID = lector.GetString(lector.GetOrdinal("Predio_id")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion_completa"))
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
