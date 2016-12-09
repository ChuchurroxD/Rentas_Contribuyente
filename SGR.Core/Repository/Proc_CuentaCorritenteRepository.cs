using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SGR.Core.Repository
{
    public class Proc_CuentaCorritenteRepository
    {
        private const String nombreprocedimiento = "_CuentaCorriente";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Proc_CuentaCorritente> listarPredialArbIndiv(String persona, string tributo_ID,int tipo,string predio_id)
        {
            try
            {
                var coleccion = new List<Proc_CuentaCorritente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);//tipo2:predial,3arbitrios
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Proc_CuentaCorritente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            nombre = lector.GetString(lector.GetOrdinal("nombre")),
                            tributo = lector.IsDBNull(lector.GetOrdinal("tributo")) ? default(String) : lector.GetString(lector.GetOrdinal("tributo")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            cargo = lector.GetDecimal(lector.GetOrdinal("cargo")),
                            abono = lector.GetDecimal(lector.GetOrdinal("abono")),
                            estado = lector.GetString(lector.GetOrdinal("estado"))

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
        public List<Proc_CuentaCorritente> listarPredialArbxPersona(String persona, string tributo_ID)
        {
            try
            {
                var coleccion = new List<Proc_CuentaCorritente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//tipo2:predial,3arbitrios
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Proc_CuentaCorritente
                        {
                            cuenta_corriente_ID = lector.GetInt32(lector.GetOrdinal("cuenta_corriente_ID")),
                            nombre = lector.GetString(lector.GetOrdinal("nombre")),
                            tributo = lector.IsDBNull(lector.GetOrdinal("tributo")) ? default(String) : lector.GetString(lector.GetOrdinal("tributo")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            fecha_vence = lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            cargo = lector.GetDecimal(lector.GetOrdinal("cargo")),
                            abono = lector.GetDecimal(lector.GetOrdinal("abono")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            predioId = lector.GetString(lector.GetOrdinal("predio_ID")),

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
        public Decimal VerificarExisteCtaCTeIndividual(String persona, string tributo_ID,int tipo,string predio_id)
        {
            try
            {
                var coleccion = new List<Proc_CuentaCorritente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_id);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);//tipo6:predial,7arbitrios
                return Convert.ToDecimal(db.ExecuteScalar(SQL));
              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Decimal VerificarExisteCtaCTe(int anio, int tipo)
        {
            try
            {
                var coleccion = new List<Proc_CuentaCorritente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.String, anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);//tipo4:predial,5arbitrios
                return Convert.ToDecimal(db.ExecuteScalar(SQL));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Decimal VerificarExisteCtaCTeEntreAnios(int anioini, int aniofin)
        {
            try
            {
                var coleccion = new List<Proc_CuentaCorritente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                //db.AddInParameter(SQL, "anio", DbType.String, anio);
                //db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);//tipo4:predial,5arbitrios
                return Convert.ToDecimal(db.ExecuteScalar(SQL));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
