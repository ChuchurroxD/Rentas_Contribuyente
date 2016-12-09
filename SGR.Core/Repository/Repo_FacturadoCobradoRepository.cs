using Microsoft.Practices.EnterpriseLibrary.Data;
using SGR.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SGR.Core.Repository
{
    public class Repo_FacturadoCobradoRepository
    {
        private const String NombreProcedimiento = "_Repo_FacturadoCobrado";
        private Database db = DatabaseFactory.CreateDatabase();



        public List<Repo_FacturadoCobrado> ListarFacturadoCobrado(Int32 anio, Int32 mes, Int32 mesFin, Int32 oficina_id)
        {
            try
            {
                var coleccion = new List<Repo_FacturadoCobrado>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "mes", DbType.Int32, mes);
                db.AddInParameter(SQL, "mesFin", DbType.Int32, mesFin);
                db.AddInParameter(SQL, "oficina_id", DbType.Int32, oficina_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_FacturadoCobrado
                        {
                            tributos_ID = lector.IsDBNull(lector.GetOrdinal("tributos_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("tributos_ID")),
                            TributoDescripcion = lector.IsDBNull(lector.GetOrdinal("TributoDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("TributoDescripcion")),
                            abono = lector.IsDBNull(lector.GetOrdinal("abono")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("abono")),
                            cargo = lector.IsDBNull(lector.GetOrdinal("cargo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("cargo")),
                            Saldo = lector.IsDBNull(lector.GetOrdinal("Saldo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Saldo")),
                            Morosidad = lector.IsDBNull(lector.GetOrdinal("Morosidad")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Morosidad")),
                            Cobrado = lector.IsDBNull(lector.GetOrdinal("Cobrado")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Cobrado")),
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
