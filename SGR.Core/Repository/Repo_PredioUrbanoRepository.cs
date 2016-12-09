using Microsoft.Practices.EnterpriseLibrary.Data;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using SGR.Entity;
namespace SGR.Core.Repository
{
    public class Repo_PredioUrbanoRepository
    {
        private const String nombreprocedimiento = "_Repo_PredioUrbano";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Repo_PredioUrbano> ListarDatosContribuyente(string persona_id)
        {
            try
            {
                var coleccion = new List<Repo_PredioUrbano>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PredioUrbano
                        {
                            persona_id = lector.IsDBNull(lector.GetOrdinal("persona_id")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_id")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                            DescripcionDocumento = lector.IsDBNull(lector.GetOrdinal("DescripcionDocumento")) ? default(String) : lector.GetString(lector.GetOrdinal("DescripcionDocumento"))
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
        public List<Repo_PredioUrbano> ListarDatosPredio(string predio_ID,int idPeriodo)
        {
            try
            {
                var coleccion = new List<Repo_PredioUrbano>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PredioUrbano
                        {
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion_completa")),
                            uso_predio = lector.IsDBNull(lector.GetOrdinal("uso_predio")) ? default(String) : lector.GetString(lector.GetOrdinal("uso_predio")),
                            DescripcionUsoPredio = lector.IsDBNull(lector.GetOrdinal("DescripcionUsoPredio")) ? default(String) : lector.GetString(lector.GetOrdinal("DescripcionUsoPredio")),
                            estado_predio = lector.IsDBNull(lector.GetOrdinal("estado_predio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("estado_predio")),
                            DescripcionEstadoPredio = lector.IsDBNull(lector.GetOrdinal("DescripcionEstadoPredio")) ? default(String) : lector.GetString(lector.GetOrdinal("DescripcionEstadoPredio")),
                            tipo_predio = lector.IsDBNull(lector.GetOrdinal("tipo_predio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tipo_predio")),
                            DescripcionTipoPredio = lector.IsDBNull(lector.GetOrdinal("DescripcionTipoPredio")) ? default(String) : lector.GetString(lector.GetOrdinal("DescripcionTipoPredio")),
                            piso_material = lector.IsDBNull(lector.GetOrdinal("piso_material")) ? default(int) : lector.GetInt32(lector.GetOrdinal("piso_material")),
                            DescripcionMaterPredom = lector.IsDBNull(lector.GetOrdinal("DescripcionMaterPredom")) ? default(String) : lector.GetString(lector.GetOrdinal("DescripcionMaterPredom"))
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

        public List<Repo_PredioUrbano> ListarImpuestoUrbano(string predio_ID, int idPeriodo)
        {
            try
            {
                var coleccion = new List<Repo_PredioUrbano>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PredioUrbano
                        {
                            // Determinacion Impuesto Predio Urbano
                            //predio_ID = lector.IsDBNull(lector.GetOrdinal("predio_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_ID")),
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
        public List<Repo_PredioUrbano> ListarImpuestoUrbanoConFormato(string predio_ID, int idPeriodo)
        {
            try
            {
                var coleccion = new List<Repo_PredioUrbano>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PredioUrbano
                        {
                            // Determinacion Impuesto Predio Urbano
                            //predio_ID = lector.IsDBNull(lector.GetOrdinal("predio_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_ID")),
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
        public Pred_Predio DataPredial(string predio_ID, int idPeriodo)
        {
            try
            {
                var coleccion = new List<Repo_PredioUrbano>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                var Predio = default(Pred_Predio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                        //area_terreno,arancel,valor_otra_instalacion,valor_terreno,valor_construccion,total_autovaluo

                            Predio = new Pred_Predio
                        {
                                area_terreno = lector.IsDBNull(lector.GetOrdinal("area_terreno")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("area_terreno")),
                                arancel = lector.IsDBNull(lector.GetOrdinal("arancel")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("arancel")),
                                valor_otra_instalacion = lector.IsDBNull(lector.GetOrdinal("valor_otra_instalacion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_otra_instalacion")),
                                valor_terreno = lector.IsDBNull(lector.GetOrdinal("valor_terreno")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_terreno")),
                                valor_construccion = lector.IsDBNull(lector.GetOrdinal("valor_construccion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_construccion")),
                                total_autovaluo = lector.IsDBNull(lector.GetOrdinal("total_autovaluo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("total_autovaluo"))

                        };
                    }
              
                SQL.Dispose();
                return Predio;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
