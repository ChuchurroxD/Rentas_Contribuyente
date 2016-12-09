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
    public class Repo_CajaResumenRepository
    {
        private const String NombreProcedimiento = "_Repo_CajaResumen";
        private Database db = DatabaseFactory.CreateDatabase();

        public List <Repo_CajaResumen> ListarDatosTributos( String FechaDesde,String FechaHasta,Int32 idOficina)
        {
            try
            {
                var coleccion = new List<Repo_CajaResumen>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "FechaDesde", DbType.String, FechaDesde);
                db.AddInParameter(SQL, "FechaHasta", DbType.String, FechaHasta);
                db.AddInParameter(SQL, "idOficina", DbType.Int32, idOficina);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_CajaResumen
                        {
                            FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            tributos_ID = lector.IsDBNull(lector.GetOrdinal("tributos_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("tributos_ID")),
                            TributoDescripcion = lector.IsDBNull(lector.GetOrdinal("TributoDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("TributoDescripcion")),
                            ImporteTotal = lector.IsDBNull(lector.GetOrdinal("ImporteTotal")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("ImporteTotal")),
                            CPresupuestal = lector.IsDBNull(lector.GetOrdinal("CPresupuestal")) ? default(String) : lector.GetString(lector.GetOrdinal("CPresupuestal"))
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

        public List<Repo_CajaResumen> ListarDatosCaja(String FechaDesde, String FechaHasta, Int32 idOficina)
        {
            try
            {
                var coleccion = new List<Repo_CajaResumen>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "FechaDesde", DbType.String, FechaDesde);
                db.AddInParameter(SQL, "FechaHasta", DbType.String, FechaHasta);
                db.AddInParameter(SQL, "idOficina", DbType.Int32, idOficina);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_CajaResumen
                        {
                            FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            Caja_id = lector.IsDBNull(lector.GetOrdinal("Caja_id")) ? default(int) : lector.GetInt32(lector.GetOrdinal("Caja_id")),
                            CajaDescripcion = lector.IsDBNull(lector.GetOrdinal("CajaDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("CajaDescripcion")),
                            MontoTotal = lector.IsDBNull(lector.GetOrdinal("MontoTotal")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("MontoTotal")),
                            Fuente = lector.IsDBNull(lector.GetOrdinal("Fuente")) ? default(String) : lector.GetString(lector.GetOrdinal("Fuente")),
                            TipoPago = lector.IsDBNull(lector.GetOrdinal("TipoPago")) ? default(String) : lector.GetString(lector.GetOrdinal("TipoPago")),
                            DescripcionTipoPago = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoPago")) ? default(String) : lector.GetString(lector.GetOrdinal("DescripcionTipoPago")),
                            TasaCambio = lector.IsDBNull(lector.GetOrdinal("TasaCambio")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("TasaCambio"))
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
