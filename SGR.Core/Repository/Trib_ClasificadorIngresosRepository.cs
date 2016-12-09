using System;
using System.Collections.Generic;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;


    public class Trib_ClasificadorIngresosRepository
    {
        private const String nombreprocedimiento = "_Trib_Clasificador_ingresos";
        private const String NombreTabla = "Clasificador_ingresos";
        private Database db = DatabaseFactory.CreateDatabase();

    public virtual void copiarClasificadores(string periodoPrevio, string periodoActual)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "periodoPrevio", DbType.String, periodoPrevio);
            db.AddInParameter(SQL, "periodoActual", DbType.String, periodoActual);
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
    public List<Trib_ClasificadorIngresos> listartodos()
        {
            try
            {
                var coleccion = new List<Trib_ClasificadorIngresos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_ClasificadorIngresos
                        {
                            Tribc_vCodigo = lector.GetString(lector.GetOrdinal("clai_codigo")),
                            Tribc_vAnio = lector.GetString(lector.GetOrdinal("clai_anio")),
                            Tribc_vPresupuesto = lector.IsDBNull(lector.GetOrdinal("clai_presupuesto")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_presupuesto")),
                            Tribc_vContable = lector.IsDBNull(lector.GetOrdinal("clai_contable")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_contable")),
                            Tribc_vContableant = lector.IsDBNull(lector.GetOrdinal("clai_contableant")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_contableant")),
                            Tribc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("clai_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_descripcion")),
                            Tribc_bEstado = lector.IsDBNull(lector.GetOrdinal("clai_estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("clai_estado"))

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
    
    public List<Trib_ClasificadorIngresos> listarHijos(String padre,String anio)
    {
        try
        {
            var coleccion = new List<Trib_ClasificadorIngresos>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);            
            db.AddInParameter(SQL, "clai_codigo", DbType.String, padre);
            db.AddInParameter(SQL, "clai_anio", DbType.Int32, anio);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Trib_ClasificadorIngresos
                    {
                        Tribc_vCodigo = lector.GetString(lector.GetOrdinal("clai_codigo")),
                        Tribc_vAnio = lector.GetString(lector.GetOrdinal("clai_anio")),
                        Tribc_vPresupuesto = lector.IsDBNull(lector.GetOrdinal("clai_presupuesto")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_presupuesto")),
                        Tribc_vContable = lector.IsDBNull(lector.GetOrdinal("clai_contable")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_contable")),
                        Tribc_vContableant = lector.IsDBNull(lector.GetOrdinal("clai_contableant")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_contableant")),
                        Tribc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("clai_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_descripcion")),
                        Tribc_bEstado = lector.IsDBNull(lector.GetOrdinal("clai_estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("clai_estado"))

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

    public virtual Int32 ExistenciaDescripcion(String descripcion,string anio)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            db.AddInParameter(SQL, "clai_anio", DbType.Int32, anio);
            //db.AddInParameter(SQL, "UnNec_iCodigo", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "clai_descripcion", DbType.String, descripcion);
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

    public virtual Int32 ExistenciaCodigo(String descripcion, string anio)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);//cambiar tipo
            db.AddInParameter(SQL, "clai_anio", DbType.Int32, anio);
            //db.AddInParameter(SQL, "UnNec_iCodigo", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "clai_codigo", DbType.String, descripcion);
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

    public List<Trib_ClasificadorIngresos> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }


        public virtual List<Trib_ClasificadorIngresos> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Trib_ClasificadorIngresos>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_ClasificadorIngresos
                        {
                            Tribc_vCodigo = lector.GetString(lector.GetOrdinal("clai_codigo")),
                            Tribc_vAnio = lector.GetString(lector.GetOrdinal("clai_anio")),
                            Tribc_vPresupuesto = lector.IsDBNull(lector.GetOrdinal("clai_presupuesto")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_presupuesto")),
                            Tribc_vContable = lector.IsDBNull(lector.GetOrdinal("clai_contable")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_contable")),
                            Tribc_vContableant = lector.IsDBNull(lector.GetOrdinal("clai_contableant")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_contableant")),
                            Tribc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("clai_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_descripcion")),
                            Tribc_bEstado = lector.IsDBNull(lector.GetOrdinal("clai_estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("clai_estado"))

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


        public virtual Trib_ClasificadorIngresos GetByPrimaryKey(String clai_codigo, String clai_anio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "clai_codigo", DbType.String, clai_codigo);
                db.AddInParameter(SQL, "clai_anio", DbType.String, clai_anio);
                var Trib_ClasificadorIngresos = default(Trib_ClasificadorIngresos);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Trib_ClasificadorIngresos = new Trib_ClasificadorIngresos
                        {
                            Tribc_vCodigo = lector.GetString(lector.GetOrdinal("clai_codigo")),
                            Tribc_vAnio = lector.GetString(lector.GetOrdinal("clai_anio")),
                            Tribc_vPresupuesto = lector.IsDBNull(lector.GetOrdinal("clai_presupuesto")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_presupuesto")),
                            Tribc_vContable = lector.IsDBNull(lector.GetOrdinal("clai_contable")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_contable")),
                            Tribc_vContableant = lector.IsDBNull(lector.GetOrdinal("clai_contableant")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_contableant")),
                            Tribc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("clai_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("clai_descripcion")),
                            Tribc_bEstado = lector.IsDBNull(lector.GetOrdinal("clai_estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("clai_estado"))

                        };
                    }
                }
                SQL.Dispose();
                return Trib_ClasificadorIngresos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT * FROM [dbo].[Trib_ClasificadorIngresos]";
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

        public virtual int Insert(Trib_ClasificadorIngresos Trib_ClasificadorIngresos)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "clai_codigo", DbType.String, Trib_ClasificadorIngresos.Tribc_vCodigo);
                db.AddInParameter(SQL, "clai_anio", DbType.String, Trib_ClasificadorIngresos.Tribc_vAnio);
                db.AddInParameter(SQL, "clai_presupuesto", DbType.String, Trib_ClasificadorIngresos.Tribc_vPresupuesto);
                db.AddInParameter(SQL, "clai_contable", DbType.String, Trib_ClasificadorIngresos.Tribc_vContable);
                db.AddInParameter(SQL, "clai_contableant", DbType.String, Trib_ClasificadorIngresos.Tribc_vContableant);
                db.AddInParameter(SQL, "clai_descripcion", DbType.String, Trib_ClasificadorIngresos.Tribc_vDescripcion);
                db.AddInParameter(SQL, "clai_estado", DbType.Boolean, Trib_ClasificadorIngresos.Tribc_bEstado);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Trib_ClasificadorIngresos.registro_user_add);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Trib_ClasificadorIngresos.registro_user_update);
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


        public virtual void Update(Trib_ClasificadorIngresos Trib_ClasificadorIngresos,string codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "clai_codigo", DbType.String, Trib_ClasificadorIngresos.Tribc_vCodigo);
                db.AddInParameter(SQL, "clai_anio", DbType.String, Trib_ClasificadorIngresos.Tribc_vAnio);
                db.AddInParameter(SQL, "clai_presupuesto", DbType.String, Trib_ClasificadorIngresos.Tribc_vPresupuesto);
                db.AddInParameter(SQL, "clai_contable", DbType.String, Trib_ClasificadorIngresos.Tribc_vContable);
                db.AddInParameter(SQL, "clai_contableant", DbType.String, Trib_ClasificadorIngresos.Tribc_vContableant);
                db.AddInParameter(SQL, "clai_descripcion", DbType.String, Trib_ClasificadorIngresos.Tribc_vDescripcion);
                db.AddInParameter(SQL, "clai_estado", DbType.Boolean, Trib_ClasificadorIngresos.Tribc_bEstado);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Trib_ClasificadorIngresos.registro_user_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
                db.AddInParameter(SQL, "anteCodigo", DbType.String, codigo);
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


        public virtual bool DeleteByPrimaryKey(String clai_codigo, String clai_anio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "clai_codigo", DbType.String, clai_codigo);
                db.AddInParameter(SQL, "clai_anio", DbType.String, clai_anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 7);
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
    public List<Trib_ClasificadorIngresos> llenarComboEnTributo(string anio)
    {
        try
        {
            var coleccion = new List<Trib_ClasificadorIngresos>();
            DbCommand sql = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(sql, "clai_anio", DbType.String, anio);
            db.AddInParameter(sql, "Tipoconsulta", DbType.String, 11);
            using (var lector = db.ExecuteReader(sql)) {
                while (lector.Read())
                {
                    coleccion.Add(new Trib_ClasificadorIngresos
                    {
                        Tribc_vCodigo  = lector.GetString(lector.GetOrdinal("clai_codigo")),
                        Tribc_vDescripcion = lector.GetString(lector.GetOrdinal("clai_descripcion"))
                    });
                }
            }
            sql.Dispose();
            return coleccion;
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

}
