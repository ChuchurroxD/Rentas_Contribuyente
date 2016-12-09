using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace SGR.Core.Repository
{
    public class Coa_expediente_coactivoRepository
    {
        private const String nombreprocedimiento = "_cOA_expediente_coactivo";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Coa_expediente_coactivo> listartodos(DateTime fechaini, DateTime fechafin, string persona_ID, string namepersona, string anio_expediente,
            string EXP_ESTADO, string descripcion_exp)
        {
            try
            {
                var coleccion = new List<Coa_expediente_coactivo>();
                persona_ID = "%" + persona_ID + "%";
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "fechaini", DbType.DateTime, fechaini);
                db.AddInParameter(SQL, "fechafin", DbType.DateTime, fechafin);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                //db.AddInParameter(SQL, "namepersona", DbType.String, namepersona);
                //db.AddInParameter(SQL, "anio_expediente", DbType.String, anio_expediente);
                db.AddInParameter(SQL, "EXP_ESTADO", DbType.String, EXP_ESTADO);
                db.AddInParameter(SQL, "descripcion_exp", DbType.String, "%" + descripcion_exp + "%");
                String cadena = namepersona;
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
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Coa_expediente_coactivo
                        {
                            expediente_coactivo_ID = lector.GetInt32(lector.GetOrdinal("expediente_coactivo_ID")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            razon_social = lector.GetString(lector.GetOrdinal("razon_social")),
                            direccCompleta = lector.GetString(lector.GetOrdinal("direccCompleta")),
                            fecha_emision = lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            descripcion_exp = lector.GetString(lector.GetOrdinal("descripcion_exp")),
                            fecha_notificacion = lector.IsDBNull(lector.GetOrdinal("fecha_notificacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_notificacion")),
                            monto_recauda_inscripcion = lector.IsDBNull(lector.GetOrdinal("monto_recauda_inscripcion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_recauda_inscripcion")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            estadoDescripcion = lector.IsDBNull(lector.GetOrdinal("estadoDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("estadoDescripcion")),
                            exp_estado = lector.IsDBNull(lector.GetOrdinal("exp_estado")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("exp_estado"))


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

        public void anular(int idcoactivo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "idcoactivo", DbType.Int32, idcoactivo);
                //db.AddInParameter(SQL, "namepersona", DbType.String, namepersona);
                //db.AddInParameter(SQL, "anio_expediente", DbType.String, anio_expediente);
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool EliminarPorcoactivo_cta_ID(Int32 coactivo_cta_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "coactivo_cta_ID", DbType.Int32);
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

        public virtual Coa_expediente_coactivo GetByPrimaryKey(String expediente_coactivo_ID, Int32 anio_expediente)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "expediente_coactivo_ID", DbType.String, expediente_coactivo_ID);
                db.AddInParameter(SQL, "anio_expediente", DbType.Int32, anio_expediente);
                var expediente_coactivo = default(Coa_expediente_coactivo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        expediente_coactivo = new Coa_expediente_coactivo
                        {
                            expediente_coactivo_ID = lector.GetInt32(lector.GetOrdinal("expediente_coactivo_ID")),
                            anio_expediente = lector.GetInt32(lector.GetOrdinal("anio_expediente")),
                            tipo_exp = lector.IsDBNull(lector.GetOrdinal("tipo_exp")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_exp")),
                            folios = lector.GetInt32(lector.GetOrdinal("folios")),
                            nro_resolucion = lector.GetString(lector.GetOrdinal("nro_resolucion")),
                            fecha_emision = lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            fecha_notificacion = lector.IsDBNull(lector.GetOrdinal("fecha_notificacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_notificacion")),
                            fecha_vencimiento = lector.IsDBNull(lector.GetOrdinal("fecha_vencimiento")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_vencimiento")),
                            descripcion_exp = lector.GetString(lector.GetOrdinal("descripcion_exp")),
                            coactivo_cta_ID = lector.GetInt32(lector.GetOrdinal("coactivo_cta_ID")),
                            exp_estado = lector.GetInt16(lector.GetOrdinal("exp_estado")),
                            exp_alias = lector.IsDBNull(lector.GetOrdinal("exp_alias")) ? default(String) : lector.GetString(lector.GetOrdinal("exp_alias")),
                            monto_recauda_retencion = lector.IsDBNull(lector.GetOrdinal("monto_recauda_retencion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_recauda_retencion")),
                            monto_recauda_inscripcion = lector.IsDBNull(lector.GetOrdinal("monto_recauda_inscripcion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_recauda_inscripcion")),
                            monto_recauda_secuestro = lector.IsDBNull(lector.GetOrdinal("monto_recauda_secuestro")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_recauda_secuestro")),
                            monto_recauda_total = lector.IsDBNull(lector.GetOrdinal("monto_recauda_total")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_recauda_total")),
                            exp_file = lector.IsDBNull(lector.GetOrdinal("exp_file")) ? default(String) : lector.GetString(lector.GetOrdinal("exp_file"))

                        };
                    }
                }
                SQL.Dispose();
                return expediente_coactivo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public virtual int Insert(Coa_expediente_coactivo expediente_coactivo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                //db.AddInParameter(SQL, "expediente_coactivo_ID", DbType.String, expediente_coactivo.expediente_coactivo_ID);
                db.AddInParameter(SQL, "anio_expediente", DbType.Int32, expediente_coactivo.anio_expediente);
                db.AddInParameter(SQL, "tipo_exp", DbType.Int16, expediente_coactivo.tipo_exp);
                db.AddInParameter(SQL, "folios", DbType.Int32, expediente_coactivo.folios);
                db.AddInParameter(SQL, "nro_resolucion", DbType.String, expediente_coactivo.nro_resolucion);
                db.AddInParameter(SQL, "fecha_emision", DbType.DateTime, expediente_coactivo.fecha_emision);
                //db.AddInParameter(SQL, "fecha_notificacion", DbType.DateTime, expediente_coactivo.fecha_notificacion);
                //db.AddInParameter(SQL, "fecha_vencimiento", DbType.DateTime, expediente_coactivo.fecha_vencimiento);
                db.AddInParameter(SQL, "descripcion_exp", DbType.String, expediente_coactivo.descripcion_exp);
                db.AddInParameter(SQL, "coactivo_cta_ID", DbType.Int32, expediente_coactivo.coactivo_cta_ID);
                //db.AddInParameter(SQL, "exp_estado", DbType.Int16, expediente_coactivo.exp_estado);
                //db.AddInParameter(SQL, "exp_alias", DbType.String, expediente_coactivo.exp_alias);
                //db.AddInParameter(SQL, "monto_recauda_retencion", DbType.Decimal, expediente_coactivo.monto_recauda_retencion);
                //db.AddInParameter(SQL, "monto_recauda_inscripcion", DbType.Decimal, expediente_coactivo.monto_recauda_inscripcion);
                //db.AddInParameter(SQL, "monto_recauda_secuestro", DbType.Decimal, expediente_coactivo.monto_recauda_secuestro);
                //db.AddInParameter(SQL, "monto_recauda_total", DbType.Decimal, expediente_coactivo.monto_recauda_total);
                db.AddInParameter(SQL, "exp_file", DbType.String, expediente_coactivo.exp_file);
                db.AddInParameter(SQL, "observacion", DbType.String, expediente_coactivo.observacion);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
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


        public virtual void Update(Coa_expediente_coactivo expediente_coactivo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "expediente_coactivo_ID", DbType.String, expediente_coactivo.expediente_coactivo_ID);
                db.AddInParameter(SQL, "anio_expediente", DbType.Int32, expediente_coactivo.anio_expediente);
                db.AddInParameter(SQL, "tipo_exp", DbType.Int16, expediente_coactivo.tipo_exp);
                db.AddInParameter(SQL, "folios", DbType.Int32, expediente_coactivo.folios);
                db.AddInParameter(SQL, "nro_resolucion", DbType.String, expediente_coactivo.nro_resolucion);
                db.AddInParameter(SQL, "fecha_emision", DbType.DateTime, expediente_coactivo.fecha_emision);
                db.AddInParameter(SQL, "fecha_notificacion", DbType.DateTime, expediente_coactivo.fecha_notificacion);
                db.AddInParameter(SQL, "fecha_vencimiento", DbType.DateTime, expediente_coactivo.fecha_vencimiento);
                db.AddInParameter(SQL, "descripcion_exp", DbType.String, expediente_coactivo.descripcion_exp);
                db.AddInParameter(SQL, "coactivo_cta_ID", DbType.Int32, expediente_coactivo.coactivo_cta_ID);
                db.AddInParameter(SQL, "exp_estado", DbType.Int16, expediente_coactivo.exp_estado);
                db.AddInParameter(SQL, "exp_alias", DbType.String, expediente_coactivo.exp_alias);
                db.AddInParameter(SQL, "monto_recauda_retencion", DbType.Decimal, expediente_coactivo.monto_recauda_retencion);
                db.AddInParameter(SQL, "monto_recauda_inscripcion", DbType.Decimal, expediente_coactivo.monto_recauda_inscripcion);
                db.AddInParameter(SQL, "monto_recauda_secuestro", DbType.Decimal, expediente_coactivo.monto_recauda_secuestro);
                db.AddInParameter(SQL, "monto_recauda_total", DbType.Decimal, expediente_coactivo.monto_recauda_total);
                db.AddInParameter(SQL, "exp_file", DbType.String, expediente_coactivo.exp_file);
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
    }
}
