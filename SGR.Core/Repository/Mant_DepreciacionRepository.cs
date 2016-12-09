
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace SGR.Core.Repository
    {
        public  class Mant_DepreciacionRepository{
            private const String nombreprocedimiento  ="_Mant_Depreciacion";
            private const String NombreTabla  ="Mant_Depreciacion";
            private Database db = DatabaseFactory.CreateDatabase();

        public  List<Mant_Depreciacion>listartodos() {
            try {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                    using (var lector=  db.ExecuteReader(SQL)){
                        while (lector.Read ()){
                            coleccion.Add(new Mant_Depreciacion
                            {
                                depreciacion_ID=lector.GetInt32(lector.GetOrdinal("depreciacion_ID")),
                                anio=lector.GetInt16(lector.GetOrdinal("anio")),
                                clasificacion=lector.GetInt16(lector.GetOrdinal("clasificacion")),
                                antiguedad=lector.GetString(lector.GetOrdinal("antiguedad_")).TrimEnd(),
                                material=lector.GetInt16(lector.GetOrdinal("material")),
                                estado_piso=lector.IsDBNull(lector.GetOrdinal("estado_piso"))? default(Int16):lector.GetInt16(lector.GetOrdinal("estado_piso")),
                                porcentaje=lector.GetDecimal(lector.GetOrdinal("porcentaje")),
                                estado=lector.GetBoolean (lector.GetOrdinal("estado")),
                                clasificacion_descripcion = lector.IsDBNull(lector.GetOrdinal("clasi"))? default(string):lector.GetString(lector.GetOrdinal("clasi")),
                                material_descripcion = lector.IsDBNull(lector.GetOrdinal("mate"))? default(string): lector.GetString(lector.GetOrdinal("mate")),
                                estadoPiso_descripcion = lector.IsDBNull(lector.GetOrdinal("esta"))? default(string): lector.GetString(lector.GetOrdinal("esta")),
                                antiguedad_descripcion = lector.IsDBNull(lector.GetOrdinal("anti"))? default(string): lector.GetString(lector.GetOrdinal("anti")),
                                anti_final = lector.GetInt16(lector.GetOrdinal("antiguedadinicial")),
                                anti_inicial = lector.GetInt16(lector.GetOrdinal("antiguedadfinal"))
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

        public List<Mant_Depreciacion> listartodoClasificacion(Int32 periodo, Int32 clasificacion)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo);
                db.AddInParameter(SQL, "clasificacion", DbType.Int32, clasificacion);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Depreciacion
                        {
                            depreciacion_ID = lector.GetInt32(lector.GetOrdinal("depreciacion_ID")),
                            anio = lector.GetInt16(lector.GetOrdinal("anio")),
                            clasificacion = lector.GetInt16(lector.GetOrdinal("clasificacion")),
                            antiguedad = lector.GetString(lector.GetOrdinal("antiguedad_")).TrimEnd(),
                            material = lector.GetInt16(lector.GetOrdinal("material")),
                            estado_piso = lector.IsDBNull(lector.GetOrdinal("estado_piso")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("estado_piso")),
                            porcentaje = lector.GetDecimal(lector.GetOrdinal("porcentaje")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            clasificacion_descripcion = lector.IsDBNull(lector.GetOrdinal("clasi")) ? default(string) : lector.GetString(lector.GetOrdinal("clasi")),
                            material_descripcion = lector.IsDBNull(lector.GetOrdinal("mate")) ? default(string) : lector.GetString(lector.GetOrdinal("mate")),
                            estadoPiso_descripcion = lector.IsDBNull(lector.GetOrdinal("esta")) ? default(string) : lector.GetString(lector.GetOrdinal("esta")),
                            antiguedad_descripcion = lector.IsDBNull(lector.GetOrdinal("anti")) ? default(string) : lector.GetString(lector.GetOrdinal("anti")),
                            anti_final = lector.GetInt16(lector.GetOrdinal("antiguedadinicial")),
                            anti_inicial = lector.GetInt16(lector.GetOrdinal("antiguedadfinal"))
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


        public  List<Mant_Depreciacion> Getcoleccion(string wheresql,string orderbysql) {
            int totalRecordCount  = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }
        public virtual List<Mant_Depreciacion> Getcoleccion(string wheresql,string orderbysql,int startIndex,int length,int totalRecordCount) {
            try {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL=db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                    using (var lector=  db.ExecuteReader(SQL)){
                        while (lector.Read ()){
                            coleccion.Add(new Mant_Depreciacion
                            {
                                depreciacion_ID=lector.GetInt32(lector.GetOrdinal("depreciacion_ID")),
                                anio=lector.GetInt16(lector.GetOrdinal("anio")),
                                clasificacion=lector.GetInt16(lector.GetOrdinal("clasificacion")),
                                antiguedad=lector.GetString(lector.GetOrdinal("antiguedad_")).TrimEnd(),
                                material=lector.GetInt16(lector.GetOrdinal("material")),
                                estado_piso=lector.IsDBNull(lector.GetOrdinal("estado_piso"))? default(Int16):lector.GetInt16(lector.GetOrdinal("estado_piso")),
                                porcentaje=lector.GetDecimal(lector.GetOrdinal("porcentaje")),
                                estado=lector.GetBoolean (lector.GetOrdinal("estado")),
                                clasificacion_descripcion = lector.IsDBNull(lector.GetOrdinal("clasi")) ? default(string) : lector.GetString(lector.GetOrdinal("clasi")),
                                material_descripcion = lector.IsDBNull(lector.GetOrdinal("mate")) ? default(string) : lector.GetString(lector.GetOrdinal("mate")),
                                estadoPiso_descripcion = lector.IsDBNull(lector.GetOrdinal("esta")) ? default(string) : lector.GetString(lector.GetOrdinal("esta")),
                                antiguedad_descripcion = lector.IsDBNull(lector.GetOrdinal("anti")) ? default(string) : lector.GetString(lector.GetOrdinal("anti")),
                                anti_final = lector.GetInt16(lector.GetOrdinal("antiguedadinicial")),
                                anti_inicial = lector.GetInt16(lector.GetOrdinal("antiguedadfinal"))

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
        public virtual Mant_Depreciacion GetByPrimaryKey(Int32 depreciacion_ID){ 
            try {
                DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL , "depreciacion_ID", DbType.Int32, depreciacion_ID);
                    var Depreciacion=default(Mant_Depreciacion);
                        using (var lector=  db.ExecuteReader(SQL)){
                            while (lector.Read ()){
                            Depreciacion=new Mant_Depreciacion
                            {
                                depreciacion_ID=lector.GetInt32(lector.GetOrdinal("depreciacion_ID")),
                                anio=lector.GetInt16(lector.GetOrdinal("anio")),
                                clasificacion=lector.GetInt16(lector.GetOrdinal("clasificacion")),
                                antiguedad=lector.GetString(lector.GetOrdinal("antiguedad")).TrimEnd(),
                                material=lector.GetInt16(lector.GetOrdinal("material")),
                                estado_piso=lector.IsDBNull(lector.GetOrdinal("estado_piso"))? default(Int16):lector.GetInt16(lector.GetOrdinal("estado_piso")),
                                porcentaje=lector.GetDecimal(lector.GetOrdinal("porcentaje")),
                                estado=lector.GetBoolean (lector.GetOrdinal("estado"))

                                };
                            }
                        }
                SQL.Dispose(); 
                return Depreciacion;
            }
            catch ( Exception ex ) {
                throw new Exception(ex.Message);
            }
        }
        protected virtual string CreateGetCommand(string whereSql, string orderBySql) {
            string sql  = "Select d.[depreciacion_ID],d.anio,d.clasificacion,d.antiguedad_,d.material,d.estado_piso,d.porcentaje,d.estado,t1.descripcion as clasi, t2.descripcion as mate, t3.descripcion as esta, t4.descripcion as anti, d.antiguedadinicial,d.antiguedadfinal " + 
                            "from Depreciacion d inner join tablas t1 on (d.clasificacion = t1.valor)" +
                            "inner join tablas t2 on (d.material = t2.valor)"+
                            "inner join tablas t3 on (d.estado_piso = t3.valor)"+
                            "inner join tablas t4 on(d.antiguedad_ = t4.valor)";
                if ((whereSql != null) && (whereSql.Trim().Length > 0)) {
                    sql += "where t1.dep_id = 20 and t2.dep_id=21 and t3.dep_id = 22 and t4.dep_id = 71 and " + whereSql ; }
                if ((orderBySql != null) && (orderBySql.Trim().Length > 0)) {
                    sql +=" ORDER BY " + orderBySql; }
            return sql;
        }
        public virtual void Insert(Mant_Depreciacion Depreciacion) {
            try  {
                DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int16, Depreciacion.anio);
                db.AddInParameter(SQL, "clasificacion", DbType.Int16, Depreciacion.clasificacion);
                db.AddInParameter(SQL, "antiguedad", DbType.String, Depreciacion.antiguedad);
                db.AddInParameter(SQL, "material", DbType.Int16, Depreciacion.material);
                db.AddInParameter(SQL, "estado_piso", DbType.Int16, Depreciacion.estado_piso);
                db.AddInParameter(SQL, "porcentaje", DbType.Decimal, Depreciacion.porcentaje);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Depreciacion.estado);
                db.AddInParameter(SQL, "antiguedadinicial", DbType.Int16, Depreciacion.anti_inicial);
                db.AddInParameter(SQL, "antiguedadfinal", DbType.Int16, Depreciacion.anti_final);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Depreciacion.registro_user_add);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Depreciacion.registro_user_update);
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
        public virtual void Update(Mant_Depreciacion Depreciacion) {
            try {
                DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "depreciacion_ID", DbType.Int32, Depreciacion.depreciacion_ID);
                db.AddInParameter(SQL, "anio", DbType.Int16, Depreciacion.anio);
                db.AddInParameter(SQL, "clasificacion", DbType.Int16, Depreciacion.clasificacion);
                db.AddInParameter(SQL, "antiguedad", DbType.String, Depreciacion.antiguedad);
                db.AddInParameter(SQL, "material", DbType.Int16, Depreciacion.material);
                db.AddInParameter(SQL, "estado_piso", DbType.Int16, Depreciacion.estado_piso);
                db.AddInParameter(SQL, "porcentaje", DbType.Decimal, Depreciacion.porcentaje);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Depreciacion.estado);
                db.AddInParameter(SQL, "antiguedadinicial", DbType.Int16, Depreciacion.anti_inicial);
                db.AddInParameter(SQL, "antiguedadfinal", DbType.Int16, Depreciacion.anti_final);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Depreciacion.registro_user_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
                int huboexito  = db.ExecuteNonQuery(SQL);
                if( huboexito == 0 ){
                    throw new Exception("Error"); }
            }
            catch ( Exception ex ) {
                throw new Exception(ex.Message);
            }
        }

        public virtual void  DeleteByPrimaryKey(Int32 depreciacion_ID) {
            try {
                DbCommand SQL=db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "depreciacion_ID", DbType.Int32, depreciacion_ID);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);
                int huboexito  = db.ExecuteNonQuery(SQL);
                if( huboexito == 0 ){
                 throw new Exception("Error"); }
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
        public List<Mant_Depreciacion> listarErroresDepreciacion(Int32 periodo)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                String a = "";
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        //a = "";
                        //a = lector.GetString(lector.GetOrdinal("Material"));
                        //if(String.Compare(a.Trim(),"0")!=0)
                        //{
                            coleccion.Add(new Mant_Depreciacion
                            {
                                clasificacion_descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcion"))
                            });
                        //}
                        
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
        public int compararDepreciaciones(Mant_Depreciacion Mant_Depreciacion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int16, Mant_Depreciacion.anio);
                db.AddInParameter(SQL, "clasificacion", DbType.Int16, Mant_Depreciacion.clasificacion);
                db.AddInParameter(SQL, "antiguedad", DbType.Int16, Mant_Depreciacion.antiguedad);
                db.AddInParameter(SQL, "material", DbType.Int16, Mant_Depreciacion.material);
                db.AddInParameter(SQL, "estado_piso", DbType.Int16, Mant_Depreciacion.estado_piso);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 9);
                Int32 total = 0;
                using(var lector = db.ExecuteReader(SQL))
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
        public int compararDepreciacionesModificar(Mant_Depreciacion Mant_Depreciacion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int16, Mant_Depreciacion.anio);
                db.AddInParameter(SQL, "clasificacion", DbType.Int16, Mant_Depreciacion.clasificacion);
                db.AddInParameter(SQL, "antiguedad", DbType.Int16, Mant_Depreciacion.antiguedad);
                db.AddInParameter(SQL, "material", DbType.Int16, Mant_Depreciacion.material);
                db.AddInParameter(SQL, "estado_piso", DbType.Int16, Mant_Depreciacion.estado_piso);
                db.AddInParameter(SQL, "depreciacion_ID", DbType.Int16, Mant_Depreciacion.depreciacion_ID);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 10);
                Int32 total = 0;
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

        public List<Mant_Depreciacion> listarDepreciaciones(Int16 anio, Int16 clasificacion)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int16, anio);
                db.AddInParameter(SQL, "clasificacion", DbType.Int16, clasificacion);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Depreciacion
                        {
                            depreciacion_ID = lector.GetInt32(lector.GetOrdinal("depreciacion_ID")),
                            anio = lector.GetInt16(lector.GetOrdinal("anio")),
                            clasificacion = lector.GetInt16(lector.GetOrdinal("clasificacion")),
                            antiguedad = lector.GetString(lector.GetOrdinal("antiguedad_")).TrimEnd(),
                            material = lector.GetInt16(lector.GetOrdinal("material")),
                            estado_piso = lector.IsDBNull(lector.GetOrdinal("estado_piso")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("estado_piso")),
                            porcentaje = lector.GetDecimal(lector.GetOrdinal("porcentaje")),
                            antiguedad_descripcion = lector.IsDBNull(lector.GetOrdinal("anti")) ? default(string) : lector.GetString(lector.GetOrdinal("anti")),
                            clasificacion_descripcion = lector.IsDBNull(lector.GetOrdinal("clasi")) ? default(string) : lector.GetString(lector.GetOrdinal("clasi")),
                            material_descripcion = lector.IsDBNull(lector.GetOrdinal("mate")) ? default(string) : lector.GetString(lector.GetOrdinal("mate")),
                            muyBueno = lector.IsDBNull(lector.GetOrdinal("MUY BUENO")) ? default(string) : lector.GetString(lector.GetOrdinal("MUY BUENO")),
                            bueno = lector.IsDBNull(lector.GetOrdinal("BUENO")) ? default(string) : lector.GetString(lector.GetOrdinal("BUENO")),
                            regular = lector.IsDBNull(lector.GetOrdinal("REGULAR")) ? default(string) : lector.GetString(lector.GetOrdinal("REGULAR")),
                            malo = lector.IsDBNull(lector.GetOrdinal("MALO")) ? default(string) : lector.GetString(lector.GetOrdinal("MALO")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            //estadoPiso_descripcion = lector.IsDBNull(lector.GetOrdinal("esta")) ? default(string) : lector.GetString(lector.GetOrdinal("esta")),
                            anti_final = lector.GetInt16(lector.GetOrdinal("antiguedadinicial")),
                            anti_inicial = lector.GetInt16(lector.GetOrdinal("antiguedadfinal"))
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

        public List<Mant_Depreciacion> listarTodasDepreciaciones(Int16 anio)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int16, anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 13);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Depreciacion
                        {
                            depreciacion_ID = lector.GetInt32(lector.GetOrdinal("depreciacion_ID")),
                            anio = lector.GetInt16(lector.GetOrdinal("anio")),
                            clasificacion = lector.GetInt16(lector.GetOrdinal("clasificacion")),
                            antiguedad = lector.GetString(lector.GetOrdinal("antiguedad_")).TrimEnd(),
                            material = lector.GetInt16(lector.GetOrdinal("material")),
                            estado_piso = lector.IsDBNull(lector.GetOrdinal("estado_piso")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("estado_piso")),
                            porcentaje = lector.GetDecimal(lector.GetOrdinal("porcentaje")),
                            antiguedad_descripcion = lector.IsDBNull(lector.GetOrdinal("anti")) ? default(string) : lector.GetString(lector.GetOrdinal("anti")),
                            clasificacion_descripcion = lector.IsDBNull(lector.GetOrdinal("clasi")) ? default(string) : lector.GetString(lector.GetOrdinal("clasi")),
                            material_descripcion = lector.IsDBNull(lector.GetOrdinal("mate")) ? default(string) : lector.GetString(lector.GetOrdinal("mate")),
                            muyBueno = lector.IsDBNull(lector.GetOrdinal("MUY BUENO")) ? default(string) : lector.GetString(lector.GetOrdinal("MUY BUENO")),
                            bueno = lector.IsDBNull(lector.GetOrdinal("BUENO")) ? default(string) : lector.GetString(lector.GetOrdinal("BUENO")),
                            regular = lector.IsDBNull(lector.GetOrdinal("REGULAR")) ? default(string) : lector.GetString(lector.GetOrdinal("REGULAR")),
                            malo = lector.IsDBNull(lector.GetOrdinal("MALO")) ? default(string) : lector.GetString(lector.GetOrdinal("MALO")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            //estadoPiso_descripcion = lector.IsDBNull(lector.GetOrdinal("esta")) ? default(string) : lector.GetString(lector.GetOrdinal("esta")),
                            anti_final = lector.GetInt16(lector.GetOrdinal("antiguedadinicial")),
                            anti_inicial = lector.GetInt16(lector.GetOrdinal("antiguedadfinal"))
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

