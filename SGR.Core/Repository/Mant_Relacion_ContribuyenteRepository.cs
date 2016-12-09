using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace SGR.Core.Repository
{
    public class Mant_Relacion_ContribuyenteRepository
    {
        private const String nombreprocedimiento = "_Mant_Relacion_Contribuyente";
        private const String NombreTabla = "Relacion_Contribuyente";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Mant_Relacion_Contribuyente> listartodos(String allegado)
        {
            try
            {
                var coleccion = new List<Mant_Relacion_Contribuyente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "cod_allegado", DbType.String, allegado);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Relacion_Contribuyente
                        {
                            relacion_ID = lector.GetInt32(lector.GetOrdinal("relacion_ID")),
                            cod_allegado = lector.GetString(lector.GetOrdinal("cod_allegado")),
                            razon_social = lector.GetString(lector.GetOrdinal("razon_social")),
                            ruc = lector.GetString(lector.GetOrdinal("ruc")),
                            tipo_relacion = lector.GetInt32(lector.GetOrdinal("tipo_relacion")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            tipo_relacion_descripcion = lector.GetString(lector.GetOrdinal("tipo_relacion_descripcion")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_update = lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_pc_update = lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_update = lector.GetInt32(lector.GetOrdinal("registro_user_update"))

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



        public List<Mant_Relacion_Contribuyente> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }


        public virtual List<Mant_Relacion_Contribuyente> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Mant_Relacion_Contribuyente>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Relacion_Contribuyente
                        {
                            relacion_ID = lector.GetInt32(lector.GetOrdinal("relacion_ID")),
                            cod_allegado = lector.GetString(lector.GetOrdinal("cod_allegado")),
                            razon_social = lector.GetString(lector.GetOrdinal("razon_social")),
                            ruc = lector.GetString(lector.GetOrdinal("ruc")),
                            tipo_relacion = lector.GetInt32(lector.GetOrdinal("tipo_relacion")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            tipo_relacion_descripcion = lector.GetString(lector.GetOrdinal("tipo_relacion_descripcion")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_update = lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_pc_update = lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_update = lector.GetInt32(lector.GetOrdinal("registro_user_update"))

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


        public List<Mant_Relacion_Contribuyente> ObtenerPorcod_allegado(String cod_allegado)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "cod_allegado", DbType.String);
                var coleccion = new List<Mant_Relacion_Contribuyente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Relacion_Contribuyente
                        {
                            relacion_ID = lector.GetInt32(lector.GetOrdinal("relacion_ID")),
                            cod_allegado = lector.GetString(lector.GetOrdinal("cod_allegado")),
                            razon_social = lector.GetString(lector.GetOrdinal("razon_social")),
                            ruc = lector.GetString(lector.GetOrdinal("ruc")),
                            tipo_relacion = lector.GetInt32(lector.GetOrdinal("tipo_relacion")),
                            tipo_relacion_descripcion = lector.GetString(lector.GetOrdinal("tipo_relacion_descripcion")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_update = lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_pc_update = lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_update = lector.GetInt32(lector.GetOrdinal("registro_user_update"))

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



        public virtual bool EliminarPorcod_allegado(String cod_allegado)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "cod_allegado", DbType.String);
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

        public List<Mant_Relacion_Contribuyente> ObtenerPorpersona_ID(String persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "persona_ID", DbType.String);
                var coleccion = new List<Mant_Relacion_Contribuyente>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Relacion_Contribuyente
                        {
                            relacion_ID = lector.GetInt32(lector.GetOrdinal("relacion_ID")),
                            cod_allegado = lector.GetString(lector.GetOrdinal("cod_allegado")),
                            razon_social = lector.GetString(lector.GetOrdinal("razon_social")),
                            ruc = lector.GetString(lector.GetOrdinal("ruc")),
                            tipo_relacion = lector.GetInt32(lector.GetOrdinal("tipo_relacion")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_update = lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_pc_update = lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //tipo_relacion_descripcion = lector.GetString(lector.GetOrdinal("tipo_relacion_descripcion")),
                            //registro_user_update = lector.GetInt32(lector.GetOrdinal("registro_user_update"))

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



        public virtual bool EliminarPorpersona_ID(String persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "persona_ID", DbType.String);
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

        public virtual Mant_Relacion_Contribuyente GetByPrimaryKey(Int32 relacion_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "relacion_ID", DbType.Int32, relacion_ID);
                var Mant_Relacion_Contribuyente = default(Mant_Relacion_Contribuyente);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Mant_Relacion_Contribuyente = new Mant_Relacion_Contribuyente
                        {
                            relacion_ID = lector.GetInt32(lector.GetOrdinal("relacion_ID")),
                            cod_allegado = lector.GetString(lector.GetOrdinal("cod_allegado")),
                            razon_social = lector.GetString(lector.GetOrdinal("razon_social")),
                            ruc = lector.GetString(lector.GetOrdinal("ruc")),
                            tipo_relacion = lector.GetInt32(lector.GetOrdinal("tipo_relacion")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_update = lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_pc_update = lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //tipo_relacion_descripcion = lector.GetString(lector.GetOrdinal("tipo_relacion_descripcion")),
                            //registro_user_update = lector.GetInt32(lector.GetOrdinal("registro_user_update"))

                        };
                    }
                }
                SQL.Dispose();
                return Mant_Relacion_Contribuyente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT * FROM [dbo].[Mant_Relacion_Contribuyente]";
            if ((whereSql != null) && (whereSql.Trim().Length > 0))
            {
                sql += " WHERE " + whereSql;
            }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
            {
                sql += " ORDER BY " + orderBySql;
            }
            return sql;
        }

        public virtual int Insert(Mant_Relacion_Contribuyente Mant_Relacion_Contribuyente)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "cod_allegado", DbType.String, Mant_Relacion_Contribuyente.cod_allegado);
                db.AddInParameter(SQL, "tipo_relacion", DbType.Int32, Mant_Relacion_Contribuyente.tipo_relacion);
                db.AddInParameter(SQL, "persona_ID", DbType.String, Mant_Relacion_Contribuyente.persona_ID);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Mant_Relacion_Contribuyente.estado);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Mant_Relacion_Contribuyente.registro_user_add);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Mant_Relacion_Contribuyente Mant_Relacion_Contribuyente)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "relacion_ID", DbType.Int32, Mant_Relacion_Contribuyente.relacion_ID);
                db.AddInParameter(SQL, "tipo_relacion", DbType.Int32, Mant_Relacion_Contribuyente.tipo_relacion);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Mant_Relacion_Contribuyente.estado);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Mant_Relacion_Contribuyente.registro_user_update);
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


        public virtual bool DeleteByPrimaryKey(Int32 relacion_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "relacion_ID", DbType.Int32, relacion_ID);
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
        public List<Mant_Relacion_Contribuyente> listarRelacionporContribuyente(string persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                var coleccion = new List<Mant_Relacion_Contribuyente>();
                using(var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Relacion_Contribuyente
                        {
                            relacion_ID = lector.GetInt32(lector.GetOrdinal("relacion_ID")),
                            razon_social = lector.GetString(lector.GetOrdinal("razon_social")),
                            persona_ID = lector.GetString(lector.GetOrdinal("direccCompleta")),
                            tipo_relacion_descripcion = lector.GetString(lector.GetOrdinal("relacion")),
                            ruc = lector.GetString(lector.GetOrdinal("tipo_documento")) + " " + lector.GetString(lector.GetOrdinal("ruc"))
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
