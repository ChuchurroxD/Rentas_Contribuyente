using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
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
    public class Pred_ViasRepository
    {
        private const String nombreProcedimiento = "_Pred_Via";
        private const String nombreTabla = "Via";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Pred_Vias> listarTodos()
        {
            try
            {
                var coleccion = new List<Pred_Vias>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Vias
                        {
                            Via_id = lector.IsDBNull(lector.GetOrdinal("Via_id")) ? default(string):lector.GetString(lector.GetOrdinal("Via_id")).TrimStart(),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")).TrimStart(),
                            TipoVia = lector.IsDBNull(lector.GetOrdinal("TipoVia")) ? default(String) : lector.GetString(lector.GetOrdinal("TipoVia")),
                            Estado = lector.IsDBNull(lector.GetOrdinal("Estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Estado")),
                            CodigoAntiguo = lector.IsDBNull(lector.GetOrdinal("CodigoAntiguo")) ? default(string) : lector.GetString(lector.GetOrdinal("CodigoAntiguo")).TrimStart(),
                            descripcionTipoVia = lector.IsDBNull(lector.GetOrdinal("descripcionTipoVia")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcionTipoVia")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
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


        public virtual List<Pred_Vias> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Pred_Vias>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Vias
                        {
                            Via_id = lector.GetString(lector.GetOrdinal("Via_id")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")).TrimStart(),
                            TipoVia = lector.IsDBNull(lector.GetOrdinal("TipoVia")) ? default(String) : lector.GetString(lector.GetOrdinal("TipoVia")),
                            Estado = lector.IsDBNull(lector.GetOrdinal("Estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Estado")),
                            CodigoAntiguo = lector.GetString(lector.GetOrdinal("CodigoAntiguo")),
                            descripcionTipoVia = lector.IsDBNull(lector.GetOrdinal("descripcionTipoVia")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcionTipoVia")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
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
            string sql = "Select v.Via_id,ltrim(rtrim(v.Descripcion))as Descripcion,v.TipoVia,v.Estado,v.CodigoAntiguo,v.registro_fecha_add,v.registro_user_add,v.registro_pc_add,v.registro_fecha_update,v.registro_user_update,v.registro_pc_update,t.descripcion as descripcionTipoVia From Via v inner join tablas t on(v.TipoVia = t.valor and t.dep_id = 17) ";
            if ((whereSql != null) && (whereSql.Trim().Length > 0))
            {
                sql += " WHERE t.dep_id=17 and v.estado = 1 and " + whereSql;
            }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
            {
                sql += " ORDER BY " + orderBySql;
            }
            return sql;
        }


        public virtual Pred_Vias GetByPrimaryKey(Int32 sector_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "Seguc_iCodigo", DbType.Int32, sector_id);
                var pred_Vias = default(Pred_Vias);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        pred_Vias = new Pred_Vias
                        {
                            Via_id = lector.GetString(lector.GetOrdinal("Via_id")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")).TrimStart(),
                            TipoVia = lector.IsDBNull(lector.GetOrdinal("TipoVia")) ? default(String) : lector.GetString(lector.GetOrdinal("TipoVia")),
                            Estado = lector.IsDBNull(lector.GetOrdinal("Estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Estado")),
                            CodigoAntiguo = lector.GetString(lector.GetOrdinal("CodigoAntiguo")),
                            descripcionTipoVia = lector.IsDBNull(lector.GetOrdinal("tipo")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
                        };
                    }
                }
                SQL.Dispose();
                return pred_Vias;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Insert(Pred_Vias pred_Vias)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Via_id", DbType.String, pred_Vias.Via_id);
                db.AddInParameter(SQL, "Descripcion", DbType.String, pred_Vias.Descripcion);
                db.AddInParameter(SQL, "TipoVia", DbType.String, pred_Vias.TipoVia);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, pred_Vias.Estado);
                db.AddInParameter(SQL, "CodigoAntiguo", DbType.String, pred_Vias.CodigoAntiguo);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, pred_Vias.registro_user_add);
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


        public virtual void Update(Pred_Vias pred_Vias)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Via_id", DbType.String, pred_Vias.Via_id);
                db.AddInParameter(SQL, "Descripcion", DbType.String, pred_Vias.Descripcion);
                db.AddInParameter(SQL, "TipoVia", DbType.String, pred_Vias.TipoVia);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, pred_Vias.Estado);
                db.AddInParameter(SQL, "CodigoAntiguo", DbType.String, pred_Vias.CodigoAntiguo);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, pred_Vias.registro_user_update);
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



        public virtual bool DeleteByPrimaryKey(String Via_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Via_id", DbType.String, Via_id);
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


        public List<Pred_TipoVia> llenarTipoVia()
        {
            try
            {
                var coleccion = new List<Pred_TipoVia>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_TipoVia
                        {
                            valor = lector.GetString(lector.GetOrdinal("valor")).Trim(),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
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

        // ---------------Combo de Vias--------------------------------
        public List<Pred_Vias> listarViasCbo()
        {
            try
            {
                var coleccion = new List<Pred_Vias>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Vias
                        {
                            Via_id = lector.GetString(lector.GetOrdinal("codigo")).Trim(),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
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
        public List<Pred_Vias> listarViasCboCodAntiguo(String codAntiguo)
        {
            try
            {
                var coleccion = new List<Pred_Vias>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "CodigoAntiguo", DbType.String, codAntiguo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Vias
                        {
                            Via_id = lector.GetString(lector.GetOrdinal("codigo")).Trim(),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
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

        public List<Pred_Vias> listarViasPorSector(string junta_id,int oficina)
        {
            try
            {
                var coleccion = new List<Pred_Vias>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "junta_ID", DbType.String, junta_id);
                db.AddInParameter(SQL, "oficina", DbType.Int32, oficina);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Vias
                        {
                            Via_id = lector.GetString(lector.GetOrdinal("Via_id")).Trim(),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
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

        public virtual Int32 GetIdViaMax()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 14);
                Int32 total = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total = lector.GetInt32(lector.GetOrdinal("Via_id"));

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
        public List<Pred_Vias> listarViasPorSectorv2(string junta_id)
        {
            try
            {
                var coleccion = new List<Pred_Vias>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 15);
                db.AddInParameter(SQL, "junta_ID", DbType.String, junta_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Vias
                        {
                            Via_id = lector.GetString(lector.GetOrdinal("Via_id")).Trim(),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
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
