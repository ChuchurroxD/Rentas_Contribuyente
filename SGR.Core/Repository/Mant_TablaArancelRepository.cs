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
    public class Mant_TablaArancelRepository
    {
        private const String nombreprocedimiento = "_Mant_TablaArancel";
        private const String NombreTabla = "TablaArancel";
        private Database db = DatabaseFactory.CreateDatabase();


        public List<Mant_TablaArancel> listartodos()
        {
            try
            {
                var coleccion = new List<Mant_TablaArancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TablaArancel
                        {
                            idTablaArancel = lector.IsDBNull(lector.GetOrdinal("idTablaArancel")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idTablaArancel")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            Estado = lector.IsDBNull(lector.GetOrdinal("Estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("Estado"))

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

        public List<Mant_TablaArancel> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }

        public virtual List<Mant_TablaArancel> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Mant_TablaArancel>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TablaArancel
                        {
                            idTablaArancel = lector.GetInt32(lector.GetOrdinal("idTablaArancel")),
                            Descripcion = lector.GetString(lector.GetOrdinal("Descripcion")),
                            Estado = lector.IsDBNull(lector.GetOrdinal("Estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("Estado")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
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
        
        public virtual Mant_TablaArancel GetByPrimaryKey()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                var TablaArancel = default(Mant_TablaArancel);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        TablaArancel = new Mant_TablaArancel
                        {
                            idTablaArancel = lector.GetInt32(lector.GetOrdinal("idTablaArancel")),
                            Descripcion = lector.GetString(lector.GetOrdinal("Descripcion")),
                            Estado = lector.IsDBNull(lector.GetOrdinal("Estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("Estado")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

                        };
                    }
                }
                SQL.Dispose();
                return TablaArancel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT * FROM [dbo].[TablaArancel]";
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

        public virtual void Insert(Mant_TablaArancel mant_TablaArancel)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Descripcion", DbType.String, mant_TablaArancel.Descripcion);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, mant_TablaArancel.Estado);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, mant_TablaArancel.registro_user_add);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
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

        public virtual void Update(Mant_TablaArancel mant_TablaArancel)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idTablaArancel", DbType.Int32, mant_TablaArancel.idTablaArancel);
                db.AddInParameter(SQL, "Descripcion", DbType.String, mant_TablaArancel.Descripcion);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, mant_TablaArancel.Estado);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, mant_TablaArancel.registro_user_update);
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

        public virtual bool DeleteByPrimaryKey()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
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
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
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

        public List<Mant_TablaArancel> llenarcomboTablaArancel()
        {
            try
            {
                var coleccion = new List<Mant_TablaArancel>();
                DbCommand sql = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(sql, "Tipoconsulta", DbType.Byte, 7);
                using (var lector = db.ExecuteReader(sql))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TablaArancel
                        {
                            idTablaArancel = lector.GetInt32(lector.GetOrdinal("idTablaArancel")),
                            Descripcion = lector.GetString(lector.GetOrdinal("Descripcion"))
                        });
                    }
                }
                sql.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_TablaArancel> listarActivosConCosto(String predio_id,String idPeriodo)
        {
            try
            {
                var coleccion = new List<Mant_TablaArancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, idPeriodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TablaArancel
                        {
                            idTablaArancel = lector.GetInt32(lector.GetOrdinal("idTablaArancel")),
                            Descripcion = lector.GetString(lector.GetOrdinal("Descripcion")),
                            Costo = lector.GetDecimal(lector.GetOrdinal("Costo"))

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

        public virtual Int32 GetExisteDescripcionNuevo(String descripcion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Descripcion", DbType.String, descripcion);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 10);                
                Int32 total = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total = lector.GetInt32(lector.GetOrdinal("TOTAL"));
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

        public virtual Int32 GetExisteDescripcionModificar(Int32 id, String descripcion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idTablaArancel", DbType.Int32, id);
                db.AddInParameter(SQL, "Descripcion", DbType.String, descripcion);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 11);//cambiar tipo
                Int32 total = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total = lector.GetInt32(lector.GetOrdinal("TOTAL"));
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

