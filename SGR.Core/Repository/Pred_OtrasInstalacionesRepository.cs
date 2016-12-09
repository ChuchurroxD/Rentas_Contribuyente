using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity;
using SGR.Core.Service;
public class Pred_OtrasInstalacionesRepository
    {
    private const String nombreprocedimiento = "_Pred_Predios_Instalaciones";
        private const String NombreTabla = "Predios_Instalaciones";
        private Database db = DatabaseFactory.CreateDatabase();
    private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
    private int periodo;

    public List<Pred_OtrasInstalaciones> listartodos()
        {
            try
            {
                var coleccion = new List<Pred_OtrasInstalaciones>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_OtrasInstalaciones
                        {
                            PrediosOtras_id = lector.GetInt32(lector.GetOrdinal("PrediosOtras_id")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            OtrasValor_id = lector.GetInt32(lector.GetOrdinal("OtrasValor_id")),
                            Observacion = lector.GetString(lector.GetOrdinal("Observacion")),
                            ValorOtras = lector.GetDecimal(lector.GetOrdinal("ValorOtras")),
                            CantidadValor = lector.GetDecimal(lector.GetOrdinal("CantidadValor")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            OtrasValor_descripcion = lector.IsDBNull(lector.GetOrdinal("OtrasValor_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("OtrasValor_descripcion")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
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

        public List<Pred_OtrasInstalaciones> listarByPredioID(String PredioID)
        {
            try
            {
                var coleccion = new List<Pred_OtrasInstalaciones>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "Predio_id", DbType.String, PredioID);
            using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_OtrasInstalaciones
                        {
                            PrediosOtras_id = lector.GetInt32(lector.GetOrdinal("PrediosOtras_id")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            OtrasValor_id = lector.GetInt32(lector.GetOrdinal("OtrasValor_id")),
                            Observacion = lector.GetString(lector.GetOrdinal("Observacion")),
                            ValorOtras = lector.GetDecimal(lector.GetOrdinal("ValorOtras")),
                            CantidadValor = lector.GetDecimal(lector.GetOrdinal("CantidadValor")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            OtrasValor_descripcion = lector.IsDBNull(lector.GetOrdinal("OtrasValor_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("OtrasValor_descripcion")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
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
    public List<Pred_OtrasInstalaciones> listarByPredioIDActivos(String PredioID,bool bandera)
    {
        try
        {
            var coleccion = new List<Pred_OtrasInstalaciones>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 13);
            db.AddInParameter(SQL, "Predio_id", DbType.String, PredioID);
            db.AddInParameter(SQL, "estado", DbType.Boolean, bandera);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Pred_OtrasInstalaciones
                    {
                        PrediosOtras_id = lector.GetInt32(lector.GetOrdinal("PrediosOtras_id")),
                        Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                        OtrasValor_id = lector.GetInt32(lector.GetOrdinal("OtrasValor_id")),
                        Observacion = lector.GetString(lector.GetOrdinal("Observacion")),
                        ValorOtras = lector.GetDecimal(lector.GetOrdinal("ValorOtras")),
                        CantidadValor = lector.GetDecimal(lector.GetOrdinal("CantidadValor")),
                        Estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                        OtrasValor_descripcion = lector.IsDBNull(lector.GetOrdinal("OtrasValor_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("OtrasValor_descripcion")),
                        //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                        //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                        //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                        //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                        //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
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
    public List<Pred_OtrasInstalaciones> GetcoleccionByPredioID(string wheresql, string orderbysql,string predioID)
        {
           try
            {
                var coleccion = new List<Pred_OtrasInstalaciones>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommandByPredioID(wheresql, orderbysql,predioID));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_OtrasInstalaciones
                        {
                            PrediosOtras_id = lector.GetInt32(lector.GetOrdinal("PrediosOtras_id")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            OtrasValor_id = lector.IsDBNull(lector.GetOrdinal("OtrasValor_id")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("OtrasValor_id")),
                            Observacion = lector.GetString(lector.GetOrdinal("Observacion")),
                            ValorOtras = lector.GetDecimal(lector.GetOrdinal("ValorOtras")),
                            CantidadValor = lector.GetDecimal(lector.GetOrdinal("CantidadValor")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
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
        protected virtual string CreateGetCommandByPredioID(string whereSql, string orderBySql,string predioID)
        {
            string sql = "Select PrediosOtras_id,Predio_id,cast(ISNULL(TA.valor,1)as int) as OtrasValor_id,TA.descripcion as OtrasValor_descripcion, " +
                            " ISNULL(Observacion, '') AS Observacion, ValorOtras, CantidadValor, CAST(ISNULL(PR.estado, 1) AS BIT) AS estado, pr.registro_fecha_add,PR.registro_fecha_update,PR.registro_pc_add, " +
                            " PR.registro_pc_update,PR.registro_user_add,PR.registro_user_update from Predios_Instalaciones PR " +
                            " LEFT JOIN TABLAS TA ON(TA.valor = PR.OtrasValor_id AND TA.dep_id = 2) WHERE PR.Predio_id='"+ predioID+"'";
            if ((whereSql != null) && (whereSql.Trim().Length > 0))
            {
                sql += " AND " + whereSql;
            }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
            {
                sql += " ORDER BY " + orderBySql;
            }
            return sql;
        }
    public List<Pred_OtrasInstalaciones> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }


        public virtual List<Pred_OtrasInstalaciones> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Pred_OtrasInstalaciones>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_OtrasInstalaciones
                        {
                            PrediosOtras_id = lector.GetInt32(lector.GetOrdinal("PrediosOtras_id")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            OtrasValor_id = lector.IsDBNull(lector.GetOrdinal("OtrasValor_id")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("OtrasValor_id")),
                            Observacion = lector.GetString(lector.GetOrdinal("Observacion")),
                            ValorOtras = lector.GetDecimal(lector.GetOrdinal("ValorOtras")),
                            CantidadValor = lector.GetDecimal(lector.GetOrdinal("CantidadValor")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
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
            protected virtual string CreateGetCommand(string whereSql, string orderBySql)
            {
                string sql = "Select PrediosOtras_id,Predio_id,cast(ISNULL(TA.valor,1)as int) as OtrasValor_id,TA.descripcion as OtrasValor_descripcion, " +
                                " ISNULL(Observacion, '') AS Observacion, ValorOtras, CantidadValor, CAST(ISNULL(PR.estado, 1) AS BIT) AS estado, pr.registro_fecha_add,PR.registro_fecha_update,PR.registro_pc_add, " +
                                " PR.registro_pc_update,PR.registro_user_add,PR.registro_user_update from Predios_Instalaciones PR " +
                                " LEFT JOIN TABLAS TA ON(TA.valor = PR.OtrasValor_id AND TA.dep_id = 2)";
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

    public virtual Pred_OtrasInstalaciones GetByPrimaryKey(Int32 PrediosOtras_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "PrediosOtras_id", DbType.Int32, PrediosOtras_id);
                var Pred_OtrasInstalaciones = default(Pred_OtrasInstalaciones);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Pred_OtrasInstalaciones = new Pred_OtrasInstalaciones
                        {
                            PrediosOtras_id = lector.GetInt32(lector.GetOrdinal("PrediosOtras_id")),
                            Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                            OtrasValor_id = lector.IsDBNull(lector.GetOrdinal("OtrasValor_id")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("OtrasValor_id")),
                            Observacion = lector.GetString(lector.GetOrdinal("Observacion")),
                            ValorOtras = lector.GetDecimal(lector.GetOrdinal("ValorOtras")),
                            CantidadValor = lector.GetDecimal(lector.GetOrdinal("CantidadValor")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

                        };
                    }
                }
                SQL.Dispose();
                return Pred_OtrasInstalaciones;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public virtual int Insert(Pred_OtrasInstalaciones Pred_OtrasInstalaciones,int periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            
                db.AddInParameter(SQL, "Predio_id", DbType.String, Pred_OtrasInstalaciones.Predio_id);
                db.AddInParameter(SQL, "OtrasValor_id", DbType.Int32, Pred_OtrasInstalaciones.OtrasValor_id);
                db.AddInParameter(SQL, "Observacion", DbType.String, Pred_OtrasInstalaciones.Observacion);
                db.AddInParameter(SQL, "ValorOtras", DbType.Decimal, Pred_OtrasInstalaciones.ValorOtras);
                db.AddInParameter(SQL, "CantidadValor", DbType.Decimal, Pred_OtrasInstalaciones.CantidadValor);
                db.AddInParameter(SQL, "registro_user", DbType.String, Pred_OtrasInstalaciones.registro_user_add);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_OtrasInstalaciones.Estado);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
            int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                //var numerogenerado = (int)db.GetParameterValue(SQL, "PrediosOtras_id");
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Pred_OtrasInstalaciones Pred_OtrasInstalaciones,int periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "PrediosOtras_id", DbType.Int32, Pred_OtrasInstalaciones.PrediosOtras_id);
                db.AddInParameter(SQL, "Predio_id", DbType.String, Pred_OtrasInstalaciones.Predio_id);
                db.AddInParameter(SQL, "OtrasValor_id", DbType.Int32, Pred_OtrasInstalaciones.OtrasValor_id);
                db.AddInParameter(SQL, "Observacion", DbType.String, Pred_OtrasInstalaciones.Observacion);
                db.AddInParameter(SQL, "ValorOtras", DbType.Decimal, Pred_OtrasInstalaciones.ValorOtras);
                db.AddInParameter(SQL, "CantidadValor", DbType.Decimal, Pred_OtrasInstalaciones.CantidadValor);
                db.AddInParameter(SQL, "registro_user", DbType.String, Pred_OtrasInstalaciones.registro_user_add);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_OtrasInstalaciones.Estado);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
                db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
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
    //insertar Otras >Intalciones en subdivisiones
    public virtual void InsertOtrasInstalcionesSubdivision(Pred_OtrasInstalaciones Pred_OtrasInstalaciones)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

            db.AddInParameter(SQL, "Predio_id", DbType.String, Pred_OtrasInstalaciones.Predio_id);
            db.AddInParameter(SQL, "OtrasValor_id", DbType.Int32, Pred_OtrasInstalaciones.OtrasValor_id);
            db.AddInParameter(SQL, "Observacion", DbType.String, Pred_OtrasInstalaciones.Observacion);
            db.AddInParameter(SQL, "ValorOtras", DbType.Decimal, Pred_OtrasInstalaciones.ValorOtras);
            db.AddInParameter(SQL, "CantidadValor", DbType.Decimal, Pred_OtrasInstalaciones.CantidadValor);
            db.AddInParameter(SQL, "registro_user", DbType.String, Pred_OtrasInstalaciones.registro_user_add);
            db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_OtrasInstalaciones.Estado);
            db.AddInParameter(SQL, "PrediosOtras_id", DbType.Int32, Pred_OtrasInstalaciones.PrediosOtras_id);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 14);
            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error al agregar al");
            }
            //var numerogenerado = (int)db.GetParameterValue(SQL, "PrediosOtras_id");
            SQL.Dispose();
            
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public virtual bool DeleteByPrimaryKey(Int32 PrediosOtras_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "PrediosOtras_id", DbType.Int32, PrediosOtras_id);
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
    public virtual Int32 GetExisteNuevo(string clase)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
            db.AddInParameter(SQL, "Observacion", DbType.String, clase);
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
    public virtual Int32 GetExisteModificar(string clase, Int32 codigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            db.AddInParameter(SQL, "Observacion", DbType.String, clase);
            db.AddInParameter(SQL, "OtrasValor_id", DbType.Int32, codigo);
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
    public virtual void GuardarOtrasInstalacionEnPredio(String predio_id, string user)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "registro_user", DbType.String, user);
            db.AddInParameter(SQL, "Predio_id", DbType.String, predio_id);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 11);
            periodo = PeriodoDataService.GetPeriodoActivo();
            db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
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
    public virtual void CancelarOtrasInstalacionEnPredio( string user)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "registro_user", DbType.String, user);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 12);
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
    public virtual void CopiarInstalacionesIndividual(Int32 id,String Predio,int user)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "PrediosOtras_id", DbType.Int32, id);
            db.AddInParameter(SQL, "Predio_id", DbType.Int32, Predio);
            db.AddInParameter(SQL, "registro_user", DbType.String, user);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 12);//modificar
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
    public virtual int InsertVariosAños(Pred_OtrasInstalaciones Pred_OtrasInstalaciones, int periodo, int periodo_idFin)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

            db.AddInParameter(SQL, "Predio_id", DbType.String, Pred_OtrasInstalaciones.Predio_id);
            db.AddInParameter(SQL, "OtrasValor_id", DbType.Int32, Pred_OtrasInstalaciones.OtrasValor_id);
            db.AddInParameter(SQL, "Observacion", DbType.String, Pred_OtrasInstalaciones.Observacion);
            db.AddInParameter(SQL, "ValorOtras", DbType.Decimal, Pred_OtrasInstalaciones.ValorOtras);
            db.AddInParameter(SQL, "CantidadValor", DbType.Decimal, Pred_OtrasInstalaciones.CantidadValor);
            db.AddInParameter(SQL, "registro_user", DbType.String, Pred_OtrasInstalaciones.registro_user_add);
            db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_OtrasInstalaciones.Estado);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 15);
            db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
            db.AddInParameter(SQL, "periodo_idFin", DbType.String, periodo_idFin);
            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error al agregar al");
            }
            //var numerogenerado = (int)db.GetParameterValue(SQL, "PrediosOtras_id");
            SQL.Dispose();
            return huboexito;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}