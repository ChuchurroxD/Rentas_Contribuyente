using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core;
using SGR.Entity;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace SGR.Core.Repository
{
    public class Pago_CajeroRepository
    {
        private const String nombreprocedimiento = "_pago_Cajero";
        private const String NombreTabla = "Cajero";
        private Database db = DatabaseFactory.CreateDatabase();


        public List<Pago_Cajero> listartodos()
        {
            try
            {
                var coleccion = new List<Pago_Cajero>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Cajero
                        {
                            Persona_id = lector.GetString(lector.GetOrdinal("Persona_id")).Trim(),
                            FechaInicio = lector.GetDateTime(lector.GetOrdinal("FechaInicio")),
                            FechaFin = lector.IsDBNull(lector.GetOrdinal("FechaFin")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaFin")),
                            Observacion = lector.IsDBNull(lector.GetOrdinal("Observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Observacion")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("Estado")),
                            persona_desc = lector.GetString(lector.GetOrdinal("Persona_Desc"))
                            //registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
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
        public List<Pago_Cajero> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }
        public virtual List<Pago_Cajero> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Pago_Cajero>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Cajero
                        {
                            Persona_id = lector.GetString(lector.GetOrdinal("Persona_id")).Trim(),
                            FechaInicio = lector.GetDateTime(lector.GetOrdinal("FechaInicio")),
                            FechaFin = lector.IsDBNull(lector.GetOrdinal("FechaFin")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaFin")),
                            Observacion = lector.IsDBNull(lector.GetOrdinal("Observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Observacion")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("Estado")),
                            persona_desc = lector.GetString(lector.GetOrdinal("Persona_Desc")),
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
        public List<Pago_Cajero> ObtenerPorPersona_id(String Persona_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "Persona_id", DbType.String);
                var coleccion = new List<Pago_Cajero>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Cajero
                        {
                            Persona_id = lector.GetString(lector.GetOrdinal("Persona_id")).Trim(),
                            FechaInicio = lector.GetDateTime(lector.GetOrdinal("FechaInicio")),
                            FechaFin = lector.IsDBNull(lector.GetOrdinal("FechaFin")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaFin")),
                            Observacion = lector.IsDBNull(lector.GetOrdinal("Observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Observacion")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("Estado")),
                            persona_desc = lector.GetString(lector.GetOrdinal("Persona_Desc"))
                            //registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

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
        public virtual bool EliminarPorPersona_id(String Persona_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "Persona_id", DbType.String);
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
        public virtual Pago_Cajero GetByPrimaryKey(String Persona_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 7);
                db.AddInParameter(SQL, "Persona_id", DbType.String, Persona_id);
                var Cajero = default(Pago_Cajero);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Cajero = new Pago_Cajero
                        {
                            Persona_id = lector.GetString(lector.GetOrdinal("Persona_id")).Trim(),
                            FechaInicio = lector.GetDateTime(lector.GetOrdinal("FechaInicio")),
                            FechaFin = lector.IsDBNull(lector.GetOrdinal("FechaFin")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("FechaFin")),
                            Observacion = lector.IsDBNull(lector.GetOrdinal("Observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Observacion")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("Estado")),
                            persona_desc = lector.GetString(lector.GetOrdinal("Persona_Desc"))
                            //registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
                        };
                    }
                }
                SQL.Dispose();
                return Cajero;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "select c.Persona_id,p.NombreCompleto as Persona_Desc,FechaInicio,(case when FechaFin is null then '1900/01/01'" +
                            "else FechaFin end) as FechaFin,(case when c.Observacion is null then ''else c.Observacion end)as Observacion,c.estado," +
                            "c.registro_fecha_add,c.registro_fecha_update,c.registro_pc_add,c.registro_pc_update,c.registro_user_add,c.registro_user_update " +
                            "from Cajero c inner join Persona p on c.Persona_id = p.persona_ID";
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

        public virtual int Insert(Pago_Cajero Cajero)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Persona_id", DbType.String, Cajero.Persona_id);
                db.AddInParameter(SQL, "FechaInicio", DbType.DateTime, Cajero.FechaInicio);
                //db.AddInParameter(SQL, "FechaFin", DbType.DateTime, Cajero.FechaFin);
                db.AddInParameter(SQL, "Observacion", DbType.String, Cajero.Observacion);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, Cajero.Estado);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Cajero.registro_fecha_add);
                //db.AddInParameter(SQL, "registro_user_add", DbType.Int32, Cajero.registro_user_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, Cajero.registro_pc_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Cajero.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_user_update", DbType.Int32, Cajero.registro_user_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, Cajero.registro_pc_update);
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


        public virtual void Update(Pago_Cajero Cajero)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Persona_id", DbType.String, Cajero.Persona_id);
                db.AddInParameter(SQL, "FechaInicio", DbType.DateTime, Cajero.FechaInicio);
                db.AddInParameter(SQL, "FechaFin", DbType.DateTime, Cajero.FechaFin);
                db.AddInParameter(SQL, "Observacion", DbType.String, Cajero.Observacion);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, Cajero.Estado);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Cajero.registro_fecha_add);
                //db.AddInParameter(SQL, "registro_user_add", DbType.Int32, Cajero.registro_user_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, Cajero.registro_pc_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Cajero.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_user_update", DbType.Int32, Cajero.registro_user_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, Cajero.registro_pc_update);
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


        public virtual bool DeleteByPrimaryKey(String Persona_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Persona_id", DbType.String, Persona_id);
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
        public List<Pago_Cajero> llenarcomboCajero()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 9);
                var coleccion = new List<Pago_Cajero>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Cajero
                        {
                            Persona_id = lector.GetString(lector.GetOrdinal("persona_ID")).Trim(),
                            persona_desc = lector.GetString(lector.GetOrdinal("NombreCompleto"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Cajero> llenarcomboCajerov2()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 10);
                var coleccion = new List<Pago_Cajero>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Cajero
                        {
                            Persona_id = lector.GetString(lector.GetOrdinal("persona_ID")).Trim(),
                            persona_desc = lector.GetString(lector.GetOrdinal("NombreCompleto"))
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
