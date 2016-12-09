using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity.Model;

namespace SGR.Core.Repository
{
    public class Pred_PredioContribuyenteRepository
    {
        private const String nombreprocedimiento = "_Pred_Predio_Contribuyente";
        private const String NombreTabla = "PREDio_COntribuyente";
        private Database db = DatabaseFactory.CreateDatabase();


        public List<Pred_PredioContribuyente> listartodos()
        {
            try
            {
                var coleccion = new List<Pred_PredioContribuyente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_PredioContribuyente
                        {
                            predio_contribuyente_id = lector.GetInt32(lector.GetOrdinal("predio_contribuyente_id")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("idPeriodo")),
                            Fecha = lector.GetDateTime(lector.GetOrdinal("Fecha")),
                            Porcentaje_Condomino = lector.GetDecimal(lector.GetOrdinal("Porcentaje_Condomino")),
                            ExonAutoValuo = lector.GetBoolean(lector.GetOrdinal("ExonAutoValuo")),
                            AnioCompra = lector.GetInt32(lector.GetOrdinal("AnioCompra")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            tipo_adquisicion = lector.GetInt32(lector.GetOrdinal("tipo_adquisicion")),
                            tipo_posesion = lector.GetInt32(lector.GetOrdinal("tipo_posesion")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            observaciones = lector.IsDBNull(lector.GetOrdinal("observaciones")) ? default(String) : lector.GetString(lector.GetOrdinal("observaciones")),
                            //registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            adq_descripcion = lector.IsDBNull(lector.GetOrdinal("adq_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("adq_descripcion")),
                            pose_descripcion = lector.IsDBNull(lector.GetOrdinal("pose_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("pose_descripcion")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            //tipo_contribuyente = lector.IsDBNull(lector.GetOrdinal("tipo_contribuyente")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_contribuyente"))


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
        public List<Pred_PredioContribuyente> listarByPredioID(String predio_id, Int16 PERIODO)
        {
            try
            {
                var coleccion = new List<Pred_PredioContribuyente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "Predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, PERIODO);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_PredioContribuyente
                        {
                            predio_contribuyente_id = lector.GetInt32(lector.GetOrdinal("predio_contribuyente_id")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("idPeriodo")),
                            Fecha = lector.GetDateTime(lector.GetOrdinal("Fecha")),
                            Porcentaje_Condomino = lector.GetDecimal(lector.GetOrdinal("Porcentaje_Condomino")),
                            ExonAutoValuo = lector.GetBoolean(lector.GetOrdinal("ExonAutoValuo")),
                            AnioCompra = lector.GetInt32(lector.GetOrdinal("AnioCompra")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            tipo_adquisicion = lector.GetInt32(lector.GetOrdinal("tipo_adquisicion")),
                            tipo_posesion = lector.GetInt32(lector.GetOrdinal("tipo_posesion")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            observaciones = lector.IsDBNull(lector.GetOrdinal("observaciones")) ? default(String) : lector.GetString(lector.GetOrdinal("observaciones")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            adq_descripcion = lector.IsDBNull(lector.GetOrdinal("adq_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("adq_descripcion")),
                            pose_descripcion = lector.IsDBNull(lector.GetOrdinal("pose_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("pose_descripcion")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            //tipo_contribuyente = lector.IsDBNull(lector.GetOrdinal("tipo_contribuyente")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_contribuyente"))
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



        public List<Pred_PredioContribuyente> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }


        public virtual List<Pred_PredioContribuyente> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Pred_PredioContribuyente>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_PredioContribuyente
                        {
                            predio_contribuyente_id = lector.GetInt32(lector.GetOrdinal("predio_contribuyente_id")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("idPeriodo")),
                            Fecha = lector.GetDateTime(lector.GetOrdinal("Fecha")),
                            Porcentaje_Condomino = lector.GetDecimal(lector.GetOrdinal("Porcentaje_Condomino")),
                            ExonAutoValuo = lector.GetBoolean(lector.GetOrdinal("ExonAutoValuo")),
                            AnioCompra = lector.GetInt32(lector.GetOrdinal("AnioCompra")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            tipo_adquisicion = lector.GetInt32(lector.GetOrdinal("tipo_adquisicion")),
                            tipo_posesion = lector.GetInt32(lector.GetOrdinal("tipo_posesion")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            observaciones = lector.IsDBNull(lector.GetOrdinal("observaciones")) ? default(String) : lector.GetString(lector.GetOrdinal("observaciones")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            adq_descripcion = lector.IsDBNull(lector.GetOrdinal("adq_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("adq_descripcion")),
                            pose_descripcion = lector.IsDBNull(lector.GetOrdinal("pose_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("pose_descripcion")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            //tipo_contribuyente = lector.IsDBNull(lector.GetOrdinal("tipo_contribuyente")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_contribuyente"))


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

        //
        public virtual Decimal GetPorcentajexPredio(String predio_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "Predio_id", DbType.String, predio_id);
                Decimal porcentaje = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        porcentaje = lector.GetDecimal(lector.GetOrdinal("porcentaje"));

                    }
                }
                SQL.Dispose();
                return porcentaje;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Pred_PredioContribuyente GetByPrimaryKey(Int32 predio_contribuyente_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "predio_contribuyente_id", DbType.Int32, predio_contribuyente_id);
                var PREDio_COntribuyente = default(Pred_PredioContribuyente);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        PREDio_COntribuyente = new Pred_PredioContribuyente
                        {
                            predio_contribuyente_id = lector.GetInt32(lector.GetOrdinal("predio_contribuyente_id")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("idPeriodo")),
                            Fecha = lector.GetDateTime(lector.GetOrdinal("Fecha")),
                            //Porcentaje_Condomino = lector.GetDecimal(lector.GetOrdinal("Porcentaje_Condomino")),
                            ExonAutoValuo = lector.GetBoolean(lector.GetOrdinal("ExonAutoValuo")),
                            AnioCompra = lector.GetInt32(lector.GetOrdinal("AnioCompra")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            tipo_adquisicion = lector.GetInt32(lector.GetOrdinal("tipo_adquisicion")),
                            tipo_posesion = lector.GetInt32(lector.GetOrdinal("tipo_posesion")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            observaciones = lector.IsDBNull(lector.GetOrdinal("observaciones")) ? default(String) : lector.GetString(lector.GetOrdinal("observaciones")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            adq_descripcion = lector.IsDBNull(lector.GetOrdinal("adq_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("adq_descripcion")),
                            pose_descripcion = lector.IsDBNull(lector.GetOrdinal("pose_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("pose_descripcion")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            //tipo_contribuyente = lector.IsDBNull(lector.GetOrdinal("tipo_contribuyente")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_contribuyente"))


                        };
                    }
                }
                SQL.Dispose();
                return PREDio_COntribuyente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT * FROM [dbo].[PREDio_COntribuyente]";
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

        public virtual int Insert(Pred_PredioContribuyente PREDio_COntribuyente)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int16, PREDio_COntribuyente.idPeriodo);
                db.AddInParameter(SQL, "Fecha", DbType.DateTime, PREDio_COntribuyente.Fecha);
                db.AddInParameter(SQL, "Porcentaje_Condomino", DbType.Decimal, PREDio_COntribuyente.Porcentaje_Condomino);
                db.AddInParameter(SQL, "ExonAutoValuo", DbType.Byte, PREDio_COntribuyente.ExonAutoValuo);
                db.AddInParameter(SQL, "AnioCompra", DbType.Int32, PREDio_COntribuyente.AnioCompra);
                db.AddInParameter(SQL, "estado", DbType.Byte, PREDio_COntribuyente.estado);
                db.AddInParameter(SQL, "Predio_id", DbType.String, PREDio_COntribuyente.Predio_id);
                db.AddInParameter(SQL, "persona_ID", DbType.String, PREDio_COntribuyente.persona_ID);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.Int32, PREDio_COntribuyente.tipo_adquisicion);
                db.AddInParameter(SQL, "tipo_posesion", DbType.Int32, PREDio_COntribuyente.tipo_posesion);
                db.AddInParameter(SQL, "expediente", DbType.String, PREDio_COntribuyente.expediente);
                db.AddInParameter(SQL, "observaciones", DbType.String, PREDio_COntribuyente.observaciones);
                db.AddInParameter(SQL, "registro_user", DbType.String, PREDio_COntribuyente.registro_user_add);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                //var numerogenerado = (int)db.GetParameterValue(SQL, "predio_contribuyente_id");
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Pred_PredioContribuyente PREDio_COntribuyente)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_contribuyente_id", DbType.Int32, PREDio_COntribuyente.predio_contribuyente_id);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int16, PREDio_COntribuyente.idPeriodo);
                db.AddInParameter(SQL, "Fecha", DbType.DateTime, PREDio_COntribuyente.Fecha);
                db.AddInParameter(SQL, "Porcentaje_Condomino", DbType.Decimal, PREDio_COntribuyente.Porcentaje_Condomino);
                db.AddInParameter(SQL, "ExonAutoValuo", DbType.Byte, PREDio_COntribuyente.ExonAutoValuo);
                db.AddInParameter(SQL, "AnioCompra", DbType.Int32, PREDio_COntribuyente.AnioCompra);
                db.AddInParameter(SQL, "estado", DbType.Byte, PREDio_COntribuyente.estado);
                db.AddInParameter(SQL, "Predio_id", DbType.String, PREDio_COntribuyente.Predio_id);
                db.AddInParameter(SQL, "persona_ID", DbType.String, PREDio_COntribuyente.persona_ID);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.Int32, PREDio_COntribuyente.tipo_adquisicion);
                db.AddInParameter(SQL, "tipo_posesion", DbType.Int32, PREDio_COntribuyente.tipo_posesion);
                db.AddInParameter(SQL, "expediente", DbType.String, PREDio_COntribuyente.expediente);
                db.AddInParameter(SQL, "observaciones", DbType.String, PREDio_COntribuyente.observaciones);
                db.AddInParameter(SQL, "registro_user", DbType.String, PREDio_COntribuyente.registro_user_add);
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
        public virtual int InsertParaSubdivision(Pred_PredioContribuyente PREDio_COntribuyente)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Fecha", DbType.DateTime, PREDio_COntribuyente.Fecha);
                db.AddInParameter(SQL, "Porcentaje_Condomino", DbType.Decimal, PREDio_COntribuyente.Porcentaje_Condomino);
                db.AddInParameter(SQL, "Predio_id", DbType.String, PREDio_COntribuyente.Predio_id);
                db.AddInParameter(SQL, "persona_ID", DbType.String, PREDio_COntribuyente.persona_ID);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.Int32, PREDio_COntribuyente.tipo_adquisicion);
                db.AddInParameter(SQL, "tipo_posesion", DbType.Int32, PREDio_COntribuyente.tipo_posesion);
                db.AddInParameter(SQL, "expediente", DbType.String, PREDio_COntribuyente.expediente);
                db.AddInParameter(SQL, "registro_user", DbType.String, PREDio_COntribuyente.registro_user_add);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 14);
                int huboexito = db.ExecuteNonQuery(SQL);
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual bool DeleteByPrimaryKey(Int32 predio_contribuyente_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_contribuyente_id", DbType.Int32, predio_contribuyente_id);
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
        public virtual void GuardarPredioContribuyenteEnPredio(String predio_id, string user, Int32 periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "registro_user", DbType.String, user);
                db.AddInParameter(SQL, "Predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, periodo);
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
        public virtual void CancelarPredioContribuyenteEnPredio(string user, Int32 periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "registro_user", DbType.String, user);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, periodo);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 11);
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
        //public virtual void CopiarPredioContribuyenteMasivo(Int32 periodoantiguo, string user, Int32 periodoactivo)
        //{
        //    try
        //    {
        //        DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
        //        db.AddInParameter(SQL, "idPeriodoAntiguo", DbType.Int32, periodoantiguo);
        //        db.AddInParameter(SQL, "idPeriodo", DbType.Int32, periodoactivo);
        //        db.AddInParameter(SQL, "registro_user", DbType.Int32, user);
        //        db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
        //        int huboexito = db.ExecuteNonQuery(SQL);
        //        if (huboexito == 0)
        //        {
        //            throw new Exception("Error");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public virtual void GenerarPredioMasivo(Int32 periodoantiguo, string user, Int32 periodoactivo)
        //{
        //    try
        //    {
        //        DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
        //        db.AddInParameter(SQL, "idPeriodoAntiguo", DbType.Int32, periodoantiguo);
        //        db.AddInParameter(SQL, "idPeriodo", DbType.Int32, periodoactivo);
        //        db.AddInParameter(SQL, "registro_user", DbType.Int32, user);
        //        db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 2);
        //        int huboexito = db.ExecuteNonQuery(SQL);
        //        if (huboexito == 0)
        //        {
        //            throw new Exception("Error");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public List<Pred_PredioContribuyente> listarDeterminacionImpuestoTotalPredios(int persona_id)
        {
            try
            {
                var coleccion = new List<Pred_PredioContribuyente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 15);
                db.AddInParameter(SQL, "persona_ID", DbType.Int32, persona_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_PredioContribuyente
                        {
                            total_Predios = lector.IsDBNull(lector.GetOrdinal("totalpredios")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("totalpredios"))
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

        public List<Pred_PredioContribuyente> listarDeterminacionImpuestoCuotaTrimestral(int persona_id)
        {
            try
            {
                var coleccion = new List<Pred_PredioContribuyente>();
                DbCommand SQL = db.GetStoredProcCommand("_Rep_HR");
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "persona_ID", DbType.Int32, persona_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_PredioContribuyente
                        {
                            cuota_Trimestral = lector.IsDBNull(lector.GetOrdinal("cuotatrimestral")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("cuotatrimestral")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("idPeriodo")),
                            persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(string) : lector.GetString(lector.GetOrdinal("persona_ID"))
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

        public List<Pred_PredioContribuyente> listarDeterminacionImpuestoImpuestoAnual(int persona_id)
        {
            try
            {
                var coleccion = new List<Pred_PredioContribuyente>();
                DbCommand SQL = db.GetStoredProcCommand("_Rep_HR");
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "persona_ID", DbType.Int32, persona_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_PredioContribuyente
                        {
                            impuesto_Anual = lector.IsDBNull(lector.GetOrdinal("impuestoanual")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("impuestoanual")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("idPeriodo")),
                            persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(string) : lector.GetString(lector.GetOrdinal("persona_ID"))
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
        public bool obtenerSISePuedeExonerar(string Predio_id)
        {
            try
            {
                var coleccion = new List<Pred_PredioContribuyente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 15);
                db.AddInParameter(SQL, "Predio_id", DbType.String, Predio_id);
                if (Convert.ToInt32(db.ExecuteScalar(SQL)) == 1)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Pred_PredioContribuyente obtenerSITieneOtroDueño(string Predio_id,string persona_ID,int anio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 16);
                db.AddInParameter(SQL, "Predio_id", DbType.String, Predio_id);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, anio);
                var Pred_PredioContribuyente = default(Pred_PredioContribuyente);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Pred_PredioContribuyente = new Pred_PredioContribuyente
                        {
                            predio_contribuyente_id = lector.GetInt32(lector.GetOrdinal("predio_contribuyente_id")),
                            Porcentaje_Condomino = lector.GetDecimal(lector.GetOrdinal("Porcentaje_Condomino"))
                        };
                    }
                }
                SQL.Dispose();
                return Pred_PredioContribuyente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_PredioContribuyente> listarPorPeriodoContribuyente(int periodo , string persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 17);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, periodo);
                var coleccion = new List<Pred_PredioContribuyente>();
                using(var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_PredioContribuyente
                        {
                           //predio_contribuyente_id = lector.GetInt32(lector.GetOrdinal("predio_contribuyente_id")),
                           Porcentaje_Condomino = lector.GetDecimal(lector.GetOrdinal("Porcentaje_Condomino")),
                           tipo_adquisicion = lector.GetInt32(lector.GetOrdinal("tipo_adquisicion")),
                           tipo_posesion = lector.GetInt32(lector.GetOrdinal("tipo_posesion")),
                           estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                           adq_descripcion = lector.GetString(lector.GetOrdinal("adquisicion")),
                           pose_descripcion = lector.GetString(lector.GetOrdinal("posesion")),
                           razon_social = lector.GetString(lector.GetOrdinal("nombre_predio")),
                           Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")).TrimEnd()
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
        public Pred_Predios detallePredioContribuyente(Int16 periodo,string predio_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 18);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, periodo);
                db.AddInParameter(SQL, "Predio_id", DbType.String, predio_ID);
                var Pred_Predio = new Pred_Predios();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Pred_Predio.tipo_predio = lector.GetString(lector.GetOrdinal("tipo_predio"));
                        Pred_Predio.area_terreno = lector.GetDecimal(lector.GetOrdinal("area_terreno"));
                        Pred_Predio.valor_construccion = lector.GetDecimal(lector.GetOrdinal("valor_construccion"));
                        Pred_Predio.tipo_adquisicion = lector.GetString(lector.GetOrdinal("adquisicion"));
                        Pred_Predio.predio_ID = lector.GetString(lector.GetOrdinal("predio_ID"));
                        Pred_Predio.tipo_inmueble = lector.GetString(lector.GetOrdinal("tipo_inmueble"));
                        Pred_Predio.area_construida = lector.GetDecimal(lector.GetOrdinal("area_construida"));
                        Pred_Predio.valor_otra_instalacion = lector.GetDecimal(lector.GetOrdinal("valor_otra_instalacion"));
                        Pred_Predio.fecha_adquisicion = lector.GetDateTime(lector.GetOrdinal("fecha_adquisicion"));
                        Pred_Predio.direccion = lector.GetString(lector.GetOrdinal("nombre_predio"));
                        Pred_Predio.estado_predio = lector.GetString(lector.GetOrdinal("estado_predio"));
                        Pred_Predio.frente_metros = lector.GetDecimal(lector.GetOrdinal("frente_metros"));
                        Pred_Predio.valor_area_comun = lector.GetDecimal(lector.GetOrdinal("valor_area_comun"));
                        Pred_Predio.posesion = lector.GetString(lector.GetOrdinal("posesion"));
                        Pred_Predio.sector = lector.GetString(lector.GetOrdinal("sector"));
                        Pred_Predio.uso_predio = lector.GetString(lector.GetOrdinal("uso_predio"));
                        Pred_Predio.valor_terreno = lector.GetDecimal(lector.GetOrdinal("valor_terreno"));
                        Pred_Predio.total_autovaluo = lector.GetDecimal(lector.GetOrdinal("total_autovaluo"));
                        Pred_Predio.estado = lector.GetString(lector.GetOrdinal("estado"));
                    }
                }
                SQL.Dispose();
                return Pred_Predio;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Banco> listarPr(string periodo, string persona_ID)
        {
            try
            {
                var coleccion = new List<Mant_Banco>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 19);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, periodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Banco
                        {
                            descripcion = lector.IsDBNull(lector.GetOrdinal("predios")) ? default(String) : lector.GetString(lector.GetOrdinal("predios")),
                            
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
        
        public virtual int InsertVariosAños(Pred_PredioContribuyente PREDio_COntribuyente, int idPeriodoAntiguo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int16, PREDio_COntribuyente.idPeriodo);
                db.AddInParameter(SQL, "idPeriodoAntiguo", DbType.Int32, idPeriodoAntiguo);
                db.AddInParameter(SQL, "Fecha", DbType.DateTime, PREDio_COntribuyente.Fecha);
                db.AddInParameter(SQL, "Porcentaje_Condomino", DbType.Decimal, PREDio_COntribuyente.Porcentaje_Condomino);
                db.AddInParameter(SQL, "ExonAutoValuo", DbType.Byte, PREDio_COntribuyente.ExonAutoValuo);
                db.AddInParameter(SQL, "AnioCompra", DbType.Int32, PREDio_COntribuyente.AnioCompra);
                //db.AddInParameter(SQL, "estado", DbType.Byte, PREDio_COntribuyente.estado);
                db.AddInParameter(SQL, "Predio_id", DbType.String, PREDio_COntribuyente.Predio_id);
                db.AddInParameter(SQL, "persona_ID", DbType.String, PREDio_COntribuyente.persona_ID);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.Int32, PREDio_COntribuyente.tipo_adquisicion);
                db.AddInParameter(SQL, "tipo_posesion", DbType.Int32, PREDio_COntribuyente.tipo_posesion);
                db.AddInParameter(SQL, "expediente", DbType.String, PREDio_COntribuyente.expediente);
                db.AddInParameter(SQL, "observaciones", DbType.String, PREDio_COntribuyente.observaciones);
                db.AddInParameter(SQL, "registro_user", DbType.String, PREDio_COntribuyente.registro_user_add);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 20);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                //var numerogenerado = (int)db.GetParameterValue(SQL, "predio_contribuyente_id");
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void DescargarPredio(string predio,string idPeriodo, string persona,string registro_user)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Predio_id", DbType.String, predio);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, idPeriodo);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                db.AddInParameter(SQL, "registro_user", DbType.String, registro_user);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 21);
                int huboexito = db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
