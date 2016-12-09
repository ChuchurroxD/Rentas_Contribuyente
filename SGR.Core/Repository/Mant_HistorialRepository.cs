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
using SGR.Entity.Model;

namespace SGR.Core.Repository
{
    public class Mant_HistorialRepository
    {
        private const String nombreprocedimiento = "_Mant_Historial";
        private const String NombreTabla = "Historial";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Mant_Historial> listartodos(Int32 tipo, string IDD, Int32 idPeriodo)
        {
            try
            {
                var coleccion = new List<Mant_Historial>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Int32, tipo);
                //if(tipo==1)
                db.AddInParameter(SQL, "idPersona", DbType.String, IDD);
                db.AddInParameter(SQL, "idPredio", DbType.String, IDD);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Historial
                        {
                            idHistorial = lector.IsDBNull(lector.GetOrdinal("idHistorial")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idHistorial")),
                            idPredio = lector.IsDBNull(lector.GetOrdinal("idPredio")) ? default(String) : lector.GetString(lector.GetOrdinal("idPredio")),
                            idPersona = lector.IsDBNull(lector.GetOrdinal("idPersona")) ? default(String) : lector.GetString(lector.GetOrdinal("idPersona")),
                            tipo = lector.IsDBNull(lector.GetOrdinal("tipo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            Obligacion = lector.IsDBNull(lector.GetOrdinal("Obligacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Obligacion")),
                            Expediente = lector.IsDBNull(lector.GetOrdinal("Expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("Expediente")),
                            TipoOperacion = lector.IsDBNull(lector.GetOrdinal("TipoOperacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("TipoOperacion")),
                            tipoOperDescrip = lector.IsDBNull(lector.GetOrdinal("operadescrip")) ? default(String) : lector.GetString(lector.GetOrdinal("operadescrip")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            tipoDocumento = lector.GetString(lector.GetOrdinal("tipoDocumento")).Trim(),
                            tipodocDescrip = lector.IsDBNull(lector.GetOrdinal("tipodocDescrip")) ? default(String) : lector.GetString(lector.GetOrdinal("tipodocDescrip")),
                            fecha = lector.GetDateTime(lector.GetOrdinal("fecha")),
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

        public List<Mant_Historial> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }

        public virtual List<Mant_Historial> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Mant_Historial>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Historial
                        {
                            idHistorial = lector.IsDBNull(lector.GetOrdinal("idHistorial")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idHistorial")),
                            idPredio = lector.IsDBNull(lector.GetOrdinal("idPredio")) ? default(String) : lector.GetString(lector.GetOrdinal("idPredio")),
                            idPersona = lector.IsDBNull(lector.GetOrdinal("idPersona")) ? default(String) : lector.GetString(lector.GetOrdinal("idPersona")),
                            tipo = lector.IsDBNull(lector.GetOrdinal("tipo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            Obligacion = lector.IsDBNull(lector.GetOrdinal("Obligacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Obligacion")),
                            Expediente = lector.IsDBNull(lector.GetOrdinal("Expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("Expediente")),
                            TipoOperacion = lector.IsDBNull(lector.GetOrdinal("TipoOperacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("TipoOperacion")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update"))

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

        public virtual Mant_Historial GetByPrimaryKey()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                var Historial = default(Mant_Historial);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Historial = new Mant_Historial
                        {
                            idHistorial = lector.IsDBNull(lector.GetOrdinal("idHistorial")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idHistorial")),
                            idPredio = lector.IsDBNull(lector.GetOrdinal("idPredio")) ? default(String) : lector.GetString(lector.GetOrdinal("idPredio")),
                            idPersona = lector.IsDBNull(lector.GetOrdinal("idPersona")) ? default(String) : lector.GetString(lector.GetOrdinal("idPersona")),
                            tipo = lector.IsDBNull(lector.GetOrdinal("tipo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            Obligacion = lector.IsDBNull(lector.GetOrdinal("Obligacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Obligacion")),
                            Expediente = lector.IsDBNull(lector.GetOrdinal("Expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("Expediente")),
                            TipoOperacion = lector.IsDBNull(lector.GetOrdinal("TipoOperacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("TipoOperacion")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update"))

                        };
                    }
                }
                SQL.Dispose();
                return Historial;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT * FROM [dbo].[Historial]";
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

        public virtual int Insert(Mant_Historial mant_Historial)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idPredio", DbType.String, mant_Historial.idPredio);
                db.AddInParameter(SQL, "idPersona", DbType.String, mant_Historial.idPersona);
                db.AddInParameter(SQL, "tipo", DbType.Int32, mant_Historial.tipo);
                db.AddInParameter(SQL, "Descripcion", DbType.String, mant_Historial.Descripcion);
                db.AddInParameter(SQL, "Obligacion", DbType.String, mant_Historial.Obligacion);
                db.AddInParameter(SQL, "Expediente", DbType.String, mant_Historial.Expediente);
                db.AddInParameter(SQL, "TipoOperacion", DbType.Int32, mant_Historial.TipoOperacion);
                db.AddInParameter(SQL, "registro_user", DbType.String, mant_Historial.registro_user_add);
                db.AddInParameter(SQL, "estado", DbType.Boolean, mant_Historial.estado);
                db.AddInParameter(SQL, "tipoDocumento", DbType.String, mant_Historial.tipoDocumento);
                db.AddInParameter(SQL, "fecha", DbType.DateTime, mant_Historial.fecha);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 3);
                int huboexito = db.ExecuteNonQuery(SQL);
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mant_Historial mant_Historial)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idHistorial", DbType.Int32, mant_Historial.idHistorial);
                db.AddInParameter(SQL, "Descripcion", DbType.String, mant_Historial.Descripcion);
                db.AddInParameter(SQL, "Obligacion", DbType.String, mant_Historial.Obligacion);
                db.AddInParameter(SQL, "Expediente", DbType.String, mant_Historial.Expediente);
                db.AddInParameter(SQL, "TipoOperacion", DbType.Int32, mant_Historial.TipoOperacion);
                db.AddInParameter(SQL, "registro_user", DbType.String, mant_Historial.registro_user_update);
                db.AddInParameter(SQL, "estado", DbType.Boolean, mant_Historial.estado);
                db.AddInParameter(SQL, "tipoDocumento", DbType.String, mant_Historial.tipoDocumento);
                db.AddInParameter(SQL, "fecha", DbType.DateTime, mant_Historial.fecha);
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

        public List<Mant_Historial> buscarHistorial(Int32 tipo, string idPersona)
        {
            try
            {
                var coleccion = new List<Mant_Historial>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Int32, tipo);
                db.AddInParameter(SQL, "idPersona", DbType.String, idPersona);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Historial
                        {
                            idHistorial = lector.IsDBNull(lector.GetOrdinal("idHistorial")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idHistorial")),
                            idPredio = lector.IsDBNull(lector.GetOrdinal("idPredio")) ? default(String) : lector.GetString(lector.GetOrdinal("idPredio")),
                            idPersona = lector.IsDBNull(lector.GetOrdinal("idPersona")) ? default(String) : lector.GetString(lector.GetOrdinal("idPersona")),
                            tipo = lector.IsDBNull(lector.GetOrdinal("tipo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            Obligacion = lector.IsDBNull(lector.GetOrdinal("Obligacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Obligacion")),
                            Expediente = lector.IsDBNull(lector.GetOrdinal("Expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("Expediente")),
                            TipoOperacion = lector.IsDBNull(lector.GetOrdinal("TipoOperacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("TipoOperacion")),
                            tipoOperDescrip = lector.IsDBNull(lector.GetOrdinal("operadescrip")) ? default(String) : lector.GetString(lector.GetOrdinal("operadescrip")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
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
