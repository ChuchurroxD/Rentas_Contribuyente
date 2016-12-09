
using System;
using System.Collections.Generic;
using SGR.Entity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;


public class Segu_UsuarioRepository
{
    private const String nombreprocedimiento = "_Segu_Usuario";
    private const String nombreprocedimiento2 = "_seguUsuario";
    private const String NombreTabla = "Segu_Usuario";
    private Database db = DatabaseFactory.CreateDatabase();

    public List<Segu_Usuario> listartodos()
    {
        try
        {
            var coleccion = new List<Segu_Usuario>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Segu_Usuario
                    {
                        Seguc_iCodigo=lector.GetInt32(lector.GetOrdinal("Seguc_iCodigo")),
                        Seguc_vNombre=lector.IsDBNull(lector.GetOrdinal("Seguc_vNombre")) ? default(String) : lector.GetString(lector.GetOrdinal("Seguc_vNombre")),
                        Seguc_fFechaCreacion=lector.IsDBNull(lector.GetOrdinal("Seguc_fFechaCreacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("Seguc_fFechaCreacion"))

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

    public Segu_Usuario validarUsuario(Segu_Usuario x)
    {
        try
        {

            Segu_Usuario usuario = null;
            DbCommand SQL = db.GetSqlStringCommand("select per_codigo,(nombre+' '+apellido)as nombre from [dbo].[usuario] where per_login =@per_login and per_pass=@per_pass");
            db.AddInParameter(SQL, "per_login", DbType.String, x.Seguc_vLogin);
            db.AddInParameter(SQL, "per_pass", DbType.String, x.Seguc_password);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    usuario = new Segu_Usuario
                    {
                        per_codigo = lector.GetString(0),
                        Seguc_vNombre = lector.GetString(1)
                    };
                }
            }
            SQL.Dispose();
            return usuario;


        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Segu_Usuario> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }

    public virtual List<Segu_Usuario> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Segu_Usuario>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Segu_Usuario
                    {
                        Seguc_iCodigo=lector.GetInt32(lector.GetOrdinal("Seguc_iCodigo")),
                        Seguc_vNombre=lector.IsDBNull(lector.GetOrdinal("Seguc_vNombre")) ? default(String) : lector.GetString(lector.GetOrdinal("Seguc_vNombre")),
                        Seguc_fFechaCreacion=lector.IsDBNull(lector.GetOrdinal("Seguc_fFechaCreacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("Seguc_fFechaCreacion"))

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
    
    public virtual Segu_Usuario GetByPrimaryKey(Int32 Seguc_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
            db.AddInParameter(SQL, "Seguc_iCodigo", DbType.Int32, Seguc_iCodigo);
            var Segu_Usuario = default(Segu_Usuario);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Segu_Usuario=new Segu_Usuario
                    {
                        Seguc_iCodigo=lector.GetInt32(lector.GetOrdinal("Seguc_iCodigo")),
                        Seguc_vNombre=lector.IsDBNull(lector.GetOrdinal("Seguc_vNombre")) ? default(String) : lector.GetString(lector.GetOrdinal("Seguc_vNombre")),
                        Seguc_fFechaCreacion=lector.IsDBNull(lector.GetOrdinal("Seguc_fFechaCreacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("Seguc_fFechaCreacion"))

                    };
                }
            }
            SQL.Dispose();
            return Segu_Usuario;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    protected virtual string CreateGetCommand(string whereSql, string orderBySql)
    {
        string sql = "SELECT * FROM [dbo].[Segu_Usuario]";
        if ((whereSql != null) && (whereSql.Trim().Length > 0))
        {
            sql += " WHERE " + whereSql;
        }
        if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
        {
            sql +=" ORDER BY " + orderBySql;
        }
        return sql;
    }

    public virtual int Insert(Segu_Usuario Segu_Usuario)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Seguc_vNombre", DbType.String, Segu_Usuario.Seguc_vNombre);
            db.AddInParameter(SQL, "Seguc_fFechaCreacion", DbType.DateTime, Segu_Usuario.Seguc_fFechaCreacion);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error al agregar al");
            }
            var numerogenerado = (int)db.GetParameterValue(SQL, "Seguc_iCodigo");
            SQL.Dispose();
            return numerogenerado;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public virtual void Update(Segu_Usuario Segu_Usuario)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Seguc_iCodigo", DbType.Int32, Segu_Usuario.Seguc_iCodigo);
            db.AddInParameter(SQL, "Seguc_vNombre", DbType.String, Segu_Usuario.Seguc_vNombre);
            db.AddInParameter(SQL, "Seguc_fFechaCreacion", DbType.DateTime, Segu_Usuario.Seguc_fFechaCreacion);
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

    public virtual bool DeleteByPrimaryKey(Int32 Seguc_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Seguc_iCodigo", DbType.Int32, Seguc_iCodigo);
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

    public virtual List<Segu_Usuario> listarUsuarios()
    {
        try
        {
            var coleccion = new List<Segu_Usuario>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Segu_Usuario
                    {
                        Seguc_iCodigo = Convert.ToInt32(lector.GetString(lector.GetOrdinal("per_codigo")).Trim()),
                        per_codigo = lector.GetString(lector.GetOrdinal("per_codigo")).Trim(),
                        areas_codarea = lector.IsDBNull(lector.GetOrdinal("areas_codarea")) ? default(String) : lector.GetString(lector.GetOrdinal("areas_codarea")),
                        Seguc_bEstado = lector.GetBoolean(lector.GetOrdinal("estado")),
                        Seguc_vNombre = lector.IsDBNull(lector.GetOrdinal("nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("nombre")),
                        Seguc_vApellidos = lector.IsDBNull(lector.GetOrdinal("apellido")) ? default(String) : lector.GetString(lector.GetOrdinal("apellido")),
                        Seguc_fFechaCreacion = lector.IsDBNull(lector.GetOrdinal("fecha_creacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_creacion")),
                        Seguc_vLogin = lector.IsDBNull(lector.GetOrdinal("per_login")) ? default(String) : lector.GetString(lector.GetOrdinal("per_login")),
                        //Seguc_password = lector.IsDBNull(lector.GetOrdinal("per_pass")) ? default(String) : lector.GetString(lector.GetOrdinal("per_pass")),
                        //Seguc_vLast = lector.IsDBNull(lector.GetOrdinal("per_last")) ? default(String) : lector.GetString(lector.GetOrdinal("per_last")),
                        //Seguc_vSession = lector.IsDBNull(lector.GetOrdinal("per_session")) ? default(String) : lector.GetString(lector.GetOrdinal("per_session")),
                        Seguc_fFechaCese = lector.IsDBNull(lector.GetOrdinal("fecha_cese")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_cese")),
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

    public virtual List<Segu_Usuario> listarUsuariosActivos()
    {
        try
        {
            var coleccion = new List<Segu_Usuario>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 4);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Segu_Usuario
                    {
                        Seguc_iCodigo = Convert.ToInt32(lector.GetString(lector.GetOrdinal("per_codigo")).Trim()),
                        per_codigo = lector.GetString(lector.GetOrdinal("per_codigo")).Trim(),
                        areas_codarea = lector.IsDBNull(lector.GetOrdinal("areas_codarea")) ? default(String) : lector.GetString(lector.GetOrdinal("areas_codarea")),
                        Seguc_bEstado = lector.GetBoolean(lector.GetOrdinal("estado")),
                        Seguc_vNombre = lector.IsDBNull(lector.GetOrdinal("nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("nombre")),
                        Seguc_vApellidos = lector.IsDBNull(lector.GetOrdinal("apellido")) ? default(String) : lector.GetString(lector.GetOrdinal("apellido")),
                        Seguc_fFechaCreacion = lector.IsDBNull(lector.GetOrdinal("fecha_creacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_creacion")),
                        Seguc_vLogin = lector.IsDBNull(lector.GetOrdinal("per_login")) ? default(String) : lector.GetString(lector.GetOrdinal("per_login")),
                        //Seguc_password = lector.IsDBNull(lector.GetOrdinal("per_pass")) ? default(String) : lector.GetString(lector.GetOrdinal("per_pass")),
                        //Seguc_vLast = lector.IsDBNull(lector.GetOrdinal("per_last")) ? default(String) : lector.GetString(lector.GetOrdinal("per_last")),
                        //Seguc_vSession = lector.IsDBNull(lector.GetOrdinal("per_session")) ? default(String) : lector.GetString(lector.GetOrdinal("per_session")),
                        Seguc_fFechaCese = lector.IsDBNull(lector.GetOrdinal("fecha_cese")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_cese")),
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

    public virtual Int32 insertUsuario(Segu_Usuario segu_Usuario)//, string rol_nombre)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "nombre", DbType.String, segu_Usuario.Seguc_vNombre);
            db.AddInParameter(SQL, "apellido", DbType.String, segu_Usuario.Seguc_vApellidos);
            db.AddInParameter(SQL, "areas_codarea", DbType.String, segu_Usuario.areas_codarea);            
            db.AddInParameter(SQL, "estado", DbType.String, segu_Usuario.Seguc_bEstado);
            //db.AddInParameter(SQL, "fecha_creacion", DbType.DateTime, segu_Usuario.Seguc_fFechaCreacion);
            db.AddInParameter(SQL, "per_login", DbType.String, segu_Usuario.Seguc_vLogin);
            db.AddInParameter(SQL, "per_pass", DbType.String, segu_Usuario.Seguc_password);
            db.AddInParameter(SQL, "per_last", DbType.String, segu_Usuario.Seguc_vLast);
            db.AddInParameter(SQL, "per_session", DbType.String, segu_Usuario.Seguc_vSession);
            //db.AddInParameter(SQL, "fecha_cese", DbType.DateTime, segu_Usuario.Seguc_fFechaCese);
            //db.AddInParameter(SQL, "rol_nombre", DbType.String, rol_nombre);
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

    public virtual Int32 updateUsuario(Segu_Usuario segu_Usuario)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "per_codigo", DbType.String, segu_Usuario.per_codigo);
            db.AddInParameter(SQL, "nombre", DbType.String, segu_Usuario.Seguc_vNombre);
            db.AddInParameter(SQL, "apellido", DbType.String, segu_Usuario.Seguc_vApellidos);
            db.AddInParameter(SQL, "areas_codarea", DbType.String, segu_Usuario.areas_codarea);
            db.AddInParameter(SQL, "estado", DbType.String, segu_Usuario.Seguc_bEstado);
            //db.AddInParameter(SQL, "fecha_creacion", DbType.DateTime, segu_Usuario.Seguc_fFechaCreacion);
            db.AddInParameter(SQL, "per_login", DbType.String, segu_Usuario.Seguc_vLogin);
            //db.AddInParameter(SQL, "per_pass", DbType.String, segu_Usuario.Seguc_password);
            db.AddInParameter(SQL, "per_last", DbType.String, segu_Usuario.Seguc_vLast);
            db.AddInParameter(SQL, "per_session", DbType.String, segu_Usuario.Seguc_vSession);
            //db.AddInParameter(SQL, "fecha_cese", DbType.DateTime, segu_Usuario.Seguc_fFechaCese);
            db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 1);//modificar tipo
            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error");
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
    public virtual Int32 updateUsuarioDatosPersonales(Segu_Usuario segu_Usuario)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "per_codigo", DbType.String, segu_Usuario.per_codigo);
            db.AddInParameter(SQL, "nombre", DbType.String, segu_Usuario.Seguc_vNombre);
            db.AddInParameter(SQL, "apellido", DbType.String, segu_Usuario.Seguc_vApellidos);
            db.AddInParameter(SQL, "per_login", DbType.String, segu_Usuario.Seguc_vLogin);
            db.AddInParameter(SQL, "per_pass", DbType.String, segu_Usuario.Seguc_password);
            //db.AddInParameter(SQL, "fecha_cese", DbType.DateTime, segu_Usuario.Seguc_fFechaCese);
            db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 12);//modificar tipo
            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error");
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
    public virtual Int32 GetExisteLoginNuevo(String per_login)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 6);
            db.AddInParameter(SQL, "per_login", DbType.String, per_login);
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

    public virtual Int32 GetExisteLoginModificar(String per_codigo, String per_login)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 7);//cambiar tipo
            db.AddInParameter(SQL, "per_codigo", DbType.String, per_codigo);
            db.AddInParameter(SQL, "per_login", DbType.String, per_login);
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

    public virtual Int32 insertRolUsuario(Segu_Usuario segu_Usuario, string rol_nombre)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "per_login", DbType.String, segu_Usuario.Seguc_vLogin);            
            db.AddInParameter(SQL, "rol_nombre", DbType.String, rol_nombre);
            db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 8);//modificar tipo

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

    public List<Conf_Rol> listarRolesXUsuario(string per_codigo)
    {
        try
        {
            var coleccion = new List<Conf_Rol>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "per_codigo", DbType.String, per_codigo);
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

    public virtual Int32 deleteRolUsuario(Segu_Usuario segu_Usuario)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "per_codigo", DbType.String, segu_Usuario.per_codigo);
            db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 9);//modificar tipo

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

    public virtual List<Segu_Usuario> buscarUsuario(string buscar)
    {
        try
        {
            var coleccion = new List<Segu_Usuario>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "per_login", DbType.String, buscar);
            db.AddInParameter(SQL, "nombre", DbType.String, buscar);
            db.AddInParameter(SQL, "apellido", DbType.String, buscar);
            db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 11);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Segu_Usuario
                    {
                        Seguc_iCodigo = Convert.ToInt32(lector.GetString(lector.GetOrdinal("per_codigo")).Trim()),
                        per_codigo = lector.GetString(lector.GetOrdinal("per_codigo")).Trim(),
                        areas_codarea = lector.IsDBNull(lector.GetOrdinal("areas_codarea")) ? default(String) : lector.GetString(lector.GetOrdinal("areas_codarea")),
                        Seguc_bEstado = lector.GetBoolean(lector.GetOrdinal("estado")),
                        Seguc_vNombre = lector.IsDBNull(lector.GetOrdinal("nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("nombre")),
                        Seguc_vApellidos = lector.IsDBNull(lector.GetOrdinal("apellido")) ? default(String) : lector.GetString(lector.GetOrdinal("apellido")),
                        Seguc_fFechaCreacion = lector.IsDBNull(lector.GetOrdinal("fecha_creacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_creacion")),
                        Seguc_vLogin = lector.IsDBNull(lector.GetOrdinal("per_login")) ? default(String) : lector.GetString(lector.GetOrdinal("per_login")),
                        //Seguc_password = lector.IsDBNull(lector.GetOrdinal("per_pass")) ? default(String) : lector.GetString(lector.GetOrdinal("per_pass")),
                        //Seguc_vLast = lector.IsDBNull(lector.GetOrdinal("per_last")) ? default(String) : lector.GetString(lector.GetOrdinal("per_last")),
                        //Seguc_vSession = lector.IsDBNull(lector.GetOrdinal("per_session")) ? default(String) : lector.GetString(lector.GetOrdinal("per_session")),
                        Seguc_fFechaCese = lector.IsDBNull(lector.GetOrdinal("fecha_cese")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_cese")),
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
    public Segu_Usuario DatosUsuario(string x)
    {
        try
        {
            Segu_Usuario usuario = null;
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento2);
            db.AddInParameter(SQL, "per_login", DbType.String, x);
            db.AddInParameter(SQL, "tipoConsulta", DbType.String,13);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    usuario = new Segu_Usuario
                    {
                        //per_codigo = lector.GetString(0),
                        per_codigo = lector.IsDBNull(lector.GetOrdinal("per_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("per_codigo")),
                        Seguc_vApellidos = lector.IsDBNull(lector.GetOrdinal("apellido")) ? default(String) : lector.GetString(lector.GetOrdinal("apellido")),
                        Seguc_vNombre = lector.IsDBNull(lector.GetOrdinal("nombre")) ? default(String) : lector.GetString(lector.GetOrdinal("nombre")),
                        Seguc_password = lector.IsDBNull(lector.GetOrdinal("per_pass")) ? default(String) : lector.GetString(lector.GetOrdinal("per_pass")),
                        Seguc_vLogin = lector.IsDBNull(lector.GetOrdinal("per_login")) ? default(String) : lector.GetString(lector.GetOrdinal("per_login"))
                    };
                }
            }
            SQL.Dispose();
            return usuario;


        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public virtual int VerificarSiEsADmin(string per_login,string per_pass)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand("_SeguUsuario");
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 14);
            db.AddInParameter(SQL, "per_login", DbType.String, per_login);
            db.AddInParameter(SQL, "per_pass", DbType.String, per_pass);
            int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
            return huboexito;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}


