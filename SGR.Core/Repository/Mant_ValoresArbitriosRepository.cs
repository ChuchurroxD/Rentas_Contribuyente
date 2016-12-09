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
    public class Mant_ValoresArbitriosRepository
    {
            private const String nombreProcedimiento = "_Mant_ValoresArbitrio";
            private const String Nombretabla = "ValoresArbitrio";
            private Database db = DatabaseFactory.CreateDatabase();

            public List<Mant_ValoresArbitrios> listarTodos(Int32 idPeriodo)
            {
                try
                {
                    var coleccion = new List<Mant_ValoresArbitrios>();
                    DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                    db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                    db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);
                    using (var lector = db.ExecuteReader(SQL))
                    {
                        while (lector.Read())
                        {
                            coleccion.Add(new Mant_ValoresArbitrios
                            {
                                idValoresArbitrio = lector.GetInt32(lector.GetOrdinal("idValorArbitrio")),
                                idTablaArancel = lector.IsDBNull(lector.GetOrdinal("idTablaArancel")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idTablaArancel")),
                                descripcionTablaArancel = lector.IsDBNull(lector.GetOrdinal("descripcionTablaArancel")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcionTablaArancel")),
                                idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                                idCodificador = lector.IsDBNull(lector.GetOrdinal("idCodificador")) ? default(string) : lector.GetString(lector.GetOrdinal("idCodificador")),
                                Costo = lector.IsDBNull(lector.GetOrdinal("Costo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("Costo")),
                                Rubro = lector.IsDBNull(lector.GetOrdinal("Rubro")) ? default(string) : lector.GetString(lector.GetOrdinal("Rubro")),
                                Recurso = lector.IsDBNull(lector.GetOrdinal("Recurso")) ? default(string) : lector.GetString(lector.GetOrdinal("Recurso")),
                                Estado = lector.IsDBNull(lector.GetOrdinal("Estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Estado")),
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
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 10);
                int huboexito = db.ExecuteNonQuery(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Mant_ValoresArbitrios GetByPrimaryKey(Int32 idValoresArbitrio)
            {
                try
                {
                    DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                    db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                    db.AddInParameter(SQL, "idValoresArbitrio", DbType.Int32, idValoresArbitrio);
                    var mant_ValoresArbitrios = default(Mant_ValoresArbitrios);
                    using (var lector = db.ExecuteReader(SQL))
                    {
                        while (lector.Read())
                        {
                            mant_ValoresArbitrios = new Mant_ValoresArbitrios
                            {
                                idValoresArbitrio = lector.GetInt32(lector.GetOrdinal("idValorArbitrio")),
                                idTablaArancel = lector.IsDBNull(lector.GetOrdinal("idTablaArancel")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idTablaArancel")),
                                descripcionTablaArancel = lector.IsDBNull(lector.GetOrdinal("descripcionTablaArancel")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcionTablaArancel")),
                                idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                                idCodificador = lector.IsDBNull(lector.GetOrdinal("idCodificador")) ? default(string) : lector.GetString(lector.GetOrdinal("idCodificador")),
                                Costo = lector.IsDBNull(lector.GetOrdinal("Costo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("Costo")),
                                Rubro = lector.IsDBNull(lector.GetOrdinal("Rubro")) ? default(string) : lector.GetString(lector.GetOrdinal("Rubro")),
                                Recurso = lector.IsDBNull(lector.GetOrdinal("Recurso")) ? default(string) : lector.GetString(lector.GetOrdinal("Recurso")),
                                Estado = lector.IsDBNull(lector.GetOrdinal("Estado")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("Estado")),
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
                    return mant_ValoresArbitrios;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public virtual void Insert(Mant_ValoresArbitrios mant_ValoresArbitrios)
            {
                try
                {
                    DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                    db.AddInParameter(SQL, "idTablaArancel", DbType.Int32, mant_ValoresArbitrios.idTablaArancel);
                    db.AddInParameter(SQL, "idPeriodo", DbType.Int32, mant_ValoresArbitrios.idPeriodo);
                    db.AddInParameter(SQL, "Costo", DbType.Decimal, mant_ValoresArbitrios.Costo);
                    db.AddInParameter(SQL, "idCodificador", DbType.String, mant_ValoresArbitrios.idCodificador);
                    db.AddInParameter(SQL, "Rubro", DbType.String, mant_ValoresArbitrios.Rubro);
                    db.AddInParameter(SQL, "Recurso", DbType.String, mant_ValoresArbitrios.Recurso);
                    db.AddInParameter(SQL, "Estado", DbType.Boolean, mant_ValoresArbitrios.Estado);
                    db.AddInParameter(SQL, "registro_user_add", DbType.String, mant_ValoresArbitrios.registro_user_add);
                    db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
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

            public virtual void Update(Mant_ValoresArbitrios mant_ValoresArbitrios)
            {
                try
                {
                    DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                    db.AddInParameter(SQL, "idValorArbitrio", DbType.Int32, mant_ValoresArbitrios.idValoresArbitrio);
                    db.AddInParameter(SQL, "idTablaArancel", DbType.Int32, mant_ValoresArbitrios.idTablaArancel);
                    db.AddInParameter(SQL, "idPeriodo", DbType.Int32, mant_ValoresArbitrios.idPeriodo);
                    db.AddInParameter(SQL, "Costo", DbType.Decimal, mant_ValoresArbitrios.Costo);
                    db.AddInParameter(SQL, "idCodificador", DbType.String, mant_ValoresArbitrios.idCodificador);
                    db.AddInParameter(SQL, "Rubro", DbType.String, mant_ValoresArbitrios.Rubro);
                    db.AddInParameter(SQL, "Recurso", DbType.String, mant_ValoresArbitrios.Recurso);
                    db.AddInParameter(SQL, "Estado", DbType.Boolean, mant_ValoresArbitrios.Estado);
                    db.AddInParameter(SQL, "registro_user_update", DbType.String, mant_ValoresArbitrios.registro_user_update);
                    db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
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

            public virtual bool DeleteByPrimaryKey(int idValoresArbitrio)
            {
                try
                {
                    DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                    db.AddInParameter(SQL, "idValorArbitrio", DbType.String, idValoresArbitrio);
                    db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
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
    }
}
