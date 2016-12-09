using Microsoft.Practices.EnterpriseLibrary.Data;
using SGR.Entity;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SGR.Core.Repository
{
    public class Repo_HojaResumenRepository
    {
        private const String nombreprocedimiento = "_Rep_HR";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Repo_HojaResumen> listarMontosPagar(string persona_id,int periodo)
        {
            try
            {
                var coleccion = new List<Repo_HojaResumen>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_id);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, periodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_HojaResumen
                        {
                            cuota = lector.IsDBNull(lector.GetOrdinal("cuota")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("cuota")),
                            vencimiento = lector.IsDBNull(lector.GetOrdinal("vencimiento")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("vencimiento")),
                            montoinsoluto = lector.IsDBNull(lector.GetOrdinal("montoinsoluto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("montoinsoluto")),
                            derechoemision = lector.IsDBNull(lector.GetOrdinal("derechoemision")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("derechoemision")),
                            reajuste = lector.IsDBNull(lector.GetOrdinal("reajuste")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("reajuste")),
                            totalpagar = lector.IsDBNull(lector.GetOrdinal("totalpagar")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("totalpagar"))
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
        public List<Repo_HojaResumen> listarMontosPagarConFormato(string persona_id, int periodo)
        {
            try
            {
                var coleccion = new List<Repo_HojaResumen>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 7);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_id);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, periodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_HojaResumen
                        {
                            cuota = lector.IsDBNull(lector.GetOrdinal("cuota")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("cuota")),
                            vencimiento = lector.IsDBNull(lector.GetOrdinal("vencimiento")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("vencimiento")),
                            montoinsoluto = lector.IsDBNull(lector.GetOrdinal("montoinsoluto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("montoinsoluto")),
                            derechoemision = lector.IsDBNull(lector.GetOrdinal("derechoemision")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("derechoemision")),
                            reajuste = lector.IsDBNull(lector.GetOrdinal("reajuste")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("reajuste")),
                            totalpagar = lector.IsDBNull(lector.GetOrdinal("totalpagar")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("totalpagar"))
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
        public List<Repo_HojaResumen> listarDeterminacionImpuesto(string persona_id,int periodo)
        {
            try
            {
                var coleccion = new List<Repo_HojaResumen>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_id);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, periodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_HojaResumen
                        {
                            total_Predios = lector.IsDBNull(lector.GetOrdinal("totalpredios")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("totalpredios")),
                            impuesto_Anual = lector.IsDBNull(lector.GetOrdinal("impuestoanual")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("impuestoanual")),
                            cuota_Trimestral = lector.IsDBNull(lector.GetOrdinal("cuotatrimestral")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("cuotatrimestral")),
                            baseImponible = lector.IsDBNull(lector.GetOrdinal("baseimponible")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("baseimponible"))
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

        public List<Pred_Predio> listarPrediosxPerContribuyente(String persona_id,int periodo)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte,5);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, periodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Predio
                        {

                            predio_ID = lector.GetString(lector.GetOrdinal("Predio_id")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("Ubicacion_Predio")) ? default(String) : lector.GetString(lector.GetOrdinal("Ubicacion_Predio")),
                            total_autovaluo = lector.IsDBNull(lector.GetOrdinal("total_autovaluo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("total_autovaluo")),
                            porcentajecondominio = lector.IsDBNull(lector.GetOrdinal("Porcentaje_Condomino")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("Porcentaje_Condomino")),
                            valorafecto = lector.IsDBNull(lector.GetOrdinal("valorafecto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valorafecto")),
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
        public List<Pred_Predio> listarPrediosxPerContribuyenteConFormato(String persona_id, int periodo)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, periodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Predio
                        {

                            predio_ID = lector.GetString(lector.GetOrdinal("Predio_id")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("Ubicacion_Predio")) ? default(String) : lector.GetString(lector.GetOrdinal("Ubicacion_Predio")),
                            total_autovaluo = lector.IsDBNull(lector.GetOrdinal("total_autovaluo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("total_autovaluo")),
                            porcentajecondominio = lector.IsDBNull(lector.GetOrdinal("Porcentaje_Condomino")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("Porcentaje_Condomino")),
                            valorafecto = lector.IsDBNull(lector.GetOrdinal("valorafecto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valorafecto")),
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
