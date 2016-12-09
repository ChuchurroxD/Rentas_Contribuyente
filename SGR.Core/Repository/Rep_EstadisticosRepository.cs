using Microsoft.Practices.EnterpriseLibrary.Data;
using SGR.Entity;
using System;
using System.Collections.Generic;
using SGR.Entity.Model;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SGR.Core.Repository
{
    class Rep_EstadisticosRepository
    {
        private const String NombreProcedimiento = "_Repo_Estadisico1";
        private Database db = DatabaseFactory.CreateDatabase();



        public List<Rep_Estadistico1> ReporteCuentaCorrienteAño(Int32 anio)
        {
            try
            {
                var coleccion = new List<Rep_Estadistico1>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Rep_Estadistico1
                        {
                            mes = lector.IsDBNull(lector.GetOrdinal("mes")) ? default(String) : lector.GetString(lector.GetOrdinal("mes")),
                            Predial = lector.IsDBNull(lector.GetOrdinal("Predial")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Predial")),
                            PredialAnterior = lector.IsDBNull(lector.GetOrdinal("PredialAnterior")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("PredialAnterior")),
                            Arbitrios = lector.IsDBNull(lector.GetOrdinal("Arbitrios")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Arbitrios")),
                            Alcabala = lector.IsDBNull(lector.GetOrdinal("Alcabala")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Alcabala")),
                            TotalMes = lector.IsDBNull(lector.GetOrdinal("TotalMes")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("TotalMes")),

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

        public List<Rep_Estadistico1> ReporteSaldosCoactivo(Int32 anio)
        {
            try
            {
                var coleccion = new List<Rep_Estadistico1>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Rep_Estadistico1
                        {
                            Periodo = lector.IsDBNull(lector.GetOrdinal("Periodo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Periodo")),
                            Predial = lector.IsDBNull(lector.GetOrdinal("Predial")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Predial")),
                            Arbitrios = lector.IsDBNull(lector.GetOrdinal("Arbitrios")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Arbitrios")),
                            Alcabala = lector.IsDBNull(lector.GetOrdinal("Alcabala")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Alcabala")),
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

        public List<Rep_Estadistico1> ReporteSaldosCoactivoAbono(Int32 anio)
        {
            try
            {
                var coleccion = new List<Rep_Estadistico1>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Rep_Estadistico1
                        {
                            Periodo = lector.IsDBNull(lector.GetOrdinal("Periodo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Periodo")),
                            Predial = lector.IsDBNull(lector.GetOrdinal("Predial")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Predial")),                            
                            Arbitrios = lector.IsDBNull(lector.GetOrdinal("Arbitrios")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Arbitrios")),
                            Alcabala = lector.IsDBNull(lector.GetOrdinal("Alcabala")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Alcabala")),
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

        public List<Rep_Estadistico1> ReporteCuentaCorrienteTotal(Int32 anio)
        {
            try
            {
                var coleccion = new List<Rep_Estadistico1>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Rep_Estadistico1
                        {
                            CargoPredio = lector.IsDBNull(lector.GetOrdinal("CargoPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CargoPredio")),
                            AbonoPredio = lector.IsDBNull(lector.GetOrdinal("AbonoPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("AbonoPredio")),
                            SaldoPredio = lector.IsDBNull(lector.GetOrdinal("SaldoPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("SaldoPredio")),
                            CargoArbitrio = lector.IsDBNull(lector.GetOrdinal("CargoArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CargoArbitrio")),
                            AbonoArbitrio = lector.IsDBNull(lector.GetOrdinal("AbonoArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("AbonoArbitrio")),
                            SaldoArbitrio = lector.IsDBNull(lector.GetOrdinal("SaldoArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("SaldoArbitrio")),
                            CargoOtros = lector.IsDBNull(lector.GetOrdinal("CargoOtros")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CargoOtros")),
                            AbonoOtros = lector.IsDBNull(lector.GetOrdinal("AbonoOtros")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("AbonoOtros")),
                            SaldoOtros = lector.IsDBNull(lector.GetOrdinal("SaldoOtros")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("SaldoOtros")),

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
        public List<Rep_Estadistico1> ReporteCuentaCorrienteMeses(Int32 anio, Int32 mes1, Int32 mes2)
        {
            try
            {
                var coleccion = new List<Rep_Estadistico1>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "m1", DbType.Int32, mes1);
                db.AddInParameter(SQL, "m2", DbType.Int32, mes2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Rep_Estadistico1
                        {
                            mes = lector.IsDBNull(lector.GetOrdinal("mes")) ? default(String) : lector.GetString(lector.GetOrdinal("mes")),
                            //nro = lector.IsDBNull(lector.GetOrdinal("nro")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("nro")),
                            CargoPredio = lector.IsDBNull(lector.GetOrdinal("CargoPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CargoPredio")),
                            AbonoPredio = lector.IsDBNull(lector.GetOrdinal("AbonoPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("AbonoPredio")),
                            SaldoPredio = lector.IsDBNull(lector.GetOrdinal("SaldoPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("SaldoPredio")),
                            CobradoPredio = lector.IsDBNull(lector.GetOrdinal("CobradoPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CobradoPredio")),
                            MorosidadPredio = lector.IsDBNull(lector.GetOrdinal("MorosidadPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MorosidadPredio")),
                            CargoArbitrio = lector.IsDBNull(lector.GetOrdinal("CargoArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CargoArbitrio")),
                            AbonoArbitrio = lector.IsDBNull(lector.GetOrdinal("AbonoArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("AbonoArbitrio")),
                            SaldoArbitrio = lector.IsDBNull(lector.GetOrdinal("SaldoArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("SaldoArbitrio")),
                            CobradoArbitrio = lector.IsDBNull(lector.GetOrdinal("CobradoArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CobradoArbitrio")),
                            MorosidadArbitrio = lector.IsDBNull(lector.GetOrdinal("MorosidadArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MorosidadArbitrio")),
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

        public List<Repo_estadistico2> ReportePagosMesComparado(Int32 anio1, Int32 mes1, Int32 anio2, Int32 mes2)
        {
            try
            {
                var coleccion = new List<Repo_estadistico2>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 7);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio1);
                db.AddInParameter(SQL, "m1", DbType.Int32, mes1);
                db.AddInParameter(SQL, "anio2", DbType.Int32, anio2);
                db.AddInParameter(SQL, "m2", DbType.Int32, mes2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_estadistico2
                        {
                            Tributos = lector.IsDBNull(lector.GetOrdinal("Tributos")) ? default(String) : lector.GetString(lector.GetOrdinal("Tributos")),
                            MontoAño1 = lector.IsDBNull(lector.GetOrdinal("MontoAño1")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MontoAño1")),
                            MontoAño2 = lector.IsDBNull(lector.GetOrdinal("MontoAño2")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("MontoAño2")),
                            //Varianza = lector.IsDBNull(lector.GetOrdinal("Varianza")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Varianza")),
                            //PorcVarianza = lector.IsDBNull(lector.GetOrdinal("PorcVarianza")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("PorcVarianza")),
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

        public List<Rep_Estadistico1> ReporteCuentaCorrienteMesesTotal(Int32 anio, Int32 mes1, Int32 mes2)
        {
            try
            {
                var coleccion = new List<Rep_Estadistico1>();
                DbCommand SQL = db.GetStoredProcCommand(NombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "m1", DbType.Int32, mes1);
                db.AddInParameter(SQL, "m2", DbType.Int32, mes2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Rep_Estadistico1
                        {
                            CargoPredio = lector.IsDBNull(lector.GetOrdinal("CargoPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CargoPredio")),
                            AbonoPredio = lector.IsDBNull(lector.GetOrdinal("AbonoPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("AbonoPredio")),
                            SaldoPredio = lector.IsDBNull(lector.GetOrdinal("SaldoPredio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("SaldoPredio")),
                            CargoArbitrio = lector.IsDBNull(lector.GetOrdinal("CargoArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CargoArbitrio")),
                            AbonoArbitrio = lector.IsDBNull(lector.GetOrdinal("AbonoArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("AbonoArbitrio")),
                            SaldoArbitrio = lector.IsDBNull(lector.GetOrdinal("SaldoArbitrio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("SaldoArbitrio")),
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
