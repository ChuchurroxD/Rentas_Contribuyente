using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using System.Data.Common;
using System.Data;
using SGR.Entity.Model;
namespace SGR.Core.Repository
{
    public class Pred_PrredioArbitrioRepository
    {
        private const string nombreprocedimiento = "_Pred_PredioArbitrio";
        private const string nombreTabla = "PredioArbitro";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Pred_PrredioArbitrio> listartodos(String predio, String idPeriodo)
        {
            try
            {
                var coleccion = new List<Pred_PrredioArbitrio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "Predio_id", DbType.String, predio);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, idPeriodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_PrredioArbitrio
                        {
                            idPredioArbitrio = lector.GetInt32(lector.GetOrdinal("idPredioArbitrio")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            idTablaArancel = lector.GetInt32(lector.GetOrdinal("idTablaArancel")),
                            costo = lector.GetDecimal(lector.GetOrdinal("Costo")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("Estado")),
                            TablaArancel_Descripcion = lector.IsDBNull(lector.GetOrdinal("tablaarancel_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tablaarancel_descripcion"))

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

        public List<Pred_PrredioArbitrio> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }


        public virtual List<Pred_PrredioArbitrio> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Pred_PrredioArbitrio>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_PrredioArbitrio
                        {
                            idPredioArbitrio = lector.GetInt32(lector.GetOrdinal("idPredioArbitrio")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            idTablaArancel = lector.GetInt32(lector.GetOrdinal("idTablaArancel")),
                            idPeriodo = lector.GetString(lector.GetOrdinal("idPeriodo")),
                            FechaRegistro = lector.GetDecimal(lector.GetOrdinal("FechaRegistro")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
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


        public virtual Pred_PrredioArbitrio GetByPrimaryKey()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                var Pred_PrredioArbitrio = default(Pred_PrredioArbitrio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Pred_PrredioArbitrio = new Pred_PrredioArbitrio
                        {
                            idPredioArbitrio = lector.GetInt32(lector.GetOrdinal("idPredioArbitrio")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            idTablaArancel = lector.GetInt32(lector.GetOrdinal("idTablaArancel")),
                            idPeriodo = lector.GetString(lector.GetOrdinal("idPeriodo")),
                            FechaRegistro = lector.GetDecimal(lector.GetOrdinal("FechaRegistro")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

                        };
                    }
                }
                SQL.Dispose();
                return Pred_PrredioArbitrio;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT * FROM [dbo].[Pred_PrredioArbitrio]";
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

        public virtual int Insert(Pred_PrredioArbitrio Pred_PrredioArbitrio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Predio_id", DbType.String, Pred_PrredioArbitrio.Predio_id);
                db.AddInParameter(SQL, "idTablaArancel", DbType.String, Pred_PrredioArbitrio.idTablaArancel);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Pred_PrredioArbitrio.registro_user_add);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, Pred_PrredioArbitrio.idPeriodo);

                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                //if (huboexito == 0)
                //{
                //    throw new Exception("Error al agregar al");
                //}
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Pred_PrredioArbitrio Pred_PrredioArbitrio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idPredioArbitrio", DbType.String, Pred_PrredioArbitrio.idPredioArbitrio);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, Pred_PrredioArbitrio.Estado);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Pred_PrredioArbitrio.registro_user_update);
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
        public virtual void GuardarArbitriosEnPredio(String predio_id, String usser)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 8);
                int huboexito = db.ExecuteNonQuery(SQL);
                //if (huboexito == 0)
                //{
                //    throw new Exception("Error");
                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void CancelarArbitriosEnPredio(String usser)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 9);
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
        public virtual void GenerarCalculoIndividual(String predio_id, String usser, String per_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "per_id", DbType.String, per_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 10);
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
        public virtual void GenerarCalculoXPersona(String usser, String per_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "per_id", DbType.String, per_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 13);
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
        public virtual void GenerarCalculoMasivo(String usser, int anio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "anio", DbType.String, anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 11);
                SQL.CommandTimeout = 60000000;
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
        public virtual void copiarArbitriosDePadreaHijo(String predio_hijo, String predio_padre, String usser)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Predio_hijo", DbType.String, predio_hijo);
                db.AddInParameter(SQL, "Predio_padre", DbType.String, predio_padre);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 12);
                int huboexito = db.ExecuteNonQuery(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void copiarArbitrioANteriores(String Predio_id, String usser)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Predio_id", DbType.String, Predio_id);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 14);
                db.ExecuteNonQuery(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void copiarArbitriomASIVO(int idPeriodoViejo, int idPeriodonUEVO, String usser)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idPeriodoViejo", DbType.String, idPeriodoViejo);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, idPeriodonUEVO);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 15);
                SQL.CommandTimeout = 6000000;
                db.ExecuteNonQuery(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void copiarArbitrioPersona(String usser, string per_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "per_id", DbType.String, per_id);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 16);
                db.ExecuteNonQuery(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual List<Mant_TablaArancel> verificarArbitrioANteriores(String Predio_id)
        {
            try
            {
                var coleccion = new List<Mant_TablaArancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Predio_id", DbType.String, Predio_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 17);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TablaArancel
                        {
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcion"))
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
        public virtual List<Mant_TablaArancel> verificarArbitriomASIVO(int idPeriodoViejo, int idPeriodonUEVO)
        {
            try
            {
                var coleccion = new List<Mant_TablaArancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idPeriodoViejo", DbType.String, idPeriodoViejo);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, idPeriodonUEVO);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 18);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TablaArancel
                        {
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcion"))
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
        public virtual List<Mant_TablaArancel> verificarArbitrioPersona(string per_id)
        {
            try
            {
                var coleccion = new List<Mant_TablaArancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "per_id", DbType.String, per_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 19);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TablaArancel
                        {
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcion"))
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

        //-------------------------------------------------------------------------------------------------------------------------
        public virtual int cantidadArbitrioANteriores(String Predio_id)
        {
            try
            {
                var coleccion = new List<Mant_TablaArancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Predio_id", DbType.String, Predio_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 20);
                return Convert.ToInt32(db.ExecuteScalar(SQL));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //public virtual List<Mant_TablaArancel> cantidadArbitriomASIVO(int idPeriodoViejo)
        //{
        //    try
        //    {
        //        var coleccion = new List<Mant_TablaArancel>();
        //        DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
        //        db.AddInParameter(SQL, "idPeriodoViejo", DbType.String, idPeriodoViejo);
        //        db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 21);
        //        SQL.CommandTimeout = 600;
        //        using (var lector = db.ExecuteReader(SQL))
        //        {
        //            while (lector.Read())
        //            {
        //                coleccion.Add(new Mant_TablaArancel
        //                {
        //                    Descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcion"))
        //                });
        //            }
        //        }
        //        SQL.Dispose();
        //        return coleccion;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public virtual List<Mant_TablaArancel> cantidadArbitrioPersona(string per_id)
        {
            try
            {
                var coleccion = new List<Mant_TablaArancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "per_id", DbType.String, per_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 22);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TablaArancel
                        {
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcion"))
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

        public virtual int InsertVariosAños(Pred_PrredioArbitrio Pred_PrredioArbitrio, string periodofin)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Predio_id", DbType.String, Pred_PrredioArbitrio.Predio_id);
                db.AddInParameter(SQL, "idTablaArancel", DbType.String, Pred_PrredioArbitrio.idTablaArancel);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Pred_PrredioArbitrio.registro_user_add);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, Pred_PrredioArbitrio.idPeriodo);
                db.AddInParameter(SQL, "idPeriodoViejo", DbType.String, periodofin);

                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 23);
                int huboexito = db.ExecuteNonQuery(SQL);
                //if (huboexito == 0)
                //{
                //    throw new Exception("Error al agregar al");
                //}
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
