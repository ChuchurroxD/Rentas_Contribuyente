
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

public class Conf_MultitablaRepository
{



    private const String nombreprocedimiento = "_Conf_Multitabla";
    private const String NombreTabla = "Tablas";
    private Database db = DatabaseFactory.CreateDatabase();


    public List<Conf_Multitabla> listartodos(String Multc_iDependenci)
    {
        try
        {
            var coleccion = new List<Conf_Multitabla>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);//modificar de acuerdo a tipo de  consulta
            db.AddInParameter(SQL, "Confc_cIdPadre", DbType.String, Multc_iDependenci);

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Multitabla
                    {

                        Multc_iCodigo = lector.GetInt64(lector.GetOrdinal("id")),
                        Multc_cValor = lector.IsDBNull(lector.GetOrdinal("valor")) ? default(String) : lector.GetString(lector.GetOrdinal("valor")),
                        Multc_cDependencia = lector.IsDBNull(lector.GetOrdinal("idPadre")) ? default(String) : lector.GetString(lector.GetOrdinal("idPadre")),
                        Multc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                        Multc_vAbreviatura = lector.IsDBNull(lector.GetOrdinal("Abreviatura")) ? default(String) : lector.GetString(lector.GetOrdinal("Abreviatura")),
                        Multc_bEstado = lector.GetBoolean(lector.GetOrdinal("estado"))


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



    public List<Conf_Multitabla> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }


    public virtual List<Conf_Multitabla> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Conf_Multitabla>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Multitabla
                    {
                        Multc_iCodigo = lector.GetInt64(lector.GetOrdinal("tabla_id")),
                        Multc_cValor = lector.IsDBNull(lector.GetOrdinal("valor")) ? default(String) : lector.GetString(lector.GetOrdinal("valor")),
                        Multc_cDependencia = lector.IsDBNull(lector.GetOrdinal("dep_id")) ? default(String) : lector.GetString(lector.GetOrdinal("dep_id")),
                        Multc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                        Multc_vAbreviatura = lector.IsDBNull(lector.GetOrdinal("abrev")) ? default(String) : lector.GetString(lector.GetOrdinal("abrev")),
                        Multc_bEstado = lector.GetBoolean(lector.GetOrdinal("estado"))

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


    public virtual Conf_Multitabla GetByPrimaryKey(Int32 Multc_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);//cambiar tipo
            db.AddInParameter(SQL, "Confc_iCodigo", DbType.Int64, Multc_iCodigo);
            var Conf_Multitabla = default(Conf_Multitabla);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Conf_Multitabla = new Conf_Multitabla
                    {
                        Multc_iCodigo = lector.GetInt64(lector.GetOrdinal("id")),
                        Multc_cValor = lector.IsDBNull(lector.GetOrdinal("valor")) ? default(String) : lector.GetString(lector.GetOrdinal("valor")),
                        Multc_cDependencia = lector.IsDBNull(lector.GetOrdinal("idPadre")) ? default(String) : lector.GetString(lector.GetOrdinal("idPadre")),
                        Multc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                        Multc_vAbreviatura = lector.IsDBNull(lector.GetOrdinal("Abreviatura")) ? default(String) : lector.GetString(lector.GetOrdinal("Abreviatura")),
                        Multc_bEstado = lector.GetBoolean(lector.GetOrdinal("estado"))

                    };
                }
            }
            SQL.Dispose();
            return Conf_Multitabla;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public virtual Int32 GetExisteDescripcionNuevo(String Multc_vDescripcion, String Multc_vDependencia)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
            //db.AddInParameter(SQL, "Confc_iCodigo", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "Confc_cIdPadre", DbType.String, Multc_vDependencia);
            db.AddInParameter(SQL, "Confc_vDescripcion", DbType.String, Multc_vDescripcion);
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
    public virtual Int32 GetExisteDescripcionModificar(Int64 Multc_iCodigo, String Multc_vDescripcion, String Multc_vDependencia)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            db.AddInParameter(SQL, "Confc_iCodigo", DbType.Int64, Multc_iCodigo);
            db.AddInParameter(SQL, "Confc_cIdPadre", DbType.String, Multc_vDependencia);
            db.AddInParameter(SQL, "Confc_vDescripcion", DbType.String, Multc_vDescripcion);
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

    public virtual int Insert(Conf_Multitabla Conf_Multitabla)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Confc_cIdPadre", DbType.String, Conf_Multitabla.Multc_cDependencia);
            db.AddInParameter(SQL, "Confc_vDescripcion", DbType.String, Conf_Multitabla.Multc_vDescripcion);
            db.AddInParameter(SQL, "Confc_vAbreviatura", DbType.String, Conf_Multitabla.Multc_vAbreviatura);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);//modificar tipo

            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error al agregar al");
            }
            ////var numerogenerado = (int)db.GetParameterValue(SQL, "Seguc_iCodigo");
            //MessageBox.Show(Convert.ToString(SQL.Parameters[0].Value));
            //MessageBox.Show(Convert.ToString(SQL.Parameters[1].Value));
            //MessageBox.Show(Convert.ToString(SQL.Parameters[2].Value));
            //MessageBox.Show(Convert.ToString(SQL.Parameters[3].Value));
            //MessageBox.Show(Convert.ToString(db.GetParameterValue(SQL, "Confc_iCodigo")));
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


    public virtual void Update(Conf_Multitabla Conf_Multitabla)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

            db.AddInParameter(SQL, "Confc_iCodigo", DbType.Int64, Conf_Multitabla.Multc_iCodigo);
            db.AddInParameter(SQL, "Confc_vDescripcion", DbType.String, Conf_Multitabla.Multc_vDescripcion);
            db.AddInParameter(SQL, "Confc_vAbreviatura", DbType.String, Conf_Multitabla.Multc_vAbreviatura);
            db.AddInParameter(SQL, "Confc_bEstado", DbType.Boolean, Conf_Multitabla.Multc_bEstado);
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


    public virtual bool DeleteByPrimaryKey(Int64 Multc_iCodigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Confc_iCodigo", DbType.Int64, Multc_iCodigo);
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

    public List<Conf_Multitabla> listarCbo(String Multc_iDependenci)
    {
        try
        {
            var coleccion = new List<Conf_Multitabla>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
            db.AddInParameter(SQL, "Confc_cIdPadre", DbType.String, Multc_iDependenci);

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Multitabla
                    {
                        
                        Multc_cValor = lector.IsDBNull(lector.GetOrdinal("valor")) ? default(String) : lector.GetString(lector.GetOrdinal("valor")).Trim(),
                        Multc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion"))
                        


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
    public Int32 GetMaxTablaDependiente(String dep)
    {
        try
        {
            Int32 maximo=1;
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
            db.AddInParameter(SQL, "Confc_cIdPadre", DbType.String, dep);
            maximo = Convert.ToInt32(db.ExecuteScalar(SQL));
            SQL.Dispose();
            return maximo;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public List<Conf_Multitabla> listarCbov2(String Multc_iDependenci)
    {
        try
        {
            var coleccion = new List<Conf_Multitabla>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
            db.AddInParameter(SQL, "Confc_cIdPadre", DbType.String, Multc_iDependenci);

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Conf_Multitabla
                    {

                        Multc_cValor = lector.IsDBNull(lector.GetOrdinal("valor")) ? default(String) : lector.GetString(lector.GetOrdinal("valor")).Trim(),
                        Multc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion"))
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


