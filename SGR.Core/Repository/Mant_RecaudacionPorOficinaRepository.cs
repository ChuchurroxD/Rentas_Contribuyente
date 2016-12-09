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
    public class Mant_RecaudacionPorOficinaRepository
    {
        private const String nombreProcedimiento = "_Mant_RecaudacionPorOficina";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Mant_RecaudacionPorOficina> listarTodos(String oficina_id)
        {
            try
            {
                var coleccion = new List<Mant_RecaudacionPorOficina>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "oficina_id", DbType.String, oficina_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_RecaudacionPorOficina
                        {
                            tributos_ID = lector.IsDBNull(lector.GetOrdinal("tributos_ID")) ? default(string) : lector.GetString(lector.GetOrdinal("tributos_ID")),
                            ClasificacionDescripcion = lector.IsDBNull(lector.GetOrdinal("ClasificacionDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("ClasificacionDescripcion")),
                            TablaDescripcion = lector.IsDBNull(lector.GetOrdinal("TablaDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("TablaDescripcion")),
                            Are_Descripcion = lector.IsDBNull(lector.GetOrdinal("Are_Descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("Are_Descripcion")),
                            TributoDescripcion = lector.IsDBNull(lector.GetOrdinal("TributoDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("TributoDescripcion")),
                            monto_pago = lector.IsDBNull(lector.GetOrdinal("monto_pago")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("monto_pago")),
                            DescripcionOficina = lector.IsDBNull(lector.GetOrdinal("DescripcionOficina")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionOficina")),
                            //clai_codigo = lector.IsDBNull(lector.GetOrdinal("clai_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("clai_codigo")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio"))
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


        public List<Mant_RecaudacionPorOficina> listarPorPeriodoDesdeHasta(Int32 PeriodoDesde, Int32 PeriodoHasta,Int32 oficina_id)
        {
            try
            {
                var coleccion = new List<Mant_RecaudacionPorOficina>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "PeriodoDesde", DbType.Int32, PeriodoDesde);
                db.AddInParameter(SQL, "PeriodoHasta", DbType.Int32, PeriodoHasta);
                db.AddInParameter(SQL, "oficina_id", DbType.String, oficina_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_RecaudacionPorOficina
                        {
                            tributos_ID = lector.IsDBNull(lector.GetOrdinal("tributos_ID")) ? default(string) : lector.GetString(lector.GetOrdinal("tributos_ID")),
                            ClasificacionDescripcion = lector.IsDBNull(lector.GetOrdinal("ClasificacionDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("ClasificacionDescripcion")),
                            TablaDescripcion = lector.IsDBNull(lector.GetOrdinal("TablaDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("TablaDescripcion")),
                            Are_Descripcion = lector.IsDBNull(lector.GetOrdinal("Are_Descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("Are_Descripcion")),
                            TributoDescripcion = lector.IsDBNull(lector.GetOrdinal("TributoDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("TributoDescripcion")),
                            monto_pago = lector.IsDBNull(lector.GetOrdinal("monto_pago")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("monto_pago")),
                            DescripcionOficina = lector.IsDBNull(lector.GetOrdinal("DescripcionOficina")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionOficina")),
                            //clai_codigo = lector.IsDBNull(lector.GetOrdinal("clai_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("clai_codigo")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio"))
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
