using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core;
using SGR.Entity;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity.Model;

namespace SGR.Core.Repository
{
    public class Liqu_CompensacionRepository
    {
        private const String nombreprocedimiento = "_Compensacion_Proceso";
        private Database db = DatabaseFactory.CreateDatabase();

        public virtual int Insert(Liqu_Compensacion liqu_Compensacion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, liqu_Compensacion.tributos_id);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, liqu_Compensacion.registro_user_add);
                db.AddInParameter(SQL, "persona_id", DbType.String, liqu_Compensacion.persona_id);
                db.AddInParameter(SQL, "observacion", DbType.String, liqu_Compensacion.observacion);
                db.AddInParameter(SQL, "expediente", DbType.String, liqu_Compensacion.expediente);
                db.AddInParameter(SQL, "tipoConsulta", DbType.String, 1);

                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert_Detalle1(int compensacion_id, String persona_id, String tributos_id, Int16 anio, Int16 mes, string predio_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "compensacion_id", DbType.Int32, compensacion_id);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, tributos_id);
                db.AddInParameter(SQL, "anio", DbType.Int16, anio);
                db.AddInParameter(SQL, "mes", DbType.Int16, mes);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "tipoConsulta", DbType.String, 2);

                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert_Detalle2(int compensacion_id, String persona_id, String tributos_id, Int16 anio, Int16 mes, Decimal montoCompensar, string predio_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "compensacion_id", DbType.Int32, compensacion_id);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, tributos_id);
                db.AddInParameter(SQL, "anio", DbType.Int16, anio);
                db.AddInParameter(SQL, "mes", DbType.Int16, mes);
                db.AddInParameter(SQL, "montoCompensar", DbType.Decimal, montoCompensar);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "tipoConsulta", DbType.String, 3);

                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Liqu_Compensacion> listartodos(String persona_id)
        {
            try
            {
                var coleccion = new List<Liqu_Compensacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Compensacion
                        {
                            persona_id = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_cod")),
                            predio = lector.IsDBNull(lector.GetOrdinal("predio")) ? default(String) : lector.GetString(lector.GetOrdinal("predio")),
                            tributos_id = lector.GetString(lector.GetOrdinal("tributo_cod")),
                            tributos_descrip = lector.GetString(lector.GetOrdinal("tributo")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            deudaVencida = lector.GetDecimal(lector.GetOrdinal("deudaVencida"))
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

        public List<Liqu_CompensacionDetalle> listarDetallePositivos(string persona_id, string predio_id, string tributos_id)
        {
            try
            {
                var coleccion = new List<Liqu_CompensacionDetalle>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, tributos_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_CompensacionDetalle
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            ene = lector.GetDecimal(lector.GetOrdinal("ene")),
                            feb = lector.GetDecimal(lector.GetOrdinal("feb")),
                            mar = lector.GetDecimal(lector.GetOrdinal("mar")),
                            abr = lector.GetDecimal(lector.GetOrdinal("abr")),
                            may = lector.GetDecimal(lector.GetOrdinal("may")),
                            jun = lector.GetDecimal(lector.GetOrdinal("jun")),
                            jul = lector.GetDecimal(lector.GetOrdinal("jul")),
                            ago = lector.GetDecimal(lector.GetOrdinal("ago")),
                            sep = lector.GetDecimal(lector.GetOrdinal("sep")),
                            oct = lector.GetDecimal(lector.GetOrdinal("oct")),
                            nov = lector.GetDecimal(lector.GetOrdinal("nov")),
                            dic = lector.GetDecimal(lector.GetOrdinal("dic")),
                            tot = lector.GetDecimal(lector.GetOrdinal("tot")),
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

        public List<Liqu_CompensacionDetalle> listarDetalleNegativos(string persona_id, string predio_id, string tributos_id)
        {
            try
            {
                var coleccion = new List<Liqu_CompensacionDetalle>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, tributos_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_CompensacionDetalle
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            ene = lector.GetDecimal(lector.GetOrdinal("ene")),
                            feb = lector.GetDecimal(lector.GetOrdinal("feb")),
                            mar = lector.GetDecimal(lector.GetOrdinal("mar")),
                            abr = lector.GetDecimal(lector.GetOrdinal("abr")),
                            may = lector.GetDecimal(lector.GetOrdinal("may")),
                            jun = lector.GetDecimal(lector.GetOrdinal("jun")),
                            jul = lector.GetDecimal(lector.GetOrdinal("jul")),
                            ago = lector.GetDecimal(lector.GetOrdinal("ago")),
                            sep = lector.GetDecimal(lector.GetOrdinal("sep")),
                            oct = lector.GetDecimal(lector.GetOrdinal("oct")),
                            nov = lector.GetDecimal(lector.GetOrdinal("nov")),
                            dic = lector.GetDecimal(lector.GetOrdinal("dic")),
                            tot = lector.GetDecimal(lector.GetOrdinal("tot")),
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

        public decimal montoCompensar(string persona_id, string predio_id, string tributos_id)
        {
            try
            {
                decimal montoCompensar = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 7);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, tributos_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        montoCompensar = lector.GetDecimal(lector.GetOrdinal("montoCompensar"));
                    }
                }
                SQL.Dispose();
                return montoCompensar;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int compensarNegativos(string persona, string tributo_id, string predio_id, decimal montoCompensar, decimal montoResultante)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, tributo_id);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);                
                db.AddInParameter(SQL, "montoCompensar", DbType.Decimal, montoCompensar);
                db.AddInParameter(SQL, "montoResultante", DbType.Decimal, montoResultante);
                db.AddInParameter(SQL, "tipoConsulta", DbType.String, 8);

                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Liqu_Compensacion> listarCompensaciones(String persona_id)
        {
            try
            {
                var coleccion = new List<Liqu_Compensacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Compensacion
                        {
                            row = lector.GetInt64(lector.GetOrdinal("row")),
                            compensacion_id = lector.GetInt32(lector.GetOrdinal("compensacion_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_ID")).ToString().Trim(),
                            nombrePersona = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            tributos_id = lector.GetString(lector.GetOrdinal("tributos_ID")).ToString().Trim(),
                            tributos_descrip = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            observacion = lector.IsDBNull(lector.GetOrdinal("observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("observacion")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            montoCompensado = lector.GetDecimal(lector.GetOrdinal("montoCompensado")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add"))
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

        public List<Liqu_Compensacion> listarCompensacionesDetalle(Int32 compensacion_id)
        {
            try
            {
                var coleccion = new List<Liqu_Compensacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "compensacion_id", DbType.String, compensacion_id);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 10);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Compensacion
                        {
                            row = lector.GetInt64(lector.GetOrdinal("row")),
                            detaCompensacion_id = lector.GetInt32(lector.GetOrdinal("detaCompensacion_id")),
                            compensacion_id = lector.GetInt32(lector.GetOrdinal("compensacion_id")),
                            cuentaCorriente_id = lector.GetInt32(lector.GetOrdinal("cuentaCorriente_id")),
                            anio = lector.GetInt16(lector.GetOrdinal("anio")),
                            mes = lector.GetInt16(lector.GetOrdinal("mes")),
                            montoCompensado = lector.GetDecimal(lector.GetOrdinal("montoDeuda")),
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

        public virtual int compensarFaltantes(string persona, string tributo_id, string predio_id, decimal montoCompensar, decimal montoResultante)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, tributo_id);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "montoCompensar", DbType.Decimal, montoCompensar);
                db.AddInParameter(SQL, "montoResultante", DbType.Decimal, montoResultante);
                db.AddInParameter(SQL, "tipoConsulta", DbType.String, 13);

                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public decimal montoFaltante(string persona_id, string predio_id, string tributos_id)
        {
            try
            {
                decimal montoCompensar = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 12);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, tributos_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        montoCompensar = lector.GetDecimal(lector.GetOrdinal("montoCompensar"));
                    }
                }
                SQL.Dispose();
                return montoCompensar;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int insertarCompensacionFaltante(Liqu_Compensacion liqu_Compensacion, decimal montoResultante)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, liqu_Compensacion.tributos_id);
                db.AddInParameter(SQL, "persona_id", DbType.String, liqu_Compensacion.persona_id);                
                db.AddInParameter(SQL, "predio_id", DbType.String, liqu_Compensacion.predio_ID);
                db.AddInParameter(SQL, "observacion", DbType.String, liqu_Compensacion.observacion);
                db.AddInParameter(SQL, "expediente", DbType.String, liqu_Compensacion.expediente);
                db.AddInParameter(SQL, "montoResultante", DbType.Decimal, montoResultante);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, liqu_Compensacion.registro_user_add);
                db.AddInParameter(SQL, "tipoConsulta", DbType.String, 11);

                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
