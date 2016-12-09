
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

public class Conf_UbicacionRepository
{



    private const String nombreprocedimiento = "_Conf_Ubicacion";
    private const String NombreTabla = "Ubigeo";
    private Database db = DatabaseFactory.CreateDatabase();


    public List<Conf_Ubicacion> listartodos()
    {
        try
        {
            var coleccion = new List<Conf_Ubicacion>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);//modificar de acuerdo a tipo de  consulta

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Ubicacion
                    {

                        Ubicacion_id = lector.GetString(lector.GetOrdinal("Ubicacion_id")),
                        Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                        Estado = lector.GetBoolean(lector.GetOrdinal("Estado"))


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



    public List<Conf_Ubicacion> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }


    public virtual List<Conf_Ubicacion> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Conf_Ubicacion>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Ubicacion
                    {
                        Ubicacion_id = lector.GetString(lector.GetOrdinal("Ubicacion_id")),
                        Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                        Estado = lector.GetBoolean(lector.GetOrdinal("Estado"))
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


    public virtual Conf_Ubicacion GetByPrimaryKey(Int64 Ubicacion_id)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);//cambiar tipo
            db.AddInParameter(SQL, "Ubicacion_id", DbType.Int64, Ubicacion_id);
            var Conf_Ubicacion = default(Conf_Ubicacion);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Conf_Ubicacion = new Conf_Ubicacion
                    {
                        Ubicacion_id = lector.GetString(lector.GetOrdinal("Ubicacion_id")),
                        Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                        Estado = lector.GetBoolean(lector.GetOrdinal("Estado"))
                    };
                }
            }
            SQL.Dispose();
            return Conf_Ubicacion;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public virtual Int32 GetExisteDescripcionNuevo(String Descripcion)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
            //db.AddInParameter(SQL, "Ubicacion_id", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "Descripcion", DbType.String, Descripcion);
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
    public virtual Int32 GetExisteDescripcionModificar(Int64 Ubicacion_id, String Descripcion)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            db.AddInParameter(SQL, "Ubicacion_id", DbType.Int64, Ubicacion_id);
            db.AddInParameter(SQL, "Descripcion", DbType.String, Descripcion);
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
        string sql = "SELECT * FROM [dbo].[Ubicacion]";
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

    public virtual int Insert(Conf_Ubicacion Conf_Ubicacion)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Descripcion", DbType.String, Conf_Ubicacion.Descripcion);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);//modificar tipo

            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error al agregar el registro");
            }
            ////var numerogenerado = (int)db.GetParameterValue(SQL, "Seguc_iCodigo");
            //MessageBox.Show(Convert.ToString(SQL.Parameters[0].Value));
            //MessageBox.Show(Convert.ToString(SQL.Parameters[1].Value));
            //MessageBox.Show(Convert.ToString(SQL.Parameters[2].Value));
            //MessageBox.Show(Convert.ToString(SQL.Parameters[3].Value));
            //MessageBox.Show(Convert.ToString(db.GetParameterValue(SQL, "Ubicacion_id")));
            //var numerogenerado = (int)SQL.Parameters[1].Value;
            SQL.Dispose();
            //return numerogenerado;
            return huboexito;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }


    public virtual void Update(Conf_Ubicacion Conf_Ubicacion)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

            db.AddInParameter(SQL, "Ubicacion_id", DbType.String, Conf_Ubicacion.Ubicacion_id);
            db.AddInParameter(SQL, "Descripcion", DbType.String, Conf_Ubicacion.Descripcion);
            db.AddInParameter(SQL, "Estado", DbType.Boolean, Conf_Ubicacion.Estado);
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


    public virtual bool DeleteByPrimaryKey(Int64 Ubicacion_id)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Ubicacion_id", DbType.Int64, Ubicacion_id);
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

    public List<Conf_Ubicacion> listarDepartamentos()//para el combo de Unidad de Negocio
    {
        try
        {
            var coleccion = new List<Conf_Ubicacion>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//modificar de acuerdo a tipo de  consulta

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Ubicacion
                    {

                        Ubicacion_id = lector.GetString(lector.GetOrdinal("codigo")),
                        Descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion"))
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
    public List<Conf_Ubicacion> listarProvincia(string dep, int ti)//para el combo de Unidad de Negocio
    {
        try
        {
            var coleccion = new List<Conf_Ubicacion>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, ti);//modificar de acuerdo a tipo de  consulta
            db.AddInParameter(SQL, "Ubicacion_id", DbType.String, dep);//modificar de acuerdo a tipo de  consulta

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Ubicacion
                    {

                        Ubicacion_id = lector.GetString(lector.GetOrdinal("codigo")),
                        Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion"))
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

    public Int32 compararUbicacionId(string Ubicacion_id)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
            db.AddInParameter(SQL, "Ubicacion_id", DbType.String, Ubicacion_id);
            Int32 total = 0;
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    total = lector.GetInt32(lector.GetOrdinal("total"));
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
    public virtual Int32 GetExisteUbicacionId(String Ubicacion_id)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
            db.AddInParameter(SQL, "Ubicacion_id", DbType.String, Ubicacion_id);
            Int32 total = 0;
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    total = lector.GetInt32(lector.GetOrdinal("total"));

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

    public virtual Int32 GetExisteUbicacionIdModificar(String Ubicacion_id)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
            db.AddInParameter(SQL, "Ubicacion_id", DbType.String, Ubicacion_id);
            Int32 total = 0;
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    total = lector.GetInt32(lector.GetOrdinal("total"));

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


