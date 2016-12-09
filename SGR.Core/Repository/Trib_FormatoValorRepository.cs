using System;
using System.Collections.Generic;
using SGR.Entity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
namespace SGR.Core
{
    public class Trib_FormatoValorRepository
    {
        private const String nombreprocedimiento = "_trib_formato_valores";
        private const String NombreTabla = "formato_valores";
        private Database db = DatabaseFactory.CreateDatabase();


        public List<Trib_FormatoValor> listartodos()
        {
            try
            {
                var coleccion = new List<Trib_FormatoValor>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_FormatoValor
                        {
                            Valoc_iformato_valores_ID = lector.GetInt32(lector.GetOrdinal("formato_valores_ID")),
                            Valoc_vdescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            Valoc_vmot_determ = lector.IsDBNull(lector.GetOrdinal("mot_determ")) ? default(String) : lector.GetString(lector.GetOrdinal("mot_determ")),
                            Valoc_vmensaje = lector.IsDBNull(lector.GetOrdinal("mensaje")) ? default(String) : lector.GetString(lector.GetOrdinal("mensaje")),
                            Valoc_vbase_legal = lector.IsDBNull(lector.GetOrdinal("base_legal")) ? default(String) : lector.GetString(lector.GetOrdinal("base_legal")),
                            Valoc_vpie_pag = lector.IsDBNull(lector.GetOrdinal("pie_pag")) ? default(String) : lector.GetString(lector.GetOrdinal("pie_pag")),
                            Valoc_ianio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio")),
                            Valoc_vtipodoc = lector.IsDBNull(lector.GetOrdinal("tipodoc")) ? default(String) : lector.GetString(lector.GetOrdinal("tipodoc")),
                            Valoc_vtipodocDec = lector.IsDBNull(lector.GetOrdinal("tipodocdesc")) ? default(String) : lector.GetString(lector.GetOrdinal("tipodocdesc")),
                            Valoc_bactivo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo"))                            
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



        public List<Trib_FormatoValor> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }


        public virtual List<Trib_FormatoValor> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Trib_FormatoValor>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_FormatoValor
                        {
                            Valoc_iformato_valores_ID = lector.GetInt32(lector.GetOrdinal("formato_valores_ID")),
                            Valoc_vdescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            Valoc_vmot_determ = lector.IsDBNull(lector.GetOrdinal("mot_determ")) ? default(String) : lector.GetString(lector.GetOrdinal("mot_determ")),
                            Valoc_vmensaje = lector.IsDBNull(lector.GetOrdinal("mensaje")) ? default(String) : lector.GetString(lector.GetOrdinal("mensaje")),
                            Valoc_vbase_legal = lector.IsDBNull(lector.GetOrdinal("base_legal")) ? default(String) : lector.GetString(lector.GetOrdinal("base_legal")),
                            Valoc_vpie_pag = lector.IsDBNull(lector.GetOrdinal("pie_pag")) ? default(String) : lector.GetString(lector.GetOrdinal("pie_pag")),
                            Valoc_ianio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio")),
                            Valoc_vtipodoc = lector.IsDBNull(lector.GetOrdinal("tipodoc")) ? default(String) : lector.GetString(lector.GetOrdinal("tipodoc")),
                            Valoc_vtipodocDec = lector.IsDBNull(lector.GetOrdinal("tipodoc")) ? default(String) : lector.GetString(lector.GetOrdinal("tipodocdesc")),
                            Valoc_bactivo = lector.IsDBNull(lector.GetOrdinal("tipodoc")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo"))
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


        public virtual Trib_FormatoValor GetByPrimaryKey(Int32 formato_valores_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "formato_valores_ID", DbType.Int32, formato_valores_ID);
                var formato_valores = default(Trib_FormatoValor);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        formato_valores = new Trib_FormatoValor
                        {
                            Valoc_iformato_valores_ID = lector.GetInt32(lector.GetOrdinal("formato_valores_ID")),
                            Valoc_vdescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            Valoc_vmot_determ = lector.IsDBNull(lector.GetOrdinal("mot_determ")) ? default(String) : lector.GetString(lector.GetOrdinal("mot_determ")),
                            Valoc_vmensaje = lector.IsDBNull(lector.GetOrdinal("mensaje")) ? default(String) : lector.GetString(lector.GetOrdinal("mensaje")),
                            Valoc_vbase_legal = lector.IsDBNull(lector.GetOrdinal("base_legal")) ? default(String) : lector.GetString(lector.GetOrdinal("base_legal")),
                            Valoc_vpie_pag = lector.IsDBNull(lector.GetOrdinal("pie_pag")) ? default(String) : lector.GetString(lector.GetOrdinal("pie_pag")),
                            Valoc_ianio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio")),
                            Valoc_vtipodoc = lector.IsDBNull(lector.GetOrdinal("tipodoc")) ? default(String) : lector.GetString(lector.GetOrdinal("tipodoc")),
                            Valoc_vtipodocDec = lector.IsDBNull(lector.GetOrdinal("tipodoc")) ? default(String) : lector.GetString(lector.GetOrdinal("tipodocdesc")),
                            Valoc_bactivo = lector.IsDBNull(lector.GetOrdinal("tipodoc")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo"))
                        };
                    }
                }
                SQL.Dispose();
                return formato_valores;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "select fv.*,t.descripcion as tipodocdesc FROM formato_valores fv inner join tablas t on fv.tipodoc = t.valor ";
            if ((whereSql != null) && (whereSql.Trim().Length > 0))
            {
                sql += " WHERE t.dep_id=38 and " + whereSql;
            }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
            {
                sql += " ORDER BY " + orderBySql;
            }
            return sql;
        }

        public virtual int Insert(Trib_FormatoValor formato_valores)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "descripcion", DbType.String, formato_valores.Valoc_vdescripcion);
                db.AddInParameter(SQL, "mot_determ", DbType.String, formato_valores.Valoc_vmot_determ);
                db.AddInParameter(SQL, "mensaje", DbType.String, formato_valores.Valoc_vmensaje);
                db.AddInParameter(SQL, "base_legal", DbType.String, formato_valores.Valoc_vbase_legal);
                db.AddInParameter(SQL, "pie_pag", DbType.String, formato_valores.Valoc_vpie_pag);
                db.AddInParameter(SQL, "anio", DbType.Int32, formato_valores.Valoc_ianio);
                db.AddInParameter(SQL, "tipodoc", DbType.String, formato_valores.Valoc_vtipodoc);                
                db.AddInParameter(SQL, "estado", DbType.Byte, formato_valores.Valoc_bactivo);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, formato_valores.registro_user_add);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, formato_valores.registro_user_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
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


