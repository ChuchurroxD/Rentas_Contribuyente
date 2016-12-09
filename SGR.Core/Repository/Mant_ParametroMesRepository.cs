using Microsoft.Practices.EnterpriseLibrary.Data;
using SGR.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SGR.Core.Repository
{
    public class Mant_ParametroMesRepository
    {
        private const String nombreprocedimiento = "_Mant_ParametroMes";
        private const String NombreTabla = "parametro_mes";
        private Database db = DatabaseFactory.CreateDatabase();


        public List<Mant_ParametroMes> listartodos(Int32 periodo_id)
        {
            try
            {
                var coleccion = new List<Mant_ParametroMes>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "periodo_id", DbType.Int32, periodo_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_ParametroMes
                        {
                            parametro_mes_ID = lector.GetInt32(lector.GetOrdinal("parametro_mes_ID")),
                            tipo = lector.GetInt32(lector.GetOrdinal("tipo")),
                            //grupoTipoImpresion = lector.IsDBNull(lector.GetOrdinal("grupoTipoImpresion")) ? default(String) : lector.GetString(lector.GetOrdinal("grupoTipoImpresion")),
                            tipoDescripcion = lector.IsDBNull(lector.GetOrdinal("tipoDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipoDescripcion")),
                            //tipoAbreviatura = lector.IsDBNull(lector.GetOrdinal("tipoAbreviatura")) ? default(String) : lector.GetString(lector.GetOrdinal("tipoAbreviatura")),
                            mes = lector.IsDBNull(lector.GetOrdinal("mes")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mes")),
                            periodo_id = lector.IsDBNull(lector.GetOrdinal("periodo_id")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("periodo_id")),
                            fecha_emision = lector.IsDBNull(lector.GetOrdinal("fecha_emision")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            fecha_vence = lector.IsDBNull(lector.GetOrdinal("fecha_vence")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
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



        public List<Mant_ParametroMes> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }


        public virtual List<Mant_ParametroMes> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Mant_ParametroMes>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_ParametroMes
                        {
                            parametro_mes_ID = lector.GetInt32(lector.GetOrdinal("parametro_mes_ID")),
                            tipo = lector.GetInt32(lector.GetOrdinal("tipo")),
                            //grupoImpresion_ID = lector.GetInt32(lector.GetOrdinal("grupoImpresion_ID")),
                            //grupoTipoImpresion = lector.IsDBNull(lector.GetOrdinal("grupoTipoImpresion")) ? default(String) : lector.GetString(lector.GetOrdinal("grupoTipoImpresion")),
                            tipoDescripcion = lector.IsDBNull(lector.GetOrdinal("tipoDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipoDescripcion")),
                            //tipoAbreviatura = lector.IsDBNull(lector.GetOrdinal("tipoAbreviatura")) ? default(String) : lector.GetString(lector.GetOrdinal("tipoAbreviatura")),
                            mes = lector.IsDBNull(lector.GetOrdinal("mes")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mes")),
                            periodo_id = lector.IsDBNull(lector.GetOrdinal("periodo_id")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("periodo_id")),
                            fecha_emision = lector.IsDBNull(lector.GetOrdinal("fecha_emision")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            fecha_vence = lector.IsDBNull(lector.GetOrdinal("fecha_vence")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
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


        public virtual Mant_ParametroMes GetByPrimaryKey()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                var parametro_mes = default(Mant_ParametroMes);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        parametro_mes = new Mant_ParametroMes
                        {
                            parametro_mes_ID = lector.GetInt32(lector.GetOrdinal("parametro_mes_ID")),
                            tipo = lector.GetInt32(lector.GetOrdinal("tipo")),
                            //grupoImpresion_ID = lector.GetInt32(lector.GetOrdinal("grupoImpresion_ID")),
                            //grupoTipoImpresion = lector.IsDBNull(lector.GetOrdinal("grupoTipoImpresion")) ? default(String) : lector.GetString(lector.GetOrdinal("grupoTipoImpresion")),
                            tipoDescripcion = lector.IsDBNull(lector.GetOrdinal("tipoDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipoDescripcion")),
                            //tipoAbreviatura = lector.IsDBNull(lector.GetOrdinal("tipoAbreviatura")) ? default(String) : lector.GetString(lector.GetOrdinal("tipoAbreviatura")),
                            mes = lector.IsDBNull(lector.GetOrdinal("mes")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mes")),
                            periodo_id = lector.IsDBNull(lector.GetOrdinal("periodo_id")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("periodo_id")),
                            fecha_emision = lector.IsDBNull(lector.GetOrdinal("fecha_emision")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            fecha_vence = lector.IsDBNull(lector.GetOrdinal("fecha_vence")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
                        };
                    }
                }
                SQL.Dispose();
                return parametro_mes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT * FROM [dbo].[parametro_mes]";
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

        public virtual void Insert(Mant_ParametroMes parametro_mes)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Int32, parametro_mes.tipo);
                db.AddInParameter(SQL, "mes", DbType.Int16, parametro_mes.mes);
                db.AddInParameter(SQL, "periodo_id", DbType.Int16, parametro_mes.periodo_id);
                db.AddInParameter(SQL, "estado", DbType.Int16, parametro_mes.estado);
                db.AddInParameter(SQL, "fecha_emision", DbType.DateTime, parametro_mes.fecha_emision);
                db.AddInParameter(SQL, "fecha_vence", DbType.DateTime, parametro_mes.fecha_vence);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, parametro_mes.registro_user_add);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar");
                }
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Mant_ParametroMes parametro_mes)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "parametro_mes_ID", DbType.Int32, parametro_mes.parametro_mes_ID);
                db.AddInParameter(SQL, "tipo", DbType.Int32, parametro_mes.tipo);
                db.AddInParameter(SQL, "mes", DbType.Int16, parametro_mes.mes);
                db.AddInParameter(SQL, "periodo_id", DbType.Int32, parametro_mes.periodo_id);
                db.AddInParameter(SQL, "estado", DbType.Int16, parametro_mes.estado);
                db.AddInParameter(SQL, "fecha_emision", DbType.DateTime, parametro_mes.fecha_emision);
                db.AddInParameter(SQL, "fecha_vence", DbType.DateTime, parametro_mes.fecha_vence);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, parametro_mes.registro_user_update);
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


        public virtual bool DeleteByPrimaryKey()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
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
        public virtual Int32 existeFechaVencimientoxPeriodoMes(Int32 periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "periodo", DbType.Int32, periodo);
                Int32 total = 0;
                total = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_ParametroMes> listarerrores(Int32 periodo_id,int codigo,int tipo, string tributo_id)
        {
            try
            {
                var coleccion = new List<Mant_ParametroMes>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "periodo", DbType.Int32, periodo_id);
                db.AddInParameter(SQL, "codigo", DbType.Int32, codigo);
                //db.AddInParameter(SQL, "grupoTipoImpresion", DbType.Int32, tipo);
                db.AddInParameter(SQL, "tributo", DbType.String, tributo_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_ParametroMes
                        {
                            tipoAbreviatura = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
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

        public Int32 compararMes(short mes,string tipo, Int32 periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "mes", DbType.String, mes);
                db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
                db.AddInParameter(SQL, "tipo", DbType.String, tipo);
                Int32 total = 0;
                total = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Int32 compararMesModificar(short mes, Int32 codigo,Int32 periodo, string tipo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                db.AddInParameter(SQL, "mes", DbType.Int32, mes);
                db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
                db.AddInParameter(SQL, "tipo", DbType.String, tipo);
                db.AddInParameter(SQL, "parametro_mes_ID", DbType.Int32, codigo);
                Int32 total = 0;
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