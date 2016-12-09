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
    public class Mant_InafectacionRepository
    {
        private const String nombreprocedimiento = "_Inafectacion";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Mant_Inafectacion> listartodos()
        {
            try
            {
                var coleccion = new List<Mant_Inafectacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Inafectacion
                        {
                            inafectado_id = lector.GetInt32(lector.GetOrdinal("inafectado_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")).Trim(),
                            nombre = lector.IsDBNull(lector.GetOrdinal("NombreCompleto")) ? default(String) : lector.GetString(lector.GetOrdinal("NombreCompleto")),
                            exp_descripcion = lector.IsDBNull(lector.GetOrdinal("exp_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("exp_descripcion")),
                            exp_anio = lector.IsDBNull(lector.GetOrdinal("exp_anio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("exp_anio")),
                            resolucion = lector.IsDBNull(lector.GetOrdinal("resolucion")) ? default(String) : lector.GetString(lector.GetOrdinal("resolucion")),
                            observacion = lector.IsDBNull(lector.GetOrdinal("observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("observacion")),
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

        public List<Mant_Inafectacion> buscar(string busqueda)
        {
            try
            {
                var coleccion = new List<Mant_Inafectacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "busqueda", DbType.String, busqueda);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Inafectacion
                        {
                            inafectado_id = lector.GetInt32(lector.GetOrdinal("inafectado_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")).Trim(),
                            nombre = lector.IsDBNull(lector.GetOrdinal("NombreCompleto")) ? default(String) : lector.GetString(lector.GetOrdinal("NombreCompleto")),
                            exp_descripcion = lector.IsDBNull(lector.GetOrdinal("exp_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("exp_descripcion")),
                            exp_anio = lector.IsDBNull(lector.GetOrdinal("exp_anio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("exp_anio")),
                            resolucion = lector.IsDBNull(lector.GetOrdinal("resolucion")) ? default(String) : lector.GetString(lector.GetOrdinal("resolucion")),
                            observacion = lector.IsDBNull(lector.GetOrdinal("observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("observacion")),
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

        public virtual int Insert(Mant_Inafectacion mant_Inafectacion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, mant_Inafectacion.persona_id);
                db.AddInParameter(SQL, "exp_descripcion", DbType.String, mant_Inafectacion.exp_descripcion);
                db.AddInParameter(SQL, "exp_anio", DbType.Int32, mant_Inafectacion.exp_anio);
                db.AddInParameter(SQL, "resolucion", DbType.String, mant_Inafectacion.resolucion);
                db.AddInParameter(SQL, "observacion", DbType.String, mant_Inafectacion.observacion);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, mant_Inafectacion.registro_user_add);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, mant_Inafectacion.registro_user_update);
                db.AddInParameter(SQL, "estado", DbType.String, mant_Inafectacion.estado);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 2);//modificar tipo

                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar el registro");
                }
                SQL.Dispose();
                //return numerogenerado;
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Update(Mant_Inafectacion mant_Inafectacion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

                db.AddInParameter(SQL, "persona_id", DbType.String, mant_Inafectacion.persona_id);
                db.AddInParameter(SQL, "exp_descripcion", DbType.String, mant_Inafectacion.exp_descripcion);
                db.AddInParameter(SQL, "exp_anio", DbType.Int32, mant_Inafectacion.exp_anio);
                db.AddInParameter(SQL, "resolucion", DbType.String, mant_Inafectacion.resolucion);
                db.AddInParameter(SQL, "observacion", DbType.String, mant_Inafectacion.observacion);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, mant_Inafectacion.registro_user_update);
                db.AddInParameter(SQL, "estado", DbType.String, mant_Inafectacion.estado);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);//modificar tipo

                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
