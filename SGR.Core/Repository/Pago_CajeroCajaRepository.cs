 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common ;
using Microsoft.Practices.EnterpriseLibrary.Data ;
using System.Data;
using System.Data.Common;
namespace SGR.Core.Repository
{
public  class Pago_CajeroCajaRepository{
    private const String nombreprocedimiento  ="_Pago_CajeroCaja";
    private const String NombreTabla  ="CajeroCaja";
    private Database db = DatabaseFactory.CreateDatabase();


    public  List<Pago_CajeroCaja>listartodos() {
        try {
            var coleccion = new List<Pago_CajeroCaja>();
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector=  db.ExecuteReader(SQL)){
                    while (lector.Read ()){
                        coleccion.Add(new Pago_CajeroCaja
                        {
                        CajeroCaja_id=lector.GetInt32(lector.GetOrdinal("CajeroCaja_id")),
                        Estado=lector.GetBoolean (lector.GetOrdinal("Estado")),
                        Caja_id=lector.GetInt32(lector.GetOrdinal("Caja_id")),
                        Persona_id=lector.GetString(lector.GetOrdinal("Persona_id")),
                        registro_fecha_add=lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                        registro_user_add=lector.GetString(lector.GetOrdinal("registro_user_add")),
                        registro_pc_add=lector.GetString(lector.GetOrdinal("registro_pc_add")),
                        registro_fecha_update=lector.IsDBNull(lector.GetOrdinal("registro_fecha_update"))? default(DateTime):lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                        registro_user_update=lector.IsDBNull(lector.GetOrdinal("registro_user_update"))? default(string):lector.GetString(lector.GetOrdinal("registro_user_update")),
                        registro_pc_update=lector.IsDBNull(lector.GetOrdinal("registro_pc_update"))? default(String):lector.GetString(lector.GetOrdinal("registro_pc_update")),
                        nombrecompleto = lector.GetString(lector.GetOrdinal("nombrecompleto")),
                        caja_descripcion = lector.GetString(lector.GetOrdinal("descripcion"))

                        });
                    }
                }
            SQL.Dispose(); 
            return coleccion;
        }
        catch ( Exception ex ) {
            throw new Exception(ex.Message);
        }
    }
        
