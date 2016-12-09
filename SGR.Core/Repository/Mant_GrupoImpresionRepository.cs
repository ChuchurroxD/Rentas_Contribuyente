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
    public class Mant_GrupoImpresionRepository
    {
        private const String nombreprocedimiento = "_Mant_GrupoImpresion";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Mant_GrupoImpresion> listartodos()
        {
            try
            {
                var coleccion = new List<Mant_GrupoImpresion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_GrupoImpresion
                        {
                            grupoImpresion_ID = lector.GetInt32(lector.GetOrdinal("grupoImpresion_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            tributo_descripcion = lector.GetString(lector.GetOrdinal("tributo_descripcion")),
                            grupoTipoImpresion = lector.GetString(lector.GetOrdinal("grupoTipoImpresion")),
                            grupoTipoImpresion_descripcion = lector.GetString(lector.GetOrdinal("grupoTipoImpresion_descripcion")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            periodo_ID = lector.GetInt32(lector.GetOrdinal("periodo_ID")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            tipo_tributo_descripcion = lector.GetString(lector.GetOrdinal("tipo_tributo_descripcion")),
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
        public List<Mant_GrupoImpresion> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }
        public virtual List<Mant_GrupoImpresion> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Mant_GrupoImpresion>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_GrupoImpresion
                        {
                            grupoImpresion_ID = lector.GetInt32(lector.GetOrdinal("grupoImpresion_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            tributo_descripcion = lector.GetString(lector.GetOrdinal("tributo_descripcion")),
                            grupoTipoImpresion = lector.GetString(lector.GetOrdinal("grupoTipoImpresion")),
                            grupoTipoImpresion_descripcion = lector.GetString(lector.GetOrdinal("grupoTipoImpresion_descripcion")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            periodo_ID = lector.GetInt32(lector.GetOrdinal("periodo_ID")),
                            tipo_tributo = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            tipo_tributo_descripcion = lector.GetString(lector.GetOrdinal("tipo_tributo_descripcion")),
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
        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "Select g.grupoImpresion_ID , g.tributo_ID, g.grupoTipoImpresion,g.estado,isnull(g.periodo_ID,0) as periodo_ID,g.registro_fecha_add,"
                        + "g.registro_pc_add,g.registro_user_add,g.registro_fecha_update,g.registro_pc_update,g.registro_user_update,"
                        + "t.descripcion as tributo_descripcion, ta.descripcion as grupoTipoImpresion_descripcion,t.tipo_tributo , ta2.descripcion as tipo_tributo_descripcion "
                        + "from GrupoImpresion g inner join Tributos t on g.tributo_ID = t.tributos_ID "
                        +"inner join tablas ta on g.grupoTipoImpresion = ta.valor "
                        +"inner join tablas ta2 on t.tipo_tributo = ta2.valor ";
            if ((whereSql != null) && (whereSql.Trim().Length > 0))
            {
                sql += " WHERE ta.dep_id = 77 and ta2.dep_id = 1 and " + whereSql;
            }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
            {
                sql += " ORDER BY " + orderBySql;
            }
            return sql;
        }
        public virtual void Insert(Mant_GrupoImpresion GrupoImpresion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, GrupoImpresion.tributo_ID);
                db.AddInParameter(SQL, "grupoTipoImpresion", DbType.String, GrupoImpresion.grupoTipoImpresion);
                db.AddInParameter(SQL, "estado", DbType.Boolean, GrupoImpresion.estado);
                db.AddInParameter(SQL, "periodo_ID", DbType.Int32, GrupoImpresion.periodo_ID);
                db.AddInParameter(SQL, "tipo_tributo", DbType.String, GrupoImpresion.tipo_tributo);
                db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, GrupoImpresion.registro_fecha_add);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, GrupoImpresion.registro_user_add);
                db.AddInParameter(SQL, "registro_pc_add", DbType.String, GrupoImpresion.registro_pc_add);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
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
        public virtual void Update(Mant_GrupoImpresion GrupoImpresion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "grupoImpresion_ID", DbType.Int32, GrupoImpresion.grupoImpresion_ID);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, GrupoImpresion.tributo_ID);
                db.AddInParameter(SQL, "grupoTipoImpresion", DbType.String, GrupoImpresion.grupoTipoImpresion);
                db.AddInParameter(SQL, "estado", DbType.Boolean, GrupoImpresion.estado);
                db.AddInParameter(SQL, "periodo_ID", DbType.Int32, GrupoImpresion.periodo_ID);
                db.AddInParameter(SQL, "tipo_tributo", DbType.String, GrupoImpresion.tipo_tributo);
                db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, GrupoImpresion.registro_fecha_add);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, GrupoImpresion.registro_user_add);
                db.AddInParameter(SQL, "registro_pc_add", DbType.String, GrupoImpresion.registro_pc_add);
                db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, GrupoImpresion.registro_fecha_update);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, GrupoImpresion.registro_user_update);
                db.AddInParameter(SQL, "registro_pc_update", DbType.String, GrupoImpresion.registro_pc_update);
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
        public List<Pred_Tributo> listarTributoporGrupoTipoImpresion(string grupoTipoImpresion, Int32 periodo, string tipo_tributo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "grupoTipoImpresion", DbType.String, grupoTipoImpresion);
                db.AddInParameter(SQL, "periodo_Id", DbType.Int32, periodo);
                db.AddInParameter(SQL, "tipo_tributo", DbType.String, tipo_tributo);
                var coleccion = new List<Pred_Tributo>();
                using(var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Tributo
                        {
                            tributos_ID = lector.GetString(lector.GetOrdinal("tributos_ID")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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

    }
}
