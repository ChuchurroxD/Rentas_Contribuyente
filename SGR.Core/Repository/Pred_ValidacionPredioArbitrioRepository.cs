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
    public class Pred_ValidacionPredioArbitrioRepository
    {
        private const String nombreProcedimiento = "_Pred_ValidacionPredioArbitrio";
        private Database db = DatabaseFactory.CreateDatabase();


        public List<Pred_ValidacionPredioArbitrio> ValidarPredioArbitrio(int idPeriodo)
        {
            try
            {
                var coleccion = new List<Pred_ValidacionPredioArbitrio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_ValidacionPredioArbitrio
                        {
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            NombreCompleto = lector.IsDBNull(lector.GetOrdinal("NombreCompleto")) ? default(string) : lector.GetString(lector.GetOrdinal("NombreCompleto")),
                            nombre_predio = lector.IsDBNull(lector.GetOrdinal("nombre_predio")) ? default(string) : lector.GetString(lector.GetOrdinal("nombre_predio")),
                            tipo_operacion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tipo_operacion")),
                            tipo_inmueble = lector.IsDBNull(lector.GetOrdinal("tipo_inmueble")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tipo_inmueble")),
                            tipo_predio = lector.IsDBNull(lector.GetOrdinal("tipo_predio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tipo_predio")),
                            estado_predio = lector.IsDBNull(lector.GetOrdinal("estado_predio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("estado_predio")),
                            DescripcionTipoOperacion = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoOperacion")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionTipoOperacion")),
                            DescripcionTipoInmueble = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoInmueble")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionTipoInmueble")),
                            DescripcionTipoPredio = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoPredio")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionTipoPredio")),
                            DescripcionEstadoPredio = lector.IsDBNull(lector.GetOrdinal("DescripcionEstadoPredio")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionEstadoPredio"))
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

        public List<Pred_ValidacionPredioArbitrio> buscarPredioArbitrio(int idPeriodo, string busqueda)
        {
            try
            {
                var coleccion = new List<Pred_ValidacionPredioArbitrio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                db.AddInParameter(SQL, "busqueda", DbType.String, busqueda);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_ValidacionPredioArbitrio
                        {                            
                            NombreCompleto = lector.IsDBNull(lector.GetOrdinal("NombreCompleto")) ? default(string) : lector.GetString(lector.GetOrdinal("NombreCompleto")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(string) : lector.GetString(lector.GetOrdinal("direccion_completa")),
                            nombre_predio = lector.IsDBNull(lector.GetOrdinal("nombre_predio")) ? default(string) : lector.GetString(lector.GetOrdinal("nombre_predio")),
                            tipo_operacion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tipo_operacion")),
                            tipo_inmueble = lector.IsDBNull(lector.GetOrdinal("tipo_inmueble")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tipo_inmueble")),
                            tipo_predio = lector.IsDBNull(lector.GetOrdinal("tipo_predio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tipo_predio")),
                            estado_predio = lector.IsDBNull(lector.GetOrdinal("estado_predio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("estado_predio")),
                            DescripcionTipoOperacion = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoOperacion")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionTipoOperacion")),
                            DescripcionTipoInmueble = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoInmueble")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionTipoInmueble")),
                            DescripcionTipoPredio = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoPredio")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionTipoPredio")),
                            DescripcionEstadoPredio = lector.IsDBNull(lector.GetOrdinal("DescripcionEstadoPredio")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionEstadoPredio"))
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
