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
    public class Reci_ReciboRepository
    {
        private const string nombreProcedimiento = "_Reci_Recibos";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Reci_Recibo> listarRecibos(string persona, int anio)
        {
            try
            {
                var coleccion = new List<Reci_Recibo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "persona", DbType.String, persona);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 16);//modificar de acuerdo a tipo de  consulta

                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Reci_Recibo
                        {
                            anio = lector.GetInt32(lector.GetOrdinal("cod")),
                            total = lector.GetInt32(lector.GetOrdinal("numero"))
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

        public List<Mant_Periodo> listarPeriodosRecibos(string persona)
        {
            try
            {
                var coleccion = new List<Mant_Periodo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "persona", DbType.String, persona);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 15);//modificar de acuerdo a tipo de  consulta

                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Periodo
                        {
                            Peric_canio = lector.GetInt32(lector.GetOrdinal("anio"))

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
        public List<Reci_ReciboDetalle> listarRecibosImpresion2(int anio, int mes1)
        {
            try
            {
                var coleccion = new List<Reci_ReciboDetalle>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 17);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "mes1", DbType.Int32, mes1);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Reci_ReciboDetalle
                        {
                            codigo = lector.GetInt32(lector.GetOrdinal("recibo_id")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = Convert.ToString(lector.GetInt32(lector.GetOrdinal("mes"))),
                            persona = lector.GetString(lector.GetOrdinal("persona_id"))
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
        public List<Reci_ReciboDetalle> listarRecibosImpresion(int anio, int mes1, int mes2, string junta, string TipoGrupo)
        {
            try
            {
                var coleccion = new List<Reci_ReciboDetalle>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 14);
                db.AddInParameter(SQL, "junta", DbType.String, junta);
                db.AddInParameter(SQL, "TipoGrupo", DbType.String, TipoGrupo);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "mes1", DbType.Int32, mes1);
                db.AddInParameter(SQL, "mes2", DbType.Int32, mes2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Reci_ReciboDetalle
                        {
                            codigo = lector.GetInt32(lector.GetOrdinal("recibo_id")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = Convert.ToString(lector.GetInt32(lector.GetOrdinal("mes"))),
                            persona = lector.GetString(lector.GetOrdinal("persona_id"))
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

        public void generarRecibosTotal(string junta, int anio, int mes1, int mes2, int elimina)
        {
            try
            {
                var coleccion = new List<Reci_Recibo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "junta", DbType.String, junta);
                db.AddInParameter(SQL, "delete", DbType.String, elimina);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "mes1", DbType.Int32, mes1);
                db.AddInParameter(SQL, "mes2", DbType.Int32, mes2);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al Generar el Recibo");
                }
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Reci_ReciboDetalle listarPorCodigo(int periodo_ID, int nroRecibo)
        {
            try
            {
                Reci_ReciboDetalle elemento = new Reci_ReciboDetalle();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 12);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo_ID);
                db.AddInParameter(SQL, "recibo", DbType.Int32, nroRecibo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        elemento = (new Reci_ReciboDetalle
                        {
                            codigo = lector.GetInt32(lector.GetOrdinal("codigo")),
                            persona = lector.GetString(lector.GetOrdinal("persona")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto"))
                        });
                    }
                }
                SQL.Dispose();
                return elemento;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Reci_Recibo> listarTodos(string junta, int anio, int mes1, int mes2, string TipoGrupo)
        {
            try
            {
                var coleccion = new List<Reci_Recibo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "junta", DbType.String, junta);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "mes1", DbType.Int32, mes1);
                db.AddInParameter(SQL, "mes2", DbType.Int32, mes2);
                db.AddInParameter(SQL, "TipoGrupo", DbType.String, TipoGrupo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Reci_Recibo
                        {
                            Sector_id = lector.GetInt32(lector.GetOrdinal("Sector_id")),
                            junta = lector.GetString(lector.GetOrdinal("junta")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = mesDesc(lector.GetInt32(lector.GetOrdinal("mes"))),
                            nromes= lector.GetInt32(lector.GetOrdinal("mes")),
                            total = lector.GetInt32(lector.GetOrdinal("total")),
                            emitidos = lector.GetInt32(lector.GetOrdinal("emitidos")),
                            pendientes = lector.GetInt32(lector.GetOrdinal("pendientes"))
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
        public List<Reci_ReciboDetalle> listarTodosDetalle(string persona, int anio, int mes1, int mes2)
        {
            try
            {
                var coleccion = new List<Reci_ReciboDetalle>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "persona", DbType.String, persona);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "mes1", DbType.Int32, mes1);
                db.AddInParameter(SQL, "mes2", DbType.Int32, mes2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Reci_ReciboDetalle
                        {
                            codigo = lector.GetInt32(lector.GetOrdinal("recibo_id")),
                            persona = lector.GetString(lector.GetOrdinal("nombres")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = mesDesc(lector.GetInt32(lector.GetOrdinal("mes"))),
                            nromes= lector.GetInt32(lector.GetOrdinal("mes")),
                            recibo = lector.GetString(lector.GetOrdinal("recibo")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto"))
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
        public void generarRecibosDetalle(string persona, int anio, int mes1, int mes2, int elimina)
        {
            try
            {
                var coleccion = new List<Reci_ReciboDetalle>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "persona", DbType.String, persona);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "delete", DbType.String, elimina);
                db.AddInParameter(SQL, "mes1", DbType.Int32, mes1);
                db.AddInParameter(SQL, "mes2", DbType.Int32, mes2);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al Generar el Recibo");
                }
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string mesDesc(int mes)
        {
            string res = "";
            switch (mes)
            {
                case 1:
                    res = "ENERO";
                    break;
                case 2:
                    res = "FEBRERO";
                    break;
                case 3:
                    res = "MARZO";
                    break;
                case 4:
                    res = "ABRIL";
                    break;
                case 5:
                    res = "MAYO";
                    break;
                case 6:
                    res = "JUNIO";
                    break;
                case 7:
                    res = "JULIO";
                    break;
                case 8:
                    res = "AGOSTO";
                    break;
                case 9:
                    res = "SETIEMBRE";
                    break;
                case 10:
                    res = "OCTUBRE";
                    break;
                case 11:
                    res = "NOVIEMBRE";
                    break;
                case 12:
                    res = "DICIEMBRE";
                    break;
            }
            return res;

        }
        public List<string> descripcionContribuyente(string codigo, int periodo, int mes1, int mes2)
        {
            var coleccion = new List<string>();
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo);
                db.AddInParameter(SQL, "mes1", DbType.Int32, mes1);
                db.AddInParameter(SQL, "mes2", DbType.Int32, mes2);
                db.AddInParameter(SQL, "persona", DbType.String, codigo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(lector.GetString(lector.GetOrdinal("razon_social")));
                        coleccion.Add(lector.GetString(lector.GetOrdinal("deuda")));
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
        public List<Reci_ReciboDetalle> listarRecibosporContribuyente(string persona_ID, Int16 mes1, Int16 mes2, Int16 anio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 13);
                db.AddInParameter(SQL, "persona", DbType.String, persona_ID);
                db.AddInParameter(SQL, "mes1", DbType.Int16, mes1);
                db.AddInParameter(SQL, "mes2", DbType.Int16, mes2);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                var coleccion = new List<Reci_ReciboDetalle>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Reci_ReciboDetalle
                        {
                            codigo = lector.GetInt32(lector.GetOrdinal("recibo_id")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetString(lector.GetOrdinal("mes")),
                            recibo = lector.GetString(lector.GetOrdinal("Recibos")),
                            persona = lector.GetString(lector.GetOrdinal("estado")),
                            nromes = lector.GetInt32(lector.GetOrdinal("nromes"))
                            //estado para no agregar otro objeto
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
        public List<Reci_ReciboDetalleReporte> cargarRecibo(int periodo, int recibo_ID, int mesProceso, string persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand("_Impresion");
                db.AddInParameter(SQL, "periodo", DbType.Int32, periodo);
                db.AddInParameter(SQL, "recibo_ID", DbType.Int32, recibo_ID);
                db.AddInParameter(SQL, "mesProceso", DbType.Int32, mesProceso);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                var coleccion = new List<Reci_ReciboDetalleReporte>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Reci_ReciboDetalleReporte
                        {
                            periodo = lector.GetInt32(lector.GetOrdinal("periodo")),
                            abrev = lector.GetString(lector.GetOrdinal("abrev")),
                            DeudaAnt = lector.GetDecimal(lector.GetOrdinal("DeudaAnt")),
                            mes = lector.GetString(lector.GetOrdinal("mes")),
                            recibo_id = lector.GetInt32(lector.GetOrdinal("recibo")),
                            tipo = lector.GetString(lector.GetOrdinal("tipo")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            domicilio = lector.GetString(lector.GetOrdinal("domicilio")),
                            nombres = lector.GetString(lector.GetOrdinal("nombres")),
                            fechaEmision = lector.GetString(lector.GetOrdinal("fechaEmision")),
                            FechaVence = lector.GetString(lector.GetOrdinal("FechaVence")),
                            junta = lector.GetString(lector.GetOrdinal("junta")),
                            peri = lector.GetString(lector.GetOrdinal("peri")),
                            Peri2 = lector.GetString(lector.GetOrdinal("Peri2"))
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
