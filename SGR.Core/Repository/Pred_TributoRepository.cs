
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity.Model;
using SGR.Entity;

namespace SGR.Core.Repository
{
public  class Pred_TributoRepository
    {
        private const String nombreprocedimiento  ="_Pred_tributo";
        private const String NombreTabla  ="Pred_tributo";
        private Database db = DatabaseFactory.CreateDatabase();


    public  List<Pred_Tributo> listartodos(int anio) {
        try {
            var coleccion = new List<Pred_Tributo>();
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
            db.AddInParameter(SQL, "clai_anio", DbType.Int32, anio);
                using (var lector=  db.ExecuteReader(SQL)){
                while (lector.Read ()){
                    coleccion.Add(new Pred_Tributo
                    {
                        tributos_ID=lector.GetString(lector.GetOrdinal("tributos_ID")),
                        descripcion=lector.GetString(lector.GetOrdinal("descripcion")),
                        importe=lector.IsDBNull(lector.GetOrdinal("importe"))? default(decimal):lector.GetDecimal(lector.GetOrdinal("importe")),
                        activo=lector.GetBoolean (lector.GetOrdinal("activo")),
                        abrev=lector.IsDBNull(lector.GetOrdinal("abrev"))? default(String):lector.GetString(lector.GetOrdinal("abrev")),
                        tipo_tributo=lector.IsDBNull(lector.GetOrdinal("tipo_tributo"))? default(String):lector.GetString(lector.GetOrdinal("tipo_tributo")),
                        porce_uit=lector.IsDBNull(lector.GetOrdinal("porce_uit"))? default(decimal):lector.GetDecimal(lector.GetOrdinal("porce_uit")),
                        clai_codigo=lector.IsDBNull(lector.GetOrdinal("clai_codigo"))? default(String):lector.GetString(lector.GetOrdinal("clai_codigo")),
                        cod_contable=lector.IsDBNull(lector.GetOrdinal("cod_contable"))? default(String):lector.GetString(lector.GetOrdinal("cod_contable")),
                        are_codigo=lector.IsDBNull(lector.GetOrdinal("are_codigo"))? default(String):lector.GetString(lector.GetOrdinal("are_codigo")),
                        porce_area=lector.IsDBNull(lector.GetOrdinal("porce_area"))? default(decimal):lector.GetDecimal(lector.GetOrdinal("porce_area")),
                        fuente=lector.IsDBNull(lector.GetOrdinal("fuente"))? default(String):lector.GetString(lector.GetOrdinal("fuente")),
                        cobro_interes=lector.GetByte(lector.GetOrdinal("cobro_interes")),
                        tipo = lector.IsDBNull(lector.GetOrdinal("tipo"))? default (string):lector.GetString(lector.GetOrdinal("tipo")),
                        tipocl = lector.IsDBNull(lector.GetOrdinal("tipocl"))?default(string):lector.GetString(lector.GetOrdinal("tipocl")),
                        area = lector.IsDBNull(lector.GetOrdinal("area"))?default(string):lector.GetString(lector.GetOrdinal("area"))

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
    public  List<Pred_Tributo> Getcoleccion(string wheresql,string orderbysql, string anio) {
        int totalRecordCount  = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount,anio);
    }
    public virtual List<Pred_Tributo> Getcoleccion(string wheresql,string orderbysql,int startIndex,int length,int totalRecordCount,string anio) {
        try {
            var coleccion = new List<Pred_Tributo>();
            DbCommand SQL=db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                db.AddInParameter(SQL, "clai_anio", DbType.String, anio);
            using (var lector=  db.ExecuteReader(SQL)){
            while (lector.Read ()){
            coleccion.Add(new Pred_Tributo
            {
                tributos_ID=lector.GetString(lector.GetOrdinal("tributos_ID")),
                descripcion=lector.GetString(lector.GetOrdinal("descripcion")),
                importe=lector.IsDBNull(lector.GetOrdinal("importe"))? default(decimal):lector.GetDecimal(lector.GetOrdinal("importe")),
                activo=lector.GetBoolean (lector.GetOrdinal("activo")),
                abrev=lector.IsDBNull(lector.GetOrdinal("abrev"))? default(String):lector.GetString(lector.GetOrdinal("abrev")),
                tipo_tributo=lector.IsDBNull(lector.GetOrdinal("tipo_tributo"))? default(string):lector.GetString(lector.GetOrdinal("tipo_tributo")),
                porce_uit=lector.IsDBNull(lector.GetOrdinal("porce_uit"))? default(decimal):lector.GetDecimal(lector.GetOrdinal("porce_uit")),
                clai_codigo=lector.IsDBNull(lector.GetOrdinal("clai_codigo"))? default(String):lector.GetString(lector.GetOrdinal("clai_codigo")),
                cod_contable=lector.IsDBNull(lector.GetOrdinal("cod_contable"))? default(String):lector.GetString(lector.GetOrdinal("cod_contable")),
                are_codigo=lector.IsDBNull(lector.GetOrdinal("are_codigo"))? default(String):lector.GetString(lector.GetOrdinal("are_codigo")),
                porce_area=lector.IsDBNull(lector.GetOrdinal("porce_area"))? default(decimal):lector.GetDecimal(lector.GetOrdinal("porce_area")),
                fuente=lector.IsDBNull(lector.GetOrdinal("fuente"))? default(String):lector.GetString(lector.GetOrdinal("fuente")),
                cobro_interes=lector.GetByte(lector.GetOrdinal("cobro_interes")),
                tipo = lector.IsDBNull(lector.GetOrdinal("tipo")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo")),
                area = lector.IsDBNull(lector.GetOrdinal("area"))? default(string) : lector.GetString(lector.GetOrdinal("area")),
                tipocl = lector.IsDBNull(lector.GetOrdinal("tipocl")) ? default(string) : lector.GetString(lector.GetOrdinal("tipocl"))
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
    //public virtual List<Pred_Tributo> GetALL(){ 
    //    try {
    //        DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
    //        db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
    //        var coleccion= new List<Pred_Tributo>();
    //            using (var lector=  db.ExecuteReader(SQL)){
    //                while (lector.Read ()){
    //                    coleccion.Add (new Pred_Tributo
    //                    {
    //                        tributos_ID=lector.GetString(lector.GetOrdinal("tributos_ID")),
    //                        descripcion=lector.GetString(lector.GetOrdinal("descripcion"))
    //                        //importe=lector.IsDBNull(lector.GetOrdinal("importe"))? default(decimal):lector.GetDecimal(lector.GetOrdinal("importe")),
    //                        //activo=lector.GetBoolean (lector.GetOrdinal("activo")),
    //                        //abrev=lector.IsDBNull(lector.GetOrdinal("abrev"))? default(String):lector.GetString(lector.GetOrdinal("abrev")),
    //                        //tipo_tributo=lector.IsDBNull(lector.GetOrdinal("tipo_tributo"))? default(string):lector.GetString(lector.GetOrdinal("tipo_tributo")),
    //                        //porce_uit=lector.IsDBNull(lector.GetOrdinal("porce_uit"))? default(double):lector.GetDouble(lector.GetOrdinal("porce_uit")),
    //                        //clai_codigo=lector.IsDBNull(lector.GetOrdinal("clai_codigo"))? default(String):lector.GetString(lector.GetOrdinal("clai_codigo")),
    //                        //cod_contable=lector.IsDBNull(lector.GetOrdinal("cod_contable"))? default(String):lector.GetString(lector.GetOrdinal("cod_contable")),
    //                        //are_codigo=lector.IsDBNull(lector.GetOrdinal("are_codigo"))? default(String):lector.GetString(lector.GetOrdinal("are_codigo")),
    //                        //porce_area=lector.IsDBNull(lector.GetOrdinal("porce_area"))? default(decimal):lector.GetDecimal(lector.GetOrdinal("porce_area")),
    //                        //fuente=lector.IsDBNull(lector.GetOrdinal("fuente"))? default(String):lector.GetString(lector.GetOrdinal("fuente")),
    //                        //cobro_interes=lector.GetByte(lector.GetOrdinal("cobro_interes")),
    //                        //tipo = lector.IsDBNull(lector.GetOrdinal("tipo")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo")),

    //                        //tipocl = lector.IsDBNull(lector.GetOrdinal("tipocl")) ? default(string) : lector.GetString(lector.GetOrdinal("tipocl"))
    //                    });
    //                }
    //            }
    //            SQL.Dispose(); 
    //            return coleccion;
    //      }
    //        catch ( Exception ex ) {
    //            throw new Exception(ex.Message);
    //        }
    //}
    protected virtual string CreateGetCommand(string whereSql, string orderBySql) {
        string sql  = "select t.tributos_ID,t.descripcion,t.importe,t.activo,t.abrev,t.tipo_tributo,t.porce_uit,t.clai_codigo,t.cod_contable ,t.are_codigo,t.porce_area,t.fuente,t.cobro_interes,ta.descripcion as tipo,ci.clai_descripcion as tipocl, a.Are_Descripcion as area from Tributos t inner join tablas ta on (t.tipo_tributo = ta.valor) inner join Clasificador_Ingresos ci on (t.clai_codigo = ci.clai_codigo) inner join Area a on(t.are_codigo = a.Are_Codigo)";
            if ((whereSql != null) && (whereSql.Trim().Length > 0)) {
                sql += "where ta.dep_id = 1 and ci.clai_anio = @clai_anio and " + whereSql ; }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0)) {
                sql +=" ORDER BY " + orderBySql; }
        return sql;
    }
    public virtual void Insert(Pred_Tributo Pred_Tributo) {
        try  {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "tributos_ID", DbType.String, Pred_Tributo.tributos_ID);
            db.AddInParameter(SQL, "descripcion", DbType.String, Pred_Tributo.descripcion);
            db.AddInParameter(SQL, "importe", DbType.Decimal, Pred_Tributo.importe);
            db.AddInParameter(SQL, "activo", DbType.Boolean, Pred_Tributo.activo);
            db.AddInParameter(SQL, "abrev", DbType.String, Pred_Tributo.abrev);
            db.AddInParameter(SQL, "tipo_tributo", DbType.String, Pred_Tributo.tipo_tributo);
            db.AddInParameter(SQL, "porce_uit", DbType.Decimal, Pred_Tributo.porce_uit);
            db.AddInParameter(SQL, "clai_codigo", DbType.String, Pred_Tributo.clai_codigo);
            db.AddInParameter(SQL, "cod_contable", DbType.String, Pred_Tributo.cod_contable);
            db.AddInParameter(SQL, "are_codigo", DbType.String, Pred_Tributo.are_codigo);
            db.AddInParameter(SQL, "porce_area", DbType.Decimal, Pred_Tributo.porce_area);
            db.AddInParameter(SQL, "fuente", DbType.String, Pred_Tributo.fuente);
            db.AddInParameter(SQL, "cobro_interes", DbType.Byte, Pred_Tributo.cobro_interes);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
            int huboexito  = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
            SQL.Dispose();
        }
        catch ( Exception ex ) {
            throw new Exception(ex.Message);
        }
    }
    public virtual void Update(Pred_Tributo Pred_Tributo) {
        try {
                DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, Pred_Tributo.tributos_ID);
                db.AddInParameter(SQL, "descripcion", DbType.String, Pred_Tributo.descripcion);
                db.AddInParameter(SQL, "importe", DbType.Decimal, Pred_Tributo.importe);
                db.AddInParameter(SQL, "activo", DbType.Boolean, Pred_Tributo.activo);
                db.AddInParameter(SQL, "abrev", DbType.String, Pred_Tributo.abrev);
                db.AddInParameter(SQL, "tipo_tributo", DbType.String, Pred_Tributo.tipo_tributo);
                db.AddInParameter(SQL, "porce_uit", DbType.Double, Pred_Tributo.porce_uit);
                db.AddInParameter(SQL, "clai_codigo", DbType.String, Pred_Tributo.clai_codigo);
                db.AddInParameter(SQL, "cod_contable", DbType.String, Pred_Tributo.cod_contable);
                db.AddInParameter(SQL, "are_codigo", DbType.String, Pred_Tributo.are_codigo);
                db.AddInParameter(SQL, "porce_area", DbType.Decimal, Pred_Tributo.porce_area);
                db.AddInParameter(SQL, "fuente", DbType.String, Pred_Tributo.fuente);
                db.AddInParameter(SQL, "cobro_interes", DbType.Byte, Pred_Tributo.cobro_interes);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
            int huboexito  = db.ExecuteNonQuery(SQL);
            if( huboexito == 0 ){
                throw new Exception("Error"); }
        }
        catch ( Exception ex ) {
            throw new Exception(ex.Message);
        }
    }
    public virtual bool  DeleteByPrimaryKey(string codigo) {
        try {
            DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, codigo);
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
        public Int32 compararDescripcionModificar(string descripcion, string codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, codigo);
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
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Int32 compararCodigo(string codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, codigo);
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

        public List<Pred_Tributo> listarTributoCbo()
        {
            try
            {
                var coleccion = new List<Pred_Tributo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Tributo
                        {
                            tributos_ID = lector.GetString(lector.GetOrdinal("tributos_ID")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public List<Pred_Tributo> listarTributoParaExoneracion(String predio)
        {
            try
            {
                var coleccion = new List<Pred_Tributo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Tributo
                        {
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public List<Pred_Tributo> listarTributoTipo1y2(String anioIni,String anioFin, String mesIni, String mesFin)
        {
            try
            {
                var coleccion = new List<Pred_Tributo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anioIni", DbType.String, anioIni);
                db.AddInParameter(SQL, "anioFin", DbType.String, anioFin);
                db.AddInParameter(SQL, "mesIni", DbType.String, mesIni);
                db.AddInParameter(SQL, "mesFin", DbType.String, mesFin);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 13);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Tributo
                        {
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion")),
                            tributos_ID = lector.GetString(lector.GetOrdinal("tributos_ID"))
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
        public List<Liqu_TributosAfectos> listarTributoCbov2(string persona)
        {
            try
            {
                var coleccion = new List<Liqu_TributosAfectos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 14);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_TributosAfectos
                        {
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo"))
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
        public List<Pred_Tributo> listarTRibuto1y2Edit()
        {
            try
            {
                var coleccion = new List<Pred_Tributo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 15);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Tributo
                        {
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion")),
                            tributos_ID = lector.GetString(lector.GetOrdinal("tributos_ID")).Trim()
                           
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
        public List<Pred_Tributo> listarTributosFraccionamiento(Int32 fraccionamiento_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 16);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.Int32, fraccionamiento_ID);
                var coleccion = new List<Pred_Tributo>();
                using(var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Tributo
                        {
                            tributos_ID = lector.GetString(lector.GetOrdinal("tributos_ID")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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

