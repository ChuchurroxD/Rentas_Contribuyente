
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

public class Conf_RolRepository
{



    private const String nombreprocedimiento = "_Conf_Rol";
    private const String NombreTabla = "Roles";
    private Database db = DatabaseFactory.CreateDatabase();
    public List<Conf_Rol> listartodos()
    {
        try
        {
            var coleccion = new List<Conf_Rol>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);//modificar de acuerdo a
            //rol_id, rol_nombre, rol_descripcion, rol_activo,idUnidadNegocio
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Rol
                    {

                        Rolec_iCodigo = lector.GetInt64(lector.GetOrdinal("rol_id")),
                        Rolec_vNombre = lector.IsDBNull(lector.GetOrdinal("rol_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_nombre")),
                        Rolec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("rol_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_descripcion")),
                        Rolec_bActivo = lector.GetBoolean(lector.GetOrdinal("rol_activo"))

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

    public List<Conf_Rol> listarxusuario(Segu_Usuario Segu_Usuario)
    {
        try
        {
            var coleccion = new List<Conf_Rol>();
            DbCommand SQL = db.GetStoredProcCommand  ("Seguridad_usurio_Rol");
            db.AddInParameter(SQL, "per_codigo", DbType.String , Segu_Usuario.per_codigo );//modificar de acuerdo a
            //rol_id, rol_nombre, rol_descripcion, rol_activo,idUnidadNegocio
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Rol
                    {

                        Rolec_iCodigo = lector.GetInt64(lector.GetOrdinal("rol_id")),
                        Rolec_vNombre = lector.IsDBNull(lector.GetOrdinal("rol_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_nombre")),
                        Rolec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("rol_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_descripcion")),
                        Rolec_bActivo = lector.GetBoolean(lector.GetOrdinal("rol_activo"))

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

    public List<Conf_Rol> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }


    public virtual List<Conf_Rol> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Conf_Rol>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Rol
                    {
                        Rolec_iCodigo = lector.GetInt64(lector.GetOrdinal("rol_id")),
                        Rolec_vNombre = lector.IsDBNull(lector.GetOrdinal("rol_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_nombre")),
                        Rolec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("rol_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_descripcion")),
                        Rolec_bActivo = lector.GetBoolean(lector.GetOrdinal("rol_activo"))

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


    public virtual Conf_Rol GetByPrimaryKey(Int32 Rolec_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);//cambiar tipo
            db.AddInParameter(SQL, "Rolec_iCodigo", DbType.Int64, Rolec_iCodigo);
            var Conf_Rol = default(Conf_Rol);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Conf_Rol = new Conf_Rol
                    {
                        Rolec_iCodigo = lector.GetInt64(lector.GetOrdinal("rol_id")),
                        Rolec_vNombre = lector.IsDBNull(lector.GetOrdinal("rol_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_nombre")),
                        Rolec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("rol_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_descripcion")),
                        Rolec_bActivo = lector.GetBoolean(lector.GetOrdinal("rol_activo"))

                    };
                }
            }
            SQL.Dispose();
            return Conf_Rol;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public virtual Int32 GetExisteDescripcionNuevo(String Rolec_vNombre)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
            db.AddInParameter(SQL, "Rolec_vNombre", DbType.String, Rolec_vNombre);
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
    public virtual Int32 GetExisteDescripcionModificar(Int64 Rolec_iCodigo, String Rolec_vNombre )
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            db.AddInParameter(SQL, "Rolec_iCodigo", DbType.Int64, Rolec_iCodigo);
            db.AddInParameter(SQL, "Rolec_vNombre", DbType.String, Rolec_vNombre);
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
        string sql = "SELECT * FROM [dbo].[Roles]";
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

    public virtual int Insert(Conf_Rol Conf_Rol)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Rolec_vNombre", DbType.String, Conf_Rol.Rolec_vNombre);
            db.AddInParameter(SQL, "Rolec_vDescripcion", DbType.String, Conf_Rol.Rolec_vDescripcion);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);//modificar tipo

            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error al agregar al");
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


    public virtual void Update(Conf_Rol Conf_Rol)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

            db.AddInParameter(SQL, "Rolec_iCodigo", DbType.Int64, Conf_Rol.Rolec_iCodigo);
            db.AddInParameter(SQL, "Rolec_vNombre", DbType.String, Conf_Rol.Rolec_vNombre);
            db.AddInParameter(SQL, "Rolec_vDescripcion", DbType.String, Conf_Rol.Rolec_vDescripcion);
            db.AddInParameter(SQL, "Rolec_bActivo", DbType.Boolean, Conf_Rol.Rolec_bActivo);
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


    public virtual bool DeleteByPrimaryKey(Int64 Rolec_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Rolec_iCodigo", DbType.Int64, Rolec_iCodigo);
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

    public List<Conf_Rol> listarRolesActivo()
    {
        try
        {
            var coleccion = new List<Conf_Rol>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Rol
                    {
                        Rolec_iCodigo = lector.GetInt64(lector.GetOrdinal("rol_id")),
                        Rolec_vNombre = lector.IsDBNull(lector.GetOrdinal("rol_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_nombre")),
                        Rolec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("rol_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("rol_descripcion")),
                        Rolec_bActivo = lector.GetBoolean(lector.GetOrdinal("rol_activo"))
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


