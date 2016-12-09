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
    public class Valo_ValoresCobranzaRepository
    {
        private const string nombreProcedimiento = "_Valo_ValoresCobranza";

        private Database db = DatabaseFactory.CreateDatabase();
        public void enviarCoactivo(int valor, string registro_user_update)
        {
            try
            {
                var coleccion = new List<Valo_ResolucionDeterminacionArbitrios>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 104);
                db.AddInParameter(SQL, "valor", DbType.Int32, valor);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, registro_user_update);
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void notificar(int valor, string registro_user_update)
        {
            try
            {
                var coleccion = new List<Valo_ResolucionDeterminacionArbitrios>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 106);
                db.AddInParameter(SQL, "valor", DbType.Int32, valor);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, registro_user_update);                
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void anular(int valor, string registro_user_update)
        {
            try
            {
                var coleccion = new List<Valo_ResolucionDeterminacionArbitrios>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 108);
                db.AddInParameter(SQL, "valor", DbType.Int32, valor);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, registro_user_update);
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Valo_ResolucionDeterminacionArbitrios> listarVencidos()
        {
            try
            {
                var coleccion = new List<Valo_ResolucionDeterminacionArbitrios>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 103);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Valo_ResolucionDeterminacionArbitrios
                        {
                            valor_ID = lector.GetInt32(lector.GetOrdinal("valor_ID")),
                            anioCurso = lector.GetInt32(lector.GetOrdinal("anioCurso")),
                            anioValor = lector.GetInt32(lector.GetOrdinal("anioValor")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            nroValor = lector.GetInt32(lector.GetOrdinal("nroValor")),
                            tipo_valor = lector.GetInt32(lector.GetOrdinal("tipo_valor")),
                            tipo_valor_desc = lector.GetString(lector.GetOrdinal("tipo_valor_desc")),
                            persona = lector.GetString(lector.GetOrdinal("persona"))
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
        public List<Valo_ResolucionDeterminacionArbitrios> listarNotificados()
        {
            try
            {
                var coleccion = new List<Valo_ResolucionDeterminacionArbitrios>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 107);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Valo_ResolucionDeterminacionArbitrios
                        {
                            valor_ID = lector.GetInt32(lector.GetOrdinal("valor_ID")),
                            anioCurso = lector.GetInt32(lector.GetOrdinal("anioCurso")),
                            anioValor = lector.GetInt32(lector.GetOrdinal("anioValor")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            nroValor = lector.GetInt32(lector.GetOrdinal("nroValor")),
                            tipo_valor = lector.GetInt32(lector.GetOrdinal("tipo_valor")),
                            tipo_valor_desc = lector.GetString(lector.GetOrdinal("tipo_valor_desc")),
                            persona = lector.GetString(lector.GetOrdinal("persona"))
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
        public List<Valo_ResolucionDeterminacionArbitrios> listarGenerados()
        {
            try
            {
                var coleccion = new List<Valo_ResolucionDeterminacionArbitrios>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 105);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Valo_ResolucionDeterminacionArbitrios
                        {
                            valor_ID = lector.GetInt32(lector.GetOrdinal("valor_ID")),
                            anioCurso = lector.GetInt32(lector.GetOrdinal("anioCurso")),
                            anioValor = lector.GetInt32(lector.GetOrdinal("anioValor")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            nroValor = lector.GetInt32(lector.GetOrdinal("nroValor")),
                            tipo_valor = lector.GetInt32(lector.GetOrdinal("tipo_valor")),
                            tipo_valor_desc = lector.GetString(lector.GetOrdinal("tipo_valor_desc")),
                            persona = lector.GetString(lector.GetOrdinal("persona"))
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
        public List<Mant_Periodo> listarPeriodos(string persona_ID)
        {
            try
            {
                var coleccion = new List<Mant_Periodo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 31);
                db.AddInParameter(SQL, "persona", DbType.String, persona_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Periodo
                        {
                            Peric_canio = lector.GetInt32(lector.GetOrdinal("anio_valor"))
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
        public List<Valo_ValorTipoValor> listarValores(string persona_ID, int anio)
        {
            try
            {
                var coleccion = new List<Valo_ValorTipoValor>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 32);
                db.AddInParameter(SQL, "persona", DbType.String, persona_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Valo_ValorTipoValor
                        {
                            valor_ID = lector.GetInt32(lector.GetOrdinal("valor_id")),
                            descripcion = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public List<Valo_ValoresCobranza> listarMonto(int junta, int anio1, int anio2, int anio1_, int anio2_, decimal monto1, decimal monto2)
        {
            try
            {
                var coleccion = new List<Valo_ValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "anio1", DbType.Int32, anio1);
                db.AddInParameter(SQL, "anio2", DbType.Int32, anio2);
                db.AddInParameter(SQL, "aniot", DbType.Int32, anio1_);
                db.AddInParameter(SQL, "aniof", DbType.Int32, anio2_);
                db.AddInParameter(SQL, "junta", DbType.Int32, junta);
                db.AddInParameter(SQL, "monto1", DbType.Decimal, monto1);
                db.AddInParameter(SQL, "monto2", DbType.Decimal, monto2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Valo_ValoresCobranza
                        {
                            cod_sector = lector.GetInt32(lector.GetOrdinal("Sector_id")),
                            sector = lector.GetString(lector.GetOrdinal("junta")),
                            nro = lector.GetInt32(lector.GetOrdinal("nro")),
                            deuda = lector.GetDecimal(lector.GetOrdinal("deuda"))
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
        public List<Valo_ListadoDeudores> listarMorosidad(int junta, int anio1, int anio2, int nro)
        {
            try
            {
                var coleccion = new List<Valo_ListadoDeudores>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "anio1", DbType.Int32, anio1);
                db.AddInParameter(SQL, "anio2", DbType.Int32, anio2);
                db.AddInParameter(SQL, "junta", DbType.Int32, junta);
                db.AddInParameter(SQL, "nro", DbType.Int32, nro);
                SQL.CommandTimeout = 1000;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Valo_ListadoDeudores
                        {
                            codigo = lector.GetString(lector.GetOrdinal("persona_id")),
                            nombres = lector.GetString(lector.GetOrdinal("nombres")),
                            sector = lector.GetString(lector.GetOrdinal("descripcion")),
                            deuda = lector.GetDecimal(lector.GetOrdinal("deuda"))
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
        public void insertarValores(int junta, int anio1, int anio2, int anio1_, int anio2_, decimal monto1,
            decimal monto2, int tipovalor, string usuario)
        {
            try
            {
                var coleccion = new List<Valo_ValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 28);
                db.AddInParameter(SQL, "anio1", DbType.Int32, anio1);
                db.AddInParameter(SQL, "anio2", DbType.Int32, anio2);
                db.AddInParameter(SQL, "aniot", DbType.Int32, anio1_);
                db.AddInParameter(SQL, "aniof", DbType.Int32, anio2_);
                db.AddInParameter(SQL, "junta", DbType.Int32, junta);
                db.AddInParameter(SQL, "monto1", DbType.Decimal, monto1);
                db.AddInParameter(SQL, "monto2", DbType.Decimal, monto2);
                db.AddInParameter(SQL, "tipovalor", DbType.Int32, tipovalor);
                db.AddInParameter(SQL, "usuario", DbType.String, usuario);
                SQL.CommandTimeout = 100000;
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insertarValores2(int junta, int anio1, int anio2, int tipovalor, string usuario, int numero)
        {
            try
            {
                var coleccion = new List<Valo_ValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 29);
                db.AddInParameter(SQL, "anio1", DbType.Int32, anio1);
                db.AddInParameter(SQL, "anio2", DbType.Int32, anio2);
                db.AddInParameter(SQL, "numero", DbType.Int32, numero);
                db.AddInParameter(SQL, "junta", DbType.Int32, junta);
                db.AddInParameter(SQL, "tipovalor", DbType.Int32, tipovalor);
                db.AddInParameter(SQL, "usuario", DbType.String, usuario);
                SQL.CommandTimeout = 100000;
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void insertarValores3(string persona, int anio1, int anio2, int tipovalor, string usuario)
        {
            try
            {
                var coleccion = new List<Valo_ValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 102);
                db.AddInParameter(SQL, "anio1", DbType.Int32, anio1);
                db.AddInParameter(SQL, "anio2", DbType.Int32, anio2);
                db.AddInParameter(SQL, "tipovalor", DbType.Int32, tipovalor);
                db.AddInParameter(SQL, "usuario", DbType.String, usuario);
                db.AddInParameter(SQL, "persona", DbType.String, persona);
                SQL.CommandTimeout = 100000;
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Conf_Multitabla> listarTipos()
        {
            try
            {
                var coleccion = new List<Conf_Multitabla>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);

                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Conf_Multitabla
                        {
                            Multc_cValor = lector.IsDBNull(lector.GetOrdinal("valor")) ? default(String) : lector.GetString(lector.GetOrdinal("valor")),
                            Multc_vDescripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion"))
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
        public List<Valo_ValoresCobranzas> listarporContribuyente(string persona_ID)
        {
            try
            {
                var coleccion = new List<Valo_ValoresCobranzas>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 100);
                db.AddInParameter(SQL, "persona", DbType.String, persona_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Valo_ValoresCobranzas
                        {
                            documento = lector.GetString(lector.GetOrdinal("documento")),
                            numero = lector.GetString(lector.GetOrdinal("numero")),
                            predio = lector.GetString(lector.GetOrdinal("predio")),
                            fecha_recep = lector.GetString(lector.GetOrdinal("fecha_recep")),
                            fecha_vence = lector.GetString(lector.GetOrdinal("fecha_vence")),
                            ubicacion = lector.GetString(lector.GetOrdinal("ubicacion")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            deuda = lector.GetDecimal(lector.GetOrdinal("deuda"))
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

        public List<Valo_ValoresCobranzas> listarporContribuyentePeriodo(string persona_ID, Int32 periodo)
        {
            try
            {
                var coleccion = new List<Valo_ValoresCobranzas>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 101);
                db.AddInParameter(SQL, "persona", DbType.String, persona_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, periodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Valo_ValoresCobranzas
                        {
                            documento = lector.GetString(lector.GetOrdinal("documento")),
                            numero = lector.GetString(lector.GetOrdinal("numero")),
                            predio = lector.GetString(lector.GetOrdinal("predio")),
                            fecha_recep = lector.GetString(lector.GetOrdinal("fecha_recep")),
                            fecha_vence = lector.GetString(lector.GetOrdinal("fecha_vence")),
                            ubicacion = lector.GetString(lector.GetOrdinal("ubicacion")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            deuda = lector.GetDecimal(lector.GetOrdinal("deuda"))
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
        public List<Valo_OrdenPago> generarReporte(int anioCurso, string persona_ID, string tipo_valor)
        {
            try
            {
                var coleccion = new List<Valo_OrdenPago>();
                DbCommand SQL = db.GetStoredProcCommand("_Valo_ReporteValoresCobranza");
                db.AddInParameter(SQL, "anio_curso", DbType.Int32, anioCurso);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "tipo_valor", DbType.String, tipo_valor);

                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Valo_OrdenPago
                        {
                            Tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio_valor")),
                            baseImponible = lector.GetDecimal(lector.GetOrdinal("total_autovaluo")),
                            tramo = lector.GetString(lector.GetOrdinal("tramo")),
                            alicuota = lector.GetString(lector.GetOrdinal("Alicuota")),
                            insoluto = lector.GetDecimal(lector.GetOrdinal("Insoluto")),
                            impuestoPredial = lector.GetDecimal(lector.GetOrdinal("predial")),
                            formulario = lector.GetDecimal(lector.GetOrdinal("form")),
                            total = lector.GetDecimal(lector.GetOrdinal("abono")),
                            persona = lector.GetString(lector.GetOrdinal("persona")),
                            mensaje = lector.GetString(lector.GetOrdinal("mensaje")),
                            motDeter = lector.GetString(lector.GetOrdinal("motDeter")),
                            baseLegal = lector.GetString(lector.GetOrdinal("baseLegal")),
                            nombres = lector.GetString(lector.GetOrdinal("nombres")),
                            ruc = lector.GetString(lector.GetOrdinal("ruc")),
                            dni = lector.GetString(lector.GetOrdinal("dni")),
                            fecha_emision = lector.GetString(lector.GetOrdinal("fecha_emision")),
                            numero = lector.GetString(lector.GetOrdinal("numero")),
                            direccion = lector.GetString(lector.GetOrdinal("direccion"))
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

        public List<RepoGrandesDeudores> listarGrandesDeudores(int junta, int anio1, int anio2, int nro)
        {
            try
            {
                var coleccion = new List<RepoGrandesDeudores>();
                DbCommand SQL = db.GetStoredProcCommand(nombreProcedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 99);
                db.AddInParameter(SQL, "anio1", DbType.Int32, anio1);
                db.AddInParameter(SQL, "anio2", DbType.Int32, anio2);
                db.AddInParameter(SQL, "junta", DbType.Int32, junta);
                db.AddInParameter(SQL, "nro", DbType.Int32, nro);
                SQL.CommandTimeout = 1000;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new RepoGrandesDeudores
                        {
                            row = lector.GetInt32(lector.GetOrdinal("persona_id")),
                            //persona_id = lector.IsDBNull(lector.GetOrdinal("persona_id")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_id")),
                            nombre = lector.IsDBNull(lector.GetOrdinal("nombres")) ? default(String) : lector.GetString(lector.GetOrdinal("nombres")),
                            documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                            //tipo = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("RAZON SOCIAL")),
                            //representante = lector.IsDBNull(lector.GetOrdinal("RAZON SOCIAL")) ? default(String) : lector.GetString(lector.GetOrdinal("RAZON SOCIAL")),
                            sector = lector.IsDBNull(lector.GetOrdinal("sector")) ? default(String) : lector.GetString(lector.GetOrdinal("sector")),
                            calle = lector.IsDBNull(lector.GetOrdinal("calle")) ? default(String) : lector.GetString(lector.GetOrdinal("calle")),
                            nroCalle = lector.GetInt32(lector.GetOrdinal("c_num")),
                            mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                            lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                            telefono = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                            deudaArbitrio = lector.GetDecimal(lector.GetOrdinal("arbitrios")),
                            deudaPredio = lector.GetDecimal(lector.GetOrdinal("predial")),
                            deudaTotal = lector.GetDecimal(lector.GetOrdinal("deuda")),
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
