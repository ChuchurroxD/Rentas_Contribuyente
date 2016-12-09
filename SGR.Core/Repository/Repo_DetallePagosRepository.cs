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
    public class Repo_DetallePagosRepository
    {
        private const String NombreProcedimiento = "_Repo_DetallePagos";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Repo_DetallePagos> ListarDetallePagos(string FechaPagoDesde, string FechaPagoHasta, Int32 Caja_id)
        {
            try
            {
                var coleccion = new List<Repo_DetallePagos>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "FechaPagoDesde", DbType.String, FechaPagoDesde);
                db.AddInParameter(SQL, "FechaPagoHasta", DbType.String, FechaPagoHasta);
                db.AddInParameter(SQL, "Caja_id", DbType.Int32, Caja_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_DetallePagos
                        {
                            nro_Recibo = lector.IsDBNull(lector.GetOrdinal("nro_Recibo")) ? default (Int32) : lector.GetInt32(lector.GetOrdinal("nro_Recibo")),
                            Caja_id = lector.IsDBNull(lector.GetOrdinal("Caja_id")) ? default (Int32) : lector.GetInt32(lector.GetOrdinal("Caja_id")),
                            Pagante = lector.IsDBNull(lector.GetOrdinal("Pagante")) ? default(String) : lector.GetString(lector.GetOrdinal("Pagante")),
                            CajaDescripcion = lector.IsDBNull(lector.GetOrdinal("CajaDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("CajaDescripcion")),
                            TipoPago = lector.IsDBNull(lector.GetOrdinal("TipoPago")) ? default(String) : lector.GetString(lector.GetOrdinal("TipoPago")),
                            DescripcionTipoPago = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoPago")) ? default(String) : lector.GetString(lector.GetOrdinal("DescripcionTipoPago")),
                            FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default (DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            MontoTotal = lector.IsDBNull(lector.GetOrdinal("MontoTotal")) ? default (Decimal) : lector.GetDecimal(lector.GetOrdinal("MontoTotal"))
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

        public List<Repo_DetallePagos> listarPorCaja(Int32 Caja_id)
        {
            try
            {
                var coleccion = new List<Repo_DetallePagos>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "Caja_id", DbType.Int32, Caja_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_DetallePagos
                        {
                            nro_Recibo = lector.IsDBNull(lector.GetOrdinal("nro_Recibo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("nro_Recibo")),
                            Caja_id = lector.IsDBNull(lector.GetOrdinal("Caja_id")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Caja_id")),
                            Pagante = lector.IsDBNull(lector.GetOrdinal("Pagante")) ? default(String) : lector.GetString(lector.GetOrdinal("Pagante")),
                            CajaDescripcion = lector.IsDBNull(lector.GetOrdinal("CajaDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("CajaDescripcion")),
                            TipoPago = lector.IsDBNull(lector.GetOrdinal("TipoPago")) ? default(String) : lector.GetString(lector.GetOrdinal("TipoPago")),
                            DescripcionTipoPago = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoPago")) ? default(String) : lector.GetString(lector.GetOrdinal("DescripcionTipoPago")),
                            FechaPago = lector.IsDBNull(lector.GetOrdinal("FechaPago")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaPago")),
                            MontoTotal = lector.IsDBNull(lector.GetOrdinal("MontoTotal")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MontoTotal"))
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
