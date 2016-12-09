
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
//using System.Globalization;

public class Mant_PeriodoRepository
{



    private const String nombreprocedimiento = "_Mant_Periodo";
    private const String NombreTabla = "Periodo";
    private Database db = DatabaseFactory.CreateDatabase();


    public List<Mant_Periodo> listartodos()
    {
        try
        {
            var coleccion = new List<Mant_Periodo>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);//modificar de acuerdo a tipo de  consulta

            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Periodo
                    {
                        Peric_canio = lector.GetInt32(lector.GetOrdinal("año")),
                        Peric_euit = lector.GetDecimal(lector.GetOrdinal("UIT")),
                        Peric_vdescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                        Peric_bactivo = lector.GetBoolean(lector.GetOrdinal("activo")),
                        Peric_ntasaAlcabala = lector.GetDecimal(lector.GetOrdinal("tasaAlcabala")),
                        Peric_iuitAlcabala = lector.GetInt32(lector.GetOrdinal("UITAlcabala")),
                        Peric_nmoraAlcaba = lector.GetDecimal(lector.GetOrdinal("moraAlcabala")),
                        MinimoPredio = lector.GetDecimal(lector.GetOrdinal("MinimoPredio")),
                        TopeUITPension = lector.GetDecimal(lector.GetOrdinal("TopeUITPension")),
                        Interes = lector.GetDecimal(lector.GetOrdinal("Interes")),
                        Formulario = lector.GetDecimal(lector.GetOrdinal("Formulario")),
                        FactorOficilizacion = lector.GetDecimal(lector.GetOrdinal("FactorOficilizacion")),
                        Tramo1 = lector.IsDBNull(lector.GetOrdinal("Tramo1")) ? default(String) : lector.GetString(lector.GetOrdinal("Tramo1")),
                        Tramo2 = lector.IsDBNull(lector.GetOrdinal("Tramo2")) ? default(String) : lector.GetString(lector.GetOrdinal("Tramo2")),
                        Tramo3 = lector.IsDBNull(lector.GetOrdinal("tramo3")) ? default(String) : lector.GetString(lector.GetOrdinal("tramo3"))


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



    public List<Mant_Periodo> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }


    public virtual List<Mant_Periodo> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Mant_Periodo>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Periodo
                    {
                        Peric_canio = lector.GetInt32(lector.GetOrdinal("año")),
                        Peric_euit = lector.GetDecimal(lector.GetOrdinal("UIT")),
                        Peric_vdescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                        Peric_bactivo = lector.GetBoolean(lector.GetOrdinal("activo")),
                        Peric_ntasaAlcabala = lector.GetDecimal(lector.GetOrdinal("tasaAlcabala")),
                        Peric_iuitAlcabala = lector.GetInt32(lector.GetOrdinal("UITAlcabala")),
                        Peric_nmoraAlcaba = lector.GetDecimal(lector.GetOrdinal("moraAlcabala")),
                        Interes = lector.GetDecimal(lector.GetOrdinal("Interes")),
                        MinimoPredio = lector.GetDecimal(lector.GetOrdinal("MinimoPredio")),
                        TopeUITPension = lector.GetDecimal(lector.GetOrdinal("TopeUITPension")),
                        FactorOficilizacion = lector.GetDecimal(lector.GetOrdinal("FactorOficilizacion"))
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


    public virtual Mant_Periodo GetByPrimaryKey(String Peric_canio)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);//cambiar tipo
            db.AddInParameter(SQL, "Peric_canio", DbType.Int64, Peric_canio);
            var Mant_Periodo = default(Mant_Periodo);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Mant_Periodo = new Mant_Periodo
                    {
                        Peric_canio = lector.GetInt32(lector.GetOrdinal("año")),
                        Peric_euit = lector.GetDecimal(lector.GetOrdinal("UIT")),
                        Peric_vdescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                        Peric_bactivo = lector.GetBoolean(lector.GetOrdinal("activo")),
                        Peric_ntasaAlcabala = lector.GetDecimal(lector.GetOrdinal("tasaAlcabala")),
                        Peric_iuitAlcabala = lector.GetInt32(lector.GetOrdinal("UITAlcabala")),
                        Peric_nmoraAlcaba = lector.GetDecimal(lector.GetOrdinal("moraAlcabala")),
                        Interes = lector.GetDecimal(lector.GetOrdinal("Interes")),
                        MinimoPredio = lector.GetDecimal(lector.GetOrdinal("MinimoPredio")),
                        TopeUITPension = lector.GetDecimal(lector.GetOrdinal("TopeUITPension")),
                        FactorOficilizacion = lector.GetDecimal(lector.GetOrdinal("FactorOficilizacion"))
                    };
                }
            }
            SQL.Dispose();
            return Mant_Periodo;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public virtual Int32 GetExisteAnioNuevo(Int32 Peric_canio)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Peric_canio", DbType.Int32, Peric_canio);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
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
    public virtual Int32 ExistePeriodoActivoNuevo()
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);//cambiar tipo
            Int32 total = 0;
            total = Convert.ToInt32(db.ExecuteScalar(SQL));
            SQL.Dispose();
            return total;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public virtual Int32 ExistePeriodoActivoModificar(Int32 Peric_canio)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Peric_canio", DbType.Int32, Peric_canio);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 13);//cambiar tipo
            Int32 total = 0;
            total = Convert.ToInt32(db.ExecuteScalar(SQL));
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
        string sql = "SELECT * FROM [dbo].[Periodo]";
        if ((whereSql != null) && (whereSql.Trim().Length > 0))
        {
            sql += " WHERE " + whereSql;
        }
        if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
        {
            sql += " ORDER BY " + orderBySql + " DESC";
        }
        return sql;
    }

    public virtual int Insert(Mant_Periodo Mant_Periodo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Peric_canio", DbType.Int32, Mant_Periodo.Peric_canio);
            db.AddInParameter(SQL, "Peric_vdescripcion", DbType.String, Mant_Periodo.Peric_vdescripcion);
            db.AddInParameter(SQL, "Peric_euit", DbType.Decimal, Mant_Periodo.Peric_euit);
            db.AddInParameter(SQL, "Peric_ntasaAlcabala", DbType.Decimal, Mant_Periodo.Peric_ntasaAlcabala);
            db.AddInParameter(SQL, "Peric_iuitAlcabala", DbType.Int32, Mant_Periodo.Peric_iuitAlcabala);
            db.AddInParameter(SQL, "Peric_nmoraAlcaba", DbType.Decimal, Mant_Periodo.Peric_nmoraAlcaba);
            db.AddInParameter(SQL, "Interes", DbType.Decimal, Mant_Periodo.Interes);
            db.AddInParameter(SQL, "FactorOficilizacion", DbType.Decimal, Mant_Periodo.FactorOficilizacion);
            db.AddInParameter(SQL, "TopeUITPension", DbType.Decimal, Mant_Periodo.TopeUITPension);
            db.AddInParameter(SQL, "MinimoPredio", DbType.Decimal, Mant_Periodo.MinimoPredio);
            db.AddInParameter(SQL, "Formulario", DbType.Decimal, Mant_Periodo.Formulario);
            db.AddInParameter(SQL, "Peric_bactivo", DbType.Boolean, Mant_Periodo.Peric_bactivo);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);//modificar tipo
            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error al agregar el registro");
            }
            SQL.Dispose();
            return huboexito;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }


    public virtual void Update(Mant_Periodo Mant_Periodo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Peric_canio", DbType.Int32, Mant_Periodo.Peric_canio);
            db.AddInParameter(SQL, "Peric_vdescripcion", DbType.String, Mant_Periodo.Peric_vdescripcion);
            db.AddInParameter(SQL, "Peric_euit", DbType.Decimal, Mant_Periodo.Peric_euit);
            db.AddInParameter(SQL, "Peric_ntasaAlcabala", DbType.Decimal, Mant_Periodo.Peric_ntasaAlcabala);
            db.AddInParameter(SQL, "Peric_iuitAlcabala", DbType.Int32, Mant_Periodo.Peric_iuitAlcabala);
            db.AddInParameter(SQL, "Peric_nmoraAlcaba", DbType.Decimal, Mant_Periodo.Peric_nmoraAlcaba);
            db.AddInParameter(SQL, "Interes", DbType.Decimal, Mant_Periodo.Interes);
            db.AddInParameter(SQL, "FactorOficilizacion", DbType.Decimal, Mant_Periodo.FactorOficilizacion);
            db.AddInParameter(SQL, "Peric_bactivo", DbType.Boolean, Mant_Periodo.Peric_bactivo);
            db.AddInParameter(SQL, "TopeUITPension", DbType.Decimal, Mant_Periodo.TopeUITPension);
            db.AddInParameter(SQL, "MinimoPredio", DbType.Decimal, Mant_Periodo.MinimoPredio);
            db.AddInParameter(SQL, "Formulario", DbType.Decimal, Mant_Periodo.Formulario);
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


    public virtual bool DeleteByPrimaryKey(String Peric_canio)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Peric_canio", DbType.Int32, Peric_canio);
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
    public List<Mant_Periodo> llenarPeriodo()
    {
        try
        {
            var coleccion = new List<Mant_Periodo>();
            DbCommand sql = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(sql, "Tipoconsulta", DbType.String, 9);
            using (var lector = db.ExecuteReader(sql))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Periodo
                    {
                        Peric_canio = lector.GetInt32(lector.GetOrdinal("anio"))
                    });
                }
            }
            sql.Dispose();
            return coleccion;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public virtual Int32 GetPeriodoActivo()
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);//cambiar tipo
            Int32 total = 0;
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    total = lector.GetInt32(lector.GetOrdinal("anio"));

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
    public List<Mant_Periodo> listarPeriodov2()
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 14);
            var coleccion = new List<Mant_Periodo>();
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Periodo
                    {
                        Peric_canio = lector.GetInt32(lector.GetOrdinal("anio")),
                        Peric_vdescripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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


