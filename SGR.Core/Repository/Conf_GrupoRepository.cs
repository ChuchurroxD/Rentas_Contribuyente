
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

public class Conf_GrupoRepository
{
    private const String nombreprocedimiento = "_Conf_Grupo";
    private const String NombreTabla = "Grupo";
    private Database db = DatabaseFactory.CreateDatabase();
    
    public List<Conf_Grupo> listartodos()
    {
        try
        {
            var coleccion = new List<Conf_Grupo>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);//modificar de acuerdo a tipo de  consulta
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Grupo
                    {
                        Grupc_iCodigo = lector.GetInt64(lector.GetOrdinal("grupo_id")),
                        Grupc_vNombre = lector.IsDBNull(lector.GetOrdinal("gru_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_nombre")),
                        Grupc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("gru_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_descripcion")),
                        Grupc_bActivo = lector.GetBoolean(lector.GetOrdinal("gru_activo"))
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

    public List<Conf_Grupo> listarxrol(int rol_id)
    {
        try
        {
            var coleccion = new List<Conf_Grupo>();
            DbCommand SQL = db.GetStoredProcCommand  ("Seguridad_Grupo_Rol");
            db.AddInParameter(SQL, "rol_id", DbType.Int32  , rol_id );//modificar de acuerdo a tipo de  consulta

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Grupo
                    {

                        Grupc_iCodigo = lector.GetInt64(lector.GetOrdinal("grupo_id")),
                        Grupc_vNombre = lector.IsDBNull(lector.GetOrdinal("gru_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_nombre")),
                        Grupc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("gru_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_descripcion")),
                        Grupc_bActivo = lector.GetBoolean(lector.GetOrdinal("gru_activo"))


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

    public List<Conf_Grupo> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }

    public virtual List<Conf_Grupo> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Conf_Grupo>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Grupo
                    {
                        Grupc_iCodigo = lector.GetInt64(lector.GetOrdinal("grupo_id")),
                        Grupc_vNombre = lector.IsDBNull(lector.GetOrdinal("gru_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_nombre")),
                        Grupc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("gru_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_descripcion")),
                        Grupc_bActivo = lector.GetBoolean(lector.GetOrdinal("gru_activo"))
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
    
    public virtual Conf_Grupo GetByPrimaryKey(Int64 Grupc_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);//cambiar tipo
            db.AddInParameter(SQL, "Grupc_iCodigo", DbType.Int64, Grupc_iCodigo);
            var Conf_Grupo = default(Conf_Grupo);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Conf_Grupo = new Conf_Grupo
                    {
                        Grupc_iCodigo = lector.GetInt64(lector.GetOrdinal("grupo_id")),
                        Grupc_vNombre = lector.IsDBNull(lector.GetOrdinal("gru_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_nombre")),
                        Grupc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("gru_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_descripcion")),
                        Grupc_bActivo = lector.GetBoolean(lector.GetOrdinal("gru_activo"))
                    };
                }
            }
            SQL.Dispose();
            return Conf_Grupo;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public virtual Int32 GetExisteDescripcionNuevo(String Grupc_vDescripcion)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
            //db.AddInParameter(SQL, "Grupc_iCodigo", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "Grupc_vNombre", DbType.String, Grupc_vDescripcion);
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
    public virtual Int32 GetExisteDescripcionModificar(Int64 Grupc_iCodigo, String Grupc_vDescripcion)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            db.AddInParameter(SQL, "Grupc_iCodigo", DbType.Int64, Grupc_iCodigo);
            db.AddInParameter(SQL, "Grupc_vNombre", DbType.String, Grupc_vDescripcion);
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

    public virtual int Insert(Conf_Grupo Conf_Grupo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Grupc_vDescripcion", DbType.String, Conf_Grupo.Grupc_vDescripcion);
            db.AddInParameter(SQL, "Grupc_vNombre", DbType.String, Conf_Grupo.Grupc_vNombre);
            db.AddInParameter(SQL, "registro_user_add", DbType.String, Conf_Grupo.registro_user_add);
            db.AddInParameter(SQL, "registro_user_update", DbType.String, Conf_Grupo.registro_user_update);
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

    public virtual void Update(Conf_Grupo Conf_Grupo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

            db.AddInParameter(SQL, "Grupc_iCodigo", DbType.Int64, Conf_Grupo.Grupc_iCodigo);
            db.AddInParameter(SQL, "Grupc_vDescripcion", DbType.String, Conf_Grupo.Grupc_vDescripcion);
            db.AddInParameter(SQL, "Grupc_vNombre", DbType.String, Conf_Grupo.Grupc_vNombre);
            db.AddInParameter(SQL, "Grupc_bActivo", DbType.Boolean, Conf_Grupo.Grupc_bActivo);
            db.AddInParameter(SQL, "registro_user_update", DbType.String, Conf_Grupo.registro_user_update);
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

    public virtual bool DeleteByPrimaryKey(Int64 Grupc_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Grupc_iCodigo", DbType.Int64, Grupc_iCodigo);
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

    public List<Conf_Grupo> listarActivos()//para el combo de Unidad de Negocio
    {
        try
        {
            var coleccion = new List<Conf_Grupo>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);//modificar de acuerdo a tipo de  consulta

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Grupo
                    {

                        Grupc_iCodigo = lector.GetInt64(lector.GetOrdinal("codigo")),
                        Grupc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion"))
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

    public List<Conf_Grupo> listarBusqueda(String Grupc_vNombre)//Para la busqueda.
    {
        try
        {
            var coleccion = new List<Conf_Grupo>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "@Grupc_vNombre", DbType.String, Grupc_vNombre);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Grupo
                    {
                        Grupc_iCodigo = lector.GetInt64(lector.GetOrdinal("grupo_id")),
                        Grupc_vNombre = lector.IsDBNull(lector.GetOrdinal("gru_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_nombre")),
                        Grupc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("gru_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_descripcion")),
                        Grupc_bActivo = lector.GetBoolean(lector.GetOrdinal("gru_activo"))
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

    public virtual Int32 GetExisteNombreNuevo(String Grupc_vNombre)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
            //db.AddInParameter(SQL, "Grupc_iCodigo", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "Grupc_vNombre", DbType.String, Grupc_vNombre);
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

    public virtual Int32 GetExisteNombreModificar(Int64 Grupc_iCodigo, String Grupc_vNombre)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            db.AddInParameter(SQL, "Grupc_iCodigo", DbType.Int64, Grupc_iCodigo);
            db.AddInParameter(SQL, "Grupc_vNombre", DbType.String, Grupc_vNombre);
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

    public List<Conf_Grupo> listarGruposActivosInactivos()
    {
        try
        {
            var coleccion = new List<Conf_Grupo>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);//modificar de acuerdo a tipo de  consulta

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Grupo
                    {

                        Grupc_iCodigo = lector.GetInt64(lector.GetOrdinal("grupo_id")),
                        Grupc_vNombre = lector.IsDBNull(lector.GetOrdinal("gru_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_nombre")),
                        Grupc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("gru_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("gru_descripcion")),
                        Grupc_bActivo = lector.GetBoolean(lector.GetOrdinal("gru_activo"))
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