        public virtual void Update(Trib_FormatoValor formato_valores)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "formato_valores_ID", DbType.Int32, formato_valores.Valoc_iformato_valores_ID);
                db.AddInParameter(SQL, "descripcion", DbType.String, formato_valores.Valoc_vdescripcion);
                db.AddInParameter(SQL, "mot_determ", DbType.String, formato_valores.Valoc_vmot_determ);
                db.AddInParameter(SQL, "mensaje", DbType.String, formato_valores.Valoc_vmensaje);
                db.AddInParameter(SQL, "base_legal", DbType.String, formato_valores.Valoc_vbase_legal);
                db.AddInParameter(SQL, "pie_pag", DbType.String, formato_valores.Valoc_vpie_pag);
                db.AddInParameter(SQL, "anio", DbType.Int32, formato_valores.Valoc_ianio);
                db.AddInParameter(SQL, "tipodoc", DbType.Byte, formato_valores.Valoc_vtipodoc);              
                db.AddInParameter(SQL, "estado", DbType.Byte, formato_valores.Valoc_bactivo);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, formato_valores.registro_user_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
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


        public virtual bool DeleteByPrimaryKey(Int32 formato_valores_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "formato_valores_ID", DbType.Int32, formato_valores_ID);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);
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

        public Trib_FormatoValor buscarByAnioByTipoValor(Int32 anio, string tipodoc)
        {
            try
            {
                Trib_FormatoValor trib_FormatoValor = new Trib_FormatoValor();
                var coleccion = new List<Trib_FormatoValor>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "tipodoc", DbType.Byte, tipodoc);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 7);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {

                        trib_FormatoValor.Valoc_iformato_valores_ID = lector.GetInt32(lector.GetOrdinal("formato_valores_ID"));
                        trib_FormatoValor.Valoc_vdescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion"));
                        trib_FormatoValor.Valoc_vmot_determ = lector.IsDBNull(lector.GetOrdinal("mot_determ")) ? default(String) : lector.GetString(lector.GetOrdinal("mot_determ"));
                        trib_FormatoValor.Valoc_vmensaje = lector.IsDBNull(lector.GetOrdinal("mensaje")) ? default(String) : lector.GetString(lector.GetOrdinal("mensaje"));
                        trib_FormatoValor.Valoc_vbase_legal = lector.IsDBNull(lector.GetOrdinal("base_legal")) ? default(String) : lector.GetString(lector.GetOrdinal("base_legal"));
                        trib_FormatoValor.Valoc_vpie_pag = lector.IsDBNull(lector.GetOrdinal("pie_pag")) ? default(String) : lector.GetString(lector.GetOrdinal("pie_pag"));
                        trib_FormatoValor.Valoc_ianio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio"));
                        trib_FormatoValor.Valoc_vtipodoc = lector.IsDBNull(lector.GetOrdinal("tipodoc")) ? default(String) : lector.GetString(lector.GetOrdinal("tipodoc"));
                        trib_FormatoValor.Valoc_vtipodocDec = lector.IsDBNull(lector.GetOrdinal("tipodocdesc")) ? default(String) : lector.GetString(lector.GetOrdinal("tipodocdesc"));
                        trib_FormatoValor.Valoc_bactivo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo"));
                    }
                }
                SQL.Dispose();
                return trib_FormatoValor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