    public  List<Pago_CajeroCaja> Getcoleccion(string wheresql,string orderbysql) {
        int totalRecordCount  = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }
    public virtual List<Pago_CajeroCaja> Getcoleccion(string wheresql,string orderbysql,int startIndex,int length,int totalRecordCount) {
        try {
            var coleccion = new List<Pago_CajeroCaja>();
            DbCommand SQL=db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector=  db.ExecuteReader(SQL)){
             while (lector.Read ()){
                coleccion.Add(new Pago_CajeroCaja
                {
                    CajeroCaja_id=lector.GetInt32(lector.GetOrdinal("CajeroCaja_id")),
                    Estado=lector.GetBoolean (lector.GetOrdinal("Estado")),
                    Caja_id=lector.GetInt32(lector.GetOrdinal("Caja_id")),
                    Persona_id=lector.GetString(lector.GetOrdinal("Persona_id")),
                    registro_fecha_add=lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                    registro_user_add=lector.GetString(lector.GetOrdinal("registro_user_add")),
                    registro_pc_add=lector.GetString(lector.GetOrdinal("registro_pc_add")),
                    registro_fecha_update=lector.IsDBNull(lector.GetOrdinal("registro_fecha_update"))? default(DateTime):lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                    registro_user_update=lector.IsDBNull(lector.GetOrdinal("registro_user_update"))? default(string):lector.GetString(lector.GetOrdinal("registro_user_update")),
                    registro_pc_update=lector.IsDBNull(lector.GetOrdinal("registro_pc_update"))? default(String):lector.GetString(lector.GetOrdinal("registro_pc_update")),
                    nombrecompleto = lector.GetString(lector.GetOrdinal("nombrecompleto")),
                    caja_descripcion = lector.GetString(lector.GetOrdinal("descripcion"))

                });
                }
            }
            SQL.Dispose(); 
            return coleccion;
        }
        catch ( Exception ex ) {
         throw new Exception(ex.Message);
        }
    }
    public virtual Pago_CajeroCaja GetByPrimaryKey(Int32 CajeroCaja_id){ 
        try {
        DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
        db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
        db.AddInParameter(SQL , "CajeroCaja_id", DbType.Int32, CajeroCaja_id);
        var CajeroCaja=default(Pago_CajeroCaja);
            using (var lector=  db.ExecuteReader(SQL)){
                while (lector.Read ()){
                    CajeroCaja=new Pago_CajeroCaja
                    {
                        CajeroCaja_id=lector.GetInt32(lector.GetOrdinal("CajeroCaja_id")),
                        Estado=lector.GetBoolean (lector.GetOrdinal("Estado")),
                        Caja_id=lector.GetInt32(lector.GetOrdinal("Caja_id")),
                        Persona_id=lector.GetString(lector.GetOrdinal("Persona_id")),
                        registro_fecha_add=lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                        registro_user_add=lector.GetString(lector.GetOrdinal("registro_user_add")),
                        registro_pc_add=lector.GetString(lector.GetOrdinal("registro_pc_add")),
                        registro_fecha_update=lector.IsDBNull(lector.GetOrdinal("registro_fecha_update"))? default(DateTime):lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                        registro_user_update=lector.IsDBNull(lector.GetOrdinal("registro_user_update"))? default(string):lector.GetString(lector.GetOrdinal("registro_user_update")),
                        registro_pc_update=lector.IsDBNull(lector.GetOrdinal("registro_pc_update"))? default(String):lector.GetString(lector.GetOrdinal("registro_pc_update"))

                    };
                }
            }
            SQL.Dispose(); 
            return CajeroCaja;
        }
        catch ( Exception ex ) {
         throw new Exception(ex.Message);
        }
    }
        
    protected virtual string CreateGetCommand(string whereSql, string orderBySql) {
        string sql  = "Select cc.CajeroCaja_id, cc.Caja_id,c.Descripcion , cc.Persona_id,p.NombreCompleto,cc.Estado,cc.registro_fecha_add,cc.registro_pc_add,cc.registro_user_add,cc.registro_fecha_update,cc.registro_pc_update,cc.registro_user_update from  CajeroCaja cc "+
                        "inner join Caja c on cc.Caja_id = c.Caja_id " +
                        "inner join Cajero cj on cc.Persona_id = cj.Persona_id "+
                        "inner join Persona p on cj.Persona_id = p.persona_ID";
        if ((whereSql != null) && (whereSql.Trim().Length > 0)) {
            sql += " WHERE " + whereSql ; }
        if ((orderBySql != null) && (orderBySql.Trim().Length > 0)) {
            sql +=" ORDER BY " + orderBySql; }
        return sql;
    }

    public virtual void Insert(Pago_CajeroCaja CajeroCaja) {
        try  {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Estado", DbType.Boolean, CajeroCaja.Estado);
            db.AddInParameter(SQL, "Caja_id", DbType.Int32, CajeroCaja.Caja_id);
            db.AddInParameter(SQL, "Persona_id", DbType.String, CajeroCaja.Persona_id);
            db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, CajeroCaja.registro_fecha_add);
            db.AddInParameter(SQL, "registro_user_add", DbType.String, CajeroCaja.registro_user_add);
            db.AddInParameter(SQL, "registro_pc_add", DbType.String, CajeroCaja.registro_pc_add);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
            int huboexito  = db.ExecuteNonQuery(SQL);
            if( huboexito == 0 ){
             throw new Exception("Error al agregar al"); }
        SQL.Dispose();
        }
        catch ( Exception ex ) {
         throw new Exception(ex.Message);
        }
    }
    public virtual void Update(Pago_CajeroCaja CajeroCaja) {
        try {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "CajeroCaja_id", DbType.Int32, CajeroCaja.CajeroCaja_id);
            db.AddInParameter(SQL, "Estado", DbType.Boolean, CajeroCaja.Estado);
            db.AddInParameter(SQL, "Caja_id", DbType.Int32, CajeroCaja.Caja_id);
            db.AddInParameter(SQL, "Persona_id", DbType.String, CajeroCaja.Persona_id);
            db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, CajeroCaja.registro_fecha_add);
            db.AddInParameter(SQL, "registro_user_add", DbType.String, CajeroCaja.registro_user_add);
            db.AddInParameter(SQL, "registro_pc_add", DbType.String, CajeroCaja.registro_pc_add);
            db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, CajeroCaja.registro_fecha_update);
            db.AddInParameter(SQL, "registro_user_update", DbType.String, CajeroCaja.registro_user_update);
            db.AddInParameter(SQL, "registro_pc_update", DbType.String, CajeroCaja.registro_pc_update);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
            int huboexito  = db.ExecuteNonQuery(SQL);
            if( huboexito == 0 ){
             throw new Exception("Error"); }
            }
        catch ( Exception ex ) {
         throw new Exception(ex.Message);
        }
    }


public virtual bool  DeleteByPrimaryKey(Int32 CajeroCaja_id) {
    try {
        DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
        db.AddInParameter(SQL, "CajeroCaja_id", DbType.Int32, CajeroCaja_id);
        db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);
        int huboexito  = db.ExecuteNonQuery(SQL);
        if( huboexito == 0 ){
            throw new Exception("Error"); }
        return true;
    }
    catch ( Exception ex ) {
        throw new Exception(ex.Message);
    }
}


public virtual bool DeleteAll() {
    try {
        DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
        db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 6);
        int huboexito  = db.ExecuteNonQuery(SQL);
        if( huboexito == 0 ){
            throw new Exception("Error"); }
        return true; }
    catch ( Exception ex ) {
        throw new Exception(ex.Message);
    }
}


}
}

