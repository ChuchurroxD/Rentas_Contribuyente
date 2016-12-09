using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity.Model;
using SGR.Entity;
using SGR.Core.Service;
namespace SGR.Core.Repository
{
    public class Pred_CalculoPorPersonaAniosRepository
    {
        private Database db = DatabaseFactory.CreateDatabase();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        public List<Pred_UsoGeneral> VerificarParametros(string periodoini, string periodofin, string persona_ID)//ambos
        {
            try
            {
                //tipo 7=predial, tipo 6=arbitrio, 5 ambos
                var coleccion = new List<Pred_UsoGeneral>();
                DbCommand SQL = db.GetStoredProcCommand("_Pred_ParametrosVerificacion");
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "periodoini", DbType.String, periodoini);
                db.AddInParameter(SQL, "periodofin", DbType.String, periodofin);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                SQL.CommandTimeout = 600;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_UsoGeneral
                        {
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public List<Pred_UsoGeneral> VerificarParametrosPredial(string periodoini, string periodofin, string persona_ID)//sim uso
        {
            try
            {
                var coleccion = new List<Pred_UsoGeneral>();
                DbCommand SQL = db.GetStoredProcCommand("_Pred_ParametrosVerificacion");
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "periodoini", DbType.String, periodoini);
                db.AddInParameter(SQL, "periodofin", DbType.String, periodofin);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                SQL.CommandTimeout = 600;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_UsoGeneral
                        {
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public List<Pred_UsoGeneral> VerificarParametrosArb(string periodoini, string periodofin, string persona_ID)//si uso
        {
            try
            {
                //tipo 7=predial, tipo 6=arbitrio, 5 ambos
                var coleccion = new List<Pred_UsoGeneral>();
                DbCommand SQL = db.GetStoredProcCommand("_Pred_ParametrosVerificacion");
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "periodoini", DbType.String, periodoini);
                db.AddInParameter(SQL, "periodofin", DbType.String, periodofin);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                SQL.CommandTimeout = 600;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_UsoGeneral
                        {
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public void CalculoPredial(string periodoini, string periodofin, string persona_ID, string usser)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand("_Pred_Fiscalizacion_Calculo");
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "periodofin", DbType.String, periodofin);
                db.AddInParameter(SQL, "periodoini", DbType.String, periodoini);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_ID);
                db.AddInParameter(SQL, "registro_user", DbType.String, usser);
                SQL.CommandTimeout = 600;
                int huboexit = db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void CalculoArbitrio(string periodoini, string periodofin, string persona_ID, string usser)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand("_Pred_Fiscalizacion_Calculo");
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "periodofin", DbType.String, periodofin);
                db.AddInParameter(SQL, "periodoini", DbType.String, periodoini);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_ID);
                db.AddInParameter(SQL, "registro_user", DbType.String, usser);
                int huboexit = db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void CalculoArbitrioPredial(string periodoini, string periodofin, string persona_ID, string usser)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand("_Pred_Fiscalizacion_Calculo");
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "periodofin", DbType.String, periodofin);
                db.AddInParameter(SQL, "periodoini", DbType.String, periodoini);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_ID);
                db.AddInParameter(SQL, "registro_user", DbType.String, usser);
                SQL.CommandTimeout = 600;
                int huboexit = db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
