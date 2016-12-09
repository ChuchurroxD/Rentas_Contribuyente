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
    public class Repo_PredioRusticoRepository
    {
        private const String nombreprocedimiento = "_Repo_PredioRustico";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Repo_PredioRustico> listarContribuyenteRustico(string persona_id)
        {
            try
            {
                var coleccion = new List<Repo_PredioRustico>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PredioRustico
                        {
                            persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_id")) ? default(string) : lector.GetString(lector.GetOrdinal("persona_id")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(string) : lector.GetString(lector.GetOrdinal("razon_social")),
                            documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(string) : lector.GetString(lector.GetOrdinal("documento")),
                            DescripcionDocumento = lector.IsDBNull(lector.GetOrdinal("DescripcionDocumento")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionDocumento"))
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

        public List<Repo_PredioRustico> ListarPredioRustico(string predio_ID, int idPeriodo)
        {
            try
            {
                var coleccion = new List<Repo_PredioRustico>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PredioRustico
                        {
                            nombre_predio = lector.IsDBNull(lector.GetOrdinal("nombre_predio")) ? default(string) : lector.GetString(lector.GetOrdinal("nombre_predio")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(string) : lector.GetString(lector.GetOrdinal("direccion_completa")),
                            este = lector.IsDBNull(lector.GetOrdinal("este")) ? default(string) : lector.GetString(lector.GetOrdinal("este")),
                            oeste = lector.IsDBNull(lector.GetOrdinal("oeste")) ? default(string) : lector.GetString(lector.GetOrdinal("oeste")),
                            norte = lector.IsDBNull(lector.GetOrdinal("norte")) ? default(string) : lector.GetString(lector.GetOrdinal("norte")),
                            sur = lector.IsDBNull(lector.GetOrdinal("sur")) ? default(string) : lector.GetString(lector.GetOrdinal("sur")),
                            Condicion_Rustico = lector.IsDBNull(lector.GetOrdinal("Condicion_Rustico")) ? default(short) : lector.GetInt16(lector.GetOrdinal("Condicion_Rustico")),
                            DescripcionCondicionRustico = lector.IsDBNull(lector.GetOrdinal("DescripcionCondicionRustico")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionCondicionRustico")),
                            tipo_predio = lector.IsDBNull(lector.GetOrdinal("tipo_predio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_predio")),
                            DescripcionTipoPredio = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoPredio")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionTipoPredio")),
                            Adquisicion_Rustico = lector.IsDBNull(lector.GetOrdinal("Adquisicion_Rustico")) ? default(short) : lector.GetInt16(lector.GetOrdinal("Adquisicion_Rustico")),
                            DescipcionAdquisicionRustico = lector.IsDBNull(lector.GetOrdinal("DescipcionAdquisicionRustico")) ? default(string) : lector.GetString(lector.GetOrdinal("DescipcionAdquisicionRustico")),
                            clasificacion_rustico = lector.IsDBNull(lector.GetOrdinal("clasificacion_rustico")) ? default(short) : lector.GetInt16(lector.GetOrdinal("clasificacion_rustico")),
                            DescripcionClasificacionRustico = lector.IsDBNull(lector.GetOrdinal("DescripcionClasificacionRustico")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionClasificacionRustico")),
                            uso_predio = lector.IsDBNull(lector.GetOrdinal("uso_predio")) ? default(string) : lector.GetString(lector.GetOrdinal("uso_predio")),
                            DescripcionUsoPredio = lector.IsDBNull(lector.GetOrdinal("DescripcionUsoPredio")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionUsoPredio")),
                            estado_predio = lector.IsDBNull(lector.GetOrdinal("estado_predio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("estado_predio")),
                            DescripcionEstadoPredio = lector.IsDBNull(lector.GetOrdinal("DescripcionEstadoPredio")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionEstadoPredio")),
                            piso_material = lector.IsDBNull(lector.GetOrdinal("piso_material")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("piso_material")),
                            DescripcionMaterPredom = lector.IsDBNull(lector.GetOrdinal("DescripcionMaterPredom")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionMaterPredom"))
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
        public List<Repo_PredioRustico> ListarImpuestoRustico(string predio_ID, int idPeriodo)
        {
            try
            {
                var coleccion = new List<Repo_PredioRustico>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PredioRustico
                        {
                            // Determinacion Impuesto
                            numero = lector.IsDBNull(lector.GetOrdinal("numero")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("numero")),
                            antiguedad = lector.IsDBNull(lector.GetOrdinal("antiguedad")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("antiguedad")),
                            DescripcionAntiguedad = lector.IsDBNull(lector.GetOrdinal("DescripcionAntiguedad")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionAntiguedad")),
                            fecha_construc = lector.IsDBNull(lector.GetOrdinal("fecha_construc")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_construc")),
                            piso_clasificacion = lector.IsDBNull(lector.GetOrdinal("piso_clasificacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("piso_clasificacion")),
                            DescripcionPisoClasificacion = lector.IsDBNull(lector.GetOrdinal("DescripcionPisoClasificacion")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionPisoClasificacion")),
                            valor_unitario = lector.IsDBNull(lector.GetOrdinal("valor_unitario")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_unitario")),
                            porcent_depreci = lector.IsDBNull(lector.GetOrdinal("porcent_depreci")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("porcent_depreci")),
                            ValorUnitarioDepreciacion = lector.IsDBNull(lector.GetOrdinal("ValorUnitarioDepreciacion")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("ValorUnitarioDepreciacion")),
                            area_construida = lector.IsDBNull(lector.GetOrdinal("area_construida")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("area_construida")),
                            valor_comun = lector.IsDBNull(lector.GetOrdinal("valor_comun")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_comun")),
                            valor_construido_total = lector.IsDBNull(lector.GetOrdinal("valor_construido_total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_construido_total"))
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
        public List<Repo_PredioRustico> ListarImpuestoRusticoConFormato(string predio_ID, int idPeriodo)
        {
            try
            {
                var coleccion = new List<Repo_PredioRustico>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PredioRustico
                        {
                            // Determinacion Impuesto
                            numero = lector.IsDBNull(lector.GetOrdinal("numero")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("numero")),
                            antiguedad = lector.IsDBNull(lector.GetOrdinal("antiguedad")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("antiguedad")),
                            DescripcionAntiguedad = lector.IsDBNull(lector.GetOrdinal("DescripcionAntiguedad")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionAntiguedad")),
                            fecha_construc = lector.IsDBNull(lector.GetOrdinal("fecha_construc")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_construc")),
                            piso_clasificacion = lector.IsDBNull(lector.GetOrdinal("piso_clasificacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("piso_clasificacion")),
                            DescripcionPisoClasificacion = lector.IsDBNull(lector.GetOrdinal("DescripcionPisoClasificacion")) ? default(string) : lector.GetString(lector.GetOrdinal("DescripcionPisoClasificacion")),
                            valor_unitario = lector.IsDBNull(lector.GetOrdinal("valor_unitario")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_unitario")),
                            porcent_depreci = lector.IsDBNull(lector.GetOrdinal("porcent_depreci")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("porcent_depreci")),
                            ValorUnitarioDepreciacion = lector.IsDBNull(lector.GetOrdinal("ValorUnitarioDepreciacion")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("ValorUnitarioDepreciacion")),
                            area_construida = lector.IsDBNull(lector.GetOrdinal("area_construida")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("area_construida")),
                            valor_comun = lector.IsDBNull(lector.GetOrdinal("valor_comun")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_comun")),
                            valor_construido_total = lector.IsDBNull(lector.GetOrdinal("valor_construido_total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_construido_total"))
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
