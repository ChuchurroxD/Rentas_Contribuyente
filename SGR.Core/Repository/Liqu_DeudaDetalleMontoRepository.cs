using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
namespace SGR.Core.Repository
{
    public class Liqu_DeudaDetalleMontoRepository
    {
        private const String nombreprocedimiento = "_Liqu_LiquidacionDetalle";
        private Database db = DatabaseFactory.CreateDatabase();


        public List<Liqu_DeudaDetalleMonto> listartodos(string persona,string predio,string grupo_trib)
        {
            try
            {
                var coleccion = new List<Liqu_DeudaDetalleMonto>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 1);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio);
                db.AddInParameter(SQL, "grupo_trib", DbType.String, grupo_trib);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_DeudaDetalleMonto
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
        public List<Liqu_DeudaDetalleTributo> listartodos2(string persona, string predio, string grupo_trib)
        {
            try
            {
                var coleccion = new List<Liqu_DeudaDetalleTributo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 2);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio);
                db.AddInParameter(SQL, "grupo_trib", DbType.String, grupo_trib);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_DeudaDetalleTributo
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            tributos_ID = lector.GetString(lector.GetOrdinal("tributos_ID")),
                            abrev = lector.GetString(lector.GetOrdinal("abrev")),
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
        public List<Liqu_DeudaDetalleTributo> listartodos3(string persona, string predio, string tributos,
            int anio_ini,int anio_fin,int mes_ini,int mes_fin)
        {
            try
            {
                var coleccion = new List<Liqu_DeudaDetalleTributo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 4);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio);
                db.AddInParameter(SQL, "tributos", DbType.String, tributos);
                db.AddInParameter(SQL, "anio_ini", DbType.Int32, anio_ini);
                db.AddInParameter(SQL, "anio_fin", DbType.Int32, anio_fin);
                db.AddInParameter(SQL, "mes_ini", DbType.Int32, mes_ini);
                db.AddInParameter(SQL, "mes_fin", DbType.Int32, mes_fin);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_DeudaDetalleTributo
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            tributos_ID = lector.GetString(lector.GetOrdinal("tributos_ID")),
                            abrev = lector.GetString(lector.GetOrdinal("abrev")),
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
        public List<Liqu_DeudaDetalleTributo> listarTodosporLiquidacion(Int32 liquidacion_ID)
        {
            try
            {
                var coleccion = new List<Liqu_DeudaDetalleTributo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 5);
                db.AddInParameter(SQL, "liquidacion_id", DbType.Int32, liquidacion_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_DeudaDetalleTributo
                        {
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            tributos_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            abrev = lector.GetString(lector.GetOrdinal("abrev")),
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
    }
}

