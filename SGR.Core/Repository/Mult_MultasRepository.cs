using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
namespace SGR.Core.Repository
{
    public class Mult_MultasRepository
    {
        private const String nombreprocedimiento = "_Mult_Multas";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Mult_Multas> listartodos()
        {
            try
            {
                var coleccion = new List<Mult_Multas>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mult_Multas
                        {
                            mult_id = lector.GetInt32(lector.GetOrdinal("mult_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            persona = lector.IsDBNull(lector.GetOrdinal("persona")) ? default(string) : lector.GetString(lector.GetOrdinal("persona")),
                            mult_direccion = lector.IsDBNull(lector.GetOrdinal("mult_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_direccion")),
                            TipoMulta_id = lector.GetInt32(lector.GetOrdinal("TipoMulta_id")),
                            mult_monto = lector.GetDecimal(lector.GetOrdinal("mult_monto")),
                            mult_nro_resolucion = lector.IsDBNull(lector.GetOrdinal("mult_nro_resolucion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_nro_resolucion")),
                            mult_anio_resolucion = lector.IsDBNull(lector.GetOrdinal("mult_anio_resolucion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_anio_resolucion")),
                            mult_fecha_resol = lector.IsDBNull(lector.GetOrdinal("mult_fecha_resol")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("mult_fecha_resol")),
                            mult_archivo = lector.IsDBNull(lector.GetOrdinal("mult_archivo")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_archivo")),
                            mult_observacion = lector.IsDBNull(lector.GetOrdinal("mult_observacion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_observacion")),
                            fecha_genera = lector.IsDBNull(lector.GetOrdinal("fecha_genera")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_genera")),
                            fecha_notifica = lector.IsDBNull(lector.GetOrdinal("fecha_notifica")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_notifica")),
                            fecha_vence = lector.IsDBNull(lector.GetOrdinal("fecha_vence")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            fecha_elimina = lector.IsDBNull(lector.GetOrdinal("fecha_elimina")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_elimina")),
                            mult_estado = lector.IsDBNull(lector.GetOrdinal("mult_estado")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_estado")),
                            tp_recurso = lector.IsDBNull(lector.GetOrdinal("tp_recurso")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tp_recurso")),
                            resol_resuelve = lector.IsDBNull(lector.GetOrdinal("resol_resuelve")) ? default(string) : lector.GetString(lector.GetOrdinal("resol_resuelve")),
                            fech_recurso = lector.IsDBNull(lector.GetOrdinal("fech_recurso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fech_recurso")),
                            tp_declaro = lector.IsDBNull(lector.GetOrdinal("tp_declaro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tp_declaro")),
                            recursod = lector.IsDBNull(lector.GetOrdinal("recursod")) ? default(string) : lector.GetString(lector.GetOrdinal("recursod")),
                            declarod = lector.IsDBNull(lector.GetOrdinal("declarod")) ? default(string) : lector.GetString(lector.GetOrdinal("declarod")),
                            tipomultad = lector.IsDBNull(lector.GetOrdinal("tipomultad")) ? default(string) : lector.GetString(lector.GetOrdinal("tipomultad"))
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

        public List<Mult_Multas> listarTodosPorAnio(int anio, int CLASEMULT)
        {
            try
            {
                var coleccion = new List<Mult_Multas>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "clase_Multa", DbType.Int32, CLASEMULT);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mult_Multas
                        {
                            mult_id = lector.GetInt32(lector.GetOrdinal("mult_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            persona = lector.IsDBNull(lector.GetOrdinal("persona")) ? default(string) : lector.GetString(lector.GetOrdinal("persona")),
                            mult_direccion = lector.IsDBNull(lector.GetOrdinal("mult_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_direccion")),
                            TipoMulta_id = lector.GetInt32(lector.GetOrdinal("TipoMulta_id")),
                            mult_monto = lector.GetDecimal(lector.GetOrdinal("mult_monto")),
                            mult_nro_resolucion = lector.IsDBNull(lector.GetOrdinal("mult_nro_resolucion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_nro_resolucion")),
                            mult_anio_resolucion = lector.IsDBNull(lector.GetOrdinal("mult_anio_resolucion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_anio_resolucion")),
                            mult_fecha_resol = lector.IsDBNull(lector.GetOrdinal("mult_fecha_resol")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("mult_fecha_resol")),
                            mult_archivo = lector.IsDBNull(lector.GetOrdinal("mult_archivo")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_archivo")),
                            mult_observacion = lector.IsDBNull(lector.GetOrdinal("mult_observacion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_observacion")),
                            fecha_genera = lector.IsDBNull(lector.GetOrdinal("fecha_genera")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_genera")),
                            fecha_notifica = lector.IsDBNull(lector.GetOrdinal("fecha_notifica")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_notifica")),
                            fecha_vence = lector.IsDBNull(lector.GetOrdinal("fecha_vence")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            fecha_elimina = lector.IsDBNull(lector.GetOrdinal("fecha_elimina")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_elimina")),
                            mult_estado = lector.IsDBNull(lector.GetOrdinal("mult_estado")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_estado")),
                            tp_recurso = lector.IsDBNull(lector.GetOrdinal("tp_recurso")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tp_recurso")),
                            resol_resuelve = lector.IsDBNull(lector.GetOrdinal("resol_resuelve")) ? default(string) : lector.GetString(lector.GetOrdinal("resol_resuelve")),
                            fech_recurso = lector.IsDBNull(lector.GetOrdinal("fech_recurso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fech_recurso")),
                            tp_declaro = lector.IsDBNull(lector.GetOrdinal("tp_declaro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tp_declaro")),
                            recursod = lector.IsDBNull(lector.GetOrdinal("recursod")) ? default(string) : lector.GetString(lector.GetOrdinal("recursod")),
                            declarod = lector.IsDBNull(lector.GetOrdinal("declarod")) ? default(string) : lector.GetString(lector.GetOrdinal("declarod")),
                            tipomultad = lector.IsDBNull(lector.GetOrdinal("tipomultad")) ? default(string) : lector.GetString(lector.GetOrdinal("tipomultad"))
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
        public List<Mult_Multas> listarTodosPorAnio2(int anio, string mult_estado,int clase_Multa)
        {
            try
            {
                var coleccion = new List<Mult_Multas>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "clase_Multa", DbType.Int32, clase_Multa);
                db.AddInParameter(SQL, "mult_estado", DbType.String, mult_estado);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mult_Multas
                        {
                            mult_id = lector.GetInt32(lector.GetOrdinal("mult_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            persona = lector.IsDBNull(lector.GetOrdinal("persona")) ? default(string) : lector.GetString(lector.GetOrdinal("persona")),
                            mult_direccion = lector.IsDBNull(lector.GetOrdinal("mult_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_direccion")),
                            TipoMulta_id = lector.GetInt32(lector.GetOrdinal("TipoMulta_id")),
                            mult_monto = lector.GetDecimal(lector.GetOrdinal("mult_monto")),
                            mult_nro_resolucion = lector.IsDBNull(lector.GetOrdinal("mult_nro_resolucion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_nro_resolucion")),
                            mult_anio_resolucion = lector.IsDBNull(lector.GetOrdinal("mult_anio_resolucion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_anio_resolucion")),
                            mult_fecha_resol = lector.IsDBNull(lector.GetOrdinal("mult_fecha_resol")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("mult_fecha_resol")),
                            mult_archivo = lector.IsDBNull(lector.GetOrdinal("mult_archivo")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_archivo")),
                            mult_observacion = lector.IsDBNull(lector.GetOrdinal("mult_observacion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_observacion")),
                            fecha_genera = lector.IsDBNull(lector.GetOrdinal("fecha_genera")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_genera")),
                            fecha_notifica = lector.IsDBNull(lector.GetOrdinal("fecha_notifica")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_notifica")),
                            fecha_vence = lector.IsDBNull(lector.GetOrdinal("fecha_vence")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            fecha_elimina = lector.IsDBNull(lector.GetOrdinal("fecha_elimina")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_elimina")),
                            mult_estado = lector.IsDBNull(lector.GetOrdinal("mult_estado")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_estado")),
                            tp_recurso = lector.IsDBNull(lector.GetOrdinal("tp_recurso")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tp_recurso")),
                            resol_resuelve = lector.IsDBNull(lector.GetOrdinal("resol_resuelve")) ? default(string) : lector.GetString(lector.GetOrdinal("resol_resuelve")),
                            fech_recurso = lector.IsDBNull(lector.GetOrdinal("fech_recurso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fech_recurso")),
                            tp_declaro = lector.IsDBNull(lector.GetOrdinal("tp_declaro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tp_declaro")),
                            recursod = lector.IsDBNull(lector.GetOrdinal("recursod")) ? default(string) : lector.GetString(lector.GetOrdinal("recursod")),
                            declarod = lector.IsDBNull(lector.GetOrdinal("declarod")) ? default(string) : lector.GetString(lector.GetOrdinal("declarod")),
                            tipomultad = lector.IsDBNull(lector.GetOrdinal("tipomultad")) ? default(string) : lector.GetString(lector.GetOrdinal("tipomultad"))
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
        public virtual int Insert(Mult_Multas Mult_Multas)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, Mult_Multas.persona_id);
                db.AddInParameter(SQL, "mult_direccion", DbType.String, Mult_Multas.mult_direccion);
                db.AddInParameter(SQL, "TipoMulta_id", DbType.Int32, Mult_Multas.TipoMulta_id);
                db.AddInParameter(SQL, "mult_monto", DbType.Decimal, Mult_Multas.mult_monto);
                db.AddInParameter(SQL, "mult_nro_resolucion", DbType.String, Mult_Multas.mult_nro_resolucion);
                db.AddInParameter(SQL, "mult_anio_resolucion", DbType.String, Mult_Multas.mult_anio_resolucion);
                db.AddInParameter(SQL, "mult_fecha_resol", DbType.DateTime, Mult_Multas.mult_fecha_resol);
                db.AddInParameter(SQL, "mult_archivo", DbType.String, Mult_Multas.mult_archivo);
                db.AddInParameter(SQL, "mult_observacion", DbType.String, Mult_Multas.mult_observacion);
                //db.AddInParameter(SQL, "fecha_genera", DbType.DateTime, Mult_Multas.fecha_genera.ToShortDateString());
                db.AddInParameter(SQL, "fecha_notifica", DbType.DateTime, Mult_Multas.fecha_notifica.ToShortDateString());//tipo_posesion
                db.AddInParameter(SQL, "fecha_vence", DbType.DateTime, Mult_Multas.fecha_vence.ToShortDateString());
                db.AddInParameter(SQL, "registro_user", DbType.String, Mult_Multas.registro_user);
                ////db.AddInParameter(SQL, "fecha_elimina", DbType.DateTime, Mult_Multas.fecha_elimina.ToShortDateString());
                //db.AddInParameter(SQL, "mult_estado", DbType.String, Mult_Multas.mult_estado);
                db.AddInParameter(SQL, "tp_recurso", DbType.Int32, Mult_Multas.tp_recurso);
                db.AddInParameter(SQL, "resol_resuelve", DbType.String, Mult_Multas.resol_resuelve);
                db.AddInParameter(SQL, "fech_recurso", DbType.DateTime, Mult_Multas.fech_recurso.ToLongDateString());
                db.AddInParameter(SQL, "tp_declaro", DbType.String, Mult_Multas.tp_declaro);
                db.AddInParameter(SQL, "clase_Multa", DbType.String, Mult_Multas.clase_Multa);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 2);
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mult_Multas mult_Multas)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "mult_id", DbType.Int32, mult_Multas.mult_id);
                db.AddInParameter(SQL, "mult_observacion", DbType.String, mult_Multas.mult_observacion);
                db.AddInParameter(SQL, "registro_user", DbType.String, mult_Multas.registro_user);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 6);
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


        public virtual int VerificarResolucion(string mult_nro_resolucion, string mult_anio_resolucion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "mult_nro_resolucion", DbType.String, mult_nro_resolucion);
                db.AddInParameter(SQL, "mult_anio_resolucion", DbType.String, mult_anio_resolucion);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
                int gg = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return gg;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT M.*, P.NombreCompleto AS Persona, t.descripcion as recursod, td.descripcion as declarod,tm.descripcion as tipomultad FROM multa_administrativa M INNER JOIN Persona P ON M.persona_id = P.persona_ID INNER JOIN TABLAS T ON T.valor = M.tp_recurso AND T.DEP_ID = 1 INNER JOIN TABLAS TD ON TD.valor = M.tp_declaro AND TD.DEP_ID = 1 INNER JOIN TABLAS TM ON TM.valor = M.TipoMulta_id AND TM.DEP_ID = 1 ";
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


        public virtual List<Mult_Multas> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Mult_Multas>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mult_Multas
                        {
                            mult_id = lector.GetInt32(lector.GetOrdinal("mult_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            persona = lector.IsDBNull(lector.GetOrdinal("persona")) ? default(string) : lector.GetString(lector.GetOrdinal("persona")),
                            mult_direccion = lector.IsDBNull(lector.GetOrdinal("mult_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_direccion")),
                            TipoMulta_id = lector.GetInt32(lector.GetOrdinal("TipoMulta_id")),
                            mult_monto = lector.GetDecimal(lector.GetOrdinal("mult_monto")),
                            mult_nro_resolucion = lector.IsDBNull(lector.GetOrdinal("mult_nro_resolucion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_nro_resolucion")),
                            mult_anio_resolucion = lector.IsDBNull(lector.GetOrdinal("mult_anio_resolucion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_anio_resolucion")),
                            mult_fecha_resol = lector.IsDBNull(lector.GetOrdinal("mult_fecha_resol")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("mult_fecha_resol")),
                            mult_archivo = lector.IsDBNull(lector.GetOrdinal("mult_archivo")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_archivo")),
                            mult_observacion = lector.IsDBNull(lector.GetOrdinal("mult_observacion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_observacion")),
                            fecha_genera = lector.IsDBNull(lector.GetOrdinal("fecha_genera")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_genera")),
                            fecha_notifica = lector.IsDBNull(lector.GetOrdinal("fecha_notifica")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_notifica")),
                            fecha_vence = lector.IsDBNull(lector.GetOrdinal("fecha_vence")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            fecha_elimina = lector.IsDBNull(lector.GetOrdinal("fecha_elimina")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_elimina")),
                            mult_estado = lector.IsDBNull(lector.GetOrdinal("mult_estado")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_estado")),
                            tp_recurso = lector.IsDBNull(lector.GetOrdinal("tp_recurso")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tp_recurso")),
                            resol_resuelve = lector.IsDBNull(lector.GetOrdinal("resol_resuelve")) ? default(string) : lector.GetString(lector.GetOrdinal("resol_resuelve")),
                            fech_recurso = lector.IsDBNull(lector.GetOrdinal("fech_recurso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fech_recurso")),
                            tp_declaro = lector.IsDBNull(lector.GetOrdinal("tp_declaro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tp_declaro")),
                            recursod = lector.IsDBNull(lector.GetOrdinal("recursod")) ? default(string) : lector.GetString(lector.GetOrdinal("recursod")),
                            declarod = lector.IsDBNull(lector.GetOrdinal("declarod")) ? default(string) : lector.GetString(lector.GetOrdinal("declarod")),
                            tipomultad = lector.IsDBNull(lector.GetOrdinal("tipomultad")) ? default(string) : lector.GetString(lector.GetOrdinal("tipomultad"))
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


        public List<Mult_Multas> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }

        public virtual void Delete(int mult_id, string registro_user)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "mult_id", DbType.String, mult_id);
                db.AddInParameter(SQL, "registro_user", DbType.String, registro_user);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 3);
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mult_Multas> listarTodosPorAño(int anio)
        {
            try
            {
                var coleccion = new List<Mult_Multas>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mult_Multas
                        {
                            mult_id = lector.GetInt32(lector.GetOrdinal("mult_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            persona = lector.IsDBNull(lector.GetOrdinal("persona")) ? default(string) : lector.GetString(lector.GetOrdinal("persona")),
                            mult_direccion = lector.IsDBNull(lector.GetOrdinal("mult_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_direccion")),
                            TipoMulta_id = lector.GetInt32(lector.GetOrdinal("TipoMulta_id")),
                            mult_monto = lector.GetDecimal(lector.GetOrdinal("mult_monto")),
                            mult_nro_resolucion = lector.IsDBNull(lector.GetOrdinal("mult_nro_resolucion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_nro_resolucion")),
                            mult_anio_resolucion = lector.IsDBNull(lector.GetOrdinal("mult_anio_resolucion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_anio_resolucion")),
                            mult_fecha_resol = lector.IsDBNull(lector.GetOrdinal("mult_fecha_resol")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("mult_fecha_resol")),
                            mult_archivo = lector.IsDBNull(lector.GetOrdinal("mult_archivo")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_archivo")),
                            mult_observacion = lector.IsDBNull(lector.GetOrdinal("mult_observacion")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_observacion")),
                            fecha_genera = lector.IsDBNull(lector.GetOrdinal("fecha_genera")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_genera")),
                            fecha_notifica = lector.IsDBNull(lector.GetOrdinal("fecha_notifica")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_notifica")),
                            fecha_vence = lector.IsDBNull(lector.GetOrdinal("fecha_vence")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            fecha_elimina = lector.IsDBNull(lector.GetOrdinal("fecha_elimina")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_elimina")),
                            mult_estado = lector.IsDBNull(lector.GetOrdinal("mult_estado")) ? default(string) : lector.GetString(lector.GetOrdinal("mult_estado")),
                            tp_recurso = lector.IsDBNull(lector.GetOrdinal("tp_recurso")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tp_recurso")),
                            resol_resuelve = lector.IsDBNull(lector.GetOrdinal("resol_resuelve")) ? default(string) : lector.GetString(lector.GetOrdinal("resol_resuelve")),
                            fech_recurso = lector.IsDBNull(lector.GetOrdinal("fech_recurso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fech_recurso")),
                            tp_declaro = lector.IsDBNull(lector.GetOrdinal("tp_declaro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("tp_declaro")),
                            recursod = lector.IsDBNull(lector.GetOrdinal("recursod")) ? default(string) : lector.GetString(lector.GetOrdinal("recursod")),
                            declarod = lector.IsDBNull(lector.GetOrdinal("declarod")) ? default(string) : lector.GetString(lector.GetOrdinal("declarod")),
                            tipomultad = lector.IsDBNull(lector.GetOrdinal("tipomultad")) ? default(string) : lector.GetString(lector.GetOrdinal("tipomultad"))
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
        public virtual void EnviarCoactivo(int mult_id, string registro_user, string idpersona)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "mult_id", DbType.String, mult_id);
                db.AddInParameter(SQL, "registro_user", DbType.String, registro_user);
                db.AddInParameter(SQL, "persona_id", DbType.String, idpersona);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 7);
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
