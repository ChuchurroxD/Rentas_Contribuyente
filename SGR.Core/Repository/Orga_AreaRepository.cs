using System;
using System.Collections.Generic;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;


    public class Orga_AreaRepository
    {
        private const String nombreprocedimiento = "_Orga_Area";
        private const String NombreTabla = "Area";
        private Database db = DatabaseFactory.CreateDatabase();


        public List<Orga_Area> listartodos()
        {
            try
            {
                var coleccion = new List<Orga_Area>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Orga_Area
                        {
                            Areac_vCodigo = lector.GetString(lector.GetOrdinal("Are_Codigo")),
                            Areac_vDescripcion = lector.IsDBNull(lector.GetOrdinal("Are_Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Are_Descripcion")),
                            Areac_vProy = lector.IsDBNull(lector.GetOrdinal("Are_proy")) ? default(String) : lector.GetString(lector.GetOrdinal("Are_proy")),
                            Areac_iDep = lector.IsDBNull(lector.GetOrdinal("Are_dep")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Are_dep")),
                            Areac_vTipoArea = lector.IsDBNull(lector.GetOrdinal("tipo_area")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_area")),
                            Areac_vCodAnterior = lector.IsDBNull(lector.GetOrdinal("cod_anterior")) ? default(String) : lector.GetString(lector.GetOrdinal("cod_anterior")),
                            Areac_bactivo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("activo"))

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

    public List<Orga_Area> listarHijos(string padre)
    {
        try
        {
            var coleccion = new List<Orga_Area>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
            db.AddInParameter(SQL, "are_codigo", DbType.String, padre);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Orga_Area
                    {
                        Areac_vCodigo = lector.GetString(lector.GetOrdinal("Are_Codigo")),
                        Areac_vDescripcion = lector.IsDBNull(lector.GetOrdinal("Are_Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Are_Descripcion")),
                        Areac_vProy = lector.IsDBNull(lector.GetOrdinal("Are_proy")) ? default(String) : lector.GetString(lector.GetOrdinal("Are_proy")),
                        Areac_iDep = lector.IsDBNull(lector.GetOrdinal("Are_dep")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Are_dep")),
                        Areac_vTipoArea = lector.IsDBNull(lector.GetOrdinal("tipo_area")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_area")),
                        Areac_vCodAnterior = lector.IsDBNull(lector.GetOrdinal("cod_anterior")) ? default(String) : lector.GetString(lector.GetOrdinal("cod_anterior")),
                        Areac_bactivo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("activo"))

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

    public virtual Int32 ExistenciaDescripcion(String descripcion)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);//cambiar tipo
            
            //db.AddInParameter(SQL, "UnNec_iCodigo", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "Are_Descripcion", DbType.String, descripcion);
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

    public virtual Int32 ExistenciaCodigo(String descripcion)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);//cambiar tipo
            //db.AddInParameter(SQL, "UnNec_iCodigo", DbType.Int32, Multc_iCodigo);
            db.AddInParameter(SQL, "Are_Codigo", DbType.String, descripcion);
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

    public List<Orga_Area> Getcoleccion(string wheresql, string orderbysql)
        {
            int totalRecordCount = -1;
            return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
        }


        public virtual List<Orga_Area> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Orga_Area>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Orga_Area
                        {
                            Areac_vCodigo = lector.GetString(lector.GetOrdinal("Are_Codigo")),
                            Areac_vDescripcion = lector.IsDBNull(lector.GetOrdinal("Are_Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Are_Descripcion")),
                            Areac_vProy = lector.IsDBNull(lector.GetOrdinal("Are_proy")) ? default(String) : lector.GetString(lector.GetOrdinal("Are_proy")),
                            Areac_iDep = lector.IsDBNull(lector.GetOrdinal("Are_dep")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Are_dep")),
                            Areac_vTipoArea = lector.IsDBNull(lector.GetOrdinal("tipo_area")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_area")),
                            Areac_vCodAnterior = lector.IsDBNull(lector.GetOrdinal("cod_anterior")) ? default(String) : lector.GetString(lector.GetOrdinal("cod_anterior")),
                            Areac_bactivo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("activo"))

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


        public virtual Orga_Area GetByPrimaryKey(string codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "Are_Codigo", DbType.String, codigo);
            var Area = default(Orga_Area);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Area = new Orga_Area
                        {
                            Areac_vCodigo = lector.GetString(lector.GetOrdinal("Are_Codigo")),
                            Areac_vDescripcion = lector.IsDBNull(lector.GetOrdinal("Are_Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Are_Descripcion")),
                            Areac_vProy = lector.IsDBNull(lector.GetOrdinal("Are_proy")) ? default(String) : lector.GetString(lector.GetOrdinal("Are_proy")),
                            Areac_iDep = lector.IsDBNull(lector.GetOrdinal("Are_dep")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Are_dep")),
                            Areac_vTipoArea = lector.IsDBNull(lector.GetOrdinal("tipo_area")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_area")),
                            Areac_vCodAnterior = lector.IsDBNull(lector.GetOrdinal("cod_anterior")) ? default(String) : lector.GetString(lector.GetOrdinal("cod_anterior")),
                            Areac_bactivo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("activo"))

                        };
                    }
                }
                SQL.Dispose();
                return Area;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "SELECT * FROM [dbo].[Area]";
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

        public virtual int Insert(Orga_Area Area)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Are_Codigo", DbType.String, Area.Areac_vCodigo);
                db.AddInParameter(SQL, "Are_Descripcion", DbType.String, Area.Areac_vDescripcion);
                db.AddInParameter(SQL, "Are_proy", DbType.String, Area.Areac_vProy);
                db.AddInParameter(SQL, "Are_dep", DbType.Int32, Area.Areac_iDep);
                db.AddInParameter(SQL, "tipo_area", DbType.String, Area.Areac_vTipoArea);
                db.AddInParameter(SQL, "cod_anterior", DbType.String, Area.Areac_vCodAnterior);
                db.AddInParameter(SQL, "activo", DbType.Boolean, Area.Areac_bactivo);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Area.registro_user_add);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Area.registro_user_update);          
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                
                SQL.Dispose();
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Orga_Area Area,String codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Are_Codigo", DbType.String, Area.Areac_vCodigo);
                db.AddInParameter(SQL, "Are_Descripcion", DbType.String, Area.Areac_vDescripcion);
                db.AddInParameter(SQL, "Are_proy", DbType.String, Area.Areac_vProy);
                db.AddInParameter(SQL, "Are_dep", DbType.Int32, Area.Areac_iDep);
                db.AddInParameter(SQL, "tipo_area", DbType.String, Area.Areac_vTipoArea);
                db.AddInParameter(SQL, "cod_anterior", DbType.String, Area.Areac_vCodAnterior);
                db.AddInParameter(SQL, "activo", DbType.Boolean, Area.Areac_bactivo);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Area.registro_pc_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
                db.AddInParameter(SQL, "cod", DbType.String, codigo);

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

        public virtual bool DeleteByPrimaryKey(string codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 7);
                db.AddInParameter(SQL, "Are_Codigo", DbType.String, codigo);
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
    public List<Orga_Area> listarAreaReporte()
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL,"TipoConsulta", DbType.Byte, 11);
            var coleccion = new List<Orga_Area>();
            using(var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Orga_Area
                    {
                        Areac_vCodigo = lector.GetString(lector.GetOrdinal("Are_Codigo")),
                        Areac_vDescripcion = lector.GetString(lector.GetOrdinal("Are_Descripcion")),
                        Areac_iDep = Convert.ToInt32(lector.GetString(lector.GetOrdinal("dep_cod"))),
                        Areac_vDepDesc = lector.GetString(lector.GetOrdinal("desc_cod"))
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

    public List<Orga_Area> listarAreasActivas()
    {
        try
        {
            var coleccion = new List<Orga_Area>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Orga_Area
                    {
                        Areac_vCodigo = lector.GetString(lector.GetOrdinal("Are_Codigo")),
                        Areac_vDescripcion = lector.IsDBNull(lector.GetOrdinal("Are_Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Are_Descripcion")),
                        Areac_vProy = lector.IsDBNull(lector.GetOrdinal("Are_proy")) ? default(String) : lector.GetString(lector.GetOrdinal("Are_proy")),
                        Areac_iDep = lector.IsDBNull(lector.GetOrdinal("Are_dep")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Are_dep")),
                        Areac_vTipoArea = lector.IsDBNull(lector.GetOrdinal("tipo_area")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_area")),
                        Areac_vCodAnterior = lector.IsDBNull(lector.GetOrdinal("cod_anterior")) ? default(String) : lector.GetString(lector.GetOrdinal("cod_anterior")),
                        Areac_bactivo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("activo"))

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
