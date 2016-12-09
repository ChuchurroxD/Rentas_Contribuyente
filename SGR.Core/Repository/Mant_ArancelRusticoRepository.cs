using Microsoft.Practices.EnterpriseLibrary.Data;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SGR.Core.Repository
{
    public class Mant_ArancelRusticoRepository
    {
        private const String nombreProcedimiento = "_Mant_ArancelRustico";
        private const String Nombretabla = "ArancelRustico";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Mant_ArancelRustico> listarTodos(Int32 idPeriodo)
        {
            try
            {
                var coleccion = new List<Mant_ArancelRustico>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_ArancelRustico
                        {
                            ArancelRustico_id = lector.GetInt32(lector.GetOrdinal("ArancelRustico_id")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Categoria_Rustico = lector.IsDBNull(lector.GetOrdinal("Categoria_Rustico")) ? default(int) : lector.GetInt32(lector.GetOrdinal("Categoria_Rustico")),
                            Categoria_RusticoDescripcion = lector.IsDBNull(lector.GetOrdinal("Categoria_RusticoDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("Categoria_RusticoDescripcion")),
                            ValorRustico = lector.IsDBNull(lector.GetOrdinal("ValorRustico")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("ValorRustico")),
                            idGrupoRustico = lector.IsDBNull(lector.GetOrdinal("idGrupoRustico")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idGrupoRustico")),
                            GrupoRusticoDescripcion = lector.IsDBNull(lector.GetOrdinal("GrupoRusticoDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("GrupoRusticoDescripcion")),
                            activo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo")),
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

        public virtual int ExisteElementosPeriodoAnterior(int tipoconsulta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
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
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 16);
                int huboexito = db.ExecuteNonQuery(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Mant_ArancelRustico GetByPrimaryKey(Int32 ArancelRustico_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "ArancelRustico_id", DbType.Int32, ArancelRustico_id);
                var mant_Arancel = default(Mant_ArancelRustico);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        mant_Arancel = new Mant_ArancelRustico
                        {
                            ArancelRustico_id = lector.GetInt32(lector.GetOrdinal("ArancelRustico_id")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Categoria_Rustico = lector.IsDBNull(lector.GetOrdinal("Categoria_Rustico")) ? default(int) : lector.GetInt32(lector.GetOrdinal("Categoria_Rustico")),
                            Categoria_RusticoDescripcion = lector.IsDBNull(lector.GetOrdinal("Categoria_RusticoDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("Categoria_RusticoDescripcion")),
                            ValorRustico = lector.IsDBNull(lector.GetOrdinal("ValorRustico")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("ValorRustico")),
                            idGrupoRustico = lector.IsDBNull(lector.GetOrdinal("idGrupoRustico")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idGrupoRustico")),
                            GrupoRusticoDescripcion = lector.IsDBNull(lector.GetOrdinal("GrupoRusticoDescripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("GrupoRusticoDescripcion")),
                            activo = lector.IsDBNull(lector.GetOrdinal("activo")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("activo")),
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

        public virtual void Insert(Mant_ArancelRustico mant_ArancelRustico)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, mant_ArancelRustico.idPeriodo);
                db.AddInParameter(SQL, "ValorRustico", DbType.Decimal, mant_ArancelRustico.ValorRustico);
                db.AddInParameter(SQL, "idGrupoRustico", DbType.Int32, mant_ArancelRustico.idGrupoRustico);
                db.AddInParameter(SQL, "Categoria_Rustico", DbType.Int32, mant_ArancelRustico.Categoria_Rustico);
                db.AddInParameter(SQL, "activo", DbType.Boolean, mant_ArancelRustico.activo);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, mant_ArancelRustico.registro_user_add);
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

        public virtual void Update(Mant_ArancelRustico mant_ArancelRustico)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "ArancelRustico_id", DbType.Int32, mant_ArancelRustico.ArancelRustico_id);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, mant_ArancelRustico.idPeriodo);
                db.AddInParameter(SQL, "ValorRustico", DbType.Decimal, mant_ArancelRustico.ValorRustico);
                db.AddInParameter(SQL, "idGrupoRustico", DbType.Int32, mant_ArancelRustico.idGrupoRustico);
                db.AddInParameter(SQL, "Categoria_Rustico", DbType.Int32, mant_ArancelRustico.Categoria_Rustico);
                db.AddInParameter(SQL, "activo", DbType.Boolean, mant_ArancelRustico.activo);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, mant_ArancelRustico.registro_user_update);
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

        public virtual bool DeleteByPrimaryKey(int ArancelRustico_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "ArancelRustico_id", DbType.String, ArancelRustico_id);
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


        public List<Conf_Multitabla> llenarComboGrupoRustico()
        {
            try
            {
                var coleccion = new List<Conf_Multitabla>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 7);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Conf_Multitabla
                        {
                            Multc_cValor = lector.GetString(lector.GetOrdinal("valor")).Trim(),
                            Multc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
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
        public List<Conf_Multitabla> llenarComboCategoriaRustico()
        {
            try
            {
                var coleccion = new List<Conf_Multitabla>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Conf_Multitabla
                        {
                            Multc_cValor = lector.GetString(lector.GetOrdinal("valor")).Trim(),
                            Multc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
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
        public virtual decimal GetMontoRustico(String idGrupoRustico, int anio, string Categoria_Rustico)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "idGrupoRustico", DbType.String, idGrupoRustico);
                db.AddInParameter(SQL, "Categoria_Rustico", DbType.String, Categoria_Rustico);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 11);
                decimal total = decimal.Parse("0");
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total = lector.GetDecimal(lector.GetOrdinal("ValorRustico"));

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

        public Int32 compararRegistros(Int32 Categoria_Rustico, Int32 idGrupoRustico, Int32 idPeriodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
                db.AddInParameter(SQL, "Categoria_Rustico", DbType.Int32, Categoria_Rustico);
                db.AddInParameter(SQL, "idGrupoRustico", DbType.Int32, idGrupoRustico);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
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
        public Int32 compararRegistrosModificar(Int32 Categoria_Rustico, Int32 idGrupoRustico, Int32 idPeriodo, Int32 ArancelRustico_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 13);
                db.AddInParameter(SQL, "Categoria_Rustico", DbType.Int32, Categoria_Rustico);
                db.AddInParameter(SQL, "idGrupoRustico", DbType.Int32, idGrupoRustico);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                db.AddInParameter(SQL, "ArancelRustico_id", DbType.Int32, ArancelRustico_id);
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
    }
}
