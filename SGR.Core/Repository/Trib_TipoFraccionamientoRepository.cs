using System;
using System.Collections.Generic;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;


namespace SGR.Core
{
    public class Trib_TipoFraccionamientoRepository
    {
        private const String nombreprocedimiento = "_Trib_TipoFraccionamiento";
        private const String NombreTabla = "TipoFraccionamiento";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Trib_TributoFraccionamiento> listarTributosFraccionamiento(int codigo)
        {
            try
            {
                var coleccion = new List<Trib_TributoFraccionamiento>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8); 
                db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, codigo);
                using (var lector = db.ExecuteReader(SQL))
                {
                     
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_TributoFraccionamiento
                        {
                            TrFrc_icod = lector.GetInt32(lector.GetOrdinal("cod")),
                            TrFrc_vtrib = lector.GetString(lector.GetOrdinal("trib")),
                            TrFrc_vtribDesc = lector.GetString(lector.GetOrdinal("trib_desc")),
                            TrFrc_vabrev = lector.GetString(lector.GetOrdinal("abrev")),
                            TrFrc_dimporte = lector.GetDecimal(lector.GetOrdinal("importe")),
                            TrFrc_vgrupo = lector.GetString(lector.GetOrdinal("grupo")),
                            TrFrc_vgrupodesc = lector.GetString(lector.GetOrdinal("grupo_desc"))                            
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
        public virtual int InsertTributoFracc(Trib_TributoFraccionamiento TributoTipoFracc)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributoid", DbType.String, TributoTipoFracc.TrFrc_vtrib);
                db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, TributoTipoFracc.TrFrc_icod);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 11);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                SQL.Dispose();
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int EliminaTributoFracc(int codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 13);
                db.AddInParameter(SQL, "trib_tfraccionamiento_id", DbType.Int32, codigo);                
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                    return 0;
                else return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual int EliminaTributosFracc()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 14);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                    return 0;
                else return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Trib_TributoFraccionamiento> listarTributosporTipo(int codigo,int tipoTributo)
        {
            try
            {
                var coleccion = new List<Trib_TributoFraccionamiento>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "tipoTributo", DbType.Int32, tipoTributo); 
                db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, codigo);
                using (var lector = db.ExecuteReader(SQL))
                {

                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_TributoFraccionamiento
                        {
                            TrFrc_vtrib = lector.GetString(lector.GetOrdinal("trib")),
                            TrFrc_vtribDesc = lector.GetString(lector.GetOrdinal("trib_desc")),                         
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
        public List<Trib_TipoFraccionamiento> listartodos()
        {
            try
            {
                var coleccion = new List<Trib_TipoFraccionamiento>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_TipoFraccionamiento
                        {
                            TiFr_tipo_fraccionamiento_ID = lector.GetInt32(lector.GetOrdinal("tipo_fraccionamiento_ID")),
                            TiFr_max_cuotas = lector.GetInt32(lector.GetOrdinal("max_cuotas")),
                            TiFr_cuota_inicial = lector.GetDecimal(lector.GetOrdinal("cuota_inicial")),
                            TiFr_porce_inicial = lector.GetDecimal(lector.GetOrdinal("porce_inicial")),
                            TiFr_cuota_minima = lector.GetDecimal(lector.GetOrdinal("cuota_minima")),
                            TiFr_fecha_inicio = lector.GetDateTime(lector.GetOrdinal("fecha_inicio")),
                            TiFr_fecha_fin = lector.GetDateTime(lector.GetOrdinal("fecha_fin")),
                            TiFr_anio_inicio = lector.GetInt32(lector.GetOrdinal("anio_inicio")),
                            TiFr_anio_fin = lector.GetInt32(lector.GetOrdinal("anio_fin")),
                            TiFr_interes_moratorio = lector.GetBoolean(lector.GetOrdinal("interes_moratorio")),
                            TiFr_interes_compensa = lector.GetDecimal(lector.GetOrdinal("interes_compensa")),
                            TiFr_descuento = lector.GetDecimal(lector.GetOrdinal("descuento")),
                            TiFr_base_legal = lector.GetString(lector.GetOrdinal("base_legal")),
                            TiFr_monto_derecho = lector.GetDecimal(lector.GetOrdinal("monto_derecho")),
                            TiFr_modalidad = lector.GetString(lector.GetOrdinal("modalidad")),
                            TiFr_tipo_f = lector.IsDBNull(lector.GetOrdinal("tipo_f")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_f")),
                            TiFr_estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            TiFr_max_uit = lector.IsDBNull(lector.GetOrdinal("max_uit")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("max_uit")),
                            TiFr_modalidadDesc= lector.GetString(lector.GetOrdinal("modalidadDesc")),
                            TiFr_tipo_fDesc= lector.GetString(lector.GetOrdinal("tipo_fDesc"))
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
        public List<Trib_TipoFraccionamiento> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }
        public virtual List<Trib_TipoFraccionamiento> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Trib_TipoFraccionamiento>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_TipoFraccionamiento
                        {
                            TiFr_tipo_fraccionamiento_ID = lector.GetInt32(lector.GetOrdinal("tipo_fraccionamiento_ID")),
                            TiFr_max_cuotas = lector.GetInt32(lector.GetOrdinal("max_cuotas")),
                            TiFr_cuota_inicial = lector.GetDecimal(lector.GetOrdinal("cuota_inicial")),
                            TiFr_porce_inicial = lector.GetDecimal(lector.GetOrdinal("porce_inicial")),
                            TiFr_cuota_minima = lector.GetDecimal(lector.GetOrdinal("cuota_minima")),
                            TiFr_fecha_inicio = lector.GetDateTime(lector.GetOrdinal("fecha_inicio")),
                            TiFr_fecha_fin = lector.GetDateTime(lector.GetOrdinal("fecha_fin")),
                            TiFr_anio_inicio = lector.GetInt32(lector.GetOrdinal("anio_inicio")),
                            TiFr_anio_fin = lector.GetInt32(lector.GetOrdinal("anio_fin")),
                            TiFr_interes_moratorio = lector.GetBoolean(lector.GetOrdinal("interes_moratorio")),
                            TiFr_interes_compensa = lector.GetDecimal(lector.GetOrdinal("interes_compensa")),
                            TiFr_descuento = lector.GetDecimal(lector.GetOrdinal("descuento")),
                            TiFr_base_legal = lector.GetString(lector.GetOrdinal("base_legal")),
                            TiFr_monto_derecho = lector.GetDecimal(lector.GetOrdinal("monto_derecho")),
                            TiFr_modalidad = lector.GetString(lector.GetOrdinal("modalidad")),
                            TiFr_tipo_f = lector.IsDBNull(lector.GetOrdinal("tipo_f")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_f")),
                            TiFr_estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            TiFr_max_uit = lector.IsDBNull(lector.GetOrdinal("max_uit")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("max_uit")),
                            TiFr_modalidadDesc = lector.GetString(lector.GetOrdinal("modalidadDesc")),
                            TiFr_tipo_fDesc = lector.GetString(lector.GetOrdinal("tipo_fDesc"))
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
        public virtual Trib_TipoFraccionamiento GetByPrimaryKey(int codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Byte, codigo);
                var TipoFraccionamiento = default(Trib_TipoFraccionamiento);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        TipoFraccionamiento = new Trib_TipoFraccionamiento
                        {
                            TiFr_tipo_fraccionamiento_ID = lector.GetInt32(lector.GetOrdinal("tipo_fraccionamiento_ID")),
                            TiFr_max_cuotas = lector.GetInt32(lector.GetOrdinal("max_cuotas")),
                            TiFr_cuota_inicial = lector.GetDecimal(lector.GetOrdinal("cuota_inicial")),
                            TiFr_porce_inicial = lector.GetDecimal(lector.GetOrdinal("porce_inicial")),
                            TiFr_cuota_minima = lector.GetDecimal(lector.GetOrdinal("cuota_minima")),
                            TiFr_fecha_inicio = lector.GetDateTime(lector.GetOrdinal("fecha_inicio")),
                            TiFr_fecha_fin = lector.GetDateTime(lector.GetOrdinal("fecha_fin")),
                            TiFr_anio_inicio = lector.GetInt32(lector.GetOrdinal("anio_inicio")),
                            TiFr_anio_fin = lector.GetInt32(lector.GetOrdinal("anio_fin")),
                            TiFr_interes_moratorio = lector.GetBoolean(lector.GetOrdinal("interes_moratorio")),
                            TiFr_interes_compensa = lector.GetDecimal(lector.GetOrdinal("interes_compensa")),
                            TiFr_descuento = lector.GetDecimal(lector.GetOrdinal("descuento")),
                            TiFr_base_legal = lector.GetString(lector.GetOrdinal("base_legal")),
                            TiFr_monto_derecho = lector.GetDecimal(lector.GetOrdinal("monto_derecho")),
                            TiFr_modalidad = lector.GetString(lector.GetOrdinal("modalidad")),
                            TiFr_tipo_f = lector.IsDBNull(lector.GetOrdinal("tipo_f")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_f")),
                            TiFr_estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            TiFr_max_uit = lector.IsDBNull(lector.GetOrdinal("max_uit")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("max_uit")),
                            TiFr_modalidadDesc = lector.GetString(lector.GetOrdinal("modalidadDesc")),
                            TiFr_tipo_fDesc = lector.GetString(lector.GetOrdinal("tipo_fDesc"))
                        };
                    }
                }
                SQL.Dispose();
                return TipoFraccionamiento;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT T.*,TA.descripcion AS modalidadDesc,TAB.descripcion AS tipo_fDesc FROM TipoFraccionamiento T " +
                "INNER JOIN TABLAS TA ON T.modalidad = TA.valor INNER JOIN tablas TAB ON T.tipo_f = TAB.valor";
            if ((whereSql != null) && (whereSql.Trim().Length > 0))
            {
                sql += " WHERE TA.dep_id = '47' AND TAB.dep_id = '49' and " + whereSql;
            }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
            {
                sql += " ORDER BY " + orderBySql;
            }
            return sql;
        }
        public virtual int Insert(Trib_TipoFraccionamiento TipoFraccionamiento)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "max_cuotas", DbType.Int32, TipoFraccionamiento.TiFr_max_cuotas);
                db.AddInParameter(SQL, "cuota_inicial", DbType.Single, TipoFraccionamiento.TiFr_cuota_inicial);
                db.AddInParameter(SQL, "porce_inicial", DbType.Single, TipoFraccionamiento.TiFr_porce_inicial);
                db.AddInParameter(SQL, "cuota_minima", DbType.Single, TipoFraccionamiento.TiFr_cuota_minima);
                db.AddInParameter(SQL, "fecha_inicio", DbType.DateTime, TipoFraccionamiento.TiFr_fecha_inicio);
                db.AddInParameter(SQL, "fecha_fin", DbType.DateTime, TipoFraccionamiento.TiFr_fecha_fin);
                db.AddInParameter(SQL, "anio_inicio", DbType.Int32, TipoFraccionamiento.TiFr_anio_inicio);
                db.AddInParameter(SQL, "anio_fin", DbType.Int32, TipoFraccionamiento.TiFr_anio_fin);
                db.AddInParameter(SQL, "interes_moratorio", DbType.Boolean, TipoFraccionamiento.TiFr_interes_moratorio);
                db.AddInParameter(SQL, "interes_compensa", DbType.Single, TipoFraccionamiento.TiFr_interes_compensa);
                db.AddInParameter(SQL, "descuento", DbType.Single, TipoFraccionamiento.TiFr_descuento);
                db.AddInParameter(SQL, "base_legal", DbType.String, TipoFraccionamiento.TiFr_base_legal);
                db.AddInParameter(SQL, "monto_derecho", DbType.Single, TipoFraccionamiento.TiFr_monto_derecho);
                db.AddInParameter(SQL, "modalidad", DbType.String, TipoFraccionamiento.TiFr_modalidad);
                db.AddInParameter(SQL, "tipo_f", DbType.String, 'N');
                db.AddInParameter(SQL, "estado", DbType.Boolean, TipoFraccionamiento.TiFr_estado);
                db.AddInParameter(SQL, "max_uit", DbType.Int32, TipoFraccionamiento.TiFr_max_uit);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                int insertado=0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        insertado = lector.GetInt32(lector.GetOrdinal("valor"));
                    }
                }                
                SQL.Dispose();
                return insertado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void actualizarTributos(int codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
               
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
                db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, codigo);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void Update(Trib_TipoFraccionamiento TipoFraccionamiento)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "max_cuotas", DbType.Int32, TipoFraccionamiento.TiFr_max_cuotas);
                db.AddInParameter(SQL, "cuota_inicial", DbType.Single, TipoFraccionamiento.TiFr_cuota_inicial);
                db.AddInParameter(SQL, "porce_inicial", DbType.Single, TipoFraccionamiento.TiFr_porce_inicial);
                db.AddInParameter(SQL, "cuota_minima", DbType.Single, TipoFraccionamiento.TiFr_cuota_minima);
                db.AddInParameter(SQL, "fecha_inicio", DbType.DateTime, TipoFraccionamiento.TiFr_fecha_inicio);
                db.AddInParameter(SQL, "fecha_fin", DbType.DateTime, TipoFraccionamiento.TiFr_fecha_fin);
                db.AddInParameter(SQL, "anio_inicio", DbType.Int32, TipoFraccionamiento.TiFr_anio_inicio);
                db.AddInParameter(SQL, "anio_fin", DbType.Int32, TipoFraccionamiento.TiFr_anio_fin);
                db.AddInParameter(SQL, "interes_moratorio", DbType.Boolean, TipoFraccionamiento.TiFr_interes_moratorio);
                db.AddInParameter(SQL, "interes_compensa", DbType.Single, TipoFraccionamiento.TiFr_interes_compensa);
                db.AddInParameter(SQL, "descuento", DbType.Single, TipoFraccionamiento.TiFr_descuento);
                db.AddInParameter(SQL, "base_legal", DbType.String, TipoFraccionamiento.TiFr_base_legal);
                db.AddInParameter(SQL, "monto_derecho", DbType.Single, TipoFraccionamiento.TiFr_monto_derecho);
                db.AddInParameter(SQL, "modalidad", DbType.String, TipoFraccionamiento.TiFr_modalidad);
                db.AddInParameter(SQL, "estado", DbType.Boolean, TipoFraccionamiento.TiFr_estado);
                db.AddInParameter(SQL, "max_uit", DbType.Int32, TipoFraccionamiento.TiFr_max_uit);
                db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, TipoFraccionamiento.TiFr_tipo_fraccionamiento_ID);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool DeleteByPrimaryKey(int codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, codigo);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool DeleteAll()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 6);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
