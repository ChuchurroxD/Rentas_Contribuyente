
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

public class Conf_TareaRepository
{
    private const String nombreprocedimiento = "_Conf_Tarea";
    private const String NombreTabla = "Tarea";
    private Database db = DatabaseFactory.CreateDatabase();
    
    public List<Conf_Tarea> listartodos(Int64 idgrupo , int rol_id)
    {
        try
        {
            var coleccion = new List<Conf_Tarea>();
            DbCommand SQL = db.GetStoredProcCommand  ("Seguridad_tarea_Rol");
            db.AddInParameter(SQL, "grupo_id", DbType.Int32 , idgrupo);//modificar de acuerdo a tipo de  consulta
            db.AddInParameter(SQL, "rol_id", DbType.Int64 , rol_id);//modificar de acuerdo a tipo de  consulta
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Tarea
                    {

                        Tarec_iCodigo = lector.GetInt64(lector.GetOrdinal("Tarea_id")),
                        Tarec_vNombre = lector.IsDBNull(lector.GetOrdinal("tar_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_nombre")),
                        Tarec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("tar_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_descripcion")),
                        Tarec_vUrl = lector.IsDBNull(lector.GetOrdinal("tar_url")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_url")),
                        Tarec_bActivo = lector.GetBoolean(lector.GetOrdinal("tar_activo")),
                        Tarec_Padre= lector.GetInt32 (lector.GetOrdinal("Tar_Padre")),
                        //confo_ogrupo = new conf_grupo
                        //{
                        //    grupc_icodigo = lector.getint64(lector.getordinal("grupo_id")),
                        //    grupc_vnombre = lector.isdbnull(lector.getordinal("grupo_descripion")) ? default(string) : lector.getstring(lector.getordinal("unidadnegocio_descripion")),
                        //}


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
    
    public List<Conf_Tarea> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }
    
    public virtual List<Conf_Tarea> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Conf_Tarea>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Tarea
                    {
                        Tarec_iCodigo = lector.GetInt64(lector.GetOrdinal("Tarea_id")),
                        Tarec_vNombre = lector.IsDBNull(lector.GetOrdinal("tar_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_nombre")),
                        Tarec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("tar_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_descripcion")),
                        Tarec_vUrl = lector.IsDBNull(lector.GetOrdinal("tar_url")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_url")),
                        Tarec_bActivo = lector.GetBoolean(lector.GetOrdinal("tar_activo")),
                        //Confo_oGrupo = new Conf_Grupo
                        //{
                        //    Grupc_iCodigo = lector.GetInt64(lector.GetOrdinal("Grupo_id")),
                        //    Grupc_vNombre = lector.IsDBNull(lector.GetOrdinal("Grupo_Descripion")) ? default(String) : lector.GetString(lector.GetOrdinal("UnidadNegocio_Descripion")),
                        //}
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
    
    public virtual Conf_Tarea GetByPrimaryKey(Int64 Tarec_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);//cambiar tipo
            db.AddInParameter(SQL, "Tarec_iCodigo", DbType.Int64, Tarec_iCodigo);
            var Conf_Tarea = default(Conf_Tarea);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Conf_Tarea = new Conf_Tarea
                    {
                        Tarec_iCodigo = lector.GetInt64(lector.GetOrdinal("Tarea_id")),
                        Tarec_vNombre = lector.IsDBNull(lector.GetOrdinal("tar_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_nombre")),
                        Tarec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("tar_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_descripcion")),
                        Tarec_vUrl = lector.IsDBNull(lector.GetOrdinal("tar_url")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_url")),
                        Tarec_bActivo = lector.GetBoolean(lector.GetOrdinal("tar_activo")),
                        //Confo_oGrupo = new Conf_Grupo
                        //{
                        //    Grupc_iCodigo = lector.GetInt64(lector.GetOrdinal("Grupo_id")),
                        //    Grupc_vNombre = lector.IsDBNull(lector.GetOrdinal("Grupo_Descripion")) ? default(String) : lector.GetString(lector.GetOrdinal("UnidadNegocio_Descripion")),
                        //}
                    };
                }
            }
            SQL.Dispose();
            return Conf_Tarea;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public virtual Int32 GetExisteDescripcionNuevo(String Tarec_vNombre)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
            //db.AddInParameter(SQL, "Tarec_iCodigo", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "Tarec_vNombre", DbType.String, Tarec_vNombre);
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

    public virtual Int32 GetExisteDescripcionModificar(Int64 Tarec_iCodigo, String Tarec_vNombre)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            db.AddInParameter(SQL, "Tarec_iCodigo", DbType.Int64, Tarec_iCodigo);
            db.AddInParameter(SQL, "Tarec_vNombre", DbType.String, Tarec_vNombre);
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

    public virtual int Insert(Conf_Tarea Conf_Tarea)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tarec_vDescripcion", DbType.String, Conf_Tarea.Tarec_vDescripcion);
            db.AddInParameter(SQL, "Tarec_vNombre", DbType.String, Conf_Tarea.Tarec_vNombre);
            db.AddInParameter(SQL, "Tarec_vUrl", DbType.String, Conf_Tarea.Tarec_vUrl);
            db.AddInParameter(SQL, "grupo_id", DbType.Int64, Conf_Tarea.Grupo_id);
            db.AddInParameter(SQL, "registro_user_add", DbType.String, Conf_Tarea.registro_user_add);
            db.AddInParameter(SQL, "registro_user_update", DbType.String, Conf_Tarea.registro_user_update);
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
    
    public virtual void Update(Conf_Tarea Conf_Tarea)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

            db.AddInParameter(SQL, "Tarec_iCodigo", DbType.Int64, Conf_Tarea.Tarec_iCodigo);
            db.AddInParameter(SQL, "Tarec_vDescripcion", DbType.String, Conf_Tarea.Tarec_vDescripcion);
            db.AddInParameter(SQL, "Tarec_vNombre", DbType.String, Conf_Tarea.Tarec_vNombre);
            db.AddInParameter(SQL, "Tarec_vUrl", DbType.String, Conf_Tarea.Tarec_vUrl);
            db.AddInParameter(SQL, "Tarec_bActivo", DbType.Boolean, Conf_Tarea.Tarec_bActivo);
            db.AddInParameter(SQL, "grupo_id", DbType.Int64, Conf_Tarea.Grupo_id);
            db.AddInParameter(SQL, "registro_user_update", DbType.String, Conf_Tarea.registro_user_update);
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
    
    public virtual bool DeleteByPrimaryKey(Int64 Tarec_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tarec_iCodigo", DbType.Int64, Tarec_iCodigo);
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

    public List<Conf_Tarea> listarActivos(Int64 grupo_id)//para combos, si quieren listar todos (grupo_id=0), si quieren por grupo (grupo_id = 1...n)
    {
        try
        {
            var coleccion = new List<Conf_Tarea>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
            db.AddInParameter(SQL, "Grupo_id", DbType.Int64, grupo_id);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Tarea
                    {
                        Tarec_iCodigo = lector.GetInt64(lector.GetOrdinal("Tarea_id")),
                        Grupo_id = lector.GetInt64(lector.GetOrdinal("grupo_id")),
                        Tarec_vNombre = lector.IsDBNull(lector.GetOrdinal("tar_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_nombre")),
                        Tarec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("tar_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_descripcion")),
                        Tarec_vUrl = lector.IsDBNull(lector.GetOrdinal("tar_url")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_url")),
                        Tarec_bActivo = lector.GetBoolean(lector.GetOrdinal("tar_activo")),
                        Tarec_Padre = lector.GetInt32(lector.GetOrdinal("Tar_Padre")),
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

    public List<Conf_Tarea> listarBusquedaByGrupo(String buscar, Int64 Grupo_id)//Para la busqueda por grupo
    {
        try
        {
            var coleccion = new List<Conf_Tarea>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tarec_vNombre", DbType.String, buscar);
            db.AddInParameter(SQL, "Tarec_vDescripcion", DbType.String, buscar);
            db.AddInParameter(SQL, "Grupo_id", DbType.Int64, Grupo_id);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);//modificar de acuerdo a tipo de  consulta
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Tarea
                    {

                        Tarec_iCodigo = lector.GetInt64(lector.GetOrdinal("Tarea_id")),
                        Grupo_id = lector.GetInt64(lector.GetOrdinal("grupo_id")),
                        Tarec_vNombre = lector.IsDBNull(lector.GetOrdinal("tar_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_nombre")),
                        Tarec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("tar_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_descripcion")),
                        Tarec_vUrl = lector.IsDBNull(lector.GetOrdinal("tar_url")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_url")),
                        Tarec_bActivo = lector.GetBoolean(lector.GetOrdinal("tar_activo")),
                        Tarec_Padre = lector.GetInt32(lector.GetOrdinal("Tar_Padre")),
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

    public virtual Int32 GetExisteNombreNuevo(String Tarec_vNombre)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
            db.AddInParameter(SQL, "Tarec_vNombre", DbType.String, Tarec_vNombre);
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

    public virtual Int32 GetExisteNombreModificar(Int64 Tarec_iCodigo, String Tarec_vNombre)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            db.AddInParameter(SQL, "Tarec_iCodigo", DbType.Int64, Tarec_iCodigo);
            db.AddInParameter(SQL, "Tarec_vNombre", DbType.String, Tarec_vNombre);
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

    public List<Conf_Tarea> listarTareasActivasInactivas(Int64 idgrupo)
    {
        try
        {
            var coleccion = new List<Conf_Tarea>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);//modificar de acuerdo a tipo de  consulta
            db.AddInParameter(SQL, "Grupo_id", DbType.Int64, idgrupo);//modificar de acuerdo a tipo de  consulta
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Tarea
                    {
                        Tarec_iCodigo = lector.GetInt64(lector.GetOrdinal("Tarea_id")),
                        Grupo_id = lector.GetInt64(lector.GetOrdinal("grupo_id")),
                        Tarec_vNombre = lector.IsDBNull(lector.GetOrdinal("tar_nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_nombre")),
                        Tarec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("tar_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_descripcion")),
                        Tarec_vUrl = lector.IsDBNull(lector.GetOrdinal("tar_url")) ? default(String) : lector.GetString(lector.GetOrdinal("tar_url")),
                        Tarec_bActivo = lector.GetBoolean(lector.GetOrdinal("tar_activo")),
                        Tarec_Padre = lector.GetInt32(lector.GetOrdinal("Tar_Padre")),
                        //confo_ogrupo = new conf_grupo
                        //{
                        //    grupc_icodigo = lector.getint64(lector.getordinal("grupo_id")),
                        //    grupc_vnombre = lector.isdbnull(lector.getordinal("grupo_descripion")) ? default(string) : lector.getstring(lector.getordinal("unidadnegocio_descripion")),
                        //}
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


