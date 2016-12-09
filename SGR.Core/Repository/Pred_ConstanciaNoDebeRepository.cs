using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity;
using SGR.Entity.Model;

namespace SGR.Core.Repository
{
    public class Pred_ConstanciaNoDebeRepository
    {
        private const String nombreprocedimiento = "_Pred_ConstanciaNoDebe";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Pred_ConstanciaNoDebe> listartodos(string busqueda, int idPeriodo, int tipo)
        {
            try
            {
                var coleccion = new List<Pred_ConstanciaNoDebe>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);
                String cadena = busqueda;
                String cad1 = "%";
                String cad2 = "%";
                String cad3 = "%";
                String cad4 = "%";
                char[] array = cadena.ToCharArray();
                int j = 0;
                for (int i = 0; i < cadena.Length; i++)
                {

                    if (array[i] == ' ')
                    {
                        j++;
                    }
                    if (j == 0 && array[i] != ' ')
                    {
                        cad1 = cad1 + array[i];
                    }
                    if (j == 1 && array[i] != ' ')
                    {
                        cad2 = cad2 + array[i];
                    }
                    if (j == 2 && array[i] != ' ')
                    {
                        cad3 = cad3 + array[i];
                    }
                    if (j == 3 && array[i] != ' ')
                    {
                        cad4 = cad4 + array[i];
                    }
                }
                cad1 = cad1 + "%";
                cad2 = cad2 + "%";
                cad3 = cad3 + "%";
                cad4 = cad4 + "%";
                db.AddInParameter(SQL, "n1", DbType.String, cad1);
                db.AddInParameter(SQL, "n2", DbType.String, cad2);
                db.AddInParameter(SQL, "n3", DbType.String, cad3);
                db.AddInParameter(SQL, "n4", DbType.String, cad4);
                db.AddInParameter(SQL, "idPeriodo", DbType.String, idPeriodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_ConstanciaNoDebe
                        {
                            idConstancia = lector.IsDBNull(lector.GetOrdinal("idConstancia")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idConstancia")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Expediente = lector.IsDBNull(lector.GetOrdinal("Expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("Expediente")),
                            IdPersona = lector.IsDBNull(lector.GetOrdinal("IdPersona")) ? default(String) : lector.GetString(lector.GetOrdinal("IdPersona")),
                            Transferencia = lector.IsDBNull(lector.GetOrdinal("Transferencia")) ? default(String) : lector.GetString(lector.GetOrdinal("Transferencia")),
                            TramiteRecibo = lector.IsDBNull(lector.GetOrdinal("TramiteRecibo")) ? default(String) : lector.GetString(lector.GetOrdinal("TramiteRecibo")),
                            TramiteImporte = lector.IsDBNull(lector.GetOrdinal("TramiteImporte")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("TramiteImporte")),
                            ImpuestoRecibo = lector.IsDBNull(lector.GetOrdinal("ImpuestoRecibo")) ? default(String) : lector.GetString(lector.GetOrdinal("ImpuestoRecibo")),
                            ImpuestoImporte = lector.IsDBNull(lector.GetOrdinal("ImpuestoImporte")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("ImpuestoImporte")),
                            Obligacion = lector.IsDBNull(lector.GetOrdinal("Obligacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Obligacion")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            idPredio = lector.IsDBNull(lector.GetOrdinal("predio_id")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_id")),
                            idAlcabala = lector.IsDBNull(lector.GetOrdinal("idAlcabala")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idAlcabala")),
                            //Tipo = lector.IsDBNull(lector.GetOrdinal("Tipo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Tipo")),
                            //Valuo = lector.IsDBNull(lector.GetOrdinal("Valuo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Valuo")),
                            //CompraVenta = lector.IsDBNull(lector.GetOrdinal("CompraVenta")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CompraVenta")),
                            //UIT = lector.IsDBNull(lector.GetOrdinal("UIT")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("UIT")),
                            //Saldo = lector.IsDBNull(lector.GetOrdinal("Saldo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Saldo")),
                            //Impuesto = lector.IsDBNull(lector.GetOrdinal("Impuesto")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Impuesto")),
                            //estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_update"))
                            Persona = lector.IsDBNull(lector.GetOrdinal("Persona")) ? default(String) : lector.GetString(lector.GetOrdinal("Persona")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado"))
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

        public virtual int InsertP(Pred_ConstanciaNoDebe Pred_ConstanciaNoDebe)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                //db.AddInParameter(SQL, "idConstancia", DbType.Int32, Pred_ConstanciaNoDebe.idConstancia);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, Pred_ConstanciaNoDebe.idPeriodo);
                db.AddInParameter(SQL, "Expediente", DbType.String, Pred_ConstanciaNoDebe.Expediente);
                db.AddInParameter(SQL, "IdPersona", DbType.String, Pred_ConstanciaNoDebe.IdPersona);
                db.AddInParameter(SQL, "Transferencia", DbType.String, Pred_ConstanciaNoDebe.Transferencia);
                db.AddInParameter(SQL, "TramiteRecibo", DbType.String, Pred_ConstanciaNoDebe.TramiteRecibo);
                db.AddInParameter(SQL, "TramiteImporte", DbType.Decimal, Pred_ConstanciaNoDebe.TramiteImporte);
                db.AddInParameter(SQL, "ImpuestoRecibo", DbType.String, Pred_ConstanciaNoDebe.ImpuestoRecibo);
                db.AddInParameter(SQL, "ImpuestoImporte", DbType.Decimal, Pred_ConstanciaNoDebe.ImpuestoImporte);
                db.AddInParameter(SQL, "Obligacion", DbType.String, Pred_ConstanciaNoDebe.Obligacion);
                db.AddInParameter(SQL, "Descripcion", DbType.String, Pred_ConstanciaNoDebe.Descripcion);
                db.AddInParameter(SQL, "predio_id", DbType.String, Pred_ConstanciaNoDebe.idPredio);
                //db.AddInParameter(SQL, "Tipo", DbType.Int32, Pred_ConstanciaNoDebe.Tipo);
                //db.AddInParameter(SQL, "Valuo", DbType.Decimal, Pred_ConstanciaNoDebe.Valuo);
                //db.AddInParameter(SQL, "CompraVenta", DbType.Decimal, Pred_ConstanciaNoDebe.CompraVenta);
                //db.AddInParameter(SQL, "UIT", DbType.Decimal, Pred_ConstanciaNoDebe.UIT);
                //db.AddInParameter(SQL, "Saldo", DbType.Decimal, Pred_ConstanciaNoDebe.Saldo);
                //db.AddInParameter(SQL, "Impuesto", DbType.Decimal, Pred_ConstanciaNoDebe.Impuesto);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_ConstanciaNoDebe.estado);
                db.AddInParameter(SQL, "registro_user", DbType.String, Pred_ConstanciaNoDebe.registro_user_add);
                //db.AddInParameter(SQL, "registro_user_update", DbType.String, Pred_ConstanciaNoDebe.registro_user_upda/*te);*/
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 3);
                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                //if (huboexito == 0)
                //{
                //    throw new Exception("Error al agregar al");
                //}
                //var numerogenerado = (int)db.GetParameterValue(SQL, "");
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int InsertA(Pred_ConstanciaNoDebe Pred_ConstanciaNoDebe)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                //db.AddInParameter(SQL, "idConstancia", DbType.Int32, Pred_ConstanciaNoDebe.idConstancia);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, Pred_ConstanciaNoDebe.idPeriodo);
                db.AddInParameter(SQL, "Expediente", DbType.String, Pred_ConstanciaNoDebe.Expediente);
                db.AddInParameter(SQL, "IdPersona", DbType.String, Pred_ConstanciaNoDebe.IdPersona);
                db.AddInParameter(SQL, "Transferencia", DbType.String, Pred_ConstanciaNoDebe.Transferencia);
                db.AddInParameter(SQL, "TramiteRecibo", DbType.String, Pred_ConstanciaNoDebe.TramiteRecibo);
                db.AddInParameter(SQL, "TramiteImporte", DbType.Decimal, Pred_ConstanciaNoDebe.TramiteImporte);
                db.AddInParameter(SQL, "ImpuestoRecibo", DbType.String, Pred_ConstanciaNoDebe.ImpuestoRecibo);
                db.AddInParameter(SQL, "ImpuestoImporte", DbType.Decimal, Pred_ConstanciaNoDebe.ImpuestoImporte);
                db.AddInParameter(SQL, "Obligacion", DbType.String, Pred_ConstanciaNoDebe.Obligacion);
                db.AddInParameter(SQL, "Descripcion", DbType.String, Pred_ConstanciaNoDebe.Descripcion);
                db.AddInParameter(SQL, "predio_id", DbType.String, Pred_ConstanciaNoDebe.idPredio);
                //db.AddInParameter(SQL, "Tipo", DbType.Int32, Pred_ConstanciaNoDebe.Tipo);
                //db.AddInParameter(SQL, "Valuo", DbType.Decimal, Pred_ConstanciaNoDebe.Valuo);
                //db.AddInParameter(SQL, "CompraVenta", DbType.Decimal, Pred_ConstanciaNoDebe.CompraVenta);
                //db.AddInParameter(SQL, "UIT", DbType.Decimal, Pred_ConstanciaNoDebe.UIT);
                //db.AddInParameter(SQL, "Saldo", DbType.Decimal, Pred_ConstanciaNoDebe.Saldo);
                //db.AddInParameter(SQL, "Impuesto", DbType.Decimal, Pred_ConstanciaNoDebe.Impuesto);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_ConstanciaNoDebe.estado);
                db.AddInParameter(SQL, "registro_user", DbType.String, Pred_ConstanciaNoDebe.registro_user_add);
                db.AddInParameter(SQL, "idAlcabala", DbType.String, Pred_ConstanciaNoDebe.idAlcabala);
                //db.AddInParameter(SQL, "registro_user_update", DbType.String, Pred_ConstanciaNoDebe.registro_user_upda/*te);*/
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);
                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                //if (huboexito == 0)
                //{
                //    throw new Exception("Error al agregar al");
                //}
                //var numerogenerado = (int)db.GetParameterValue(SQL, "");
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_ConstanciaNoDebe Pred_ConstanciaNoDebe)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idConstancia", DbType.Int32, Pred_ConstanciaNoDebe.idConstancia);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, Pred_ConstanciaNoDebe.idPeriodo);
                db.AddInParameter(SQL, "Expediente", DbType.String, Pred_ConstanciaNoDebe.Expediente);
                db.AddInParameter(SQL, "IdPersona", DbType.String, Pred_ConstanciaNoDebe.IdPersona);
                db.AddInParameter(SQL, "Transferencia", DbType.String, Pred_ConstanciaNoDebe.Transferencia);
                db.AddInParameter(SQL, "TramiteRecibo", DbType.String, Pred_ConstanciaNoDebe.TramiteRecibo);
                db.AddInParameter(SQL, "TramiteImporte", DbType.Decimal, Pred_ConstanciaNoDebe.TramiteImporte);
                db.AddInParameter(SQL, "ImpuestoRecibo", DbType.String, Pred_ConstanciaNoDebe.ImpuestoRecibo);
                db.AddInParameter(SQL, "ImpuestoImporte", DbType.Decimal, Pred_ConstanciaNoDebe.ImpuestoImporte);
                db.AddInParameter(SQL, "Obligacion", DbType.String, Pred_ConstanciaNoDebe.Obligacion);
                db.AddInParameter(SQL, "Descripcion", DbType.String, Pred_ConstanciaNoDebe.Descripcion);
                //db.AddInParameter(SQL, "Tipo", DbType.Int32, Pred_ConstanciaNoDebe.Tipo);
                //db.AddInParameter(SQL, "Valuo", DbType.Decimal, Pred_ConstanciaNoDebe.Valuo);
                //db.AddInParameter(SQL, "CompraVenta", DbType.Decimal, Pred_ConstanciaNoDebe.CompraVenta);
                //db.AddInParameter(SQL, "UIT", DbType.Decimal, Pred_ConstanciaNoDebe.UIT);
                //db.AddInParameter(SQL, "Saldo", DbType.Decimal, Pred_ConstanciaNoDebe.Saldo);
                //db.AddInParameter(SQL, "Impuesto", DbType.Decimal, Pred_ConstanciaNoDebe.Impuesto);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_ConstanciaNoDebe.estado);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Pred_ConstanciaNoDebe.registro_fecha_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Pred_ConstanciaNoDebe.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, Pred_ConstanciaNoDebe.registro_pc_add);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, Pred_ConstanciaNoDebe.registro_pc_update);
                db.AddInParameter(SQL, "registro_user", DbType.String, Pred_ConstanciaNoDebe.registro_user_add);
                //db.AddInParameter(SQL, "registro_user_update", DbType.String, Pred_ConstanciaNoDebe.registro_user_update);
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

        public virtual void Update2(Pred_ConstanciaNoDebe Pred_ConstanciaNoDebe)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "idConstancia", DbType.Int32, Pred_ConstanciaNoDebe.idConstancia);
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, Pred_ConstanciaNoDebe.idPeriodo);
                db.AddInParameter(SQL, "Expediente", DbType.String, Pred_ConstanciaNoDebe.Expediente);
                db.AddInParameter(SQL, "IdPersona", DbType.String, Pred_ConstanciaNoDebe.IdPersona);
                db.AddInParameter(SQL, "Transferencia", DbType.String, Pred_ConstanciaNoDebe.Transferencia);
                db.AddInParameter(SQL, "TramiteRecibo", DbType.String, Pred_ConstanciaNoDebe.TramiteRecibo);
                db.AddInParameter(SQL, "TramiteImporte", DbType.Decimal, Pred_ConstanciaNoDebe.TramiteImporte);
                db.AddInParameter(SQL, "ImpuestoRecibo", DbType.String, Pred_ConstanciaNoDebe.ImpuestoRecibo);
                db.AddInParameter(SQL, "ImpuestoImporte", DbType.Decimal, Pred_ConstanciaNoDebe.ImpuestoImporte);
                db.AddInParameter(SQL, "Obligacion", DbType.String, Pred_ConstanciaNoDebe.Obligacion);
                db.AddInParameter(SQL, "Descripcion", DbType.String, Pred_ConstanciaNoDebe.Descripcion);
                //db.AddInParameter(SQL, "Tipo", DbType.Int32, Pred_ConstanciaNoDebe.Tipo);
                //db.AddInParameter(SQL, "Valuo", DbType.Decimal, Pred_ConstanciaNoDebe.Valuo);
                //db.AddInParameter(SQL, "CompraVenta", DbType.Decimal, Pred_ConstanciaNoDebe.CompraVenta);
                //db.AddInParameter(SQL, "UIT", DbType.Decimal, Pred_ConstanciaNoDebe.UIT);
                //db.AddInParameter(SQL, "Saldo", DbType.Decimal, Pred_ConstanciaNoDebe.Saldo);
                //db.AddInParameter(SQL, "Impuesto", DbType.Decimal, Pred_ConstanciaNoDebe.Impuesto);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_ConstanciaNoDebe.estado);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Pred_ConstanciaNoDebe.registro_fecha_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Pred_ConstanciaNoDebe.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, Pred_ConstanciaNoDebe.registro_pc_add);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, Pred_ConstanciaNoDebe.registro_pc_update);
                db.AddInParameter(SQL, "registro_user", DbType.String, Pred_ConstanciaNoDebe.registro_user_add);
                //db.AddInParameter(SQL, "registro_user_update", DbType.String, Pred_ConstanciaNoDebe.registro_user_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 11);
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

        public List<Pred_ConstanciaNoDebe> listarbyPersona(String IdPersona)
        {
            try
            {
                var coleccion = new List<Pred_ConstanciaNoDebe>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "IdPersona", DbType.String, IdPersona);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_ConstanciaNoDebe
                        {
                            idConstancia = lector.IsDBNull(lector.GetOrdinal("idConstancia")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idConstancia")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Expediente = lector.IsDBNull(lector.GetOrdinal("Expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("Expediente")),
                            IdPersona = lector.IsDBNull(lector.GetOrdinal("IdPersona")) ? default(String) : lector.GetString(lector.GetOrdinal("IdPersona")),
                            Transferencia = lector.IsDBNull(lector.GetOrdinal("Transferencia")) ? default(String) : lector.GetString(lector.GetOrdinal("Transferencia")),
                            TramiteRecibo = lector.IsDBNull(lector.GetOrdinal("TramiteRecibo")) ? default(String) : lector.GetString(lector.GetOrdinal("TramiteRecibo")),
                            TramiteImporte = lector.IsDBNull(lector.GetOrdinal("TramiteImporte")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("TramiteImporte")),
                            ImpuestoRecibo = lector.IsDBNull(lector.GetOrdinal("ImpuestoRecibo")) ? default(String) : lector.GetString(lector.GetOrdinal("ImpuestoRecibo")),
                            ImpuestoImporte = lector.IsDBNull(lector.GetOrdinal("ImpuestoImporte")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("ImpuestoImporte")),
                            Obligacion = lector.IsDBNull(lector.GetOrdinal("Obligacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Obligacion")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            Tipo = lector.IsDBNull(lector.GetOrdinal("Tipo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Tipo")),
                            Valuo = lector.IsDBNull(lector.GetOrdinal("Valuo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Valuo")),
                            CompraVenta = lector.IsDBNull(lector.GetOrdinal("CompraVenta")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CompraVenta")),
                            UIT = lector.IsDBNull(lector.GetOrdinal("UIT")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("UIT")),
                            Saldo = lector.IsDBNull(lector.GetOrdinal("Saldo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Saldo")),
                            Impuesto = lector.IsDBNull(lector.GetOrdinal("Impuesto")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Impuesto")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_update"))

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

        public Pred_ConstanciaNoDebe getByPrimaryKey(int idconstancia)
        {
            try
            {
                var coleccion = new List<Pred_ConstanciaNoDebe>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "idConstancia", DbType.String, idconstancia);
                var constancia = default(Pred_ConstanciaNoDebe);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        constancia = new Pred_ConstanciaNoDebe
                        {
                            idConstancia = lector.IsDBNull(lector.GetOrdinal("idConstancia")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idConstancia")),
                            idPeriodo = lector.IsDBNull(lector.GetOrdinal("idPeriodo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idPeriodo")),
                            Expediente = lector.IsDBNull(lector.GetOrdinal("Expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("Expediente")),
                            IdPersona = lector.IsDBNull(lector.GetOrdinal("IdPersona")) ? default(String) : lector.GetString(lector.GetOrdinal("IdPersona")),
                            Transferencia = lector.IsDBNull(lector.GetOrdinal("Transferencia")) ? default(String) : lector.GetString(lector.GetOrdinal("Transferencia")),
                            TramiteRecibo = lector.IsDBNull(lector.GetOrdinal("TramiteRecibo")) ? default(String) : lector.GetString(lector.GetOrdinal("TramiteRecibo")),
                            TramiteImporte = lector.IsDBNull(lector.GetOrdinal("TramiteImporte")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("TramiteImporte")),
                            ImpuestoRecibo = lector.IsDBNull(lector.GetOrdinal("ImpuestoRecibo")) ? default(String) : lector.GetString(lector.GetOrdinal("ImpuestoRecibo")),
                            ImpuestoImporte = lector.IsDBNull(lector.GetOrdinal("ImpuestoImporte")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("ImpuestoImporte")),
                            Obligacion = lector.IsDBNull(lector.GetOrdinal("Obligacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Obligacion")),
                            Descripcion = lector.IsDBNull(lector.GetOrdinal("Descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("Descripcion")),
                            Tipo = lector.IsDBNull(lector.GetOrdinal("Tipo")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Tipo")),
                            Valuo = lector.IsDBNull(lector.GetOrdinal("Valuo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Valuo")),
                            CompraVenta = lector.IsDBNull(lector.GetOrdinal("CompraVenta")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("CompraVenta")),
                            UIT = lector.IsDBNull(lector.GetOrdinal("UIT")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("UIT")),
                            Saldo = lector.IsDBNull(lector.GetOrdinal("Saldo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Saldo")),
                            Impuesto = lector.IsDBNull(lector.GetOrdinal("Impuesto")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("Impuesto")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            idAlcabala = lector.IsDBNull(lector.GetOrdinal("idAlcabala")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("idAlcabala")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            idPredio = lector.IsDBNull(lector.GetOrdinal("predio_id")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_id"))
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_update"))

                        };
                    }
                }
                SQL.Dispose();
                return constancia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public String getTransferencia()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                string constancia = Convert.ToString(db.ExecuteScalar(SQL));

                SQL.Dispose();
                return constancia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
