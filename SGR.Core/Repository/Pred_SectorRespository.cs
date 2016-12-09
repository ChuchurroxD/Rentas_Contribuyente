using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using System.Data.Common;
using System.Data;
using SGR.Entity.Model;

namespace SGR.Core.Repository
{
    public class Pred_SectorRespository
    {
        private const string nombreProcedimiento = "_Pred_Sector";
        private const string nombreTabla = "Pred_Sector";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Pred_Sector> listarTodos()
        {
            try
            {
                var coleccion = new List<Pred_Sector>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Sector
                        {
                            sector_id = lector.GetInt32(lector.GetOrdinal("Sector_id")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")).TrimStart(),
                            tipo_Junta = lector.IsDBNull(lector.GetOrdinal("Tipo_Junta")) ? default(String) : lector.GetString(lector.GetOrdinal("Tipo_Junta")),
                            barrido = lector.IsDBNull(lector.GetOrdinal("Barrido")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Barrido")),
                            recojo = lector.IsDBNull(lector.GetOrdinal("Recojo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Recojo")),
                            jardin = lector.IsDBNull(lector.GetOrdinal("Jardin")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Jardin")),
                            serenazgo = lector.IsDBNull(lector.GetOrdinal("Serenezgo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Serenezgo")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            sysFecha = lector.IsDBNull(lector.GetOrdinal("sysFecha")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("sysFecha")),
                            sysUser = lector.IsDBNull(lector.GetOrdinal("sysUser")) ? default(String) : lector.GetString(lector.GetOrdinal("sysUser")),
                            descripcionTIpo = lector.IsDBNull(lector.GetOrdinal("tipo")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo"))

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
        public virtual List<Pred_Sector> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
        {
            try
            {
                var coleccion = new List<Pred_Sector>();
                DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Sector
                        {
                            sector_id = lector.GetInt32(lector.GetOrdinal("Sector_id")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            tipo_Junta = lector.IsDBNull(lector.GetOrdinal("Tipo_Junta")) ? default(String) : lector.GetString(lector.GetOrdinal("Tipo_Junta")),
                            barrido = lector.IsDBNull(lector.GetOrdinal("barrido")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Barrido")),
                            recojo = lector.IsDBNull(lector.GetOrdinal("recojo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Recojo")),
                            jardin = lector.IsDBNull(lector.GetOrdinal("jardin")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Jardin")),
                            serenazgo = lector.IsDBNull(lector.GetOrdinal("Serenezgo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Serenezgo")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            sysFecha = lector.IsDBNull(lector.GetOrdinal("sysFecha")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("sysFecha")),
                            sysUser = lector.IsDBNull(lector.GetOrdinal("sysUser")) ? default(String) : lector.GetString(lector.GetOrdinal("sysUser")),
                            descripcionTIpo = lector.IsDBNull(lector.GetOrdinal("tipo"))? default(String) : lector.GetString(lector.GetOrdinal("tipo"))
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


        public virtual Pred_Sector GetByPrimaryKey(Int32 sector_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "Seguc_iCodigo", DbType.Int32, sector_id);
                var Pred_Sector = default(Pred_Sector);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Pred_Sector = new Pred_Sector
                        {
                            sector_id = lector.GetInt32(lector.GetOrdinal("Sector_id")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            tipo_Junta = lector.IsDBNull(lector.GetOrdinal("Tipo_Junta")) ? default(String) : lector.GetString(lector.GetOrdinal("Tipo_Junta")),
                            barrido = lector.IsDBNull(lector.GetOrdinal("barrido")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Barrido")),
                            recojo = lector.IsDBNull(lector.GetOrdinal("recojo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Recojo")),
                            jardin = lector.IsDBNull(lector.GetOrdinal("jardin")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Jardin")),
                            serenazgo = lector.IsDBNull(lector.GetOrdinal("serenazgo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Serenezgo")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            sysFecha = lector.IsDBNull(lector.GetOrdinal("sysFecha")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("sysFecha")),
                            sysUser = lector.IsDBNull(lector.GetOrdinal("sysUser")) ? default(String) : lector.GetString(lector.GetOrdinal("sysUser")),
                            descripcionTIpo = lector.IsDBNull(lector.GetOrdinal("tipo")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo"))
                        };
                    }
                }
                SQL.Dispose();
                return Pred_Sector;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        protected virtual string CreateGetCommand(string whereSql, string orderBySql)
        {
            string sql = "Select s.Sector_id ,ltrim(rtrim(s.descripcion))as descripcion ,s.Tipo_Junta,s.barrido,s.recojo,s.jardin,s.serenezgo,s.estado,s.sysFecha,s.sysUser,p.descripcion as tipo from Sector s inner join tablas p on(s.Tipo_Junta=p.valor)";
            if ((whereSql != null) && (whereSql.Trim().Length > 0))
            {
                sql += " where p.dep_id=15 and " + whereSql;
            }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
            {
                sql += " ORDER BY " + orderBySql;
            }
            return sql;
        }

        public virtual void Insert(Pred_Sector Pred_Sector)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Descripcion", DbType.String, Pred_Sector.descripcion);
                db.AddInParameter(SQL, "Tipo_Junta", DbType.String, Pred_Sector.tipo_Junta);
                db.AddInParameter(SQL, "Barrido", DbType.Boolean, Pred_Sector.barrido);
                db.AddInParameter(SQL, "Recojo", DbType.Boolean, Pred_Sector.recojo);
                db.AddInParameter(SQL, "Jardin", DbType.Boolean, Pred_Sector.jardin);
                db.AddInParameter(SQL, "Serenazgo", DbType.Boolean, Pred_Sector.serenazgo);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_Sector.estado);
                db.AddInParameter(SQL, "sysUser", DbType.String, Pred_Sector.sysUser);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Pred_Sector.registro_user_add);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Pred_Sector.registro_user_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                //var numerogenerado = (int)db.GetParameterValue(SQL, "Seguc_iCodigo");
                //var numerogenerado = (int)SQL.Parameters[2].Value;
                SQL.Dispose();
                //return numerogenerado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Pred_Sector Pred_Sector)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Sector_id", DbType.Int32, Pred_Sector.sector_id);
                db.AddInParameter(SQL, "Descripcion", DbType.String, Pred_Sector.descripcion);
                db.AddInParameter(SQL, "Tipo_Junta", DbType.String, Pred_Sector.tipo_Junta);
                db.AddInParameter(SQL, "Barrido", DbType.Boolean, Pred_Sector.barrido);
                db.AddInParameter(SQL, "Recojo", DbType.Boolean, Pred_Sector.recojo);
                db.AddInParameter(SQL, "Jardin", DbType.Boolean, Pred_Sector.jardin);
                db.AddInParameter(SQL, "Serenazgo", DbType.Boolean, Pred_Sector.serenazgo);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_Sector.estado);
                db.AddInParameter(SQL, "sysUser", DbType.String, Pred_Sector.sysUser);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Pred_Sector.registro_user_update);
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


        public virtual bool DeleteByPrimaryKey(Int32 sector_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Sector_id", DbType.Int32, sector_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);
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
        public List<Pred_TipoSector> llenarTipoSector()
        {
            try
            {
                var coleccion = new List<Pred_TipoSector>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_TipoSector
                        {
                            valor = lector.GetString(lector.GetOrdinal("valor")).Trim(),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
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
        //combo de sectores
                
            public List<Pred_Sector> listarSectorCboValidos()
        {
            try
            {
                var coleccion = new List<Pred_Sector>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Sector
                        {
                            sector_id = lector.GetInt32(lector.GetOrdinal("codigo")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
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
        public List<Pred_Sector> listarSectorCbo()
        {
            try
            {
                var coleccion = new List<Pred_Sector>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Sector
                        {
                            sector_id = lector.GetInt32(lector.GetOrdinal("codigo")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
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
        //NUNCA MODIFICAR
        public List<Pred_Sector> listarSectorCbo(int oficina)
        {
            try
            {
                var coleccion = new List<Pred_Sector>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 13);
                db.AddInParameter(SQL, "oficina", DbType.Int32, oficina);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Sector
                        {
                            sector_id = lector.GetInt32(lector.GetOrdinal("codigo")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
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
        public Int32 compararDescripcion(string descripcion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
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
        public Int32 compararDescripcionModificar(string descripcion, Int32 codigo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "descripcion", DbType.String, descripcion);
                db.AddInParameter(SQL, "sector_id", DbType.Int32, codigo);
                Int32 total = 0;
                using(var lector = db.ExecuteReader(SQL))
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
    }
}
