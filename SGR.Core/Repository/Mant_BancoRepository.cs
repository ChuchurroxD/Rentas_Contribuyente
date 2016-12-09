using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace SGR.Core.Repository
{
    public class Mant_BancoRepository
    {
        private const String nombreprocedimiento = "_Mant_Banco";
        private const String NombreTabla = "banco";
        private Database db = DatabaseFactory.CreateDatabase();


        public List<Mant_Banco> listartodos()
        {
            try
            {
                var coleccion = new List<Mant_Banco>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Banco
                        {
                            banco_ID = lector.GetInt32(lector.GetOrdinal("banco_ID")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default (string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

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

        public List<Mant_Banco> listarActivos()
        {
            try
            {
                var coleccion = new List<Mant_Banco>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Banco
                        {
                            banco_ID = lector.GetInt32(lector.GetOrdinal("banco_ID")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

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



        public List<Mant_Banco> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }


        public virtual List<Mant_Banco> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Mant_Banco>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Banco
                        {
                            banco_ID = lector.GetInt32(lector.GetOrdinal("banco_ID")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default (string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

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


        public virtual Mant_Banco GetByPrimaryKey(Int32 banco_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "banco_ID", DbType.Int32, banco_ID);
                var banco = default(Mant_Banco);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        banco = new Mant_Banco
                        {
                            banco_ID = lector.GetInt32(lector.GetOrdinal("banco_ID")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

                        };
                    }
                }
                SQL.Dispose();
                return banco;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT * FROM [dbo].[banco]";
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

        public virtual void Insert(Mant_Banco banco)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "descripcion", DbType.String, banco.descripcion);
                db.AddInParameter(SQL, "estado", DbType.Boolean, banco.estado);
                db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, banco.registro_fecha_add);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, banco.registro_user_add);
                db.AddInParameter(SQL, "registro_pc_add", DbType.String, banco.registro_pc_add);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Mant_Banco banco)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "banco_ID", DbType.Int32, banco.banco_ID);
                db.AddInParameter(SQL, "descripcion", DbType.String, banco.descripcion);
                db.AddInParameter(SQL, "estado", DbType.Boolean, banco.estado);
                db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, banco.registro_fecha_add);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, banco.registro_user_add);
                db.AddInParameter(SQL, "registro_pc_add", DbType.String, banco.registro_pc_add);
                db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, banco.registro_fecha_update);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, banco.registro_user_update);
                db.AddInParameter(SQL, "registro_pc_update", DbType.String, banco.registro_pc_update);
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


        public virtual bool DeleteByPrimaryKey(Int32 banco_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "banco_ID", DbType.Int32, banco_ID);
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
        public int compararDescripcion(string descripcion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "descripcion", DbType.String, descripcion);
                int total = 0;
                using(var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total = lector.GetInt32(lector.GetOrdinal("total"));
                    }
                }
                SQL.Dispose();
                return total;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int compararDescripcionModificar(string descripcion, Int32 codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "descripcion", DbType.String, descripcion);
                db.AddInParameter(SQL, "banco_ID", DbType.Int32, codigo);
                int total = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total = lector.GetInt32(lector.GetOrdinal("total"));
                    }
                }
                SQL.Dispose();
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
