
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity;

namespace SGR.Core.Repository
{
    public  class Pago_OficinaRepository
    {

        private const String nombreprocedimiento  ="_Pago_Oficina";
        private const String NombreTabla  ="Oficina";
        private Database db = DatabaseFactory.CreateDatabase();


    public  List<Pago_Oficina>listartodos() {
        try {
            var coleccion = new List<Pago_Oficina>();
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
            using (var lector=  db.ExecuteReader(SQL)){
                 while (lector.Read ()){
                    coleccion.Add(new Pago_Oficina
                    {
                    oficina_id=lector.GetInt32(lector.GetOrdinal("oficina_id")),
                    Descripcion=lector.IsDBNull(lector.GetOrdinal("Descripcion"))? default(String):lector.GetString(lector.GetOrdinal("Descripcion")),
                    Estado = lector.GetBoolean(lector.GetOrdinal("estado"))
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


        public List<Pago_Oficina> listarxrol(string rol_id)
        {
            try
            {
                var coleccion = new List<Pago_Oficina>();
                DbCommand SQL = db.GetSqlStringCommand ("SELECT  dbo.Oficina.oficina_id, dbo.Oficina.Descripcion,"+
                    "dbo.Oficina.Estado FROM  dbo.Rol_oficina INNER JOIN   dbo.Oficina ON "+
                    " dbo.Rol_oficina.oficina_id = dbo.Oficina.oficina_id where Rol_oficina.rol_id = @rol_id"+
                    " union select 0, ' Seleccione Un Oficina', '0'");
                db.AddInParameter(SQL, "rol_id", DbType.String , rol_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Oficina
                        {
                            oficina_id = lector.GetInt32(lector.GetOrdinal("oficina_id")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("estado"))
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





        public  List<Pago_Oficina> Getcoleccion(string wheresql,string orderbysql) {
int totalRecordCount  = -1;
return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
}


public virtual List<Pago_Oficina> Getcoleccion(string wheresql,string orderbysql,int startIndex,int length,int totalRecordCount) {
        try {
        var coleccion = new List<Pago_Oficina>();
        DbCommand SQL=db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
        using (var lector=  db.ExecuteReader(SQL)){
         while (lector.Read ()){
        coleccion.Add(new Pago_Oficina
        {
        oficina_id=lector.GetInt32(lector.GetOrdinal("oficina_id")),
        Descripcion=lector.IsDBNull(lector.GetOrdinal("Descripcion"))? default(String):lector.GetString(lector.GetOrdinal("Descripcion")),
            Estado = lector.GetBoolean(lector.GetOrdinal("estado"))

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


public virtual Pago_Oficina GetByPrimaryKey(Int32 oficina_id){ 
try {
DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
db.AddInParameter(SQL , "oficina_id", DbType.Int32, oficina_id);
var Oficina=default(Pago_Oficina);
using (var lector=  db.ExecuteReader(SQL)){
 while (lector.Read ()){
Oficina=new Pago_Oficina
{
oficina_id=lector.GetInt32(lector.GetOrdinal("oficina_id")),
Descripcion=lector.IsDBNull(lector.GetOrdinal("Descripcion"))? default(String):lector.GetString(lector.GetOrdinal("Descripcion")),
Estado= lector.GetBoolean(lector.GetOrdinal("estado")),

};
}
}
SQL.Dispose(); 
return Oficina;
}
catch ( Exception ex ) {
 throw new Exception(ex.Message);
}
}



protected virtual string CreateGetCommand(string whereSql, string orderBySql) {
 string sql  = "SELECT * FROM [dbo].[Oficina]";
 if ((whereSql != null) && (whereSql.Trim().Length > 0)) {
sql += " WHERE " + whereSql ; }
if ((orderBySql != null) && (orderBySql.Trim().Length > 0)) {
 sql +=" ORDER BY " + orderBySql; }
return sql;
}







public virtual bool  DeleteByPrimaryKey(Int32 oficina_id) {
    try {
        DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
        db.AddInParameter(SQL, "oficina_id", DbType.Int32, oficina_id);
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
        public virtual Int32 GetExisteDescripcionNuevo(String descripcion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
                db.AddInParameter(SQL, "descripcion", DbType.String, descripcion);
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
        public virtual Int32 GetExisteDescripcionModificar(Int32 oficina_id, String descripcion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
                db.AddInParameter(SQL, "oficina_id", DbType.Int32, oficina_id);
                db.AddInParameter(SQL, "descripcion", DbType.String, descripcion);
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
        public virtual int Insert(Pago_Oficina pago_Oficina)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Descripcion", DbType.String, pago_Oficina.Descripcion);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, pago_Oficina.Estado);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, pago_Oficina.registro_user_add);
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


        public virtual void Update(Pago_Oficina pago_Oficina)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

                db.AddInParameter(SQL, "oficina_id", DbType.Int64, pago_Oficina.oficina_id);
                db.AddInParameter(SQL, "Descripcion", DbType.String, pago_Oficina.Descripcion);
                db.AddInParameter(SQL, "Estado", DbType.Boolean, pago_Oficina.Estado);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, pago_Oficina.registro_user_add);
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
        public List<Pago_Oficina> llenarOficina()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 3);
                var coleccion = new List<Pago_Oficina>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Oficina
                        {
                            oficina_id = lector.GetInt32(lector.GetOrdinal("oficina_id")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion"))
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
          }
        public List<Pago_Oficina> listarComboOficina()
        {
            try
            {
                var coleccion = new List<Pago_Oficina>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Oficina
                        {
                            oficina_id = lector.GetInt32(lector.GetOrdinal("oficina_id")),
                            Descripcion = lector.GetString(lector.GetOrdinal("Descripcion"))
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
        public List<Pago_Oficina> listarComboOficinaCajero(int oficina)
        {
            try
            {
                var coleccion = new List<Pago_Oficina>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                db.AddInParameter(SQL, "oficina_ID", DbType.Int32, oficina);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Oficina
                        {
                            oficina_id = lector.GetInt32(lector.GetOrdinal("oficina_id")),
                            Descripcion = lector.GetString(lector.GetOrdinal("Descripcion"))
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

        public List<Pago_Oficina> listarActivos()
        {
            try
            {
                var coleccion = new List<Pago_Oficina>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Oficina
                        {
                            oficina_id = lector.GetInt32(lector.GetOrdinal("oficina_id")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            Estado = lector.GetBoolean(lector.GetOrdinal("estado"))
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
}

