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
    public class Conf_RolOficinaRepository
    {
        private const String nombreprocedimiento = "_Conf_Rol_Oficina";
        private Database db = DatabaseFactory.CreateDatabase();

        public virtual int Insert(Conf_RolOficina conf_RolOficina)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "rol_id", DbType.Int64, conf_RolOficina.rol_id);
                db.AddInParameter(SQL, "oficina_id", DbType.Int64, conf_RolOficina.oficina_id);
                db.AddInParameter(SQL, "estado", DbType.Boolean, conf_RolOficina.estado);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 2);//modificar tipo

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
        public virtual int Update(Conf_RolOficina conf_RolOficina)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "rol_id", DbType.Int64, conf_RolOficina.rol_id);
                db.AddInParameter(SQL, "oficina_id", DbType.Int64, conf_RolOficina.oficina_id);
                db.AddInParameter(SQL, "estado", DbType.Boolean, conf_RolOficina.estado);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 1);//modificar tipo

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
        public List<Conf_RolOficina> listarTodosRolOficina()
        {
            try
            {
                var coleccion = new List<Conf_RolOficina>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 3);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Conf_RolOficina
                        {
                            rol_id = lector.GetInt64(lector.GetOrdinal("rol_id")),
                            rol_descripcion = lector.IsDBNull(lector.GetOrdinal("rol_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_nombre")),
                            oficina_id = lector.GetInt64(lector.GetOrdinal("oficina_id")),
                            oficina_descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado"))
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
        public List<Conf_RolOficina> listarActivosRolOficina()
        {
            try
            {
                var coleccion = new List<Conf_RolOficina>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 4);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Conf_RolOficina
                        {
                            rol_id = lector.GetInt64(lector.GetOrdinal("rol_id")),
                            rol_descripcion = lector.IsDBNull(lector.GetOrdinal("rol_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_nombre")),
                            oficina_id = lector.GetInt64(lector.GetOrdinal("oficina_id")),
                            oficina_descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado"))
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
        public List<Conf_RolOficina> buscarRolOficina(String busqueda)
        {
            try
            {
                var coleccion = new List<Conf_RolOficina>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "busqueda", DbType.String, busqueda);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 7);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Conf_RolOficina
                        {
                            rol_id = lector.GetInt64(lector.GetOrdinal("rol_id")),
                            rol_descripcion = lector.IsDBNull(lector.GetOrdinal("rol_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_nombre")),
                            oficina_id = lector.GetInt64(lector.GetOrdinal("oficina_id")),
                            oficina_descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado"))
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
        public int existeRolOficina(Int64 rol_id, Int64 oficina_id)
        {
            try
            {
                var coleccion = new List<Conf_RolOficina>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "rol_id", DbType.Int64, rol_id);
                db.AddInParameter(SQL, "oficina_id", DbType.Int64, oficina_id);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 6);//modificar de acuerdo a tipo de  consulta
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
    }
}
