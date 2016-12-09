 
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
        public  class Pago_CajaRepository{
            private const String nombreprocedimiento  ="_Pago_Caja";
            private const String NombreTabla  ="Pago_Caja";
            private Database db = DatabaseFactory.CreateDatabase();
    public  List<Pago_Caja>listartodos() {
        try {
            var coleccion = new List<Pago_Caja>();
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
            using (var lector=  db.ExecuteReader(SQL)){
                while (lector.Read ()){
                    coleccion.Add(new Pago_Caja
                    {
                        Caja_id=lector.GetInt32(lector.GetOrdinal("Caja_id")),
                        Descripcion=lector.GetString(lector.GetOrdinal("Descripcion")),
                        idOficina=lector.GetInt32(lector.GetOrdinal("idOficina")),
                        Estado=lector.GetBoolean (lector.GetOrdinal("Estado")),
                        registro_fecha_add=lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                        registro_user_add=lector.GetString(lector.GetOrdinal("registro_user_add")),
                        registro_pc_add=lector.GetString(lector.GetOrdinal("registro_pc_add")),
                        registro_fecha_update=lector.IsDBNull(lector.GetOrdinal("registro_fecha_update"))? default(DateTime):lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                        registro_user_update=lector.IsDBNull(lector.GetOrdinal("registro_user_update"))? default(string):lector.GetString(lector.GetOrdinal("registro_user_update")),
                        registro_pc_update=lector.IsDBNull(lector.GetOrdinal("registro_pc_update"))? default(String):lector.GetString(lector.GetOrdinal("registro_pc_update")),
                        tipo = lector.IsDBNull(lector.GetOrdinal("tipo"))? default(String) : lector.GetString(lector.GetOrdinal("tipo"))
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
        
    public  List<Pago_Caja> Getcoleccion(string wheresql,string orderbysql) {
        int totalRecordCount  = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }
    public virtual List<Pago_Caja> Getcoleccion(string wheresql,string orderbysql,int startIndex,int length,int totalRecordCount) {
        try {
            var coleccion = new List<Pago_Caja>();
            DbCommand SQL=db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector=  db.ExecuteReader(SQL)){
                while (lector.Read ()){
                    coleccion.Add(new Pago_Caja
                    {
                        Caja_id=lector.GetInt32(lector.GetOrdinal("Caja_id")),
                        Descripcion=lector.GetString(lector.GetOrdinal("Descripcion")),
                        idOficina=lector.GetInt32(lector.GetOrdinal("idOficina")),
                        Estado=lector.GetBoolean (lector.GetOrdinal("Estado")),
                        registro_fecha_add=lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                        registro_user_add=lector.GetString(lector.GetOrdinal("registro_user_add")),
                        registro_pc_add=lector.GetString(lector.GetOrdinal("registro_pc_add")),
                        registro_fecha_update=lector.IsDBNull(lector.GetOrdinal("registro_fecha_update"))? default(DateTime):lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                        registro_user_update=lector.IsDBNull(lector.GetOrdinal("registro_user_update"))? default(string):lector.GetString(lector.GetOrdinal("registro_user_update")),
                        registro_pc_update=lector.IsDBNull(lector.GetOrdinal("registro_pc_update"))? default(String):lector.GetString(lector.GetOrdinal("registro_pc_update")),
                        tipo = lector.IsDBNull(lector.GetOrdinal("tipo"))? default(String) : lector.GetString(lector.GetOrdinal("tipo"))
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
    public virtual List<Pago_Caja> GetAllDescripcion(){ 
        try {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
            var coleccion=new List<Pago_Caja>();
            using (var lector=  db.ExecuteReader(SQL)){
                while (lector.Read ()){
                    coleccion.Add( new Pago_Caja
                    {
                        Caja_id = lector.GetInt32(lector.GetOrdinal("Caja_id")),
                        Descripcion = lector.GetString(lector.GetOrdinal("Descripcion"))
                        //idOficina=lector.GetInt32(lector.GetOrdinal("idOficina")),
                        //Estado=lector.GetBoolean (lector.GetOrdinal("Estado")),
                        //registro_fecha_add=lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                        //registro_user_add=lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                        //registro_pc_add=lector.GetString(lector.GetOrdinal("registro_pc_add")),
                        //registro_fecha_update=lector.IsDBNull(lector.GetOrdinal("registro_fecha_update"))? default(DateTime):lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                        //registro_user_update=lector.IsDBNull(lector.GetOrdinal("registro_user_update"))? default(Int32):lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                        //registro_pc_update=lector.IsDBNull(lector.GetOrdinal("registro_pc_update"))? default(String):lector.GetString(lector.GetOrdinal("registro_pc_update"))
                    } );
                }
            }
            SQL.Dispose(); 
            return coleccion;
        }
        catch ( Exception ex ) {
            throw new Exception(ex.Message);
        }
    }
    protected virtual string CreateGetCommand(string whereSql, string orderBySql) {
        string sql  = "Select c.[Caja_id],c.[Descripcion],c.[idOficina],c.[Estado],c.[registro_fecha_add],c.[registro_user_add],c.[registro_pc_add],c.[registro_fecha_update],c.[registro_user_update],c.[registro_pc_update],o.Descripcion as tipo from Caja c inner join oficina o on c.idOficina = o.[oficina_id] ";
            if ((whereSql != null) && (whereSql.Trim().Length > 0)) {
                sql += " WHERE " + whereSql ; }
                if ((orderBySql != null) && (orderBySql.Trim().Length > 0)) {
                    sql +=" ORDER BY " + orderBySql; }
        return sql;
    }

    public virtual void Insert(Pago_Caja Caja) {
        try  {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Descripcion", DbType.String, Caja.Descripcion);
            db.AddInParameter(SQL, "idOficina", DbType.Int32, Caja.idOficina);
            db.AddInParameter(SQL, "Estado", DbType.Boolean, Caja.Estado);
            db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Caja.registro_fecha_add);
            db.AddInParameter(SQL, "registro_user_add", DbType.String, Caja.registro_user_add);
            db.AddInParameter(SQL, "registro_pc_add", DbType.String, Caja.registro_pc_add);
            //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Caja.registro_fecha_update);
            db.AddInParameter(SQL, "registro_user_update", DbType.String, Caja.registro_user_update);
            db.AddInParameter(SQL, "registro_pc_update", DbType.String, Caja.registro_pc_update);
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
    public virtual void Update(Pago_Caja Caja) {
        try {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Caja_id", DbType.Int32, Caja.Caja_id);
            db.AddInParameter(SQL, "Descripcion", DbType.String, Caja.Descripcion);
            db.AddInParameter(SQL, "idOficina", DbType.Int32, Caja.idOficina);
            db.AddInParameter(SQL, "Estado", DbType.Boolean, Caja.Estado);
            db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Caja.registro_fecha_add);
            db.AddInParameter(SQL, "registro_user_add", DbType.String, Caja.registro_user_add);
            db.AddInParameter(SQL, "registro_pc_add", DbType.String, Caja.registro_pc_add);
            db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Caja.registro_fecha_update);
            db.AddInParameter(SQL, "registro_user_update", DbType.String, Caja.registro_user_update);
            db.AddInParameter(SQL, "registro_pc_update", DbType.String, Caja.registro_pc_update);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
            int huboexito  = db.ExecuteNonQuery(SQL);
            if( huboexito == 0 ){
                throw new Exception("Error"); }
            }
        catch ( Exception ex ) {
            throw new Exception(ex.Message);
        }
    }
        
    public virtual void  DeleteByPrimaryKey(int codigo) {
        try {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);
                db.AddInParameter(SQL, "Caja_id", DbType.Int32, codigo);
            int huboexito  = db.ExecuteNonQuery(SQL);
            if( huboexito == 0 ){
                throw new Exception("Error"); };
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
        public Int32 compararDescripcion(string descripcion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 7);
                db.AddInParameter(SQL, "descripcion", DbType.String, descripcion);
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
        public Int32 compararDescripcionModificar(string descripcion, Int32 codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "descripcion", DbType.String, descripcion);
                db.AddInParameter(SQL, "Caja_id", DbType.Int32, codigo);
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
        public List<Pago_Caja> llenarcomboCaja()
        {
            try
            {
                var coleccion = new List<Pago_Caja>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 9);
                using(var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Caja
                        {
                            Descripcion = lector.GetString(lector.GetOrdinal("Descripcion")),
                            Caja_id = lector.GetInt32(lector.GetOrdinal("Caja_id"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Caja> llenarComboCajaporCajero(string persona_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "cajero_id", DbType.String, persona_id);
                var coleccion = new List<Pago_Caja>();
                using(var lector= db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Caja
                        {
                            Descripcion = lector.GetString(lector.GetOrdinal("Descripcion")),
                            Caja_id = lector.GetInt32(lector.GetOrdinal("Caja_id"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual List<Pago_Caja> llenarCombov2()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                var coleccion = new List<Pago_Caja>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Caja
                        {
                            Caja_id = lector.GetInt32(lector.GetOrdinal("Caja_id")),
                            Descripcion = lector.GetString(lector.GetOrdinal("Descripcion"))                        });
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
}

