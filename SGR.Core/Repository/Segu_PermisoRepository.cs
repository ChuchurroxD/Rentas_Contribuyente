
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

public class Segu_PermisoRepository
{



    private const String nombreprocedimiento = "_Segu_Permiso";
    private const String NombreTabla = "Permo";
    private Database db = DatabaseFactory.CreateDatabase();


    public List<Segu_Permiso> listartodos()
    {
        try
        {
            var coleccion = new List<Segu_Permiso>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);//modificar de acuerdo a tipo de  consulta

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Segu_Permiso
                    {

                        Permc_iCodigo = lector.GetInt64(lector.GetOrdinal("per_id")),
                        Roleo_oRol = new Conf_Rol
                        {
                            Rolec_iCodigo = lector.GetInt64(lector.GetOrdinal("Rol_id")),
                            Rolec_vNombre = lector.IsDBNull(lector.GetOrdinal("Rol_Descripion")) ? default(String) : lector.GetString(lector.GetOrdinal("UnidadNegocio_Descripion")),
                        },
                        Tareo_oTarea = new Conf_Tarea
                        {
                            Tarec_iCodigo = lector.GetInt64(lector.GetOrdinal("Tarea_id")),
                            Tarec_vNombre = lector.IsDBNull(lector.GetOrdinal("Tarea_Descripion")) ? default(String) : lector.GetString(lector.GetOrdinal("UnidadNegocio_Descripion")),
                        },
                        Permc_bActivo = lector.GetBoolean(lector.GetOrdinal("per_activo"))


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



    public List<Segu_Permiso> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }


    public virtual List<Segu_Permiso> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Segu_Permiso>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Segu_Permiso
                    {
                        Permc_iCodigo = lector.GetInt64(lector.GetOrdinal("per_id")),
                        Roleo_oRol = new Conf_Rol
                        {
                            Rolec_iCodigo = lector.GetInt64(lector.GetOrdinal("Rol_id")),
                            Rolec_vNombre = lector.IsDBNull(lector.GetOrdinal("Rol_Descripion")) ? default(String) : lector.GetString(lector.GetOrdinal("UnidadNegocio_Descripion")),
                        },
                        Tareo_oTarea = new Conf_Tarea
                        {
                            Tarec_iCodigo = lector.GetInt64(lector.GetOrdinal("Tarea_id")),
                            Tarec_vNombre = lector.IsDBNull(lector.GetOrdinal("Tarea_Descripion")) ? default(String) : lector.GetString(lector.GetOrdinal("UnidadNegocio_Descripion")),
                        },
                        Permc_bActivo = lector.GetBoolean(lector.GetOrdinal("per_activo"))
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


    public virtual Segu_Permiso GetByPrimaryKey(Int64 Permc_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);//cambiar tipo
            db.AddInParameter(SQL, "Permc_iCodigo", DbType.Int64, Permc_iCodigo);
            var Segu_Permiso = default(Segu_Permiso);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Segu_Permiso = new Segu_Permiso
                    {
                        Permc_iCodigo = lector.GetInt64(lector.GetOrdinal("per_id")),
                        Roleo_oRol = new Conf_Rol
                        {
                            Rolec_iCodigo = lector.GetInt64(lector.GetOrdinal("Rol_id")),
                            Rolec_vNombre = lector.IsDBNull(lector.GetOrdinal("Rol_Descripion")) ? default(String) : lector.GetString(lector.GetOrdinal("UnidadNegocio_Descripion")),
                        },
                        Tareo_oTarea = new Conf_Tarea
                        {
                            Tarec_iCodigo = lector.GetInt64(lector.GetOrdinal("Tarea_id")),
                            Tarec_vNombre = lector.IsDBNull(lector.GetOrdinal("Tarea_Descripion")) ? default(String) : lector.GetString(lector.GetOrdinal("UnidadNegocio_Descripion")),
                        },
                        Permc_bActivo = lector.GetBoolean(lector.GetOrdinal("per_activo"))
                    };
                }
            }
            SQL.Dispose();
            return Segu_Permiso;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public virtual Int32 GetExisteDescripcionNuevo(Int64 rol, Int64 tarea)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
            //db.AddInParameter(SQL, "Permc_iCodigo", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "tarea_id", DbType.Int64, rol);
            db.AddInParameter(SQL, "rol_id", DbType.Int64, tarea);
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
  

    protected virtual string CreateGetCommand(string whereSql, string orderBySql)
    {
        string sql = "SELECT * FROM [dbo].[Tablas]";
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

    public virtual int Insert(Segu_Permiso Segu_Permiso)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "tarea_id", DbType.String, Segu_Permiso.Tareo_oTarea.Tarec_iCodigo);
            db.AddInParameter(SQL, "rol_id", DbType.String, Segu_Permiso.Roleo_oRol.Rolec_iCodigo);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);//modificar tipo

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


    public virtual void Update(Segu_Permiso Segu_Permiso)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

            db.AddInParameter(SQL, "Permc_iCodigo", DbType.Int64, Segu_Permiso.Permc_iCodigo);
            db.AddInParameter(SQL, "tarea_id", DbType.String, Segu_Permiso.Tareo_oTarea.Tarec_iCodigo);
            db.AddInParameter(SQL, "rol_id", DbType.String, Segu_Permiso.Roleo_oRol.Rolec_iCodigo);
            db.AddInParameter(SQL, "Permc_bActivo", DbType.Boolean, Segu_Permiso.Permc_bActivo);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);//modificar tipo
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


    public virtual bool DeleteByPrimaryKey(Int64 Permc_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Permc_iCodigo", DbType.Int64, Permc_iCodigo);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);//modificar tipo
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


