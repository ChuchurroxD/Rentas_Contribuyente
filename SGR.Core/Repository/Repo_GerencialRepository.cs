using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace SGR.Core.Repository
{
    public class Repo_GerencialRepository
    {
        private const String nombreprocedimiento = "_Rep_Gerencial";        
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Repo_Gerencial> ingresoMes(int anio)
        {
            try
            {
                var coleccion = new List<Repo_Gerencial>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 1);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_Gerencial
                        {
                            row = lector.GetInt32(lector.GetOrdinal("ROW")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("MES")) ? default(String) : lector.GetString(lector.GetOrdinal("MES")),
                            monto = lector.GetDecimal(lector.GetOrdinal("MONTO")),
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

        public List<Repo_Gerencial> porTipoPago(int anio)
        {
            try
            {
                var coleccion = new List<Repo_Gerencial>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 2);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_Gerencial
                        {
                            descripcion = lector.IsDBNull(lector.GetOrdinal("TIPO PAGO")) ? default(String) : lector.GetString(lector.GetOrdinal("TIPO PAGO")),
                            monto = lector.GetDecimal(lector.GetOrdinal("MONTO")),
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

        public List<Repo_Gerencial> fraccionamientoMes(int anio)
        {
            try
            {
                var coleccion = new List<Repo_Gerencial>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 3);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_Gerencial
                        {
                            row = lector.GetInt32(lector.GetOrdinal("ROW")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("MES")) ? default(String) : lector.GetString(lector.GetOrdinal("MES")),
                            monto = Convert.ToDecimal(lector.GetInt32(lector.GetOrdinal("MONTO"))),
                            fraccionamiento = lector.GetInt32(lector.GetOrdinal("MONTO")),
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

        public List<Repo_Gerencial> emisionTributo(int anio)
        {
            try
            {
                var coleccion = new List<Repo_Gerencial>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 4);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_Gerencial
                        {
                            descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            monto = lector.GetDecimal(lector.GetOrdinal("MONTO")),
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
