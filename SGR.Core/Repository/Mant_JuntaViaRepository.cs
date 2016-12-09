using System.Linq;
using System.Text;
using SGR.Core;
using SGR.Entity;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using System;
using System.Collections.Generic;

public class Mant_JuntaViaRepository
{
    private const string nombreprocedimiento = "_Mant_Junta_Via";
    private Database db = DatabaseFactory.CreateDatabase();

    public virtual int GetJuntaVia(int junta, int via)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
            db.AddInParameter(SQL, "junta_ID", DbType.Int32, junta);
            db.AddInParameter(SQL, "via_ID", DbType.Int32, via);
            int total = 0;
            total = Convert.ToInt32(db.ExecuteScalar(SQL));
            SQL.Dispose();
            return total;
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }
    public List<Mant_Junta_Via> listartodos()
    {
        try
        {
            var coleccion = new List<Mant_Junta_Via>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Junta_Via
                    {
                        junta_via_ID = lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                        junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")).Trim(),
                        via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")).Trim(),
                        estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                        registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                        registro_user_add = lector.GetString(lector.GetOrdinal("registro_user_add")),
                        registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                        registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                        registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                        registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                        descripcion_sector = lector.GetString(lector.GetOrdinal("descripcion_sector")),
                        via_descripcion = lector.GetString(lector.GetOrdinal("via_descripcion"))
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
    public List<Mant_Junta_Via> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }


    public virtual List<Mant_Junta_Via> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Mant_Junta_Via>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Junta_Via
                    {
                        junta_via_ID = lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                        junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")).Trim(),
                        via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")).Trim(),
                        estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                        registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                        registro_user_add = lector.GetString(lector.GetOrdinal("registro_user_add")),
                        registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                        registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                        registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                        registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                        descripcion_sector = lector.GetString(lector.GetOrdinal("descripcion_sector")),
                        via_descripcion = lector.GetString(lector.GetOrdinal("via_descripcion"))
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
    protected virtual string CreateGetCommand(string whereSql, string orderBySql)
    {
        string sql = "Select jv.junta_via_ID,jv.junta_ID,jv.via_ID,jv.estado,jv.registro_fecha_add,jv.registro_user_add,jv.registro_pc_add,jv.registro_fecha_update,jv.registro_user_update,jv.registro_pc_update, " +
                        "s.Descripcion as descripcion_sector, v.Descripcion as via_descripcion "+
                        "from Junta_Via jv inner join Sector s on jv.junta_ID = s.Sector_id "+
                        "inner join Via v on jv.via_ID = v.Via_id";
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

    public virtual void Insert(Mant_Junta_Via Junta_Via)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "junta_ID", DbType.String, Junta_Via.junta_ID);
            db.AddInParameter(SQL, "via_ID", DbType.String, Junta_Via.via_ID);
            db.AddInParameter(SQL, "estado", DbType.Boolean, Junta_Via.estado);
            db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Junta_Via.registro_fecha_add);
            db.AddInParameter(SQL, "registro_user_add", DbType.String, Junta_Via.registro_user_add);
            db.AddInParameter(SQL, "registro_pc_add", DbType.String, Junta_Via.registro_pc_add);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error al agregar al");
            }
            SQL.Dispose();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    
    public virtual void Update(Mant_Junta_Via Junta_Via)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, Junta_Via.junta_via_ID);
            db.AddInParameter(SQL, "junta_ID", DbType.String, Junta_Via.junta_ID);
            db.AddInParameter(SQL, "via_ID", DbType.String, Junta_Via.via_ID);
            db.AddInParameter(SQL, "estado", DbType.Boolean, Junta_Via.estado);
            db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Junta_Via.registro_fecha_add);
            db.AddInParameter(SQL, "registro_user_add", DbType.String, Junta_Via.registro_user_add);
            db.AddInParameter(SQL, "registro_pc_add", DbType.String, Junta_Via.registro_pc_add);
            db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Junta_Via.registro_fecha_update);
            db.AddInParameter(SQL, "registro_user_update", DbType.String, Junta_Via.registro_user_update);
            db.AddInParameter(SQL, "registro_pc_update", DbType.String, Junta_Via.registro_pc_update);
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
    public int compararSectorJuntaVia(string via_ID, string sector_id)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "TipoConsulta",DbType.Byte,7);
            db.AddInParameter(SQL, "via_ID", DbType.String, via_ID);
            db.AddInParameter(SQL, "junta_ID", DbType.String, sector_id);
            var total = 0;
            using(var lector= db.ExecuteReader(SQL))
            {
                if (lector.Read())
                {
                    total = lector.GetInt32(lector.GetOrdinal("total"));
                }
            }
            SQL.Dispose();
            return total;
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public int compararSectorViaModificar(Int32 junta_via_ID, string via_ID, string junta_ID)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 9);
            db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, junta_via_ID);
            db.AddInParameter(SQL, "via_ID", DbType.String, via_ID);
            db.AddInParameter(SQL, "junta_ID", DbType.String, junta_ID);
            var total = 0;
            using (var lector = db.ExecuteReader(SQL))
            {
                if (lector.Read())
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
