using Microsoft.Practices.EnterpriseLibrary.Data;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SGR.Core.Repository
{
    public class Repo_PlanillaIngresosRepository
    {
        private const String nombreProcedimiento = "_Repo_PlanillaIngreso";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Repo_PlanillaIngresos> listarPorOficina(Int32 oficina_id)
        {
            try
            {
                var coleccion = new List<Repo_PlanillaIngresos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "oficina_id", DbType.String, oficina_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PlanillaIngresos
                        {
                            FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            nro_Recibo = lector.IsDBNull(lector.GetOrdinal("nro_Recibo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("nro_Recibo")),
                            Pagante = lector.IsDBNull(lector.GetOrdinal("Pagante")) ? default(string) : lector.GetString(lector.GetOrdinal("Pagante")),
                            monto_pago = lector.IsDBNull(lector.GetOrdinal("monto_pago")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_pago")),
                            Fuente = lector.IsDBNull(lector.GetOrdinal("Fuente"))? default(String) : lector.GetString(lector.GetOrdinal("Fuente")),
                            clai_codigo = lector.IsDBNull(lector.GetOrdinal("clai_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_codigo")),
                            Recurso = lector.IsDBNull(lector.GetOrdinal("Recurso")) ? default(String) : lector.GetString(lector.GetOrdinal("Recurso"))
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


        public List<Repo_PlanillaIngresos> listarPorFechaDesdeHasta(string FechaDesde, string FechaHasta, Int32 oficina_id)
        {
            try
            {
                var coleccion = new List<Repo_PlanillaIngresos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "FechaDesde", DbType.String, FechaDesde);
                db.AddInParameter(SQL, "FechaHasta", DbType.String, FechaHasta);
                db.AddInParameter(SQL, "oficina_id", DbType.Int32, oficina_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PlanillaIngresos
                        {
                            FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            nro_Recibo = lector.IsDBNull(lector.GetOrdinal("nro_Recibo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("nro_Recibo")),
                            Pagante = lector.IsDBNull(lector.GetOrdinal("Pagante")) ? default(string) : lector.GetString(lector.GetOrdinal("Pagante")),
                            monto_pago = lector.IsDBNull(lector.GetOrdinal("monto_pago")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_pago")),
                            Fuente = lector.IsDBNull(lector.GetOrdinal("Fuente")) ? default(String) : lector.GetString(lector.GetOrdinal("Fuente")),
                            clai_codigo = lector.IsDBNull(lector.GetOrdinal("clai_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_codigo")),
                            Recurso = lector.IsDBNull(lector.GetOrdinal("Recurso")) ? default(String) : lector.GetString(lector.GetOrdinal("Recurso"))
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

        public List<Repo_PlanillaIngresos> listarPorFechaDesdeHastaContribuyente(string FechaDesde, string FechaHasta, Int32 oficina_id, string persona_id)
        {
            try
            {
                var coleccion = new List<Repo_PlanillaIngresos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "FechaDesde", DbType.String, FechaDesde);
                db.AddInParameter(SQL, "FechaHasta", DbType.String, FechaHasta);
                db.AddInParameter(SQL, "oficina_id", DbType.Int32, oficina_id);
                db.AddInParameter(SQL, "Pagante", DbType.Int32, persona_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PlanillaIngresos
                        {
                            FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            nro_Recibo = lector.IsDBNull(lector.GetOrdinal("nro_Recibo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("nro_Recibo")),
                            Pagante = lector.IsDBNull(lector.GetOrdinal("Pagante")) ? default(string) : lector.GetString(lector.GetOrdinal("Pagante")),
                            monto_pago = lector.IsDBNull(lector.GetOrdinal("monto_pago")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_pago")),
                            Fuente = lector.IsDBNull(lector.GetOrdinal("Fuente")) ? default(String) : lector.GetString(lector.GetOrdinal("Fuente")),
                            clai_codigo = lector.IsDBNull(lector.GetOrdinal("clai_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_codigo")),
                            Recurso = lector.IsDBNull(lector.GetOrdinal("Recurso")) ? default(String) : lector.GetString(lector.GetOrdinal("Recurso"))
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

        public List<Repo_PlanillaIngresos> listarResumenPorDia(string FechaDesde, string FechaHasta)
        {
            try
            {
                var coleccion = new List<Repo_PlanillaIngresos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "FechaDesde", DbType.String, FechaDesde);
                db.AddInParameter(SQL, "FechaHasta", DbType.String, FechaHasta);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PlanillaIngresos
                        {
                            //FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            MontoTotal = lector.IsDBNull(lector.GetOrdinal("MontoTotal")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MontoTotal")),
                            Fuente = lector.IsDBNull(lector.GetOrdinal("Fuente")) ? default(String) : lector.GetString(lector.GetOrdinal("Fuente")),
                            //Recurso = lector.IsDBNull(lector.GetOrdinal("Recurso")) ? default(String) : lector.GetString(lector.GetOrdinal("Recurso"))
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

        public List<Repo_PlanillaIngresos> listarResumenPorDiaConcepto(string FechaDesde, string FechaHasta, string Concepto)
        {
            try
            {
                var coleccion = new List<Repo_PlanillaIngresos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 7);
                db.AddInParameter(SQL, "FechaDesde", DbType.String, FechaDesde);
                db.AddInParameter(SQL, "FechaHasta", DbType.String, FechaHasta);
                db.AddInParameter(SQL, "tributo", DbType.String, Concepto);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PlanillaIngresos
                        {
                            //FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            MontoTotal = lector.IsDBNull(lector.GetOrdinal("MontoTotal")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MontoTotal")),
                            Fuente = lector.IsDBNull(lector.GetOrdinal("Fuente")) ? default(String) : lector.GetString(lector.GetOrdinal("Fuente")),
                            Recurso = lector.IsDBNull(lector.GetOrdinal("Recurso")) ? default(String) : lector.GetString(lector.GetOrdinal("Recurso"))
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

        public List<Repo_PlanillaIngresos> listarResumenPorDevolucion(string FechaDesde, string FechaHasta)
        {
            try
            {
                var coleccion = new List<Repo_PlanillaIngresos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "FechaDesde", DbType.String, FechaDesde);
                db.AddInParameter(SQL, "FechaHasta", DbType.String, FechaHasta);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PlanillaIngresos
                        {
                            //FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            MontoTotal = lector.IsDBNull(lector.GetOrdinal("MontoTotal")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MontoTotal")),
                            Fuente = lector.IsDBNull(lector.GetOrdinal("Fuente")) ? default(String) : lector.GetString(lector.GetOrdinal("Fuente")),
                            clai_codigo = lector.IsDBNull(lector.GetOrdinal("clai_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_codigo")),
                            clai_descripcion = lector.IsDBNull(lector.GetOrdinal("clai_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_descripcion"))
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

        public List<Repo_PlanillaIngresos> listarResumenPorDevolucionPlanilla(string FechaDesde, string FechaHasta, string Concepto)
        {
            try
            {
                var coleccion = new List<Repo_PlanillaIngresos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "FechaDesde", DbType.String, FechaDesde);
                db.AddInParameter(SQL, "FechaHasta", DbType.String, FechaHasta);
                db.AddInParameter(SQL, "tributo", DbType.String, Concepto);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PlanillaIngresos
                        {
                            //FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            MontoTotal = lector.IsDBNull(lector.GetOrdinal("MontoTotal")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MontoTotal")),
                            Fuente = lector.IsDBNull(lector.GetOrdinal("Fuente")) ? default(String) : lector.GetString(lector.GetOrdinal("Fuente")),
                            clai_codigo = lector.IsDBNull(lector.GetOrdinal("clai_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_codigo")),
                            clai_descripcion = lector.IsDBNull(lector.GetOrdinal("clai_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_descripcion"))
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

        public List<Repo_PlanillaIngresos> listarResumenPorPartida(string FechaDesde, string FechaHasta)
        {
            try
            {
                var coleccion = new List<Repo_PlanillaIngresos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "FechaDesde", DbType.DateTime, FechaDesde);
                db.AddInParameter(SQL, "FechaHasta", DbType.DateTime, FechaHasta);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PlanillaIngresos
                        {
                            //FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            MontoTotal = lector.IsDBNull(lector.GetOrdinal("MontoTotal")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MontoTotal")),
                            Fuente = lector.IsDBNull(lector.GetOrdinal("Fuente")) ? default(String) : lector.GetString(lector.GetOrdinal("Fuente")),
                            clai_codigo = lector.IsDBNull(lector.GetOrdinal("clai_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_codigo")),
                            clai_descripcion = lector.IsDBNull(lector.GetOrdinal("clai_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_descripcion"))
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

        public List<Repo_PlanillaIngresos> listarResumenPorPartidaPlanilla(string FechaDesde, string FechaHasta, string Concepto)
        {
            try
            {
                var coleccion = new List<Repo_PlanillaIngresos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "FechaDesde", DbType.DateTime, FechaDesde);
                db.AddInParameter(SQL, "FechaHasta", DbType.DateTime, FechaHasta);
                db.AddInParameter(SQL, "Tributo", DbType.String, Concepto);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PlanillaIngresos
                        {
                            //FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            MontoTotal = lector.IsDBNull(lector.GetOrdinal("MontoTotal")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MontoTotal")),
                            Fuente = lector.IsDBNull(lector.GetOrdinal("Fuente")) ? default(String) : lector.GetString(lector.GetOrdinal("Fuente")),
                            clai_codigo = lector.IsDBNull(lector.GetOrdinal("clai_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_codigo")),
                            clai_descripcion = lector.IsDBNull(lector.GetOrdinal("clai_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_descripcion"))
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
