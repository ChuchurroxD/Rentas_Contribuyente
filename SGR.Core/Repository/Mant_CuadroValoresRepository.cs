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
    public class Mant_CuadroValoresRepository
    {
        private const String nombreprocedimiento = "_mant_cuadro_valores";
        private const String NombreTabla = "cuadro_valores";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Mant_CuadroValores> listartodos()
        {
            try
            {
                var coleccion = new List<Mant_CuadroValores>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_CuadroValores
                        {
                            cuadro_valores_id = lector.GetInt32(lector.GetOrdinal("cuadro_valores_id")),
                            codigo = lector.GetInt32(lector.GetOrdinal("codigo")),
                            serie = lector.IsDBNull(lector.GetOrdinal("serie")) ? default(String) : lector.GetString(lector.GetOrdinal("serie")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("estado")),
                            codigoDesc = lector.GetString(lector.GetOrdinal("codigodesc")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.GetString(lector.GetOrdinal("registro_user_add")),
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
        public List<Mant_CuadroValores> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }

        public virtual int ExisteElementosPeriodoAnterior(int tipoconsulta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, tipoconsulta);
                int CANTIDAD = Convert.ToInt32(db.ExecuteScalar(SQL));

                SQL.Dispose();
                return CANTIDAD;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void CopiarElementosPeriodoAnterior(string usser)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
                int huboexito = db.ExecuteNonQuery(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual List<Mant_CuadroValores> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Mant_CuadroValores>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_CuadroValores
                        {
                            cuadro_valores_id = lector.GetInt32(lector.GetOrdinal("cuadro_valores_id")),
                            codigo = lector.GetInt32(lector.GetOrdinal("codigo")),
                            serie = lector.IsDBNull(lector.GetOrdinal("serie")) ? default(String) : lector.GetString(lector.GetOrdinal("serie")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("estado")),
                            codigoDesc = lector.GetString(lector.GetOrdinal("codigodesc")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.GetString(lector.GetOrdinal("registro_user_add")),
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
        public virtual Mant_CuadroValores GetByPrimaryKey(Int32 cuadro_valores_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "cuadro_valores_id", DbType.Int32, cuadro_valores_id);
                var cuadro_valores = default(Mant_CuadroValores);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        cuadro_valores = new Mant_CuadroValores
                        {
                            cuadro_valores_id = lector.GetInt32(lector.GetOrdinal("cuadro_valores_id")),
                            codigo = lector.GetInt32(lector.GetOrdinal("codigo")),
                            serie = lector.IsDBNull(lector.GetOrdinal("serie")) ? default(String) : lector.GetString(lector.GetOrdinal("serie")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("estado")),
                            codigoDesc = lector.GetString(lector.GetOrdinal("codigodesc")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

                        };
                    }
                }
                SQL.Dispose();
                return cuadro_valores;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "select cv.*,t.descripcion as codigodesc from cuadro_valores cv inner join tablas t on cv.codigo = t.valor";
            if ((whereSql != null) && (whereSql.Trim().Length > 0))
            {
                sql += " WHERE t.dep_id=27 and " + whereSql;
            }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
            {
                sql += " ORDER BY " + orderBySql;
            }
            return sql;
        }
        public virtual int validarRegistro(Mant_CuadroValores cuadro_valores, int opcion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "codigo", DbType.Int32, cuadro_valores.codigo);
                db.AddInParameter(SQL, "serie", DbType.String, cuadro_valores.serie);
                db.AddInParameter(SQL, "descripcion", DbType.String, cuadro_valores.descripcion);
                db.AddInParameter(SQL, "monto", DbType.Decimal, cuadro_valores.monto);
                db.AddInParameter(SQL, "anio", DbType.Int32, cuadro_valores.anio);
                db.AddInParameter(SQL, "estado", DbType.Int16, cuadro_valores.estado);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, cuadro_valores.registro_fecha_add);
                //db.AddInParameter(SQL, "registro_user_add", DbType.Int32, cuadro_valores.registro_user_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, cuadro_valores.registro_pc_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, cuadro_valores.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_user_update", DbType.Int32, cuadro_valores.registro_user_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, cuadro_valores.registro_pc_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
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
        public virtual int valida(Mant_CuadroValores cuadro_valores)
        {
            try
            {
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "codigo", DbType.Int32, cuadro_valores.codigo);
                db.AddInParameter(SQL, "serie", DbType.String, cuadro_valores.serie);
                db.AddInParameter(SQL, "anio", DbType.Int32, cuadro_valores.anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 7);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public virtual int Insert(Mant_CuadroValores cuadro_valores)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "codigo", DbType.Int32, cuadro_valores.codigo);
                db.AddInParameter(SQL, "serie", DbType.String, cuadro_valores.serie);
                db.AddInParameter(SQL, "descripcion", DbType.String, cuadro_valores.descripcion);
                db.AddInParameter(SQL, "monto", DbType.Decimal, cuadro_valores.monto);
                db.AddInParameter(SQL, "anio", DbType.Int32, cuadro_valores.anio);
                db.AddInParameter(SQL, "estado", DbType.Int16, cuadro_valores.estado);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, cuadro_valores.registro_fecha_add);
                //db.AddInParameter(SQL, "registro_user_add", DbType.Int32, cuadro_valores.registro_user_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, cuadro_valores.registro_pc_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, cuadro_valores.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_user_update", DbType.Int32, cuadro_valores.registro_user_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, cuadro_valores.registro_pc_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
               
                SQL.Dispose();
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void Update(Mant_CuadroValores cuadro_valores)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "cuadro_valores_id", DbType.Int32, cuadro_valores.cuadro_valores_id);
                db.AddInParameter(SQL, "codigo", DbType.Int32, cuadro_valores.codigo);
                db.AddInParameter(SQL, "serie", DbType.String, cuadro_valores.serie);
                db.AddInParameter(SQL, "descripcion", DbType.String, cuadro_valores.descripcion);
                db.AddInParameter(SQL, "monto", DbType.Decimal, cuadro_valores.monto);
                db.AddInParameter(SQL, "anio", DbType.Int32, cuadro_valores.anio);
                db.AddInParameter(SQL, "estado", DbType.Int16, cuadro_valores.estado);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, cuadro_valores.registro_fecha_add);
                //db.AddInParameter(SQL, "registro_user_add", DbType.Int32, cuadro_valores.registro_user_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, cuadro_valores.registro_pc_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, cuadro_valores.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_user_update", DbType.Int32, cuadro_valores.registro_user_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, cuadro_valores.registro_pc_update);
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
        public virtual bool DeleteByPrimaryKey(Int32 cuadro_valores_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "cuadro_valores_id", DbType.Int32, cuadro_valores_id);
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
        public List<Mant_CuadroValores> listarErroresCuadroValores(Int32 periodo)
        {
            try
            {
                var coleccion = new List<Mant_CuadroValores>();
                String a = "";
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        //a = "";
                        //a = lector.GetString(lector.GetOrdinal("Material"));
                        //if(String.Compare(a.Trim(),"0")!=0)
                        //{
                        coleccion.Add(new Mant_CuadroValores
                        {
                            descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcion"))
                        });
                        //}

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
