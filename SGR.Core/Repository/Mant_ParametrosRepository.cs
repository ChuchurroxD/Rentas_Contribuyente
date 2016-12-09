 
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
    public  class Mant_ParametrosRepository{
        private const String nombreprocedimiento  ="_Mant_Parametros";
        private const String NombreTabla  ="parametros";
        private Database db = DatabaseFactory.CreateDatabase();
        
    public  List<Mant_Parametros> listartodos(Int32 anio) {
        try {
            var coleccion = new List<Mant_Parametros>();
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
            db.AddInParameter(SQL, "anio", DbType.Int32, anio);
            using (var lector=  db.ExecuteReader(SQL)){
                 while (lector.Read ()){
                coleccion.Add(new Mant_Parametros
                {
                    parametros_ID=lector.GetInt32(lector.GetOrdinal("parametros_ID")),
                    codigo=lector.IsDBNull(lector.GetOrdinal("codigo"))? default(Int32):lector.GetInt32(lector.GetOrdinal("codigo")),
                    anio=lector.IsDBNull(lector.GetOrdinal("anio"))? default(Int32):lector.GetInt32(lector.GetOrdinal("anio")),
                    descripcion=lector.IsDBNull(lector.GetOrdinal("descripcion"))? default(String):lector.GetString(lector.GetOrdinal("descripcion")),
                    valor=lector.IsDBNull(lector.GetOrdinal("valor"))? default(Decimal):lector.GetDecimal(lector.GetOrdinal("valor")),
                    valor1=lector.IsDBNull(lector.GetOrdinal("valor1"))? default(Int32):lector.GetInt32(lector.GetOrdinal("valor1")),
                    estado=lector.IsDBNull(lector.GetOrdinal("estado"))? default(Boolean):lector.GetBoolean (lector.GetOrdinal("estado")),
                    registro_fecha_add=lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                    registro_user_add=lector.GetString(lector.GetOrdinal("registro_user_add")),
                    registro_pc_add=lector.GetString(lector.GetOrdinal("registro_pc_add")),
                    registro_fecha_update=lector.IsDBNull(lector.GetOrdinal("registro_fecha_update"))? default(DateTime):lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                    registro_user_update=lector.IsDBNull(lector.GetOrdinal("registro_user_update"))? default(string):lector.GetString(lector.GetOrdinal("registro_user_update")),
                    registro_pc_update=lector.IsDBNull(lector.GetOrdinal("registro_pc_update"))? default(String):lector.GetString(lector.GetOrdinal("registro_pc_update"))

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
    public  List<Mant_Parametros> Getcoleccion(string wheresql,string orderbysql,Int32 anio) {
        int totalRecordCount  = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount,anio);
    }
    public virtual List<Mant_Parametros> Getcoleccion(string wheresql,string orderbysql,int startIndex,int length,int totalRecordCount,Int32 anio) {
        try {
            var coleccion = new List<Mant_Parametros>();
            DbCommand SQL=db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
            using (var lector=  db.ExecuteReader(SQL)){
                 while (lector.Read ()){
                    coleccion.Add(new Mant_Parametros
                    {
                        parametros_ID=lector.GetInt32(lector.GetOrdinal("parametros_ID")),
                        codigo=lector.IsDBNull(lector.GetOrdinal("codigo"))? default(Int32):lector.GetInt32(lector.GetOrdinal("codigo")),
                        anio=lector.IsDBNull(lector.GetOrdinal("anio"))? default(Int32):lector.GetInt32(lector.GetOrdinal("anio")),
                        descripcion=lector.IsDBNull(lector.GetOrdinal("descripcion"))? default(String):lector.GetString(lector.GetOrdinal("descripcion")),
                        valor=lector.IsDBNull(lector.GetOrdinal("valor"))? default(decimal):lector.GetDecimal(lector.GetOrdinal("valor")),
                        valor1=lector.IsDBNull(lector.GetOrdinal("valor1"))? default(Int32):lector.GetInt32(lector.GetOrdinal("valor1")),
                        estado=lector.IsDBNull(lector.GetOrdinal("estado"))? default(Boolean):lector.GetBoolean (lector.GetOrdinal("estado")),
                        registro_fecha_add=lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                        registro_user_add=lector.GetString(lector.GetOrdinal("registro_user_add")),
                        registro_pc_add=lector.GetString(lector.GetOrdinal("registro_pc_add")),
                        registro_fecha_update=lector.IsDBNull(lector.GetOrdinal("registro_fecha_update"))? default(DateTime):lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                        registro_user_update=lector.IsDBNull(lector.GetOrdinal("registro_user_update"))? default(string):lector.GetString(lector.GetOrdinal("registro_user_update")),
                        registro_pc_update=lector.IsDBNull(lector.GetOrdinal("registro_pc_update"))? default(String):lector.GetString(lector.GetOrdinal("registro_pc_update"))

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
    public virtual Mant_Parametros GetByPrimaryKey(Int32 parametros_ID){ 
        try {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
            db.AddInParameter(SQL , "parametros_ID", DbType.Int32, parametros_ID);
            var parametros=default(Mant_Parametros);
            using (var lector=  db.ExecuteReader(SQL)){
                while (lector.Read ()){
                parametros=new Mant_Parametros
                {
                    parametros_ID=lector.GetInt32(lector.GetOrdinal("parametros_ID")),
                    codigo=lector.IsDBNull(lector.GetOrdinal("codigo"))? default(Int32):lector.GetInt32(lector.GetOrdinal("codigo")),
                    anio=lector.IsDBNull(lector.GetOrdinal("anio"))? default(Int32):lector.GetInt32(lector.GetOrdinal("anio")),
                    descripcion=lector.IsDBNull(lector.GetOrdinal("descripcion"))? default(String):lector.GetString(lector.GetOrdinal("descripcion")),
                    valor=lector.IsDBNull(lector.GetOrdinal("valor"))? default(decimal):lector.GetDecimal(lector.GetOrdinal("valor")),
                    valor1=lector.IsDBNull(lector.GetOrdinal("valor1"))? default(Int32):lector.GetInt32(lector.GetOrdinal("valor1")),
                    estado=lector.IsDBNull(lector.GetOrdinal("estado"))? default(Boolean):lector.GetBoolean (lector.GetOrdinal("estado")),
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
        return parametros;
        }
        catch ( Exception ex ) {
         throw new Exception(ex.Message);
        }
    }



    protected virtual string CreateGetCommand(string whereSql, string orderBySql) {
            string sql = "Select parametros_ID,codigo,anio,descripcion,valor,valor1,estado," +
                         "registro_fecha_add,registro_user_add,registro_pc_add," +
                        "registro_fecha_update,registro_user_update,registro_pc_update " +
                        "from parametros";
        if ((whereSql != null) && (whereSql.Trim().Length > 0)) {
            sql += " where anio = @anio and "+ whereSql ; }
        if ((orderBySql != null) && (orderBySql.Trim().Length > 0)) {
            sql += " ORDER BY codigo" + orderBySql; }
    return sql;
    }

    public virtual void Insert(Mant_Parametros parametros) {
        try  {                
            DbCommand SQL1=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL1, "anio", DbType.Int32, parametros.anio);
            db.AddInParameter(SQL1, "descripcion", DbType.String, parametros.descripcion);
            db.AddInParameter(SQL1, "valor", DbType.Decimal, parametros.valor);
            db.AddInParameter(SQL1, "valor1", DbType.Int32, parametros.valor1);
            db.AddInParameter(SQL1, "estado", DbType.Boolean, parametros.estado);
            db.AddInParameter(SQL1, "registro_fecha_add", DbType.DateTime, parametros.registro_fecha_add);
            db.AddInParameter(SQL1, "registro_user_add", DbType.String, parametros.registro_user_add);
            db.AddInParameter(SQL1, "registro_pc_add", DbType.String, parametros.registro_pc_add);
                db.AddInParameter(SQL1, "TipoConsulta", DbType.Byte, 4);
            int huboexito  = db.ExecuteNonQuery(SQL1);
            if( huboexito == 0 ){
             throw new Exception("Error al agregar al"); }
        SQL1.Dispose();
        }
        catch ( Exception ex ) {
         throw new Exception(ex.Message);
        }
    }
    public void insertarv2(Mant_Parametros Mant_Parametros)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "codigo", DbType.Int32, Mant_Parametros.codigo);
                db.AddInParameter(SQL, "anio", DbType.Int32, Mant_Parametros.anio);
                db.AddInParameter(SQL, "descripcion", DbType.String, Mant_Parametros.descripcion);
                db.AddInParameter(SQL, "valor", DbType.Decimal, Mant_Parametros.valor);
                db.AddInParameter(SQL, "valor1", DbType.Int32, Mant_Parametros.valor1);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Mant_Parametros.estado);
                db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Mant_Parametros.registro_fecha_add);
                db.AddInParameter(SQL, "registro_pc_add", DbType.String, Mant_Parametros.registro_pc_add);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Mant_Parametros.registro_user_add);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                SQL.Dispose();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    public virtual void Update(Mant_Parametros parametros) {
        try {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "parametros_ID", DbType.Int32, parametros.parametros_ID);
            db.AddInParameter(SQL, "codigo", DbType.Int32, parametros.codigo);
            db.AddInParameter(SQL, "anio", DbType.Int32, parametros.anio);
            db.AddInParameter(SQL, "descripcion", DbType.String, parametros.descripcion);
            db.AddInParameter(SQL, "valor", DbType.Decimal, parametros.valor);
            db.AddInParameter(SQL, "valor1", DbType.Int32, parametros.valor1);
            db.AddInParameter(SQL, "estado", DbType.Boolean, parametros.estado);
            db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, parametros.registro_fecha_add);
            db.AddInParameter(SQL, "registro_user_add", DbType.String, parametros.registro_user_add);
            db.AddInParameter(SQL, "registro_pc_add", DbType.String, parametros.registro_pc_add);
            db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, parametros.registro_fecha_update);
            db.AddInParameter(SQL, "registro_user_update", DbType.String, parametros.registro_user_update);
            db.AddInParameter(SQL, "registro_pc_update", DbType.String, parametros.registro_pc_update);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
            int huboexito  = db.ExecuteNonQuery(SQL);
            if( huboexito == 0 ){
             throw new Exception("Error"); }
        }
        catch ( Exception ex ) {
         throw new Exception(ex.Message);
        }
    }
        
    public virtual bool  DeleteByPrimaryKey(Int32 parametros_ID) {
        try {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "parametros_ID", DbType.Int32, parametros_ID);
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
    public List<Mant_Parametros> llenarComboDescripcion()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 7);
                var coleccion = new List<Mant_Parametros>();
                using(var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Parametros
                        {
                            codigo = lector.GetInt32(lector.GetOrdinal("codigo")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public Int32 compararDescripcion(string descripcion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "descripcion", DbType.String, descripcion);
                int resultado = 0;
                using(var lector = db.ExecuteReader(SQL))
                {
                    if (lector.Read())
                    {
                        resultado = lector.GetInt32(lector.GetOrdinal("total"));
                    }
                }
                SQL.Dispose();
                return resultado;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_Periodo> llenarcomboporDescripcion(Int32 codigo)
        {
            try
            {
                var coleccion = new List<Mant_Periodo>();
                DbCommand sql = db.GetStoredProcCommand("_Mant_Periodo");
                db.AddInParameter(sql, "Tipoconsulta", DbType.String, 11);
                db.AddInParameter(sql, "codigo", DbType.Int32, codigo);
                using (var lector = db.ExecuteReader(sql))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Periodo
                        {
                            Peric_canio = lector.GetInt32(lector.GetOrdinal("año"))
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
        public virtual Int32 totalParametroxAnioxCodigo(int anio,int codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "anio", DbType.String, anio);
                db.AddInParameter(SQL, "codigo", DbType.String, codigo);
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
    }
}

