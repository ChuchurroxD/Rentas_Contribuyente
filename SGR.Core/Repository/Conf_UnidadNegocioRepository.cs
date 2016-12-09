
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

public class Conf_UnidadNegocioRepository
{



    private const String nombreprocedimiento = "_Conf_UnidadNegocio";
    private const String NombreTabla = "UnidadNegocio";
    private Database db = DatabaseFactory.CreateDatabase();


    public List<Conf_UnidadNegocio> listartodos()
    {
        try
        {
            var coleccion = new List<Conf_UnidadNegocio>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);//modificar de acuerdo a tipo de  consulta

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_UnidadNegocio
                    {

                        UnNec_iCodigo = lector.GetInt64(lector.GetOrdinal("UnidadNegocio_id")),
                        UnNec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                        UnNegoc_bActivo = lector.GetBoolean(lector.GetOrdinal("estado"))


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



    public List<Conf_UnidadNegocio> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }


    public virtual List<Conf_UnidadNegocio> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Conf_UnidadNegocio>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_UnidadNegocio
                    {
                        UnNec_iCodigo = lector.GetInt64(lector.GetOrdinal("UnidadNegocio_id")),
                        UnNec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                        UnNegoc_bActivo = lector.GetBoolean(lector.GetOrdinal("estado"))
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


    public virtual Conf_UnidadNegocio GetByPrimaryKey(Int64 UnNec_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);//cambiar tipo
            db.AddInParameter(SQL, "UnNec_iCodigo", DbType.Int64, UnNec_iCodigo);
            var Conf_UnidadNegocio = default(Conf_UnidadNegocio);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Conf_UnidadNegocio = new Conf_UnidadNegocio
                    {
                        UnNec_iCodigo = lector.GetInt64(lector.GetOrdinal("UnidadNegocio_id")),
                        UnNec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                        UnNegoc_bActivo = lector.GetBoolean(lector.GetOrdinal("estado"))
                    };
                }
            }
            SQL.Dispose();
            return Conf_UnidadNegocio;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public virtual Int32 GetExisteDescripcionNuevo(String UnNec_vDescripcion)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
            //db.AddInParameter(SQL, "UnNec_iCodigo", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "UnNec_vDescripcion", DbType.String, UnNec_vDescripcion);
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
    public virtual Int32 GetExisteDescripcionModificar(Int64 UnNec_iCodigo, String UnNec_vDescripcion)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            db.AddInParameter(SQL, "UnNec_iCodigo", DbType.Int64, UnNec_iCodigo);
            db.AddInParameter(SQL, "UnNec_vDescripcion", DbType.String, UnNec_vDescripcion);
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
        string sql = "SELECT * FROM [dbo].[UnidadNegocio]";
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

    public virtual int Insert(Conf_UnidadNegocio Conf_UnidadNegocio)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "UnNec_vDescripcion", DbType.String, Conf_UnidadNegocio.UnNec_vDescripcion);
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
            //MessageBox.Show(Convert.ToString(db.GetParameterValue(SQL, "UnNec_iCodigo")));
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


    public virtual void Update(Conf_UnidadNegocio Conf_UnidadNegocio)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

            db.AddInParameter(SQL, "UnNec_iCodigo", DbType.Int64, Conf_UnidadNegocio.UnNec_iCodigo);
            db.AddInParameter(SQL, "UnNec_vDescripcion", DbType.String, Conf_UnidadNegocio.UnNec_vDescripcion);
            db.AddInParameter(SQL, "UnNegoc_bActivo", DbType.Boolean, Conf_UnidadNegocio.UnNegoc_bActivo);
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


    public virtual bool DeleteByPrimaryKey(Int64 UnNec_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "UnNec_iCodigo", DbType.Int64, UnNec_iCodigo);
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

    public List<Conf_UnidadNegocio> listarActivos()//para el combo de Unidad de Negocio
    {
        try
        {
            var coleccion = new List<Conf_UnidadNegocio>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);//modificar de acuerdo a tipo de  consulta

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_UnidadNegocio
                    {

                        UnNec_iCodigo = lector.GetInt64(lector.GetOrdinal("codigo")),
                        UnNec_vDescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion"))
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


