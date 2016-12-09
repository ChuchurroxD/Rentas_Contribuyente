using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;

namespace SGR.Core.Repository
{
    public class Mant_ArancelRepository
    {
        private const String nombreprocedimiento = "_Mant_Arancel";
        private const String Nombretabla = "Arancel";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Mant_Arancel> listarTodos(int anio)
        {
            try
            {
                var coleccion = new List<Mant_Arancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Arancel
                        {
                            arancel_ID = lector.IsDBNull(lector.GetOrdinal("arancel_ID")) ? default (int) : lector.GetInt32(lector.GetOrdinal("arancel_ID")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("anio")),
                            arancel_monto = lector.IsDBNull(lector.GetOrdinal("arancel_monto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("arancel_monto")),
                            junta_via_ID = lector.IsDBNull(lector.GetOrdinal("junta_via_ID")) ? default(int) : lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                            cuadra = lector.IsDBNull(lector.GetOrdinal("cuadra")) ? default(int) : lector.GetInt32(lector.GetOrdinal("cuadra")),
                            lado = lector.IsDBNull(lector.GetOrdinal("lado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("lado")),
                            activo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo")),
                            Sector_id = lector.IsDBNull(lector.GetOrdinal("Sector_id")) ? default(int) : lector.GetInt32(lector.GetOrdinal("Sector_id")),
                            SectorDescripcion = lector.IsDBNull(lector.GetOrdinal("SectorDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("SectorDescripcion")),
                            Via_id = lector.IsDBNull(lector.GetOrdinal("Via_id")) ? default(string) : lector.GetString(lector.GetOrdinal("Via_id")),
                            ViaDescripcion = lector.IsDBNull(lector.GetOrdinal("ViaDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("ViaDescripcion")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
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
        public List<Mant_Arancel> listarTodosPorsector(int Sector_id, int anio)
        {
            try
            {
                var coleccion = new List<Mant_Arancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "Sector_id", DbType.Int32, Sector_id);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Arancel
                        {
                            arancel_ID = lector.IsDBNull(lector.GetOrdinal("arancel_ID")) ? default(int) : lector.GetInt32(lector.GetOrdinal("arancel_ID")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("anio")),
                            arancel_monto = lector.IsDBNull(lector.GetOrdinal("arancel_monto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("arancel_monto")),
                            junta_via_ID = lector.IsDBNull(lector.GetOrdinal("junta_via_ID")) ? default(int) : lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                            cuadra = lector.IsDBNull(lector.GetOrdinal("cuadra")) ? default(int) : lector.GetInt32(lector.GetOrdinal("cuadra")),
                            lado = lector.IsDBNull(lector.GetOrdinal("lado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("lado")),
                            activo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo")),
                            Sector_id = lector.IsDBNull(lector.GetOrdinal("Sector_id")) ? default(int) : lector.GetInt32(lector.GetOrdinal("Sector_id")),
                            SectorDescripcion = lector.IsDBNull(lector.GetOrdinal("SectorDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("SectorDescripcion")),
                            Via_id = lector.IsDBNull(lector.GetOrdinal("Via_id")) ? default(string) : lector.GetString(lector.GetOrdinal("Via_id")),
                            ViaDescripcion = lector.IsDBNull(lector.GetOrdinal("ViaDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("ViaDescripcion")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
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

        public List<Mant_Arancel> listarTodosPorVia(String Via_id, int anio)
        {
            try
            {
                var coleccion = new List<Mant_Arancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "Via_id", DbType.String, Via_id);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Arancel
                        {
                            arancel_ID = lector.IsDBNull(lector.GetOrdinal("arancel_ID")) ? default(int) : lector.GetInt32(lector.GetOrdinal("arancel_ID")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("anio")),
                            arancel_monto = lector.IsDBNull(lector.GetOrdinal("arancel_monto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("arancel_monto")),
                            junta_via_ID = lector.IsDBNull(lector.GetOrdinal("junta_via_ID")) ? default(int) : lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                            cuadra = lector.IsDBNull(lector.GetOrdinal("cuadra")) ? default(int) : lector.GetInt32(lector.GetOrdinal("cuadra")),
                            lado = lector.IsDBNull(lector.GetOrdinal("lado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("lado")),
                            activo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo")),
                            Sector_id = lector.IsDBNull(lector.GetOrdinal("Sector_id")) ? default(int) : lector.GetInt32(lector.GetOrdinal("Sector_id")),
                            SectorDescripcion = lector.IsDBNull(lector.GetOrdinal("SectorDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("SectorDescripcion")),
                            Via_id = lector.IsDBNull(lector.GetOrdinal("Via_id")) ? default(string) : lector.GetString(lector.GetOrdinal("Via_id")),
                            ViaDescripcion = lector.IsDBNull(lector.GetOrdinal("ViaDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("ViaDescripcion")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
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

        public List<Mant_Arancel> listarTodosPorSectorAñoVia(int anio, int Sector_id,String Via_id)
        {
            try
            {
                var coleccion = new List<Mant_Arancel>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "Sector_id", DbType.Int32, Sector_id);
                db.AddInParameter(SQL, "Via_id", DbType.String, Via_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Arancel
                        {
                            arancel_ID = lector.IsDBNull(lector.GetOrdinal("arancel_ID")) ? default(int) : lector.GetInt32(lector.GetOrdinal("arancel_ID")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("anio")),
                            arancel_monto = lector.IsDBNull(lector.GetOrdinal("arancel_monto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("arancel_monto")),
                            junta_via_ID = lector.IsDBNull(lector.GetOrdinal("junta_via_ID")) ? default(int) : lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                            cuadra = lector.IsDBNull(lector.GetOrdinal("cuadra")) ? default(int) : lector.GetInt32(lector.GetOrdinal("cuadra")),
                            lado = lector.IsDBNull(lector.GetOrdinal("lado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("lado")),
                            activo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo")),
                            Sector_id = lector.IsDBNull(lector.GetOrdinal("Sector_id")) ? default(int) : lector.GetInt32(lector.GetOrdinal("Sector_id")),
                            SectorDescripcion = lector.IsDBNull(lector.GetOrdinal("SectorDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("SectorDescripcion")),
                            Via_id = lector.IsDBNull(lector.GetOrdinal("Via_id")) ? default(string) : lector.GetString(lector.GetOrdinal("Via_id")),
                            ViaDescripcion = lector.IsDBNull(lector.GetOrdinal("ViaDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("ViaDescripcion")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
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
            string sql = "Select a.arancel_ID,a.anio,a.arancel_monto,a.cuadra,a.lado,a.activo,a.junta_via_ID,s.Sector_id,s.Descripcion as SectorDescripcion,v.Via_id,v.Descripcion as ViaDescripcion,a.registro_fecha_add,a.registro_pc_add,a.registro_user_add,a.registro_fecha_update,a.registro_user_update,a.registro_pc_update From Arancel a inner join Junta_Via jv on jv.junta_via_ID = a.junta_via_ID inner join Sector s on s.Sector_id= jv.junta_ID inner join Via v on v.Via_id = jv.via_ID";
            if ((whereSql != null) && (whereSql.Trim().Length > 0))
            {
                sql += " where a.anio=@anio and" + whereSql;
            }
            if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
            {
                sql += " ORDER BY " + orderBySql;
            }
            return sql;
        }

        public virtual Mant_Arancel GetByPrimaryKey(Int32 arancelID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "arancelID", DbType.Int32, arancelID);
                var mant_Arancel = default(Mant_Arancel);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        mant_Arancel = new Mant_Arancel
                        {
                            arancel_ID = lector.IsDBNull(lector.GetOrdinal("arancel_ID")) ? default(int) : lector.GetInt32(lector.GetOrdinal("arancel_ID")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("anio")),
                            arancel_monto = lector.IsDBNull(lector.GetOrdinal("arancel_monto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("arancel_monto")),
                            junta_via_ID = lector.IsDBNull(lector.GetOrdinal("junta_via_ID")) ? default(int) : lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                            lado = lector.IsDBNull(lector.GetOrdinal("lado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("lado")),
                            cuadra = lector.IsDBNull(lector.GetOrdinal("cuadra")) ? default(int) : lector.GetInt32(lector.GetOrdinal("cuadra")),
                            activo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo")),
                            Sector_id = lector.IsDBNull(lector.GetOrdinal("Sector_id")) ? default(int) : lector.GetInt32(lector.GetOrdinal("Sector_id")),
                            SectorDescripcion = lector.IsDBNull(lector.GetOrdinal("SectorDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("SectorDescripcion")),
                            Via_id = lector.IsDBNull(lector.GetOrdinal("Via_id")) ? default(string) : lector.GetString(lector.GetOrdinal("Via_id")),
                            ViaDescripcion = lector.IsDBNull(lector.GetOrdinal("ViaDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("ViaDescripcion")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_pc_update"))
                        };
                    }
                }
                SQL.Dispose();
                return mant_Arancel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Insert(Mant_Arancel mant_Arancel)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, mant_Arancel.anio);
                db.AddInParameter(SQL, "arancel_monto", DbType.Decimal, mant_Arancel.arancel_monto);
                db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, mant_Arancel.junta_via_ID);
                db.AddInParameter(SQL, "cuadra", DbType.Int32, mant_Arancel.cuadra);
                db.AddInParameter(SQL, "lado", DbType.Int32, mant_Arancel.lado);
                db.AddInParameter(SQL, "activo", DbType.Boolean, mant_Arancel.activo);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, mant_Arancel.registro_user_add);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar");
                }
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mant_Arancel mant_Arancel)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "arancel_ID", DbType.Int32, mant_Arancel.arancel_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, mant_Arancel.anio);
                db.AddInParameter(SQL, "arancel_monto", DbType.Decimal, mant_Arancel.arancel_monto);
                db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, mant_Arancel.junta_via_ID);
                db.AddInParameter(SQL, "lado", DbType.Int32, mant_Arancel.lado);
                db.AddInParameter(SQL, "cuadra", DbType.Int32, mant_Arancel.cuadra);
                db.AddInParameter(SQL, "activo", DbType.Boolean, mant_Arancel.activo);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, mant_Arancel.registro_user_update);
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

        public virtual bool DeleteByPrimaryKey(int arancel_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "arancel_ID", DbType.String, arancel_ID);
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

        public virtual decimal GetMonto(int idjuntavia, int anio,int lado,int cuadra)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "junta_via_ID", DbType.String, idjuntavia);
                db.AddInParameter(SQL, "anio", DbType.String, anio);
                db.AddInParameter(SQL, "lado", DbType.String, lado);
                db.AddInParameter(SQL, "cuadra", DbType.String, cuadra);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 7);
                decimal total = decimal.Parse("0");
                total = Convert.ToDecimal(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Int32 GetExisteArancelNuevo(Int32 anio, Int32 cuadra, Int32 lado, Int32 sector_id, String via_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "cuadra", DbType.Int32, cuadra);
                db.AddInParameter(SQL, "lado", DbType.Int32, lado);
                db.AddInParameter(SQL, "Sector_id", DbType.Int32, sector_id);
                db.AddInParameter(SQL, "Via_id", DbType.String, via_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);

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

        public virtual Int32 GetExisteArancelModificar(Int32 anio, Int32 cuadra, Int32 lado, Int32 sector_id, String via_id, Int32 arancel_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "arancel_id", DbType.Int32, arancel_id);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "cuadra", DbType.Int32, cuadra);
                db.AddInParameter(SQL, "lado", DbType.Int32, lado);
                db.AddInParameter(SQL, "Sector_id", DbType.Int32, sector_id);
                db.AddInParameter(SQL, "Via_id", DbType.String, via_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
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

        public virtual int ExisteElementosPeriodoAnterior(int tipoconsulta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, tipoconsulta);
                int CANTIDAD = Convert.ToInt32(db.ExecuteScalar(SQL));

                SQL.Dispose();
                return CANTIDAD;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void CopiarElementosPeriodoAnterior(string usser)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 13);
                int huboexito = db.ExecuteNonQuery(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
