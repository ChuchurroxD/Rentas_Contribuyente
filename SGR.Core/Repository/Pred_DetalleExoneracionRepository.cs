using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
namespace SGR.Core.Repository
{
    public class Pred_DetalleExoneracionRepository
    {
        private const String nombreprocedimiento = "_Pred_DetalleExoneracion";
        private const String NombreTabla = "DetalleExoneracion";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Mant_Mes> listarxExoneracion(Int32 des_exo_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "des_exo_ID", DbType.String, des_exo_ID);
                var coleccion = new List<Mant_Mes>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Mes
                        {
                            Enero = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("1"))),
                            Febrero = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("2"))),
                            Marzo = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("3"))),
                            Abril = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("4"))),
                            Mayo = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("5"))),
                            Junio = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("6"))),
                            Julio = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("7"))),
                            Agosto = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("8"))),
                            Setiembre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("9"))),
                            Octubre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("10"))),
                            Noviembre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("11"))),
                            Anio = Convert.ToString(lector.GetInt16(lector.GetOrdinal("anio"))),
                            Total = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("total"))),
                            Diciembre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("12")))
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



        public List<Pred_DetalleExoneracion> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }


        public virtual List<Pred_DetalleExoneracion> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Pred_DetalleExoneracion>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_DetalleExoneracion
                        {
                            detalle_exoneracion_id = lector.GetInt32(lector.GetOrdinal("detalle_exoneracion_id")),
                            estado = lector.GetInt32(lector.GetOrdinal("estado")),
                            Cuenta_Corriente_ID = lector.GetInt32(lector.GetOrdinal("Cuenta_Corriente_ID")),
                            monto_deuda = lector.GetDecimal(lector.GetOrdinal("monto_deuda")),
                            monto_abono = lector.GetDecimal(lector.GetOrdinal("monto_abono")),
                            mes = lector.IsDBNull(lector.GetOrdinal("mes")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mes")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio")),
                            descuentos_exoneracion_id = lector.IsDBNull(lector.GetOrdinal("descuentos_exoneracion_id")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("descuentos_exoneracion_id"))

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


        public virtual Pred_DetalleExoneracion GetByPrimaryKey(Int32 detalle_exoneracion_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "detalle_exoneracion_id", DbType.Int32, detalle_exoneracion_id);
                var DetalleExoneracion = default(Pred_DetalleExoneracion);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        DetalleExoneracion = new Pred_DetalleExoneracion
                        {
                            detalle_exoneracion_id = lector.GetInt32(lector.GetOrdinal("detalle_exoneracion_id")),
                            estado = lector.GetInt32(lector.GetOrdinal("estado")),
                            Cuenta_Corriente_ID = lector.GetInt32(lector.GetOrdinal("Cuenta_Corriente_ID")),
                            monto_deuda = lector.GetDecimal(lector.GetOrdinal("monto_deuda")),
                            monto_abono = lector.GetDecimal(lector.GetOrdinal("monto_abono")),
                            mes = lector.IsDBNull(lector.GetOrdinal("mes")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mes")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio")),
                            descuentos_exoneracion_id = lector.IsDBNull(lector.GetOrdinal("descuentos_exoneracion_id")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("descuentos_exoneracion_id"))

                        };
                    }
                }
                SQL.Dispose();
                return DetalleExoneracion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT * FROM [dbo].[DetalleExoneracion]";
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

        public virtual int Insert(Pred_DetalleExoneracion DetalleExoneracion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "estado", DbType.Int32, DetalleExoneracion.estado);
                db.AddInParameter(SQL, "Cuenta_Corriente_ID", DbType.Int32, DetalleExoneracion.Cuenta_Corriente_ID);
                db.AddInParameter(SQL, "monto_deuda", DbType.Single, DetalleExoneracion.monto_deuda);
                db.AddInParameter(SQL, "monto_abono", DbType.Single, DetalleExoneracion.monto_abono);
                db.AddInParameter(SQL, "mes", DbType.Int16, DetalleExoneracion.mes);
                db.AddInParameter(SQL, "anio", DbType.Int16, DetalleExoneracion.anio);
                db.AddInParameter(SQL, "descuentos_exoneracion_id", DbType.Int32, DetalleExoneracion.descuentos_exoneracion_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                var numerogenerado = (int)db.GetParameterValue(SQL, "detalle_exoneracion_id");
                SQL.Dispose();
                return numerogenerado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Pred_DetalleExoneracion DetalleExoneracion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "detalle_exoneracion_id", DbType.Int32, DetalleExoneracion.detalle_exoneracion_id);
                db.AddInParameter(SQL, "estado", DbType.Int32, DetalleExoneracion.estado);
                db.AddInParameter(SQL, "Cuenta_Corriente_ID", DbType.Int32, DetalleExoneracion.Cuenta_Corriente_ID);
                db.AddInParameter(SQL, "monto_deuda", DbType.Single, DetalleExoneracion.monto_deuda);
                db.AddInParameter(SQL, "monto_abono", DbType.Single, DetalleExoneracion.monto_abono);
                db.AddInParameter(SQL, "mes", DbType.Int16, DetalleExoneracion.mes);
                db.AddInParameter(SQL, "anio", DbType.Int16, DetalleExoneracion.anio);
                db.AddInParameter(SQL, "descuentos_exoneracion_id", DbType.Int32, DetalleExoneracion.descuentos_exoneracion_id);
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


        public virtual bool DeleteByPrimaryKey(Int32 detalle_exoneracion_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "detalle_exoneracion_id", DbType.Int32, detalle_exoneracion_id);
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



    }
}
