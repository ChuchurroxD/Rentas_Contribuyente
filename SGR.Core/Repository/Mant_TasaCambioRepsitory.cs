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
    public class Mant_TasaCambioRepsitory
    {
        private const String nombreProcedimiento = "_Mant_TasaCambio";
        private const String nombreTabla = "Tasa_Cambio";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Mant_TasaCambio> listarTodos()
        {
            try
            {
                var coleccion = new List<Mant_TasaCambio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TasaCambio
                        {
                            idTasaCambio = lector.IsDBNull(lector.GetOrdinal("idTasaCambio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idTasaCambio")),
                            fecha = lector.IsDBNull(lector.GetOrdinal("fecha")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha")),
                            precioVenta = lector.IsDBNull(lector.GetOrdinal("precioVenta")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("precioVenta")),
                            precioCompra = lector.IsDBNull(lector.GetOrdinal("precioCompra")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("precioCompra")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("estado")),
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

        public virtual List<Mant_TasaCambio> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Mant_TasaCambio>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TasaCambio
                        {
                            idTasaCambio = lector.IsDBNull(lector.GetOrdinal("idTasaCambio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idTasaCambio")),
                            fecha = lector.IsDBNull(lector.GetOrdinal("fecha")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha")),
                            precioVenta = lector.IsDBNull(lector.GetOrdinal("precioVenta")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("precioVenta")),
                            precioCompra = lector.IsDBNull(lector.GetOrdinal("precioCompra")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("precioCompra")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("estado")),
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
            string sql = "Select idTasaCambio,fecha,precioVenta,precioCompra,estado,registro_fecha_add,registro_pc_add, registro_user_add,registro_fecha_update,registro_pc_update,registro_user_update From Tasa_Cambio";
            if ((whereSql != null) && (whereSql.Trim().Length > 0))
            {
                sql += " WHERE estado = 1 and " + whereSql;
            }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
            {
                sql += " ORDER BY " + orderBySql;
            }
            return sql;
        }

        public virtual Mant_TasaCambio GetByPrimaryKey(Int32 arancelID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "arancelID", DbType.Int32, arancelID);
                var mant_TasaCambio = default(Mant_TasaCambio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        mant_TasaCambio = new Mant_TasaCambio
                        {
                            idTasaCambio = lector.IsDBNull(lector.GetOrdinal("idTasaCambio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idTasaCambio")),
                            fecha = lector.IsDBNull(lector.GetOrdinal("fecha")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha")),
                            precioVenta = lector.IsDBNull(lector.GetOrdinal("precioVenta")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("precioVenta")),
                            precioCompra = lector.IsDBNull(lector.GetOrdinal("precioCompra")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("precioCompra")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("estado")),
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
                return mant_TasaCambio;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Insert(Mant_TasaCambio mant_TasaCambio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "fecha", DbType.DateTime, mant_TasaCambio.fecha);
                db.AddInParameter(SQL, "precioVenta", DbType.Decimal, mant_TasaCambio.precioVenta);
                db.AddInParameter(SQL, "precioCompra", DbType.Decimal, mant_TasaCambio.precioCompra);
                db.AddInParameter(SQL, "estado", DbType.Boolean, mant_TasaCambio.estado);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, mant_TasaCambio.registro_user_add);
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

        public virtual void Update(Mant_TasaCambio mant_TasaCambio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "idTasaCambio", DbType.Int32, mant_TasaCambio.idTasaCambio);
                db.AddInParameter(SQL, "fecha", DbType.DateTime, mant_TasaCambio.fecha);
                db.AddInParameter(SQL, "precioVenta", DbType.Decimal, mant_TasaCambio.precioVenta);
                db.AddInParameter(SQL, "precioCompra", DbType.Decimal, mant_TasaCambio.precioCompra);
                db.AddInParameter(SQL, "estado", DbType.Boolean, mant_TasaCambio.estado);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, mant_TasaCambio.registro_user_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("No se pudo realizar la modificación");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual bool DeleteByPrimaryKey(int idTasaCambio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "idTasaCambio", DbType.String, idTasaCambio);
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

        public virtual List<Mant_TasaCambio> buscarByDate(string fecha)
        {
            try
            {
                var coleccion = new List<Mant_TasaCambio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "fecha", DbType.String, fecha);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_TasaCambio
                        {
                            idTasaCambio = lector.IsDBNull(lector.GetOrdinal("idTasaCambio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idTasaCambio")),
                            fecha = lector.IsDBNull(lector.GetOrdinal("fecha")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha")),
                            precioVenta = lector.IsDBNull(lector.GetOrdinal("precioVenta")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("precioVenta")),
                            precioCompra = lector.IsDBNull(lector.GetOrdinal("precioCompra")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("precioCompra")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("estado")),
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
    }
}
