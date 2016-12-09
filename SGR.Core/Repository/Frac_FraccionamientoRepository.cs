using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core;
using SGR.Entity;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace SGR.Core.Repository
{

    public class Frac_FraccionamientoRepository
    {

        /// <summary>
        /// ////
        /// Gestion de convenios de fraccionamiento
        /// </summary>
        private String nombreprocedimiento = "_frac_Fraccionamiento_Proceso";
        private Database db = DatabaseFactory.CreateDatabase();

        public Frac_FraccionamientoDetalle listarParam(int fraccionamiento_ID)
        {
            try
            {
                var coleccion = new Frac_FraccionamientoDetalle();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 21);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.Int32, fraccionamiento_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion= (new Frac_FraccionamientoDetalle
                        {
                            Numero = lector.GetInt32(lector.GetOrdinal("Cuotas")),
                            Descuento = lector.GetDecimal(lector.GetOrdinal("Inicial")),
                            Deuda_Total = lector.GetDecimal(lector.GetOrdinal("monto_derecho")),
                            fraccionamiento_id= lector.GetInt32(lector.GetOrdinal("numero")),
                            idPeriodo= lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Interes= lector.GetDecimal(lector.GetOrdinal("interes_compensa")),                            
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
        public List<Frac_FraccionamientoListado> listarFraccionamientos(String persona_ID)
        {
            try
            {
                var coleccion = new List<Frac_FraccionamientoListado>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 7);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_FraccionamientoListado
                        {
                            base_legal = lector.GetString(lector.GetOrdinal("base_legal")),
                            codigo = lector.GetString(lector.GetOrdinal("codigo")),
                            fecha_acogida = lector.GetDateTime(lector.GetOrdinal("fecha_acogida")),
                            Cuotas = lector.GetInt32(lector.GetOrdinal("Cuotas")),
                            deuda_fraccionada = lector.GetDecimal(lector.GetOrdinal("saldo")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            fraccionamiento_id = lector.GetInt32(lector.GetOrdinal("fraccionamiento_id"))
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
        public List<Frac_Cronograma> listarCronograma(int fraccionamiento_ID)
        {
            try
            {
                var coleccion = new List<Frac_Cronograma>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 9);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.String, fraccionamiento_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_Cronograma
                        {
                            amortizacion = lector.GetDecimal(lector.GetOrdinal("amortizacion")),
                            Fraccionamiento_id = lector.GetInt32(lector.GetOrdinal("Fraccionamiento_id")),
                            NroCuota = lector.GetInt32(lector.GetOrdinal("NroCuota")),
                            importe = lector.GetDecimal(lector.GetOrdinal("importe")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            FechaVence = lector.GetDateTime(lector.GetOrdinal("FechaVence"))
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
        public List<Frac_CronogramaDetalle> listarFraccTributos(int fraccionamiento_ID)
        {
            try
            {
                var coleccion = new List<Frac_CronogramaDetalle>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 10);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.String, fraccionamiento_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_CronogramaDetalle
                        {
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            impuesto = lector.GetDecimal(lector.GetOrdinal("impuesto"))
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
        public List<Frac_Fraccionamiento> listartodos(String persona_ID)
        {
            try
            {
                var coleccion = new List<Frac_Fraccionamiento>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 1);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_Fraccionamiento
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            predial = lector.GetDecimal(lector.GetOrdinal("predial")),
                            predialI = lector.GetDecimal(lector.GetOrdinal("predialI")),
                            arbitrios = lector.GetDecimal(lector.GetOrdinal("arbitrios")),
                            arbitriosI = lector.GetDecimal(lector.GetOrdinal("arbitriosI")),
                            alcabala = lector.GetDecimal(lector.GetOrdinal("alcabala")),
                            alcabalaI = lector.GetDecimal(lector.GetOrdinal("alcabalaI")),
                            multas = lector.GetDecimal(lector.GetOrdinal("multas")),
                            multasI = lector.GetDecimal(lector.GetOrdinal("multasI")),
                            fincas = lector.GetDecimal(lector.GetOrdinal("fincas")),
                            fincasI = lector.GetDecimal(lector.GetOrdinal("fincasI")),
                            alquileres = lector.GetDecimal(lector.GetOrdinal("alquileres")),
                            alquileresI = lector.GetDecimal(lector.GetOrdinal("alquileresI")),
                            tasas = lector.GetDecimal(lector.GetOrdinal("tasas")),
                            tasasI = lector.GetDecimal(lector.GetOrdinal("tasasI")),
                            total = lector.GetDecimal(lector.GetOrdinal("total"))
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
        public List<Trib_TipoFraccionamiento> listarFraccionamiento()
        {
            try
            {
                var coleccion = new List<Trib_TipoFraccionamiento>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_TipoFraccionamiento
                        {
                            TiFr_tipo_fraccionamiento_ID = lector.GetInt32(lector.GetOrdinal("tipo_fraccionamiento_ID")),
                            TiFr_base_legal = lector.GetString(lector.GetOrdinal("base_legal"))
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
        public decimal montoTributo(string persona_ID, int anio_ini, int anio_fin, int mes_ini, int mes_fin, string tributo_ID)
        {
            try
            {
                decimal monto = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 3);
                db.AddInParameter(SQL, "@persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "@tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "@anio_ini", DbType.Int32, anio_ini);
                db.AddInParameter(SQL, "@anio_fin", DbType.Int32, anio_fin);
                db.AddInParameter(SQL, "@mes_fin", DbType.Int32, mes_fin);
                db.AddInParameter(SQL, "@mes_ini", DbType.Int32, mes_ini);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {

                        monto = lector.GetDecimal(lector.GetOrdinal("monto"));
                    }
                }
                SQL.Dispose();
                return monto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insertCta(string persona_ID, int anio_ini, int anio_fin, int mes_ini, int mes_fin, string tributo_ID,int fraccionamiento_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 6);
                db.AddInParameter(SQL, "@persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "@tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "@anio_ini", DbType.Int32, anio_ini);
                db.AddInParameter(SQL, "@anio_fin", DbType.Int32, anio_fin);
                db.AddInParameter(SQL, "@mes_fin", DbType.Int32, mes_fin);
                db.AddInParameter(SQL, "@mes_ini", DbType.Int32, mes_ini);
                db.AddInParameter(SQL, "@fraccionamiento_ID", DbType.Int32, fraccionamiento_ID);
                int huboexito = db.ExecuteNonQuery(SQL);
                //if (huboexito == 0)
                //{
                //    throw new Exception("Error al Generar Liquidacion");
                //}
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int Insert(Frac_FraccionamientoDetalle fraccionamiento)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, fraccionamiento.idPeriodo);
                db.AddInParameter(SQL, "Numero", DbType.Int32, fraccionamiento.Numero);
                db.AddInParameter(SQL, "mes_ini", DbType.Int32, fraccionamiento.idPeriodoInicio);
                db.AddInParameter(SQL, "mes_fin", DbType.Int32, fraccionamiento.idPeriodoFin);
                db.AddInParameter(SQL, "Deuda_Total", DbType.Single, fraccionamiento.Deuda_Total);
                db.AddInParameter(SQL, "Inicial", DbType.Single, fraccionamiento.Inicial);
                db.AddInParameter(SQL, "Saldo", DbType.Single, fraccionamiento.Saldo);
                db.AddInParameter(SQL, "Descuento", DbType.Single, fraccionamiento.Descuento);
                db.AddInParameter(SQL, "Interes", DbType.Single, fraccionamiento.Interes);
                db.AddInParameter(SQL, "Cuotas", DbType.Int32, fraccionamiento.Cuotas);
                db.AddInParameter(SQL, "ValorCuota", DbType.Single, fraccionamiento.ValorCuota);
                db.AddInParameter(SQL, "Estado", DbType.String, fraccionamiento.Estado);
                db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, fraccionamiento.tipo_fraccionamiento_ID);
                db.AddInParameter(SQL, "Persona_id", DbType.String, fraccionamiento.Persona_id);
                db.AddInParameter(SQL, "anio_ini", DbType.Int32, fraccionamiento.anio_inicio);
                db.AddInParameter(SQL, "anio_fin", DbType.Int32, fraccionamiento.anio_fin);
                db.AddInParameter(SQL, "tipo", DbType.String, 4);
                int ultimo = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public Frac_FraccionamientoDetalle obtenerFraccionamiento(Int32 fraccionamiento_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 8);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.Int32,fraccionamiento_ID);
                var coleccion = new Frac_FraccionamientoDetalle();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion = new Frac_FraccionamientoDetalle
                        {
                            fraccionamiento_id = lector.GetInt32(lector.GetOrdinal("fraccionamiento_id")),
                            idPeriodo = lector.GetInt16(lector.GetOrdinal("idPeriodo")),
                            Numero = lector.GetInt32(lector.GetOrdinal("Numero")),
                            Fecha_Acogida = lector.GetDateTime(lector.GetOrdinal("Fecha_Acogida")),
                            idPeriodoInicio = lector.GetInt32(lector.GetOrdinal("idPeriodoInicio")),
                            idPeriodoFin = lector.GetInt32(lector.GetOrdinal("idPeriodoFin")),
                            Deuda_Total = lector.GetDecimal(lector.GetOrdinal("Deuda_Total")),
                            Inicial = lector.GetDecimal(lector.GetOrdinal("Inicial")),
                            Saldo = lector.GetDecimal(lector.GetOrdinal("Saldo")),
                            Descuento = lector.GetDecimal(lector.GetOrdinal("Descuento")),
                            Interes = lector.GetDecimal(lector.GetOrdinal("Interes")),
                            Cuotas = lector.GetInt32(lector.GetOrdinal("Cuotas")),
                            ValorCuota = lector.GetDecimal(lector.GetOrdinal("ValorCuota")),
                            Estado = lector.GetString(lector.GetOrdinal("Estado")),
                            tipo_fraccionamiento_ID = lector.GetInt32(lector.GetOrdinal("tipo_fraccionamiento_ID")),
                            Persona_id = lector.GetString(lector.GetOrdinal("Persona_id")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_user_add = lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(string) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            anio_inicio = lector.GetInt32(lector.GetOrdinal("anio_inicio")),
                            anio_fin = lector.GetInt32(lector.GetOrdinal("anio_fin"))

                        };
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
        public virtual int InsertDetalle(Frac_Cronograma cronograma)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "amortizacion", DbType.Decimal, cronograma.amortizacion);
                db.AddInParameter(SQL, "importe", DbType.Decimal, cronograma.importe);
                db.AddInParameter(SQL, "interes", DbType.Decimal, cronograma.interes);
                db.AddInParameter(SQL, "NroCuota", DbType.Int32, cronograma.NroCuota);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.Int32, cronograma.Fraccionamiento_id);
                db.AddInParameter(SQL, "tipo", DbType.String, 5);
                int ultimo = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetInt32(lector.GetOrdinal("ultimo"));
                    }
                }
                SQL.Dispose();
                return ultimo;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public virtual int UpdateCouta(Frac_Cronograma cronograma)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.Int32, cronograma.Fraccionamiento_id);
                db.AddInParameter(SQL, "tipo", DbType.String, 23);
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public Frac_Fraccionamiento listarPorCodigo(int periodo_ID,int nrConvenio,int NroCuota)
        {
            try
            {
                Frac_Fraccionamiento elemento = new Frac_Fraccionamiento();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 11);
                db.AddInParameter(SQL, "periodo_ID", DbType.Int32, periodo_ID);
                db.AddInParameter(SQL, "nrConvenio", DbType.Int32, nrConvenio);
                db.AddInParameter(SQL, "NroCuota", DbType.Int32, NroCuota);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        elemento = (new Frac_Fraccionamiento
                        {
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona")),
                            anio = lector.GetInt32(lector.GetOrdinal("fraccionamiento_ID"))
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
        public Frac_Fraccionamiento listarPorCodigo2(int periodo_ID, int nrConvenio)
        {
            try
            {
                Frac_Fraccionamiento elemento = new Frac_Fraccionamiento();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 16);
                db.AddInParameter(SQL, "periodo_ID", DbType.Int32, periodo_ID);
                db.AddInParameter(SQL, "nrConvenio", DbType.Int32, nrConvenio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        elemento = (new Frac_Fraccionamiento
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona")),
                            anio = lector.GetInt32(lector.GetOrdinal("fraccionamiento_ID"))
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
        public List<Frac_FraccionamientoDetalle> seguimientoContribuyente(string contribuyente,Int32 tipofracc,string estadofracc,DateTime fechaInicio,DateTime fechafin)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 12);
                db.AddInParameter(SQL, "razon_social", DbType.String, contribuyente);
                db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, tipofracc);
                db.AddInParameter(SQL, "Estado", DbType.String, estadofracc);
                db.AddInParameter(SQL, "fecha_inicio", DbType.Date, fechaInicio);
                db.AddInParameter(SQL, "fecha_fin", DbType.Date, fechafin);
                var coleccion = new List<Frac_FraccionamientoDetalle>();
                using(var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_FraccionamientoDetalle
                        {
                            fraccionamiento_id = lector.GetInt32(lector.GetOrdinal("fraccionamiento_id")),
                            idPeriodo = lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Numero = lector.GetInt32(lector.GetOrdinal("numero")),
                            Fecha_Acogida = lector.GetDateTime(lector.GetOrdinal("fecha_Acogida")),
                            idPeriodoInicio = lector.GetInt32(lector.GetOrdinal("idPeriodoInicio")),
                            idPeriodoFin = lector.GetInt32(lector.GetOrdinal("idPeriodoFin")),
                            Deuda_Total = lector.GetDecimal(lector.GetOrdinal("deuda_Total")),
                            Inicial = lector.GetDecimal(lector.GetOrdinal("inicial")),
                            Saldo = lector.GetDecimal(lector.GetOrdinal("saldo")),
                            Descuento = lector.GetDecimal(lector.GetOrdinal("descuento")),
                            Interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            Cuotas = lector.GetInt32(lector.GetOrdinal("cuotas")),
                            ValorCuota = lector.GetDecimal(lector.GetOrdinal("valorCuota")),
                            Estado = lector.GetString(lector.GetOrdinal("estado")),
                            tipo_fraccionamiento_ID = lector.GetInt32(lector.GetOrdinal("tipo_fraccionamiento_ID")),
                            Persona_id = lector.GetString(lector.GetOrdinal("persona_id"))
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

        /// <summary>
        /// ////
        /// Recaudacion de fraccionamiento
        /// </summary>
        /// 
        public List<Frac_FraccionamientoListado2> listarFraccionamientosRecaudacion(int nroCuotas,int nroCuotasVenc,string via,
            int sector,string razonSocial,string estado,int tipoFracc,int periodo,DateTime fechaInicio,DateTime fechaFin)
        {
            try
            {
                var coleccion = new List<Frac_FraccionamientoListado2>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 13);
                if (nroCuotas>0 ) db.AddInParameter(SQL, "NroCuota", DbType.Int32, nroCuotas);                
                if(nroCuotasVenc>0) db.AddInParameter(SQL, "cuotasVencidas", DbType.Int32, nroCuotasVenc);
                if(!via.Equals("0"))db.AddInParameter(SQL, "via", DbType.String, via);
                if(sector>0)db.AddInParameter(SQL, "sector", DbType.Int32, sector);
                db.AddInParameter(SQL, "razon_social", DbType.String, razonSocial);
                if(!estado.Equals("0"))db.AddInParameter(SQL, "Estado", DbType.String, estado);
                if(tipoFracc>0)db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, tipoFracc);
                if(periodo>0)db.AddInParameter(SQL, "idPeriodo", DbType.Int32, periodo);
                db.AddInParameter(SQL, "fecha_inicio", DbType.DateTime, fechaInicio);
                db.AddInParameter(SQL, "fecha_fin", DbType.DateTime, fechaFin);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_FraccionamientoListado2
                        {
                            fraccionamiento_id = lector.GetInt32(lector.GetOrdinal("fraccionamiento_id")),
                            convenio = lector.GetString(lector.GetOrdinal("convenio")),
                            persona_ID = lector.GetString(lector.GetOrdinal("Persona_Id")),
                            persona = lector.GetString(lector.GetOrdinal("razon_social")),
                            junta = lector.GetString(lector.GetOrdinal("junta")),
                            via = lector.GetString(lector.GetOrdinal("via")),
                            fechaAcogida = lector.GetDateTime(lector.GetOrdinal("fecha_acogida")),
                            deudaFraccionada = lector.GetDecimal(lector.GetOrdinal("Saldo")),
                            nroCuotas = lector.GetInt32(lector.GetOrdinal("Cuotas")),
                            cuota = lector.GetDecimal(lector.GetOrdinal("ValorCuota")),
                            cuotasVencidas = lector.GetInt32(lector.GetOrdinal("cuotasVencidas")),
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
        public List<Frac_FraccionamientoListado2> listarFraccionamientosRecaudacion2(int nroCuotas, int nroCuotasVenc, string via,
            int sector, string razonSocial, string estado, int tipoFracc, int periodo, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                var coleccion = new List<Frac_FraccionamientoListado2>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 18);
                if (nroCuotas > 0) db.AddInParameter(SQL, "NroCuota", DbType.Int32, nroCuotas);
                if (nroCuotasVenc > 0) db.AddInParameter(SQL, "cuotasVencidas", DbType.Int32, nroCuotasVenc);
                if (!via.Equals("0")) db.AddInParameter(SQL, "via", DbType.String, via);
                if (sector > 0) db.AddInParameter(SQL, "sector", DbType.Int32, sector);
                db.AddInParameter(SQL, "razon_social", DbType.String, razonSocial);
                if (!estado.Equals("0")) db.AddInParameter(SQL, "Estado", DbType.String, estado);
                if (tipoFracc > 0) db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, tipoFracc);
                if (periodo > 0) db.AddInParameter(SQL, "idPeriodo", DbType.Int32, periodo);
                db.AddInParameter(SQL, "fecha_inicio", DbType.DateTime, fechaInicio);
                db.AddInParameter(SQL, "fecha_fin", DbType.DateTime, fechaFin);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_FraccionamientoListado2
                        {
                            fraccionamiento_id = lector.GetInt32(lector.GetOrdinal("fraccionamiento_id")),
                            convenio = lector.GetString(lector.GetOrdinal("convenio")),
                            persona_ID = lector.GetString(lector.GetOrdinal("Persona_Id")),
                            persona = lector.GetString(lector.GetOrdinal("razon_social")),
                            junta = lector.GetString(lector.GetOrdinal("junta")),
                            via = lector.GetString(lector.GetOrdinal("via")),
                            fechaAcogida = lector.GetDateTime(lector.GetOrdinal("fecha_acogida")),
                            deudaFraccionada = lector.GetDecimal(lector.GetOrdinal("Saldo")),
                            nroCuotas = lector.GetInt32(lector.GetOrdinal("Cuotas")),
                            cuota = lector.GetDecimal(lector.GetOrdinal("ValorCuota")),
                            cuotasVencidas = lector.GetInt32(lector.GetOrdinal("cuotasVencidas")),
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
        public List<Frac_DeudaFraccionada> listarMontoFraccionado(int nroCuotas, int nroCuotasVenc, string via,
           int sector, string razonSocial, string estado, int tipoFracc, int periodo, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                var coleccion = new List<Frac_DeudaFraccionada>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 14);
                if (nroCuotas > 0) db.AddInParameter(SQL, "NroCuota", DbType.Int32, nroCuotas);
                if (nroCuotasVenc > 0) db.AddInParameter(SQL, "cuotasVencidas", DbType.Int32, nroCuotasVenc);
                if (!via.Equals("0")) db.AddInParameter(SQL, "via", DbType.String, via);
                if (sector > 0) db.AddInParameter(SQL, "sector", DbType.Int32, sector);
                db.AddInParameter(SQL, "razon_social", DbType.String, razonSocial);
                if (!estado.Equals("0")) db.AddInParameter(SQL, "Estado", DbType.String, estado);
                if (tipoFracc > 0) db.AddInParameter(SQL, "tipo_fraccionamiento_ID", DbType.Int32, tipoFracc);
                if (periodo > 0) db.AddInParameter(SQL, "idPeriodo", DbType.Int32, periodo);
                db.AddInParameter(SQL, "fecha_inicio", DbType.DateTime, fechaInicio);
                db.AddInParameter(SQL, "fecha_fin", DbType.DateTime, fechaFin);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_DeudaFraccionada
                        {
                            fraccionamiento_ID = lector.GetInt32(lector.GetOrdinal("fraccionamiento_id")),
                            junta = lector.GetString(lector.GetOrdinal("junta")),
                            via = lector.GetString(lector.GetOrdinal("via")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            pagado = lector.GetDecimal(lector.GetOrdinal("pagado")),
                            vencido = lector.GetDecimal(lector.GetOrdinal("vencido")),
                            anulado = lector.GetDecimal(lector.GetOrdinal("anulado")),
                            pendiente = lector.GetDecimal(lector.GetOrdinal("pendiente"))
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

        public int validarPagoCuota(int periodo_ID, int nroConvenio)
        {
            try
            {
                int resultado = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 15);
                db.AddInParameter(SQL, "periodo_ID", DbType.Int32, periodo_ID);
                db.AddInParameter(SQL, "nroConvenio", DbType.Int32, nroConvenio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        resultado = lector.GetInt32(lector.GetOrdinal("resultado"));
                    }
                }
                SQL.Dispose();
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void anularFraccionamiento(int fraccionamiento_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 17);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.Int32, fraccionamiento_id);
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Frac_Fraccionamientos> listarfraccinamientoContribuyente(string persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 19);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                var coleccion = new List<Frac_Fraccionamientos>();
                using(var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_Fraccionamientos
                        {
                            fraccionamiento_id = lector.GetInt32(lector.GetOrdinal("fraccionamiento_id")),
                            base_legal = lector.GetString(lector.GetOrdinal("base_legal")),
                            fecha_acogida = lector.GetDateTime(lector.GetOrdinal("Fecha_Acogida")).ToShortDateString(),
                            periodos = lector.GetString(lector.GetOrdinal("periodos")),
                            deuda_total = lector.GetDecimal(lector.GetOrdinal("Deuda_Total")),
                            inicial = lector.GetDecimal(lector.GetOrdinal("Inicial")),
                            saldo = lector.GetDecimal(lector.GetOrdinal("Saldo")),
                            valorCuota = lector.GetDecimal(lector.GetOrdinal("ValorCuota")),
                            nroCuotas = lector.GetInt32(lector.GetOrdinal("Cuotas")),
                            estado = lector.GetString(lector.GetOrdinal("estado"))
                        });
                    }
                    SQL.Dispose();
                    return coleccion;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Frac_Cronogramas> listarCronogramaContriFracciona(int fraccionamiento_ID)
        {
            try
            {
                var coleccion = new List<Frac_Cronogramas>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 20);
                db.AddInParameter(SQL, "fraccionamiento_ID", DbType.String, fraccionamiento_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Frac_Cronogramas
                        {
                            amortizacion = lector.GetDecimal(lector.GetOrdinal("amortizacion")),
                            fraccionamiento_ID = lector.GetInt32(lector.GetOrdinal("Fraccionamiento_id")),
                            nroCuota = lector.GetInt32(lector.GetOrdinal("NroCuota")),
                            importe = lector.GetDecimal(lector.GetOrdinal("importe")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            fechaVence = lector.GetDateTime(lector.GetOrdinal("FechaVence")),
                            fechaPago = lector.GetString(lector.GetOrdinal("FechaPago")),
                            saldo = lector.GetDecimal(lector.GetOrdinal("saldo")),
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
    }
}
