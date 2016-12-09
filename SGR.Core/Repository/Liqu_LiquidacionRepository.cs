using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using SGR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using SGR.Entity.Model;

namespace SGR.Core.Repository
{
    public class Liqu_LiquidacionRepository
    {

        private const String nombreprocedimiento = "_liqu_Liquidacion_Proceso";
        private const String Nombretabla = "liquidacion";
        private Database db = DatabaseFactory.CreateDatabase();
        public virtual int Insert(Liqu_Liquidacion Liquidacion)
        {
            try
            {
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                //db.AddInParameter(SQL, "fecha", DbType.DateTime, Liquidacion.fecha);
                db.AddInParameter(SQL, "importe", DbType.Decimal, Liquidacion.importe);
                db.AddInParameter(SQL, "estado", DbType.String, Liquidacion.estado);
                db.AddInParameter(SQL, "persona_ID", DbType.String, Liquidacion.Persona_id);
                db.AddInParameter(SQL, "grupo_trib", DbType.String, Liquidacion.tipo);
                db.AddInParameter(SQL, "interes", DbType.Decimal, Liquidacion.Intereses);
                //db.AddInParameter(SQL, "registro_user_add", DbType.String, Liquidacion.registro_user_add);
                //db.AddInParameter(SQL, "registro_ip", DbType.String, Liquidacion.registro_ip);
                //db.AddInParameter(SQL, "registroFecha", DbType.DateTime, Liquidacion.registroFecha);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Liquidacion.registro_fecha_add);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Liquidacion.registro_user_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, Liquidacion.registro_pc_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Liquidacion.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_user_update", DbType.Int32, Liquidacion.registro_user_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, Liquidacion.registro_pc_update);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 1);
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
                throw new Exception(ex.Message);
            }
        }
        public Liqu_Liquidacion Insert2(Liqu_Liquidacion Liquidacion, string tributo_ID)
        {
            try
            {
                Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "importe", DbType.Decimal, Liquidacion.importe);
                db.AddInParameter(SQL, "estado", DbType.String, Liquidacion.estado);
                db.AddInParameter(SQL, "persona_ID", DbType.String, Liquidacion.Persona_id);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "interes", DbType.Decimal, Liquidacion.Intereses);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Liquidacion.registro_user_add);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 4);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        elemento.liquidacion_id = lector.GetInt32(lector.GetOrdinal("ultimo"));
                        elemento.tipo = lector.GetString(lector.GetOrdinal("tributo_ID"));
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
        public virtual int InsertDetalle(string persona_ID, string predio_ID,
        string tributo_ID, int mes, int anio, decimal monto)
        {
            try
            {
                int ultimo = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                //db.AddInParameter(SQL, "fecha", DbType.DateTime, Liquidacion.fecha);
                db.AddInParameter(SQL, "persona_ID", DbType.Decimal, persona_ID);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "anio", DbType.Decimal, anio);
                db.AddInParameter(SQL, "mes", DbType.Decimal, mes);
                db.AddInParameter(SQL, "monto", DbType.Int32, monto);
                //db.AddInParameter(SQL, "registro_user", DbType.String, Liquidacion.registro_user);
                //db.AddInParameter(SQL, "registro_ip", DbType.String, Liquidacion.registro_ip);
                //db.AddInParameter(SQL, "registroFecha", DbType.DateTime, Liquidacion.registroFecha);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Liquidacion.registro_fecha_add);
                //db.AddInParameter(SQL, "registro_user_add", DbType.String, Liquidacion.registro_user_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, Liquidacion.registro_pc_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Liquidacion.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_user_update", DbType.Int32, Liquidacion.registro_user_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, Liquidacion.registro_pc_update);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 7);
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
                throw new Exception(ex.Message);
            }
        }
        public virtual string InsertDetalle2(int liquidacion_ID, string persona_ID, string predio_ID,
        string tributo_ID, int mes, int anio, decimal monto)
        {
            try
            {
                string ultimo = "";
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "anio", DbType.Decimal, anio);
                db.AddInParameter(SQL, "mes", DbType.Decimal, mes);
                db.AddInParameter(SQL, "monto", DbType.Decimal, monto);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 6);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        ultimo = lector.GetString(lector.GetOrdinal("tipo_trib"));
                    }
                }
                SQL.Dispose();
                return ultimo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void InsertarDetalles(int liquidacion_ID, string persona_ID)
        {
              try
                {
                    DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                    db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                    db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                    db.AddInParameter(SQL, "tipo", DbType.Byte, 2);
                    int huboexito = db.ExecuteNonQuery(SQL);
                    if (huboexito == 0)
                    {
                        throw new Exception("Error al Generar Liquidacion");
                    }
                    SQL.Dispose();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }
        public List<Liqu_Liquidacion> listartodos(string persona)
        {
            try
            {
                var coleccion = new List<Liqu_Liquidacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 3);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Liquidacion
                        {
                            liquidacion_id = lector.GetInt32(lector.GetOrdinal("liquidacion_ID")),
                            fecha = lector.GetDateTime(lector.GetOrdinal("fecha")),
                            importe = lector.GetDecimal(lector.GetOrdinal("importe")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            Persona_id = lector.GetString(lector.GetOrdinal("persona_ID")),
                            Intereses = lector.GetDecimal(lector.GetOrdinal("intereses")),
                            tipo = lector.GetString(lector.GetOrdinal("tipo_desc")),
                            total_final = lector.GetDecimal(lector.GetOrdinal("total_fin"))

                            //registro_ip = lector.IsDBNull(lector.GetOrdinal("registro_ip")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_ip")),
                            //registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

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

        public Liqu_Liquidacion listarPorCodigo(int liquidacion_ID)
        {
            try
            {
                Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 14);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        elemento=(new Liqu_Liquidacion
                        {
                            liquidacion_id = lector.GetInt32(lector.GetOrdinal("liquidacion_ID")),
                            fecha = lector.GetDateTime(lector.GetOrdinal("fecha")),
                            importe = lector.GetDecimal(lector.GetOrdinal("importe")),
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            Persona_id = lector.GetString(lector.GetOrdinal("persona_ID")),
                            Intereses = lector.GetDecimal(lector.GetOrdinal("Intereses")),
                            tipo = lector.GetString(lector.GetOrdinal("tipo")),
                            total_final = lector.GetDecimal(lector.GetOrdinal("total")),
                            razon_social = lector.GetString(lector.GetOrdinal("persona"))

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

        public List<Liqu_TributosAfectos> listarTributosAfectos(string persona)
        {
            try
            {
                var coleccion = new List<Liqu_TributosAfectos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 5);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_TributosAfectos
                        {
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_ID")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo"))
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
        public virtual bool eliminarLiquidacionPendiente()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.String, 19);
                int huboexito = db.ExecuteNonQuery(SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool eliminarLiquidacion(int liquidacion_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                db.AddInParameter(SQL, "tipo", DbType.String, 7);
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
        public virtual void modificarEstado(int liquidacion_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                db.AddInParameter(SQL, "tipo", DbType.String, 8);
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
        public virtual void InsertDetalle3(int liquidacion_ID,string persona_ID,string predio_ID,
            int mes, int anio,string grupo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "anio", DbType.Decimal, anio);
                db.AddInParameter(SQL, "mes", DbType.Decimal, mes);
                db.AddInParameter(SQL, "grupo_trib", DbType.String, grupo);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 9);
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
        public virtual void InsertDetalle4(int liquidacion_ID, string persona_ID, string predio_ID,
            int mes, int anio, string grupo,decimal restante)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "anio", DbType.Decimal, anio);
                db.AddInParameter(SQL, "mes", DbType.Decimal, mes);
                db.AddInParameter(SQL, "grupo_trib", DbType.String, grupo);
                db.AddInParameter(SQL, "monto", DbType.Decimal, restante);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 10);
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
        public virtual void InsertDetalle5(int liquidacion_ID, string persona_ID, string predio_ID,
           int mes, int anio, string tributo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "anio", DbType.Decimal, anio);
                db.AddInParameter(SQL, "mes", DbType.Decimal, mes);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 11);
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
        public virtual void modificarEstadoFinal(int liquidacion_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                db.AddInParameter(SQL, "tipo", DbType.String, 12);
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
        public List<Liqu_Liquidacion> listadoLiquidaciones()
        {
            try
            {
                var coleccion = new List<Liqu_Liquidacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 13);
                using (var lector = db.ExecuteReader(SQL)){
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Liquidacion
                        {
                            liquidacion_id = lector.GetInt32(lector.GetOrdinal("liquidacion_id")),
                            tipo = lector.GetString(lector.GetOrdinal("tipo")),
                            Persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            razon_social = lector.GetString(lector.GetOrdinal("razon_social")),
                            importe = lector.GetDecimal(lector.GetOrdinal("importe")),
                            Intereses = lector.GetDecimal(lector.GetOrdinal("intereses")),
                            total_final = lector.GetDecimal(lector.GetOrdinal("total")),
                            fecha = lector.GetDateTime(lector.GetOrdinal("fecha")),
                            estado = lector.GetString(lector.GetOrdinal("estado"))
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
        public List<Liqu_Liquidacion> listadoLiquidacionesBusqueda(DateTime fecha_ini,DateTime fecha_fin,
            string estado,string tipo_liqui, string contribuyente)
        {
            try
            {
                var coleccion = new List<Liqu_Liquidacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 20);
                db.AddInParameter(SQL, "fecha_ini", DbType.DateTime, fecha_ini);
                db.AddInParameter(SQL, "fecha_fin", DbType.DateTime, fecha_fin);
                db.AddInParameter(SQL, "estado", DbType.String, estado);
                db.AddInParameter(SQL, "tipo_liqui", DbType.String, tipo_liqui);
                db.AddInParameter(SQL, "contribuyente", DbType.String,contribuyente);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Liquidacion
                        {
                            liquidacion_id = lector.GetInt32(lector.GetOrdinal("liquidacion_id")),
                            tipo = lector.GetString(lector.GetOrdinal("tipo")),
                            Persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            razon_social = lector.GetString(lector.GetOrdinal("razon_social")),
                            importe = lector.GetDecimal(lector.GetOrdinal("importe")),
                            Intereses = lector.GetDecimal(lector.GetOrdinal("intereses")),
                            total_final = lector.GetDecimal(lector.GetOrdinal("total")),
                            fecha = lector.GetDateTime(lector.GetOrdinal("fecha")),
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
        public List<Liqu_Deuda> verificacionLiquidacion(string idpersona)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 15);
                db.AddInParameter(SQL, "persona_ID", DbType.String, idpersona);
                var coleccion = new List<Liqu_Deuda>();
                using(var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Deuda
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            tributo = lector.GetString(lector.GetOrdinal("descripcion")),
                            monto = lector.GetDecimal(lector.GetOrdinal("deuda")),
                            periodo = lector.GetString(lector.GetOrdinal("meses")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio"))
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
        public List<Liqu_Deuda> verificacionLiquidacion2(string idpersona,string predio_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 16);
                db.AddInParameter(SQL, "persona_ID", DbType.String, idpersona);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                var coleccion = new List<Liqu_Deuda>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Deuda
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            tributo = lector.GetString(lector.GetOrdinal("descripcion")),
                            monto = lector.GetDecimal(lector.GetOrdinal("deuda")),
                            periodo = lector.GetString(lector.GetOrdinal("meses")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio"))
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
        public List<Liqu_Deuda> verificacionLiquidacion3(string persona, string predio, string tributos,
            int anio_ini, int anio_fin, int mes_ini, int mes_fin)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 16);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio);
                db.AddInParameter(SQL, "tributos", DbType.String, tributos);
                db.AddInParameter(SQL, "anio_ini", DbType.Int32, anio_ini);
                db.AddInParameter(SQL, "anio_fin", DbType.Int32, anio_fin);
                db.AddInParameter(SQL, "mes_ini", DbType.Int32, mes_ini);
                db.AddInParameter(SQL, "mes_fin", DbType.Int32, mes_fin);
                var coleccion = new List<Liqu_Deuda>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Deuda
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            tributo = lector.GetString(lector.GetOrdinal("descripcion")),
                            monto = lector.GetDecimal(lector.GetOrdinal("deuda")),
                            periodo = lector.GetString(lector.GetOrdinal("meses")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio"))
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
        public List<Liqu_Deuda> mostrarLiquidacion(int liquidacion_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 18);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                var coleccion = new List<Liqu_Deuda>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Deuda
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            tributo = lector.GetString(lector.GetOrdinal("descripcion")),
                            monto = lector.GetDecimal(lector.GetOrdinal("deuda")),
                            periodo = lector.GetString(lector.GetOrdinal("meses")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            interes= lector.GetDecimal(lector.GetOrdinal("interes"))
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
        public List<Int32> listarRango(string personaID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 21);
                db.AddInParameter(SQL, "persona_ID", DbType.String, personaID);
                var coleccion = new List<Int32>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(lector.GetInt32(lector.GetOrdinal("anio_ini")));
                        coleccion.Add(lector.GetInt32(lector.GetOrdinal("mes_ini")));
                        coleccion.Add(lector.GetInt32(lector.GetOrdinal("anio_fin")));
                        coleccion.Add(lector.GetInt32(lector.GetOrdinal("mes_fin")));
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
        public List<Liqu_Liquidacion> listarLiquiContribuyente(string persona_ID, Int16 mes, Int16 anio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 22);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "mes", DbType.Int16, mes);
                db.AddInParameter(SQL, "anio", DbType.Int16, anio);
                var coleccion = new List<Liqu_Liquidacion>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Liquidacion
                        {
                            liquidacion_id = lector.GetInt32(lector.GetOrdinal("liquidacion_id")),
                            tipo = lector.GetString(lector.GetOrdinal("fecha")), // como fecha
                            estado = lector.GetString(lector.GetOrdinal("estado")),
                            importe = lector.GetDecimal(lector.GetOrdinal("importe")),
                            Intereses = lector.GetDecimal(lector.GetOrdinal("intereses")),
                            total_final = lector.GetDecimal(lector.GetOrdinal("importeTotal"))
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
        public Liqu_Liquidacion listarTotalesContribuyente(string persona_ID, Int16 mes, Int16 anio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 23);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "mes", DbType.Int16, mes);
                db.AddInParameter(SQL, "anio", DbType.Int16, anio);
                var liquidacion = new Liqu_Liquidacion();
                using (var lector = db.ExecuteReader(SQL))
                {
                    if (lector.Read())
                    {
                        liquidacion.importe = lector.GetDecimal(lector.GetOrdinal("totalImporte"));
                        liquidacion.Intereses = lector.GetDecimal(lector.GetOrdinal("totalInteres"));
                        liquidacion.total_final = lector.GetDecimal(lector.GetOrdinal("importeTotal"));
                    }
                }
                SQL.Dispose();
                return liquidacion;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_Deuda> mostrarLiquidacionTodos(int liquidacion_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 24);
                db.AddInParameter(SQL, "liquidacion_ID", DbType.Int32, liquidacion_ID);
                var coleccion = new List<Liqu_Deuda>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Deuda
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tipo_tributo")),
                            tributo = lector.GetString(lector.GetOrdinal("descripcion")),
                            monto = lector.GetDecimal(lector.GetOrdinal("deuda")),
                            periodo = lector.GetString(lector.GetOrdinal("meses")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes"))
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
